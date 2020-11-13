namespace ConsoleSaveManager
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            this.XboxButton = new System.Windows.Forms.Button();
            this.PS4Button = new System.Windows.Forms.Button();
            this.NSWButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // XboxButton
            // 
            this.XboxButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.XboxButton.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XboxButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.XboxButton.Location = new System.Drawing.Point(12, 37);
            this.XboxButton.Name = "XboxButton";
            this.XboxButton.Size = new System.Drawing.Size(440, 100);
            this.XboxButton.TabIndex = 0;
            this.XboxButton.Text = "XBOX";
            this.XboxButton.UseVisualStyleBackColor = false;
            this.XboxButton.Click += new System.EventHandler(this.XboxButton_Click);
            // 
            // PS4Button
            // 
            this.PS4Button.BackColor = System.Drawing.Color.Blue;
            this.PS4Button.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PS4Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PS4Button.Location = new System.Drawing.Point(12, 143);
            this.PS4Button.Name = "PS4Button";
            this.PS4Button.Size = new System.Drawing.Size(440, 100);
            this.PS4Button.TabIndex = 1;
            this.PS4Button.Text = "PS4";
            this.PS4Button.UseVisualStyleBackColor = false;
            this.PS4Button.Click += new System.EventHandler(this.PS4Button_Click);
            // 
            // NSWButton
            // 
            this.NSWButton.BackColor = System.Drawing.Color.Red;
            this.NSWButton.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NSWButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NSWButton.Location = new System.Drawing.Point(12, 249);
            this.NSWButton.Name = "NSWButton";
            this.NSWButton.Size = new System.Drawing.Size(440, 100);
            this.NSWButton.TabIndex = 2;
            this.NSWButton.Text = "NSW";
            this.NSWButton.UseVisualStyleBackColor = false;
            this.NSWButton.Click += new System.EventHandler(this.NSWButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(464, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.Olive;
            this.buttonSettings.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSettings.Location = new System.Drawing.Point(12, 355);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(440, 100);
            this.buttonSettings.TabIndex = 4;
            this.buttonSettings.Text = "SETTINGS";
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 465);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.NSWButton);
            this.Controls.Add(this.PS4Button);
            this.Controls.Add(this.XboxButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button XboxButton;
        private System.Windows.Forms.Button PS4Button;
        private System.Windows.Forms.Button NSWButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

