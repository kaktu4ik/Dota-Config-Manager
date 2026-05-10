/*
    ############################################
    #••••••• ••••••• •     •  ••••••• •     •  #
    #•          •    •     •  •       •     •  #
    #•••••••    •    •stufuu  •••••   •     •  #
    #      •    •    •     •  •       •     •  #
    #•••••••    •    •••••••• •       •••••••• #
    ############################################
*/

/*
 * false = "165, 42 , 42" | "Brown";
 * true = "85, 107, 47" | "DarkOliveGreen";
 * warn = "240, 230, 140" | "Khaki";
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dota_Config_Manager
{
    public partial class MainForm : Form
    {
        public bool saveHotkeys = false;
        public bool saveHeroGrids = false;
        public bool saveSettings = false;
        public bool saveGuides = false;
        public bool closeAfterCopy = false;
        public bool isDotaPathValid = false;
        public bool startDota = false;

        public string userDataPath = "C:\\Program Files (x86)\\Steam\\userdata";

        public static void CopyDirectory(string sourceDir, string destinationDir, bool recursive = true)
        {
            var dir = new DirectoryInfo(sourceDir);
            if (!dir.Exists)
                throw new DirectoryNotFoundException($"Исходная папка не найдена: {sourceDir}");

            DirectoryInfo[] dirs = dir.GetDirectories();

            // Создаём целевую папку
            Directory.CreateDirectory(destinationDir);

            // Копируем все файлы
            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = Path.Combine(destinationDir, file.Name);
                file.CopyTo(targetFilePath, true); // true = перезаписывать
            }

            // Рекурсия для подпапок
            if (recursive)
            {
                foreach (DirectoryInfo subDir in dirs)
                {
                    string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                    CopyDirectory(subDir.FullName, newDestinationDir, true);
                }
            }
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void Console_TextChanged(object sender, EventArgs e) // console
        {

        }

        private void button1_Click_1(object sender, EventArgs e) // save setting button
        {
            string mainId = mainIdTextBox.Text;
            string smurfId = smurfIdTextBox.Text;
            string customPath = customIdTextBox.Text;
            string userDataPath = "C:\\Program Files (x86)\\Steam\\userdata";

            string mainHotkeysPath = userDataPath + "\\" + mainId + "\\" + "570" + "\\" + "remote" + "\\" + "cfg" + "\\" + "dotakeys_personal.lst";
            string smurfHotkeysPath = userDataPath + "\\" + smurfId + "\\" + "570" + "\\" + "remote" + "\\" + "cfg" + "\\" + "dotakeys_personal.lst";

            string customHotKeysPath = customPath + "\\" + "570" + "\\" + "remote" + "\\" + "cfg" + "\\" + "dotakeys_personal.lst";

            string mainHeroGridsPath = userDataPath + "\\" + mainId + "\\" + "570" + "\\" + "remote" + "\\" + "cfg" + "\\" + "hero_grid_config.json";
            string smurfHeroGridsPath = userDataPath + "\\" + smurfId + "\\" + "570" + "\\" + "remote" + "\\" + "cfg" + "\\" + "hero_grid_config.json";

            string customHeroGridsPath = customPath + "\\" + "570" + "\\" + "remote" + "\\" + "cfg" + "\\" + "hero_grid_config.json";

            string mainGuidesPath = userDataPath + "\\" + mainId + "\\" + "570" + "\\" + "remote" + "\\" + "guides";
            string smurfGuidesPath = userDataPath + "\\" + smurfId + "\\" + "570" + "\\" + "remote" + "\\" + "guides";

            string customGuidesPath = customPath + "\\" + "570" + "\\" + "remote" + "\\" + "guides";

            string mainSettingPath = userDataPath + "\\" + mainId + "\\" + "570" + "\\" + "local";
            string smurfSettingPath = userDataPath + "\\" + smurfId + "\\" + "570" + "\\" + "local";

            string customSettingPath = customPath + "\\" + "570" + "\\" + "local";

            try
            {
                if (customIdTextBox.Text.Length > 0)
                {
                    if (saveHotkeys == true)
                    {
                        File.Copy(customHotKeysPath, smurfHotkeysPath, true);
                        Console.SelectionColor = Color.DarkOliveGreen;
                        Console.AppendText($"\n[{DateTime.Now.ToString("HH:mm:ss:fff")}] -> Hotkeys перенесены на смурф аккаунт.");
                        Console.SelectionColor = Color.Silver;
                    }
                    if (saveHeroGrids == true)
                    {
                        File.Copy(customHeroGridsPath, smurfHeroGridsPath, true);
                        Console.SelectionColor = Color.DarkOliveGreen;
                        Console.AppendText($"\n[{DateTime.Now.ToString("HH:mm:ss:fff")}] -> Hero Grids перенесены на смурф аккаунт.");
                        Console.SelectionColor = Color.Silver;
                    }
                    if (saveGuides == true)
                    {
                        CopyDirectory(customGuidesPath, smurfGuidesPath, true);
                        Console.SelectionColor = Color.DarkOliveGreen;
                        Console.AppendText($"\n[{DateTime.Now.ToString("HH:mm:ss:fff")}] -> Guides перенесены на смурф аккаунт.");
                        Console.SelectionColor = Color.Silver;
                    }
                    if (saveSettings == true)
                    {
                        CopyDirectory(customSettingPath, smurfSettingPath, true);
                        Console.SelectionColor = Color.DarkOliveGreen;
                        Console.AppendText($"\n[{DateTime.Now.ToString("HH:mm:ss:fff")}] -> Settings перенесены на смурф аккаунт.");
                        Console.SelectionColor = Color.Silver;
                    }
                    if (!saveHotkeys && !saveHeroGrids && !saveGuides && !saveSettings)
                    {
                        Console.SelectionColor = Color.Khaki;
                        Console.AppendText($"\n[{DateTime.Now.ToString("HH:mm:ss:fff")}] -> Вы не выбрали ни один чекбокс. Посмотрите How to use.");
                        Console.SelectionColor = Color.Silver;
                    }

                    if (startDota == true)
                    {
                        string steamUrl = $"steam://run/{570}";
                        if (isDotaPathValid == true)
                        {
                            Console.SelectionColor = Color.DarkOliveGreen;
                            Console.AppendText($"\n[{DateTime.Now.ToString("HH:mm:ss:fff")}] -> Запуск dota2.exe");
                            Process.Start(new ProcessStartInfo(steamUrl)
                            {
                                UseShellExecute = true
                            });
                            Console.SelectionColor = Color.Silver;
                        }
                        else
                        {
                            Console.SelectionColor = Color.Brown;
                            Console.AppendText($"\n[{DateTime.Now.ToString("HH:mm:ss:fff")}] -> Ошибка пути к dota2.exe");
                            Console.SelectionColor = Color.Silver;
                        }
                    }
                    if (closeAfterCopy)
                    {
                        Environment.Exit(0);
                    }
                }
                else
                {

                    if (saveHotkeys == true)
                    {
                        File.Copy(mainHotkeysPath, smurfHotkeysPath, true);
                        Console.SelectionColor = Color.DarkOliveGreen;
                        Console.AppendText($"\n[{DateTime.Now.ToString("HH:mm:ss:fff")}] -> Hotkeys перенесены на смурф аккаунт.");
                        Console.SelectionColor = Color.Silver;

                    }
                    if (saveHeroGrids == true)
                    {
                        File.Copy(mainHeroGridsPath, smurfHeroGridsPath, true);
                        Console.SelectionColor = Color.DarkOliveGreen;
                        Console.AppendText($"\n[{DateTime.Now.ToString("HH:mm:ss:fff")}] -> Hero Grids перенесены на смурф аккаунт.");
                        Console.SelectionColor = Color.Silver;
                    }
                    if (saveGuides == true)
                    {
                        CopyDirectory(mainGuidesPath, smurfGuidesPath, true);
                        Console.SelectionColor = Color.DarkOliveGreen;
                        Console.AppendText($"\n[{DateTime.Now.ToString("HH:mm:ss:fff")}] -> Guides перенесены на смурф аккаунт.");
                        Console.SelectionColor = Color.Silver;
                    }
                    if (saveSettings == true)
                    {
                        CopyDirectory(mainSettingPath, smurfSettingPath, true);
                        Console.SelectionColor = Color.DarkOliveGreen;
                        Console.AppendText($"\n[{DateTime.Now.ToString("HH:mm:ss:fff")}] -> Settings перенесены на смурф аккаунт.");
                        Console.SelectionColor = Color.Silver;
                    }
                    if (!saveHotkeys && !saveHeroGrids && !saveGuides && !saveSettings)
                    {
                        Console.SelectionColor = Color.Khaki;
                        Console.AppendText($"\n[{DateTime.Now.ToString("HH:mm:ss:fff")}] -> Вы не выбрали ни один чекбокс. Посмотрите How to use.");
                        Console.SelectionColor = Color.Silver;
                    }
                    if (startDota == true)
                    {
                        string steamUrl = $"steam://run/{570}";
                        if (isDotaPathValid == true)
                        {
                            Console.SelectionColor = Color.DarkOliveGreen;
                            Console.AppendText($"\n[{DateTime.Now.ToString("HH:mm:ss:fff")}] -> Запуск dota2.exe");
                            Process.Start(new ProcessStartInfo(steamUrl)
                            {
                                UseShellExecute = true
                            });
                            Console.SelectionColor = Color.Silver;
                        }
                        else
                        {
                            Console.SelectionColor = Color.Brown;
                            Console.AppendText($"\n[{DateTime.Now.ToString("HH:mm:ss:fff")}] -> Ошибка пути к dota2.exe");
                            Console.SelectionColor = Color.Silver;
                        }
                    }
                    if (closeAfterCopy)
                    {
                        Environment.Exit(0);
                    }
                }


            }
            catch (Exception)
            {
                Console.SelectionColor = Color.Brown;
                Console.AppendText($"\n[{DateTime.Now.ToString("HH:mm:ss:fff")}] -> Не удалось выполнить коприрование конфига. Посмотрите How to use.");
                Console.SelectionColor = Color.Silver;
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) // main id
        {
            string tempDir = mainIdTextBox.Text;

            if (Directory.Exists(userDataPath + "\\" + tempDir))
            {
                mainIdPathValidTextBox.ForeColor = Color.DarkOliveGreen;
                mainIdPathValidTextBox.Text = "Main id:   true";
            }
            if (!Directory.Exists(userDataPath + "\\" + tempDir))
            {
                mainIdPathValidTextBox.ForeColor = Color.Brown;
                mainIdPathValidTextBox.Text = "Main id:   false";
            }
            if (mainIdTextBox.Text.Length < 1)
            {
                mainIdPathValidTextBox.ForeColor = Color.Silver;
                mainIdPathValidTextBox.Text = "Main id:   null";
            }
            if (customIdTextBox.Text.Length > 0)
            {
                mainIdPathValidTextBox.ForeColor = Color.DarkMagenta;
                mainIdPathValidTextBox.Text = "Main id:   custom";
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e) // smurf id
        {
            string tempDir = smurfIdTextBox.Text;

            if (Directory.Exists(userDataPath + "\\" + tempDir))
            {
                smurfIdPathValidTextBox.ForeColor = Color.DarkOliveGreen;
                smurfIdPathValidTextBox.Text = "Smurf id:   true";
            }
            if (!Directory.Exists(userDataPath + "\\" + tempDir))
            {
                smurfIdPathValidTextBox.ForeColor = Color.Brown;
                smurfIdPathValidTextBox.Text = "Smurf id:   false";
            }
            if (smurfIdTextBox.Text.Length < 1)
            {
                smurfIdPathValidTextBox.ForeColor = Color.Silver;
                smurfIdPathValidTextBox.Text = "Smurf id:   null";
            }
        }

        private void button4_Click(object sender, EventArgs e) // how to use buttton
        {
            Process.Start(new ProcessStartInfo("https://youtu.be/88kAkT2SPZI") { UseShellExecute = true });
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) // save Hotkeys checkbox
        {
            if (hotkeysCheckBox.Checked)
            {
                saveHotkeys = true;
            }
            else
            {
                saveHotkeys = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) // save Hero grid checkbox
        {
            if (heroGridsCheckBox.Checked)
            {
                saveHeroGrids = true;
            }
            else
            {
                saveHeroGrids = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e) // save Settings checkbox
        {
            if (settingsCheckBox.Checked)
            {
                saveSettings = true;
            }
            else
            {
                saveSettings = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e) // save Guides checkbox
        {
            if (guidesCheckBox.Checked)
            {
                saveGuides = true;
            }
            else
            {
                saveGuides = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e) // form
        {
            Console.SelectionColor = Color.Silver;
            Console.AppendText($"[{DateTime.Now.ToString("HH:mm:ss.fff")}] -> logs console [v2]");

            string dotaExe = SteamDotaFinder.FindDotaExe();
            if (dotaExe != null)
            {
                isDotaPathValid = true;
                dotaPathValidTextBox.Text = "Dota.exe:   true";
                dotaPathValidTextBox.ForeColor = Color.DarkOliveGreen;

                Console.SelectionColor = Color.DarkOliveGreen;
                Console.AppendText($"\n[{DateTime.Now.ToString("HH:mm:ss.fff")}] -> Путь к dota2.exe найден");
            }
            else
            {
                isDotaPathValid = false;
                dotaPathValidTextBox.Text = "Dota.exe:   false";
                dotaPathValidTextBox.ForeColor = Color.Brown;

                Console.SelectionColor = Color.Brown;
                Console.AppendText($"\n[{DateTime.Now.ToString("HH:mm:ss.fff")}] -> Путь к dota2.exe не найден");
            }

        }

        private void button2_Click_1(object sender, EventArgs e) // Clear button
        {
            Console.Clear();

            Console.SelectionColor = Color.Silver;
            Console.AppendText($"[{DateTime.Now.ToString("HH:mm:ss.fff")}] -> logs console [v2]");
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e) // custom path textbox
        {
            if (customIdTextBox.Text.Length > 0)
            {
                mainIdPathValidTextBox.ForeColor = Color.DarkMagenta;
                mainIdPathValidTextBox.Text = "Main id:   custom";
            }
            if (customIdTextBox.Text.Length < 1)
            {
                mainIdPathValidTextBox.ForeColor = Color.Silver;
                mainIdPathValidTextBox.Text = "Main id:   null";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e) // Close After Copy checkbox
        {
            if (closeAfterCopyCheckBox.Checked == true)
            {
                closeAfterCopy = true;
            }
            else {
                closeAfterCopy = false;
            }
        }

        private void startDotaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (startDotaCheckBox.Checked)
            {
                startDota = true;
            }
            else
            {
                startDota = false;
            }
        }

        private void githubButton_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/kaktu4ik/Dota-Config-Manager") { UseShellExecute = true });
        }
    }
}
