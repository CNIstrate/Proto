namespace ConsoleSaveManager.MenuOptions.NSW
{
    partial class NswMenu
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
            this.ImportButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.ButtonBackNswMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ImportButton
            // 
            this.ImportButton.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportButton.Location = new System.Drawing.Point(14, 151);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(460, 100);
            this.ImportButton.TabIndex = 4;
            this.ImportButton.Text = "IMPORT";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportButton.Location = new System.Drawing.Point(14, 45);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(460, 100);
            this.ExportButton.TabIndex = 3;
            this.ExportButton.Text = "EXPORT";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ButtonBackNswMenu
            // 
            this.ButtonBackNswMenu.Location = new System.Drawing.Point(14, 12);
            this.ButtonBackNswMenu.Name = "ButtonBackNswMenu";
            this.ButtonBackNswMenu.Size = new System.Drawing.Size(40, 23);
            this.ButtonBackNswMenu.TabIndex = 5;
            this.ButtonBackNswMenu.Text = "🢀";
            this.ButtonBackNswMenu.UseVisualStyleBackColor = true;
            this.ButtonBackNswMenu.Click += new System.EventHandler(this.ButtonBackXboxSettings_Click);
            // 
            // NswMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 263);
            this.Controls.Add(this.ButtonBackNswMenu);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.ExportButton);
            this.Name = "NswMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NSW Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button ButtonBackNswMenu;
    }
}