namespace ConsoleSaveManager.MenuOptions.Xbox
{
    partial class XboxExportMenu
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
            this.xboxExportMenuTitle = new System.Windows.Forms.Label();
            this.exportToLabel = new System.Windows.Forms.Label();
            this.ExportStart = new System.Windows.Forms.Button();
            this.exportMenuTextBox = new System.Windows.Forms.TextBox();
            this.ButtonBackXboxSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xboxExportMenuTitle
            // 
            this.xboxExportMenuTitle.AutoSize = true;
            this.xboxExportMenuTitle.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xboxExportMenuTitle.Location = new System.Drawing.Point(123, 12);
            this.xboxExportMenuTitle.Name = "xboxExportMenuTitle";
            this.xboxExportMenuTitle.Size = new System.Drawing.Size(179, 59);
            this.xboxExportMenuTitle.TabIndex = 0;
            this.xboxExportMenuTitle.Text = "EXPORT";
            // 
            // exportToLabel
            // 
            this.exportToLabel.AutoSize = true;
            this.exportToLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportToLabel.Location = new System.Drawing.Point(12, 89);
            this.exportToLabel.Name = "exportToLabel";
            this.exportToLabel.Size = new System.Drawing.Size(86, 18);
            this.exportToLabel.TabIndex = 1;
            this.exportToLabel.Text = "Exporting to:";
            // 
            // ExportStart
            // 
            this.ExportStart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportStart.Location = new System.Drawing.Point(163, 117);
            this.ExportStart.Name = "ExportStart";
            this.ExportStart.Size = new System.Drawing.Size(85, 32);
            this.ExportStart.TabIndex = 2;
            this.ExportStart.Text = "Start";
            this.ExportStart.UseVisualStyleBackColor = true;
            this.ExportStart.Click += new System.EventHandler(this.ExportStart_Click);
            // 
            // exportMenuTextBox
            // 
            this.exportMenuTextBox.Location = new System.Drawing.Point(98, 87);
            this.exportMenuTextBox.Name = "exportMenuTextBox";
            this.exportMenuTextBox.ReadOnly = true;
            this.exportMenuTextBox.Size = new System.Drawing.Size(293, 20);
            this.exportMenuTextBox.TabIndex = 3;
            // 
            // ButtonBackXboxSettings
            // 
            this.ButtonBackXboxSettings.Location = new System.Drawing.Point(15, 12);
            this.ButtonBackXboxSettings.Name = "ButtonBackXboxSettings";
            this.ButtonBackXboxSettings.Size = new System.Drawing.Size(40, 23);
            this.ButtonBackXboxSettings.TabIndex = 4;
            this.ButtonBackXboxSettings.Text = "🢀";
            this.ButtonBackXboxSettings.UseVisualStyleBackColor = true;
            this.ButtonBackXboxSettings.Click += new System.EventHandler(this.ButtonBackXboxExportMenu_Click);
            // 
            // XboxExportMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 161);
            this.Controls.Add(this.ButtonBackXboxSettings);
            this.Controls.Add(this.exportMenuTextBox);
            this.Controls.Add(this.ExportStart);
            this.Controls.Add(this.exportToLabel);
            this.Controls.Add(this.xboxExportMenuTitle);
            this.MaximumSize = new System.Drawing.Size(420, 200);
            this.MinimumSize = new System.Drawing.Size(420, 200);
            this.Name = "XboxExportMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XboxExportMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label xboxExportMenuTitle;
        private System.Windows.Forms.Label exportToLabel;
        private System.Windows.Forms.Button ExportStart;
        private System.Windows.Forms.TextBox exportMenuTextBox;
        private System.Windows.Forms.Button ButtonBackXboxSettings;
    }
}