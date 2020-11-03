namespace SaveManager
{
    partial class Xbox
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
                Close();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Xbox));
            this.exportButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.exportTextBox = new System.Windows.Forms.TextBox();
            this.importTextBox = new System.Windows.Forms.TextBox();
            this.deleteTextBox = new System.Windows.Forms.TextBox();
            this.scidbox = new System.Windows.Forms.TextBox();
            this.getSCID = new System.Windows.Forms.Button();
            this.browseSCID = new System.Windows.Forms.Button();
            this.dial = new System.Windows.Forms.TextBox();
            this.menumain = new System.Windows.Forms.Button();
            this.appxLoc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exportBrowse = new System.Windows.Forms.TextBox();
            this.exportBrowseButton = new System.Windows.Forms.Button();
            this.importBrowse = new System.Windows.Forms.TextBox();
            this.importBrowseButton = new System.Windows.Forms.Button();
            this.consoleIP = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exportButton
            // 
            this.exportButton.AutoSize = true;
            this.exportButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportButton.Location = new System.Drawing.Point(15, 116);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(112, 36);
            this.exportButton.TabIndex = 0;
            this.exportButton.Text = "Export save file";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.ExportButton);
            // 
            // importButton
            // 
            this.importButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importButton.Location = new System.Drawing.Point(15, 186);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(112, 36);
            this.importButton.TabIndex = 1;
            this.importButton.Text = "Import save file";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.ImportButton);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(15, 254);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(112, 45);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete save\r\nfrom console\r\n";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton);
            // 
            // exportTextBox
            // 
            this.exportTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportTextBox.Location = new System.Drawing.Point(166, 136);
            this.exportTextBox.Name = "exportTextBox";
            this.exportTextBox.ReadOnly = true;
            this.exportTextBox.Size = new System.Drawing.Size(58, 26);
            this.exportTextBox.TabIndex = 6;
            this.exportTextBox.Text = "- - -";
            this.exportTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // importTextBox
            // 
            this.importTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importTextBox.Location = new System.Drawing.Point(166, 209);
            this.importTextBox.Name = "importTextBox";
            this.importTextBox.ReadOnly = true;
            this.importTextBox.Size = new System.Drawing.Size(58, 26);
            this.importTextBox.TabIndex = 7;
            this.importTextBox.Text = "- - -";
            this.importTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // deleteTextBox
            // 
            this.deleteTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTextBox.Location = new System.Drawing.Point(166, 264);
            this.deleteTextBox.Name = "deleteTextBox";
            this.deleteTextBox.ReadOnly = true;
            this.deleteTextBox.Size = new System.Drawing.Size(58, 26);
            this.deleteTextBox.TabIndex = 8;
            this.deleteTextBox.Text = "- - -";
            this.deleteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // scidbox
            // 
            this.scidbox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scidbox.Location = new System.Drawing.Point(65, 74);
            this.scidbox.Name = "scidbox";
            this.scidbox.ReadOnly = true;
            this.scidbox.Size = new System.Drawing.Size(276, 26);
            this.scidbox.TabIndex = 9;
            this.scidbox.Text = "-";
            this.scidbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.scidbox.TextChanged += new System.EventHandler(this.SCIDbox_TextChanged);
            // 
            // getSCID
            // 
            this.getSCID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getSCID.Location = new System.Drawing.Point(347, 75);
            this.getSCID.Name = "getSCID";
            this.getSCID.Size = new System.Drawing.Size(75, 23);
            this.getSCID.TabIndex = 10;
            this.getSCID.Text = "Get SCID!";
            this.getSCID.UseVisualStyleBackColor = true;
            this.getSCID.Click += new System.EventHandler(this.GetSCID);
            // 
            // browseSCID
            // 
            this.browseSCID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseSCID.Location = new System.Drawing.Point(347, 42);
            this.browseSCID.Name = "browseSCID";
            this.browseSCID.Size = new System.Drawing.Size(75, 23);
            this.browseSCID.TabIndex = 11;
            this.browseSCID.Text = "Browse";
            this.browseSCID.UseVisualStyleBackColor = true;
            this.browseSCID.Click += new System.EventHandler(this.BrowseAppxFile);
            // 
            // dial
            // 
            this.dial.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dial.Location = new System.Drawing.Point(65, 42);
            this.dial.Name = "dial";
            this.dial.ReadOnly = true;
            this.dial.Size = new System.Drawing.Size(276, 26);
            this.dial.TabIndex = 12;
            this.dial.Text = "- Path to title\'s AppxManifest file -";
            this.dial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menumain
            // 
            this.menumain.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menumain.Location = new System.Drawing.Point(4, 2);
            this.menumain.Name = "menumain";
            this.menumain.Size = new System.Drawing.Size(28, 40);
            this.menumain.TabIndex = 13;
            this.menumain.Text = "🢀";
            this.menumain.UseVisualStyleBackColor = true;
            this.menumain.Click += new System.EventHandler(this.BackButton);
            // 
            // appxLoc
            // 
            this.appxLoc.AutoSize = true;
            this.appxLoc.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appxLoc.Location = new System.Drawing.Point(1, 45);
            this.appxLoc.Name = "appxLoc";
            this.appxLoc.Size = new System.Drawing.Size(63, 18);
            this.appxLoc.TabIndex = 14;
            this.appxLoc.Text = "Location:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "SCID:";
            // 
            // exportBrowse
            // 
            this.exportBrowse.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBrowse.Location = new System.Drawing.Point(166, 116);
            this.exportBrowse.Name = "exportBrowse";
            this.exportBrowse.ReadOnly = true;
            this.exportBrowse.Size = new System.Drawing.Size(256, 26);
            this.exportBrowse.TabIndex = 16;
            this.exportBrowse.Text = "- Where to export? -";
            this.exportBrowse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // exportBrowseButton
            // 
            this.exportBrowseButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBrowseButton.Location = new System.Drawing.Point(347, 139);
            this.exportBrowseButton.Name = "exportBrowseButton";
            this.exportBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.exportBrowseButton.TabIndex = 17;
            this.exportBrowseButton.Text = "Browse";
            this.exportBrowseButton.UseVisualStyleBackColor = true;
            this.exportBrowseButton.Click += new System.EventHandler(this.ExportBrowseButton);
            // 
            // importBrowse
            // 
            this.importBrowse.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importBrowse.Location = new System.Drawing.Point(166, 186);
            this.importBrowse.Name = "importBrowse";
            this.importBrowse.ReadOnly = true;
            this.importBrowse.Size = new System.Drawing.Size(256, 26);
            this.importBrowse.TabIndex = 18;
            this.importBrowse.Text = "- Select the save file you want to use -";
            this.importBrowse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // importBrowseButton
            // 
            this.importBrowseButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importBrowseButton.Location = new System.Drawing.Point(347, 210);
            this.importBrowseButton.Name = "importBrowseButton";
            this.importBrowseButton.Size = new System.Drawing.Size(75, 25);
            this.importBrowseButton.TabIndex = 19;
            this.importBrowseButton.Text = "Browse";
            this.importBrowseButton.UseVisualStyleBackColor = true;
            this.importBrowseButton.Click += new System.EventHandler(this.ImportBrowseButton);
            // 
            // consoleIP
            // 
            this.consoleIP.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.consoleIP.Location = new System.Drawing.Point(146, 9);
            this.consoleIP.Name = "consoleIP";
            this.consoleIP.Size = new System.Drawing.Size(195, 26);
            this.consoleIP.TabIndex = 20;
            this.consoleIP.Text = "Your console IP";
            this.consoleIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.ConnectButton.Location = new System.Drawing.Point(65, 10);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 21;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(347, 15);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(54, 13);
            this.StatusLabel.TabIndex = 22;
            this.StatusLabel.Text = "WAITING";
            // 
            // Xbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.consoleIP);
            this.Controls.Add(this.importBrowseButton);
            this.Controls.Add(this.importBrowse);
            this.Controls.Add(this.exportBrowseButton);
            this.Controls.Add(this.exportBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.appxLoc);
            this.Controls.Add(this.menumain);
            this.Controls.Add(this.dial);
            this.Controls.Add(this.browseSCID);
            this.Controls.Add(this.getSCID);
            this.Controls.Add(this.scidbox);
            this.Controls.Add(this.deleteTextBox);
            this.Controls.Add(this.importTextBox);
            this.Controls.Add(this.exportTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.exportButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(450, 350);
            this.MinimumSize = new System.Drawing.Size(450, 350);
            this.Name = "Xbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaveManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox exportTextBox;
        private System.Windows.Forms.TextBox importTextBox;
        private System.Windows.Forms.TextBox deleteTextBox;
        private System.Windows.Forms.TextBox scidbox;
        private System.Windows.Forms.Button getSCID;
        private System.Windows.Forms.Button browseSCID;
        private System.Windows.Forms.TextBox dial;
        private System.Windows.Forms.Button menumain;
        private System.Windows.Forms.Label appxLoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox exportBrowse;
        private System.Windows.Forms.Button exportBrowseButton;
        private System.Windows.Forms.TextBox importBrowse;
        private System.Windows.Forms.Button importBrowseButton;
        private System.Windows.Forms.TextBox consoleIP;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label StatusLabel;
    }
}

