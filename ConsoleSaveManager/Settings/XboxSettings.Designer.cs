namespace ConsoleSaveManager
{
    partial class XboxSettings
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
                if (System.Windows.Forms.Application.MessageLoop)
                {
                    // WinForms app
                    System.Windows.Forms.Application.Exit();
                }
                else
                {
                    // Console app
                    System.Environment.Exit(1);
                }
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
            this.LabelExportPath = new System.Windows.Forms.Label();
            this.LabelConsoleIP = new System.Windows.Forms.Label();
            this.ButtonBackXboxSettings = new System.Windows.Forms.Button();
            this.TextBoxConsoleIP = new System.Windows.Forms.TextBox();
            this.TextBoxExportedSavesPath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LabelAppxManifestFile = new System.Windows.Forms.Label();
            this.TextBoxAppxManifestFile = new System.Windows.Forms.TextBox();
            this.ButtonBrowseAppxManifestFile = new System.Windows.Forms.Button();
            this.ButtonBrowseExportedSavesPath = new System.Windows.Forms.Button();
            this.LabelCurrentSettings = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelSavedIP = new System.Windows.Forms.Label();
            this.LabelSavedAppxManifest = new System.Windows.Forms.Label();
            this.LabelSavedExported = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelSavedSCID = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelExportPath
            // 
            this.LabelExportPath.AutoSize = true;
            this.LabelExportPath.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelExportPath.Location = new System.Drawing.Point(5, 93);
            this.LabelExportPath.Name = "LabelExportPath";
            this.LabelExportPath.Size = new System.Drawing.Size(136, 18);
            this.LabelExportPath.TabIndex = 0;
            this.LabelExportPath.Text = "Exported saves path:";
            // 
            // LabelConsoleIP
            // 
            this.LabelConsoleIP.AutoSize = true;
            this.LabelConsoleIP.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelConsoleIP.Location = new System.Drawing.Point(64, 36);
            this.LabelConsoleIP.Name = "LabelConsoleIP";
            this.LabelConsoleIP.Size = new System.Drawing.Size(77, 18);
            this.LabelConsoleIP.TabIndex = 1;
            this.LabelConsoleIP.Text = "Console IP:";
            // 
            // ButtonBackXboxSettings
            // 
            this.ButtonBackXboxSettings.Location = new System.Drawing.Point(8, 2);
            this.ButtonBackXboxSettings.Name = "ButtonBackXboxSettings";
            this.ButtonBackXboxSettings.Size = new System.Drawing.Size(40, 23);
            this.ButtonBackXboxSettings.TabIndex = 2;
            this.ButtonBackXboxSettings.Text = "🢀";
            this.ButtonBackXboxSettings.UseVisualStyleBackColor = true;
            this.ButtonBackXboxSettings.Click += new System.EventHandler(this.ButtonBackXboxSettings_Click);
            // 
            // TextBoxConsoleIP
            // 
            this.TextBoxConsoleIP.Location = new System.Drawing.Point(148, 33);
            this.TextBoxConsoleIP.Name = "TextBoxConsoleIP";
            this.TextBoxConsoleIP.Size = new System.Drawing.Size(100, 20);
            this.TextBoxConsoleIP.TabIndex = 3;
            this.TextBoxConsoleIP.Text = "none";
            this.TextBoxConsoleIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxExportedSavesPath
            // 
            this.TextBoxExportedSavesPath.Location = new System.Drawing.Point(148, 93);
            this.TextBoxExportedSavesPath.Name = "TextBoxExportedSavesPath";
            this.TextBoxExportedSavesPath.ReadOnly = true;
            this.TextBoxExportedSavesPath.Size = new System.Drawing.Size(381, 20);
            this.TextBoxExportedSavesPath.TabIndex = 4;
            this.TextBoxExportedSavesPath.Text = "none";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(272, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LabelAppxManifestFile
            // 
            this.LabelAppxManifestFile.AutoSize = true;
            this.LabelAppxManifestFile.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAppxManifestFile.Location = new System.Drawing.Point(18, 65);
            this.LabelAppxManifestFile.Name = "LabelAppxManifestFile";
            this.LabelAppxManifestFile.Size = new System.Drawing.Size(123, 18);
            this.LabelAppxManifestFile.TabIndex = 6;
            this.LabelAppxManifestFile.Text = "AppxManifest file:";
            // 
            // TextBoxAppxManifestFile
            // 
            this.TextBoxAppxManifestFile.Location = new System.Drawing.Point(148, 63);
            this.TextBoxAppxManifestFile.Name = "TextBoxAppxManifestFile";
            this.TextBoxAppxManifestFile.ReadOnly = true;
            this.TextBoxAppxManifestFile.Size = new System.Drawing.Size(381, 20);
            this.TextBoxAppxManifestFile.TabIndex = 7;
            this.TextBoxAppxManifestFile.Text = "none";
            // 
            // ButtonBrowseAppxManifestFile
            // 
            this.ButtonBrowseAppxManifestFile.Location = new System.Drawing.Point(535, 61);
            this.ButtonBrowseAppxManifestFile.Name = "ButtonBrowseAppxManifestFile";
            this.ButtonBrowseAppxManifestFile.Size = new System.Drawing.Size(75, 23);
            this.ButtonBrowseAppxManifestFile.TabIndex = 8;
            this.ButtonBrowseAppxManifestFile.Text = "Browse";
            this.ButtonBrowseAppxManifestFile.UseVisualStyleBackColor = true;
            this.ButtonBrowseAppxManifestFile.Click += new System.EventHandler(this.ButtonBrowseAppxManifestFile_Click);
            // 
            // ButtonBrowseExportedSavesPath
            // 
            this.ButtonBrowseExportedSavesPath.Location = new System.Drawing.Point(535, 91);
            this.ButtonBrowseExportedSavesPath.Name = "ButtonBrowseExportedSavesPath";
            this.ButtonBrowseExportedSavesPath.Size = new System.Drawing.Size(75, 23);
            this.ButtonBrowseExportedSavesPath.TabIndex = 9;
            this.ButtonBrowseExportedSavesPath.Text = "Browse";
            this.ButtonBrowseExportedSavesPath.UseVisualStyleBackColor = true;
            this.ButtonBrowseExportedSavesPath.Click += new System.EventHandler(this.ButtonBrowseExportedSavesPath_Click);
            // 
            // LabelCurrentSettings
            // 
            this.LabelCurrentSettings.AutoSize = true;
            this.LabelCurrentSettings.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCurrentSettings.Location = new System.Drawing.Point(35, 138);
            this.LabelCurrentSettings.Name = "LabelCurrentSettings";
            this.LabelCurrentSettings.Size = new System.Drawing.Size(96, 18);
            this.LabelCurrentSettings.TabIndex = 10;
            this.LabelCurrentSettings.Text = "Saved settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "AppxManifest file:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Console IP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Exported saves path:";
            // 
            // LabelSavedIP
            // 
            this.LabelSavedIP.AutoSize = true;
            this.LabelSavedIP.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSavedIP.Location = new System.Drawing.Point(147, 165);
            this.LabelSavedIP.Name = "LabelSavedIP";
            this.LabelSavedIP.Size = new System.Drawing.Size(0, 18);
            this.LabelSavedIP.TabIndex = 14;
            // 
            // LabelSavedAppxManifest
            // 
            this.LabelSavedAppxManifest.AutoSize = true;
            this.LabelSavedAppxManifest.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSavedAppxManifest.Location = new System.Drawing.Point(147, 194);
            this.LabelSavedAppxManifest.Name = "LabelSavedAppxManifest";
            this.LabelSavedAppxManifest.Size = new System.Drawing.Size(0, 18);
            this.LabelSavedAppxManifest.TabIndex = 15;
            // 
            // LabelSavedExported
            // 
            this.LabelSavedExported.AutoSize = true;
            this.LabelSavedExported.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSavedExported.Location = new System.Drawing.Point(147, 222);
            this.LabelSavedExported.Name = "LabelSavedExported";
            this.LabelSavedExported.Size = new System.Drawing.Size(0, 18);
            this.LabelSavedExported.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(269, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "SCID:";
            // 
            // LabelSavedSCID
            // 
            this.LabelSavedSCID.Location = new System.Drawing.Point(315, 165);
            this.LabelSavedSCID.Name = "LabelSavedSCID";
            this.LabelSavedSCID.ReadOnly = true;
            this.LabelSavedSCID.Size = new System.Drawing.Size(229, 20);
            this.LabelSavedSCID.TabIndex = 20;
            this.LabelSavedSCID.Text = "Empty";
            this.LabelSavedSCID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(8, 261);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(50, 32);
            this.buttonClear.TabIndex = 21;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // XboxSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 305);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.LabelSavedSCID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LabelSavedExported);
            this.Controls.Add(this.LabelSavedAppxManifest);
            this.Controls.Add(this.LabelSavedIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelCurrentSettings);
            this.Controls.Add(this.ButtonBrowseExportedSavesPath);
            this.Controls.Add(this.ButtonBrowseAppxManifestFile);
            this.Controls.Add(this.TextBoxAppxManifestFile);
            this.Controls.Add(this.LabelAppxManifestFile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBoxExportedSavesPath);
            this.Controls.Add(this.TextBoxConsoleIP);
            this.Controls.Add(this.ButtonBackXboxSettings);
            this.Controls.Add(this.LabelConsoleIP);
            this.Controls.Add(this.LabelExportPath);
            this.Name = "XboxSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XboxSettings";
            this.Load += new System.EventHandler(this.XboxSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelExportPath;
        private System.Windows.Forms.Label LabelConsoleIP;
        private System.Windows.Forms.Button ButtonBackXboxSettings;
        private System.Windows.Forms.TextBox TextBoxConsoleIP;
        private System.Windows.Forms.TextBox TextBoxExportedSavesPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LabelAppxManifestFile;
        private System.Windows.Forms.TextBox TextBoxAppxManifestFile;
        private System.Windows.Forms.Button ButtonBrowseAppxManifestFile;
        private System.Windows.Forms.Button ButtonBrowseExportedSavesPath;
        private System.Windows.Forms.Label LabelCurrentSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label LabelSavedIP;
        public System.Windows.Forms.Label LabelSavedAppxManifest;
        public System.Windows.Forms.Label LabelSavedExported;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LabelSavedSCID;
        private System.Windows.Forms.Button buttonClear;
    }
}