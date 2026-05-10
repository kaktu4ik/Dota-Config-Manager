using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

public class SteamDotaFinder
{
    public static string FindDotaExe()
    {
        return FindDotaExeWithDebug(false);
    }

    public static string FindDotaExeWithDebug(bool allowDriveScan = false)
    {
        string steamPath = GetSteamInstallPath();
        var libraries = GetAllSteamLibraries(steamPath);
        foreach (var lib in libraries)
        {
            string dotaPath = FindDotaInLibrary(lib);
            if (!string.IsNullOrEmpty(dotaPath))
                return dotaPath;
        }

        foreach (var candidate in GetCommonFallbackPaths())
        {
            if (File.Exists(candidate))
                return candidate;
        }

        if (allowDriveScan)
        {
            var found = SearchDrivesForDota(limitFoldersPerDrive: 100);
            if (!string.IsNullOrEmpty(found))
                return found;
        }

        return null;
    }

    private static string GetSteamInstallPath()
    {
        var candidates = new (RegistryHive hive, string subKey)[]
        {
            (RegistryHive.LocalMachine, @"SOFTWARE\WOW6432Node\Valve\Steam"),
            (RegistryHive.LocalMachine, @"SOFTWARE\Valve\Steam"),
            (RegistryHive.CurrentUser, @"SOFTWARE\Valve\Steam"),
            (RegistryHive.CurrentUser, @"SOFTWARE\WOW6432Node\Valve\Steam")
        };

        foreach (var view in new[] { RegistryView.Registry64, RegistryView.Registry32 })
        {
            foreach (var c in candidates)
            {
                try
                {
                    using (var baseKey = RegistryKey.OpenBaseKey(c.hive, view))
                    using (var key = baseKey.OpenSubKey(c.subKey))
                    {
                        var val = key?.GetValue("InstallPath") as string;
                        if (!string.IsNullOrEmpty(val) && Directory.Exists(val))
                            return val;
                    }
                }
                catch
                {
                    // пропускаем ошибки доступа к реестру
                }
            }
        }

        return null;
    }

    private static List<string> GetAllSteamLibraries(string steamPath)
    {
        var libraries = new List<string>();
        if (!string.IsNullOrEmpty(steamPath) && Directory.Exists(steamPath))
            libraries.Add(steamPath);

        string vdfPath = Path.Combine(steamPath ?? string.Empty, "steamapps", "libraryfolders.vdf");
        if (!File.Exists(vdfPath))
            return libraries;

        try
        {
            string content = File.ReadAllText(vdfPath);
            var matches = Regex.Matches(content, @"\""path\""\s*\""([^\""]+)\""", RegexOptions.IgnoreCase);
            foreach (Match m in matches)
            {
                string path = m.Groups[1].Value.Replace(@"\\", @"\");
                if (Directory.Exists(path) && !libraries.Contains(path))
                    libraries.Add(path);
            }

            var simpleMatches = Regex.Matches(content, @"[A-Z]:\\\\[^\""\r\n]+", RegexOptions.IgnoreCase);
            foreach (Match m in simpleMatches)
            {
                string cand = m.Value.Replace(@"\\", @"\");
                if (Directory.Exists(cand) && Directory.Exists(Path.Combine(cand, "steamapps")) && !libraries.Contains(cand))
                    libraries.Add(cand);
            }
        }
        catch
        {
            // пропускаем ошибки чтения файла vdf
        }

        return libraries;
    }

    private static string FindDotaInLibrary(string libraryPath)
    {
        if (string.IsNullOrEmpty(libraryPath) || !Directory.Exists(libraryPath))
            return null;

        string manifestPath = Path.Combine(libraryPath, "steamapps", "appmanifest_570.acf");
        if (File.Exists(manifestPath))
        {
            try
            {
                string content = File.ReadAllText(manifestPath);
                var match = Regex.Match(content, @"\""installdir\""\s*\""([^\""]+)\""", RegexOptions.IgnoreCase);
                if (match.Success)
                {
                    string installDir = match.Groups[1].Value;
                    string gameRoot = Path.Combine(libraryPath, "steamapps", "common", installDir);

                    var possibleExes = new[]
                    {
                        Path.Combine(gameRoot, "game", "bin", "win64", "dota2.exe"),
                        Path.Combine(gameRoot, "game", "bin", "win64", "dota.exe"),
                        Path.Combine(gameRoot, "game", "bin", "win32", "dota2.exe"),
                        Path.Combine(gameRoot, "game", "bin", "win32", "dota.exe"),
                        Path.Combine(gameRoot, "dota2.exe"),
                        Path.Combine(gameRoot, "dota.exe")
                    };

                    foreach (var exe in possibleExes)
                        if (File.Exists(exe))
                            return exe;
                }
            }
            catch
            {
                // пропускаем ошибки чтения манифеста
            }
        }

        var commonRoot = Path.Combine(libraryPath, "steamapps", "common");
        if (Directory.Exists(commonRoot))
        {
            var candidates = Directory.EnumerateDirectories(commonRoot)
                                      .Where(d => d.IndexOf("dota", StringComparison.OrdinalIgnoreCase) >= 0)
                                      .ToList();
            foreach (var cand in candidates)
            {
                var possibleExes = new[]
                {
                    Path.Combine(cand, "game", "bin", "win64", "dota2.exe"),
                    Path.Combine(cand, "game", "bin", "win64", "dota.exe"),
                    Path.Combine(cand, "dota2.exe"),
                    Path.Combine(cand, "dota.exe")
                };

                foreach (var exe in possibleExes)
                    if (File.Exists(exe))
                        return exe;
            }
        }

        return null;
    }

    private static IEnumerable<string> GetCommonFallbackPaths()
    {
        var programs = new[]
        {
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "Steam"),
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "Steam")
        };

        foreach (var pf in programs.Where(Directory.Exists))
        {
            yield return Path.Combine(pf, "steamapps", "common", "dota 2 beta", "game", "bin", "win64", "dota2.exe");
            yield return Path.Combine(pf, "steamapps", "common", "dota 2 beta", "dota2.exe");
            yield return Path.Combine(pf, "steamapps", "common", "dota 2", "game", "bin", "win64", "dota2.exe");
            yield return Path.Combine(pf, "steamapps", "common", "dota 2", "dota2.exe");
        }
    }

    private static string SearchDrivesForDota(int limitFoldersPerDrive = 100)
    {
        foreach (var d in DriveInfo.GetDrives().Where(dr => dr.DriveType == DriveType.Fixed && dr.IsReady))
        {
            try
            {
                var steamappsDirs = Directory.EnumerateDirectories(d.RootDirectory.FullName, "steamapps", SearchOption.AllDirectories)
                                             .Take(limitFoldersPerDrive);

                foreach (var sa in steamappsDirs)
                {
                    string common = Path.Combine(sa, "common");
                    if (!Directory.Exists(common)) continue;

                    var candidates = Directory.EnumerateDirectories(common)
                                              .Where(p => p.IndexOf("dota", StringComparison.OrdinalIgnoreCase) >= 0);

                    foreach (var cand in candidates)
                    {
                        var exe = new[]
                        {
                            Path.Combine(cand, "game", "bin", "win64", "dota2.exe"),
                            Path.Combine(cand, "dota2.exe"),
                            Path.Combine(cand, "dota.exe")
                        }.FirstOrDefault(File.Exists);

                        if (!string.IsNullOrEmpty(exe))
                            return exe;
                    }
                }
            }
            catch
            {
                // пропускаем ошибки сканирования диска
            }
        }

        return null;
    }
}