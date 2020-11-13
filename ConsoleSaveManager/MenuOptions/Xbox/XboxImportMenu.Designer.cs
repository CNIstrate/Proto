namespace ConsoleSaveManager.MenuOptions.Xbox
{
    partial class XboxImportMenu
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
            this.xboxImportMenuTitle = new System.Windows.Forms.Label();
            this.importMenuTextBox = new System.Windows.Forms.TextBox();
            this.importToLabel = new System.Windows.Forms.Label();
            this.ImportStart = new System.Windows.Forms.Button();
            this.ButtonBackXboxSettings = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xboxImportMenuTitle
            // 
            this.xboxImportMenuTitle.AutoSize = true;
            this.xboxImportMenuTitle.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xboxImportMenuTitle.Location = new System.Drawing.Point(110, 9);
            this.xboxImportMenuTitle.Name = "xboxImportMenuTitle";
            this.xboxImportMenuTitle.Size = new System.Drawing.Size(184, 59);
            this.xboxImportMenuTitle.TabIndex = 1;
            this.xboxImportMenuTitle.Text = "IMPORT";
            // 
            // importMenuTextBox
            // 
            this.importMenuTextBox.Location = new System.Drawing.Point(120, 73);
            this.importMenuTextBox.Name = "importMenuTextBox";
            this.importMenuTextBox.ReadOnly = true;
            this.importMenuTextBox.Size = new System.Drawing.Size(380, 20);
            this.importMenuTextBox.TabIndex = 5;
            this.importMenuTextBox.TabStop = false;
            // 
            // importToLabel
            // 
            this.importToLabel.AutoSize = true;
            this.importToLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importToLabel.Location = new System.Drawing.Point(9, 73);
            this.importToLabel.Name = "importToLabel";
            this.importToLabel.Size = new System.Drawing.Size(105, 18);
            this.importToLabel.TabIndex = 4;
            this.importToLabel.Text = "Importing from:";
            // 
            // ImportStart
            // 
            this.ImportStart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportStart.Location = new System.Drawing.Point(209, 117);
            this.ImportStart.Name = "ImportStart";
            this.ImportStart.Size = new System.Drawing.Size(85, 32);
            this.ImportStart.TabIndex = 6;
            this.ImportStart.Text = "Start";
            this.ImportStart.UseVisualStyleBackColor = true;
            this.ImportStart.Click += new System.EventHandler(this.ImportStart_Click);
            // 
            // ButtonBackXboxSettings
            // 
            this.ButtonBackXboxSettings.Location = new System.Drawing.Point(12, 9);
            this.ButtonBackXboxSettings.Name = "ButtonBackXboxSettings";
            this.ButtonBackXboxSettings.Size = new System.Drawing.Size(40, 23);
            this.ButtonBackXboxSettings.TabIndex = 7;
            this.ButtonBackXboxSettings.Text = "🢀";
            this.ButtonBackXboxSettings.UseVisualStyleBackColor = true;
            this.ButtonBackXboxSettings.Click += new System.EventHandler(this.ButtonBackXboxSettings_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowse.Location = new System.Drawing.Point(442, 99);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(58, 20);
            this.buttonBrowse.TabIndex = 8;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
            // 
            // XboxImportMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 161);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.ButtonBackXboxSettings);
            this.Controls.Add(this.ImportStart);
            this.Controls.Add(this.importMenuTextBox);
            this.Controls.Add(this.importToLabel);
            this.Controls.Add(this.xboxImportMenuTitle);
            this.Name = "XboxImportMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XboxImportMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label xboxImportMenuTitle;
        private System.Windows.Forms.TextBox importMenuTextBox;
        private System.Windows.Forms.Label importToLabel;
        private System.Windows.Forms.Button ImportStart;
        private System.Windows.Forms.Button ButtonBackXboxSettings;
        private System.Windows.Forms.Button buttonBrowse;
    }
}