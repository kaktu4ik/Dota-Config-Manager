namespace Dota_Config_Manager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Console = new System.Windows.Forms.RichTextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.copySettingsButton = new System.Windows.Forms.Button();
            this.howToUseButton = new System.Windows.Forms.Button();
            this.howToUseTextBox = new System.Windows.Forms.TextBox();
            this.mainIdTextBox = new System.Windows.Forms.RichTextBox();
            this.smurfIdTextBox = new System.Windows.Forms.RichTextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.hotkeysCheckBox = new System.Windows.Forms.CheckBox();
            this.heroGridsCheckBox = new System.Windows.Forms.CheckBox();
            this.guidesCheckBox = new System.Windows.Forms.CheckBox();
            this.settingsCheckBox = new System.Windows.Forms.CheckBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.customIdTextBox = new System.Windows.Forms.RichTextBox();
            this.customPathTextBox = new System.Windows.Forms.TextBox();
            this.copySettingsTextBox = new System.Windows.Forms.TextBox();
            this.startDotaCheckBox = new System.Windows.Forms.CheckBox();
            this.clientSettingsTextBox = new System.Windows.Forms.TextBox();
            this.closeAfterCopyCheckBox = new System.Windows.Forms.CheckBox();
            this.githubButton = new System.Windows.Forms.Button();
            this.githubTextBox = new System.Windows.Forms.TextBox();
            this.dotaPathValidTextBox = new System.Windows.Forms.RichTextBox();
            this.mainIdPathValidTextBox = new System.Windows.Forms.RichTextBox();
            this.smurfIdPathValidTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Console
            // 
            this.Console.AutoWordSelection = true;
            this.Console.BackColor = System.Drawing.Color.Black;
            this.Console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Console.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Console.ForeColor = System.Drawing.Color.Silver;
            this.Console.Location = new System.Drawing.Point(100, 26);
            this.Console.Name = "Console";
            this.Console.ReadOnly = true;
            this.Console.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Console.Size = new System.Drawing.Size(349, 165);
            this.Console.TabIndex = 1;
            this.Console.Text = "";
            this.Console.TextChanged += new System.EventHandler(this.Console_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.nameTextBox.Location = new System.Drawing.Point(189, 7);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(249, 13);
            this.nameTextBox.TabIndex = 7;
            this.nameTextBox.Text = "This shit made by stufuu <3";
            // 
            // copySettingsButton
            // 
            this.copySettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.copySettingsButton.FlatAppearance.BorderSize = 0;
            this.copySettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copySettingsButton.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copySettingsButton.ForeColor = System.Drawing.Color.White;
            this.copySettingsButton.Location = new System.Drawing.Point(444, 249);
            this.copySettingsButton.Name = "copySettingsButton";
            this.copySettingsButton.Size = new System.Drawing.Size(136, 25);
            this.copySettingsButton.TabIndex = 8;
            this.copySettingsButton.Text = "Copy settings";
            this.copySettingsButton.UseVisualStyleBackColor = false;
            this.copySettingsButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // howToUseButton
            // 
            this.howToUseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.howToUseButton.FlatAppearance.BorderSize = 0;
            this.howToUseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.howToUseButton.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.howToUseButton.ForeColor = System.Drawing.Color.White;
            this.howToUseButton.Location = new System.Drawing.Point(10, 253);
            this.howToUseButton.Name = "howToUseButton";
            this.howToUseButton.Size = new System.Drawing.Size(29, 25);
            this.howToUseButton.TabIndex = 9;
            this.howToUseButton.Text = "?";
            this.howToUseButton.UseVisualStyleBackColor = false;
            this.howToUseButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // howToUseTextBox
            // 
            this.howToUseTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.howToUseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.howToUseTextBox.Enabled = false;
            this.howToUseTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.howToUseTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.howToUseTextBox.Location = new System.Drawing.Point(45, 261);
            this.howToUseTextBox.Name = "howToUseTextBox";
            this.howToUseTextBox.ReadOnly = true;
            this.howToUseTextBox.Size = new System.Drawing.Size(138, 13);
            this.howToUseTextBox.TabIndex = 10;
            this.howToUseTextBox.Text = "<-- How to use?";
            // 
            // mainIdTextBox
            // 
            this.mainIdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.mainIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainIdTextBox.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainIdTextBox.ForeColor = System.Drawing.Color.White;
            this.mainIdTextBox.Location = new System.Drawing.Point(10, 222);
            this.mainIdTextBox.Name = "mainIdTextBox";
            this.mainIdTextBox.Size = new System.Drawing.Size(145, 21);
            this.mainIdTextBox.TabIndex = 11;
            this.mainIdTextBox.Text = "";
            this.mainIdTextBox.WordWrap = false;
            this.mainIdTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // smurfIdTextBox
            // 
            this.smurfIdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.smurfIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.smurfIdTextBox.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smurfIdTextBox.ForeColor = System.Drawing.Color.White;
            this.smurfIdTextBox.Location = new System.Drawing.Point(423, 222);
            this.smurfIdTextBox.Name = "smurfIdTextBox";
            this.smurfIdTextBox.Size = new System.Drawing.Size(157, 21);
            this.smurfIdTextBox.TabIndex = 12;
            this.smurfIdTextBox.Text = "";
            this.smurfIdTextBox.WordWrap = false;
            this.smurfIdTextBox.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.textBox3.Location = new System.Drawing.Point(161, 224);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(256, 13);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "<-- Main id      Smurf id-->";
            // 
            // hotkeysCheckBox
            // 
            this.hotkeysCheckBox.AutoSize = true;
            this.hotkeysCheckBox.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotkeysCheckBox.ForeColor = System.Drawing.Color.White;
            this.hotkeysCheckBox.Location = new System.Drawing.Point(455, 41);
            this.hotkeysCheckBox.Name = "hotkeysCheckBox";
            this.hotkeysCheckBox.Size = new System.Drawing.Size(75, 19);
            this.hotkeysCheckBox.TabIndex = 14;
            this.hotkeysCheckBox.Text = "Hotkeys";
            this.hotkeysCheckBox.UseVisualStyleBackColor = true;
            this.hotkeysCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // heroGridsCheckBox
            // 
            this.heroGridsCheckBox.AutoSize = true;
            this.heroGridsCheckBox.Font = new System.Drawing.Font("Consolas", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heroGridsCheckBox.ForeColor = System.Drawing.Color.White;
            this.heroGridsCheckBox.Location = new System.Drawing.Point(455, 90);
            this.heroGridsCheckBox.Name = "heroGridsCheckBox";
            this.heroGridsCheckBox.Size = new System.Drawing.Size(96, 18);
            this.heroGridsCheckBox.TabIndex = 15;
            this.heroGridsCheckBox.Text = "Hero grids";
            this.heroGridsCheckBox.UseVisualStyleBackColor = true;
            this.heroGridsCheckBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // guidesCheckBox
            // 
            this.guidesCheckBox.AutoSize = true;
            this.guidesCheckBox.Font = new System.Drawing.Font("Consolas", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guidesCheckBox.ForeColor = System.Drawing.Color.White;
            this.guidesCheckBox.Location = new System.Drawing.Point(455, 114);
            this.guidesCheckBox.Name = "guidesCheckBox";
            this.guidesCheckBox.Size = new System.Drawing.Size(68, 18);
            this.guidesCheckBox.TabIndex = 17;
            this.guidesCheckBox.Text = "Guides";
            this.guidesCheckBox.UseVisualStyleBackColor = true;
            this.guidesCheckBox.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // settingsCheckBox
            // 
            this.settingsCheckBox.AutoSize = true;
            this.settingsCheckBox.Font = new System.Drawing.Font("Consolas", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsCheckBox.ForeColor = System.Drawing.Color.White;
            this.settingsCheckBox.Location = new System.Drawing.Point(455, 66);
            this.settingsCheckBox.Name = "settingsCheckBox";
            this.settingsCheckBox.Size = new System.Drawing.Size(82, 18);
            this.settingsCheckBox.TabIndex = 16;
            this.settingsCheckBox.Text = "Settings";
            this.settingsCheckBox.UseVisualStyleBackColor = true;
            this.settingsCheckBox.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(100, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(60, 20);
            this.clearButton.TabIndex = 18;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // customIdTextBox
            // 
            this.customIdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.customIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customIdTextBox.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customIdTextBox.ForeColor = System.Drawing.Color.White;
            this.customIdTextBox.Location = new System.Drawing.Point(10, 197);
            this.customIdTextBox.Name = "customIdTextBox";
            this.customIdTextBox.Size = new System.Drawing.Size(349, 21);
            this.customIdTextBox.TabIndex = 20;
            this.customIdTextBox.Text = "";
            this.customIdTextBox.WordWrap = false;
            this.customIdTextBox.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // customPathTextBox
            // 
            this.customPathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.customPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customPathTextBox.Enabled = false;
            this.customPathTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customPathTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.customPathTextBox.Location = new System.Drawing.Point(365, 201);
            this.customPathTextBox.Name = "customPathTextBox";
            this.customPathTextBox.ReadOnly = true;
            this.customPathTextBox.Size = new System.Drawing.Size(135, 13);
            this.customPathTextBox.TabIndex = 21;
            this.customPathTextBox.Text = "<-- Custom path";
            // 
            // copySettingsTextBox
            // 
            this.copySettingsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.copySettingsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.copySettingsTextBox.Enabled = false;
            this.copySettingsTextBox.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copySettingsTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.copySettingsTextBox.Location = new System.Drawing.Point(464, 26);
            this.copySettingsTextBox.Name = "copySettingsTextBox";
            this.copySettingsTextBox.ReadOnly = true;
            this.copySettingsTextBox.Size = new System.Drawing.Size(116, 11);
            this.copySettingsTextBox.TabIndex = 23;
            this.copySettingsTextBox.Text = "Copy settings";
            this.copySettingsTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // startDotaCheckBox
            // 
            this.startDotaCheckBox.AutoSize = true;
            this.startDotaCheckBox.Font = new System.Drawing.Font("Consolas", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDotaCheckBox.ForeColor = System.Drawing.Color.White;
            this.startDotaCheckBox.Location = new System.Drawing.Point(452, 173);
            this.startDotaCheckBox.Name = "startDotaCheckBox";
            this.startDotaCheckBox.Size = new System.Drawing.Size(96, 18);
            this.startDotaCheckBox.TabIndex = 24;
            this.startDotaCheckBox.Text = "Start dota";
            this.startDotaCheckBox.UseVisualStyleBackColor = true;
            this.startDotaCheckBox.CheckedChanged += new System.EventHandler(this.startDotaCheckBox_CheckedChanged);
            // 
            // clientSettingsTextBox
            // 
            this.clientSettingsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.clientSettingsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientSettingsTextBox.Enabled = false;
            this.clientSettingsTextBox.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientSettingsTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.clientSettingsTextBox.Location = new System.Drawing.Point(464, 136);
            this.clientSettingsTextBox.Name = "clientSettingsTextBox";
            this.clientSettingsTextBox.ReadOnly = true;
            this.clientSettingsTextBox.Size = new System.Drawing.Size(126, 11);
            this.clientSettingsTextBox.TabIndex = 25;
            this.clientSettingsTextBox.Text = "Client settings";
            this.clientSettingsTextBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // closeAfterCopyCheckBox
            // 
            this.closeAfterCopyCheckBox.AutoSize = true;
            this.closeAfterCopyCheckBox.Font = new System.Drawing.Font("Consolas", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeAfterCopyCheckBox.ForeColor = System.Drawing.Color.White;
            this.closeAfterCopyCheckBox.Location = new System.Drawing.Point(452, 149);
            this.closeAfterCopyCheckBox.Name = "closeAfterCopyCheckBox";
            this.closeAfterCopyCheckBox.Size = new System.Drawing.Size(138, 18);
            this.closeAfterCopyCheckBox.TabIndex = 26;
            this.closeAfterCopyCheckBox.Text = "Close after Copy";
            this.closeAfterCopyCheckBox.UseVisualStyleBackColor = true;
            this.closeAfterCopyCheckBox.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // githubButton
            // 
            this.githubButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.githubButton.FlatAppearance.BorderSize = 0;
            this.githubButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.githubButton.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.githubButton.ForeColor = System.Drawing.Color.White;
            this.githubButton.Location = new System.Drawing.Point(189, 253);
            this.githubButton.Name = "githubButton";
            this.githubButton.Size = new System.Drawing.Size(29, 25);
            this.githubButton.TabIndex = 27;
            this.githubButton.Text = "?";
            this.githubButton.UseVisualStyleBackColor = false;
            this.githubButton.Click += new System.EventHandler(this.githubButton_Click);
            // 
            // githubTextBox
            // 
            this.githubTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.githubTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.githubTextBox.Enabled = false;
            this.githubTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.githubTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.githubTextBox.Location = new System.Drawing.Point(224, 261);
            this.githubTextBox.Name = "githubTextBox";
            this.githubTextBox.ReadOnly = true;
            this.githubTextBox.Size = new System.Drawing.Size(94, 13);
            this.githubTextBox.TabIndex = 28;
            this.githubTextBox.Text = "<-- Github";
            // 
            // dotaPathValidTextBox
            // 
            this.dotaPathValidTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.dotaPathValidTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dotaPathValidTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dotaPathValidTextBox.ForeColor = System.Drawing.Color.Silver;
            this.dotaPathValidTextBox.Location = new System.Drawing.Point(10, 7);
            this.dotaPathValidTextBox.Name = "dotaPathValidTextBox";
            this.dotaPathValidTextBox.ReadOnly = true;
            this.dotaPathValidTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.dotaPathValidTextBox.Size = new System.Drawing.Size(84, 31);
            this.dotaPathValidTextBox.TabIndex = 37;
            this.dotaPathValidTextBox.Text = "Dota.exe:   null";
            // 
            // mainIdPathValidTextBox
            // 
            this.mainIdPathValidTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.mainIdPathValidTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainIdPathValidTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainIdPathValidTextBox.ForeColor = System.Drawing.Color.Silver;
            this.mainIdPathValidTextBox.Location = new System.Drawing.Point(10, 41);
            this.mainIdPathValidTextBox.Name = "mainIdPathValidTextBox";
            this.mainIdPathValidTextBox.ReadOnly = true;
            this.mainIdPathValidTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.mainIdPathValidTextBox.Size = new System.Drawing.Size(84, 31);
            this.mainIdPathValidTextBox.TabIndex = 38;
            this.mainIdPathValidTextBox.Text = "Main id:   null";
            // 
            // smurfIdPathValidTextBox
            // 
            this.smurfIdPathValidTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.smurfIdPathValidTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.smurfIdPathValidTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.smurfIdPathValidTextBox.ForeColor = System.Drawing.Color.Silver;
            this.smurfIdPathValidTextBox.Location = new System.Drawing.Point(10, 77);
            this.smurfIdPathValidTextBox.Name = "smurfIdPathValidTextBox";
            this.smurfIdPathValidTextBox.ReadOnly = true;
            this.smurfIdPathValidTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.smurfIdPathValidTextBox.Size = new System.Drawing.Size(84, 31);
            this.smurfIdPathValidTextBox.TabIndex = 39;
            this.smurfIdPathValidTextBox.Text = "Smurf id:   null";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(588, 282);
            this.Controls.Add(this.smurfIdPathValidTextBox);
            this.Controls.Add(this.mainIdPathValidTextBox);
            this.Controls.Add(this.dotaPathValidTextBox);
            this.Controls.Add(this.githubTextBox);
            this.Controls.Add(this.githubButton);
            this.Controls.Add(this.closeAfterCopyCheckBox);
            this.Controls.Add(this.clientSettingsTextBox);
            this.Controls.Add(this.startDotaCheckBox);
            this.Controls.Add(this.copySettingsTextBox);
            this.Controls.Add(this.customPathTextBox);
            this.Controls.Add(this.customIdTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.guidesCheckBox);
            this.Controls.Add(this.settingsCheckBox);
            this.Controls.Add(this.heroGridsCheckBox);
            this.Controls.Add(this.hotkeysCheckBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.smurfIdTextBox);
            this.Controls.Add(this.mainIdTextBox);
            this.Controls.Add(this.howToUseTextBox);
            this.Controls.Add(this.howToUseButton);
            this.Controls.Add(this.copySettingsButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.Console);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Dota Config Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox Console;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button copySettingsButton;
        private System.Windows.Forms.Button howToUseButton;
        private System.Windows.Forms.TextBox howToUseTextBox;
        private System.Windows.Forms.RichTextBox mainIdTextBox;
        private System.Windows.Forms.RichTextBox smurfIdTextBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox hotkeysCheckBox;
        private System.Windows.Forms.CheckBox heroGridsCheckBox;
        private System.Windows.Forms.CheckBox guidesCheckBox;
        private System.Windows.Forms.CheckBox settingsCheckBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.RichTextBox customIdTextBox;
        private System.Windows.Forms.TextBox customPathTextBox;
        private System.Windows.Forms.TextBox copySettingsTextBox;
        private System.Windows.Forms.CheckBox startDotaCheckBox;
        private System.Windows.Forms.TextBox clientSettingsTextBox;
        private System.Windows.Forms.CheckBox closeAfterCopyCheckBox;
        private System.Windows.Forms.Button githubButton;
        private System.Windows.Forms.TextBox githubTextBox;
        private System.Windows.Forms.RichTextBox dotaPathValidTextBox;
        private System.Windows.Forms.RichTextBox mainIdPathValidTextBox;
        private System.Windows.Forms.RichTextBox smurfIdPathValidTextBox;
    }
}

