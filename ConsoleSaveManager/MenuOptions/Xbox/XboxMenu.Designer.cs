namespace ConsoleSaveManager
{
    partial class XboxMenu
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
            this.ExportButton = new System.Windows.Forms.Button();
            this.ImportButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ButtonBackXboxSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExportButton
            // 
            this.ExportButton.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportButton.Location = new System.Drawing.Point(12, 31);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(460, 100);
            this.ExportButton.TabIndex = 1;
            this.ExportButton.Text = "EXPORT";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ImportButton
            // 
            this.ImportButton.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportButton.Location = new System.Drawing.Point(12, 137);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(460, 100);
            this.ImportButton.TabIndex = 2;
            this.ImportButton.Text = "IMPORT";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(12, 243);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(460, 100);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // ButtonBackXboxSettings
            // 
            this.ButtonBackXboxSettings.Location = new System.Drawing.Point(12, 2);
            this.ButtonBackXboxSettings.Name = "ButtonBackXboxSettings";
            this.ButtonBackXboxSettings.Size = new System.Drawing.Size(40, 23);
            this.ButtonBackXboxSettings.TabIndex = 4;
            this.ButtonBackXboxSettings.Text = "🢀";
            this.ButtonBackXboxSettings.UseVisualStyleBackColor = true;
            this.ButtonBackXboxSettings.Click += new System.EventHandler(this.ButtonBackXboxMenu_Click);
            // 
            // XboxMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.ButtonBackXboxSettings);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.ExportButton);
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "XboxMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XboxMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ButtonBackXboxSettings;
    }
}