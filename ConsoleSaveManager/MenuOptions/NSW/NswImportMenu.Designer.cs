namespace ConsoleSaveManager.MenuOptions.NSW
{
    partial class NswImportMenu
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
            this.LabelmportNsw = new System.Windows.Forms.Label();
            this.TextNswImportPath = new System.Windows.Forms.TextBox();
            this.ButtomImportBrowse = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ButtonBackNswMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelmportNsw
            // 
            this.LabelmportNsw.AutoSize = true;
            this.LabelmportNsw.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelmportNsw.Location = new System.Drawing.Point(12, 60);
            this.LabelmportNsw.Name = "LabelmportNsw";
            this.LabelmportNsw.Size = new System.Drawing.Size(87, 18);
            this.LabelmportNsw.TabIndex = 0;
            this.LabelmportNsw.Text = "Import from:";
            // 
            // TextNswImportPath
            // 
            this.TextNswImportPath.Location = new System.Drawing.Point(105, 58);
            this.TextNswImportPath.Name = "TextNswImportPath";
            this.TextNswImportPath.Size = new System.Drawing.Size(367, 20);
            this.TextNswImportPath.TabIndex = 1;
            // 
            // ButtomImportBrowse
            // 
            this.ButtomImportBrowse.Location = new System.Drawing.Point(478, 58);
            this.ButtomImportBrowse.Name = "ButtomImportBrowse";
            this.ButtomImportBrowse.Size = new System.Drawing.Size(71, 20);
            this.ButtomImportBrowse.TabIndex = 2;
            this.ButtomImportBrowse.Text = "Browse";
            this.ButtomImportBrowse.UseVisualStyleBackColor = true;
            this.ButtomImportBrowse.Click += new System.EventHandler(this.ButtomImportBrowse_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(259, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Import";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ButtonBackNswMenu
            // 
            this.ButtonBackNswMenu.Location = new System.Drawing.Point(15, 12);
            this.ButtonBackNswMenu.Name = "ButtonBackNswMenu";
            this.ButtonBackNswMenu.Size = new System.Drawing.Size(40, 23);
            this.ButtonBackNswMenu.TabIndex = 6;
            this.ButtonBackNswMenu.Text = "🢀";
            this.ButtonBackNswMenu.UseVisualStyleBackColor = true;
            this.ButtonBackNswMenu.Click += new System.EventHandler(this.ButtonBackNswMenu_Click);
            // 
            // NswImportMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 154);
            this.Controls.Add(this.ButtonBackNswMenu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtomImportBrowse);
            this.Controls.Add(this.TextNswImportPath);
            this.Controls.Add(this.LabelmportNsw);
            this.Name = "NswImportMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NswImportMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelmportNsw;
        private System.Windows.Forms.TextBox TextNswImportPath;
        private System.Windows.Forms.Button ButtomImportBrowse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ButtonBackNswMenu;
    }
}