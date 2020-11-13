namespace ConsoleSaveManager.Settings
{
    partial class NswSettings
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
            this.NswSettingsLabel = new System.Windows.Forms.Label();
            this.TextBoxNswSaveLocation = new System.Windows.Forms.TextBox();
            this.ButtonNswBrowse = new System.Windows.Forms.Button();
            this.ButtonNswSettingsSave = new System.Windows.Forms.Button();
            this.LabelCurrentSettings = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxSavedNswPath = new System.Windows.Forms.TextBox();
            this.ButtonBackXboxSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NswSettingsLabel
            // 
            this.NswSettingsLabel.AutoSize = true;
            this.NswSettingsLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NswSettingsLabel.Location = new System.Drawing.Point(12, 43);
            this.NswSettingsLabel.Name = "NswSettingsLabel";
            this.NswSettingsLabel.Size = new System.Drawing.Size(93, 18);
            this.NswSettingsLabel.TabIndex = 0;
            this.NswSettingsLabel.Text = "Save location:";
            // 
            // TextBoxNswSaveLocation
            // 
            this.TextBoxNswSaveLocation.Location = new System.Drawing.Point(108, 41);
            this.TextBoxNswSaveLocation.Name = "TextBoxNswSaveLocation";
            this.TextBoxNswSaveLocation.Size = new System.Drawing.Size(331, 20);
            this.TextBoxNswSaveLocation.TabIndex = 1;
            // 
            // ButtonNswBrowse
            // 
            this.ButtonNswBrowse.Location = new System.Drawing.Point(445, 41);
            this.ButtonNswBrowse.Name = "ButtonNswBrowse";
            this.ButtonNswBrowse.Size = new System.Drawing.Size(71, 22);
            this.ButtonNswBrowse.TabIndex = 2;
            this.ButtonNswBrowse.Text = "Browse";
            this.ButtonNswBrowse.UseVisualStyleBackColor = true;
            this.ButtonNswBrowse.Click += new System.EventHandler(this.ButtonNswBrowse_Click);
            // 
            // ButtonNswSettingsSave
            // 
            this.ButtonNswSettingsSave.Location = new System.Drawing.Point(235, 147);
            this.ButtonNswSettingsSave.Name = "ButtonNswSettingsSave";
            this.ButtonNswSettingsSave.Size = new System.Drawing.Size(71, 22);
            this.ButtonNswSettingsSave.TabIndex = 3;
            this.ButtonNswSettingsSave.Text = "Save";
            this.ButtonNswSettingsSave.UseVisualStyleBackColor = true;
            this.ButtonNswSettingsSave.Click += new System.EventHandler(this.ButtonNswSettingsSave_Click);
            // 
            // LabelCurrentSettings
            // 
            this.LabelCurrentSettings.AutoSize = true;
            this.LabelCurrentSettings.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCurrentSettings.Location = new System.Drawing.Point(12, 95);
            this.LabelCurrentSettings.Name = "LabelCurrentSettings";
            this.LabelCurrentSettings.Size = new System.Drawing.Size(96, 18);
            this.LabelCurrentSettings.TabIndex = 11;
            this.LabelCurrentSettings.Text = "Saved settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Save location:";
            // 
            // TextBoxSavedNswPath
            // 
            this.TextBoxSavedNswPath.Location = new System.Drawing.Point(108, 121);
            this.TextBoxSavedNswPath.Name = "TextBoxSavedNswPath";
            this.TextBoxSavedNswPath.Size = new System.Drawing.Size(331, 20);
            this.TextBoxSavedNswPath.TabIndex = 13;
            // 
            // ButtonBackXboxSettings
            // 
            this.ButtonBackXboxSettings.Location = new System.Drawing.Point(15, 12);
            this.ButtonBackXboxSettings.Name = "ButtonBackXboxSettings";
            this.ButtonBackXboxSettings.Size = new System.Drawing.Size(40, 23);
            this.ButtonBackXboxSettings.TabIndex = 14;
            this.ButtonBackXboxSettings.Text = "🢀";
            this.ButtonBackXboxSettings.UseVisualStyleBackColor = true;
            this.ButtonBackXboxSettings.Click += new System.EventHandler(this.ButtonBackXboxSettings_Click);
            // 
            // NswSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 181);
            this.Controls.Add(this.ButtonBackXboxSettings);
            this.Controls.Add(this.TextBoxSavedNswPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelCurrentSettings);
            this.Controls.Add(this.ButtonNswSettingsSave);
            this.Controls.Add(this.ButtonNswBrowse);
            this.Controls.Add(this.TextBoxNswSaveLocation);
            this.Controls.Add(this.NswSettingsLabel);
            this.Name = "NswSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NswSettings";
            this.Load += new System.EventHandler(this.NswSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NswSettingsLabel;
        private System.Windows.Forms.TextBox TextBoxNswSaveLocation;
        private System.Windows.Forms.Button ButtonNswBrowse;
        private System.Windows.Forms.Button ButtonNswSettingsSave;
        private System.Windows.Forms.Label LabelCurrentSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxSavedNswPath;
        private System.Windows.Forms.Button ButtonBackXboxSettings;
    }
}