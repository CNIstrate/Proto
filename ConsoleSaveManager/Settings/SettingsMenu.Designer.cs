namespace ConsoleSaveManager.Settings
{
    partial class SettingsMenu
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
            this.NSWSettingsButton = new System.Windows.Forms.Button();
            this.PS4SettingsButton = new System.Windows.Forms.Button();
            this.XboxSettingsButton = new System.Windows.Forms.Button();
            this.ButtonBackNswSettings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NSWSettingsButton
            // 
            this.NSWSettingsButton.BackColor = System.Drawing.Color.Red;
            this.NSWSettingsButton.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NSWSettingsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NSWSettingsButton.Location = new System.Drawing.Point(12, 305);
            this.NSWSettingsButton.Name = "NSWSettingsButton";
            this.NSWSettingsButton.Size = new System.Drawing.Size(440, 100);
            this.NSWSettingsButton.TabIndex = 5;
            this.NSWSettingsButton.Text = "NSW";
            this.NSWSettingsButton.UseVisualStyleBackColor = false;
            this.NSWSettingsButton.Click += new System.EventHandler(this.NSWSettingsButton_Click);
            // 
            // PS4SettingsButton
            // 
            this.PS4SettingsButton.BackColor = System.Drawing.Color.Blue;
            this.PS4SettingsButton.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PS4SettingsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PS4SettingsButton.Location = new System.Drawing.Point(12, 199);
            this.PS4SettingsButton.Name = "PS4SettingsButton";
            this.PS4SettingsButton.Size = new System.Drawing.Size(440, 100);
            this.PS4SettingsButton.TabIndex = 4;
            this.PS4SettingsButton.Text = "PS4";
            this.PS4SettingsButton.UseVisualStyleBackColor = false;
            this.PS4SettingsButton.Click += new System.EventHandler(this.PS4SettingsButton_Click);
            // 
            // XboxSettingsButton
            // 
            this.XboxSettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.XboxSettingsButton.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XboxSettingsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.XboxSettingsButton.Location = new System.Drawing.Point(12, 93);
            this.XboxSettingsButton.Name = "XboxSettingsButton";
            this.XboxSettingsButton.Size = new System.Drawing.Size(440, 100);
            this.XboxSettingsButton.TabIndex = 3;
            this.XboxSettingsButton.Text = "XBOX";
            this.XboxSettingsButton.UseVisualStyleBackColor = false;
            this.XboxSettingsButton.Click += new System.EventHandler(this.XboxSettingsButton_Click);
            // 
            // ButtonBackNswSettings
            // 
            this.ButtonBackNswSettings.Location = new System.Drawing.Point(12, 12);
            this.ButtonBackNswSettings.Name = "ButtonBackNswSettings";
            this.ButtonBackNswSettings.Size = new System.Drawing.Size(40, 23);
            this.ButtonBackNswSettings.TabIndex = 6;
            this.ButtonBackNswSettings.Text = "🢀";
            this.ButtonBackNswSettings.UseVisualStyleBackColor = true;
            this.ButtonBackNswSettings.Click += new System.EventHandler(this.ButtonBackNswSettings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 59);
            this.label1.TabIndex = 7;
            this.label1.Text = "SETTINGS";
            // 
            // SettingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonBackNswSettings);
            this.Controls.Add(this.NSWSettingsButton);
            this.Controls.Add(this.PS4SettingsButton);
            this.Controls.Add(this.XboxSettingsButton);
            this.Name = "SettingsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NSWSettingsButton;
        private System.Windows.Forms.Button PS4SettingsButton;
        private System.Windows.Forms.Button XboxSettingsButton;
        private System.Windows.Forms.Button ButtonBackNswSettings;
        private System.Windows.Forms.Label label1;
    }
}