
namespace Error_Hunter
{
    partial class windowTitle
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
                System.Environment.Exit(1);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(windowTitle));
            this.ErrorExport = new System.Windows.Forms.Button();
            this.warningExport = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ErrorExport
            // 
            this.ErrorExport.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorExport.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ErrorExport.Location = new System.Drawing.Point(248, 152);
            this.ErrorExport.Name = "ErrorExport";
            this.ErrorExport.Size = new System.Drawing.Size(114, 40);
            this.ErrorExport.TabIndex = 0;
            this.ErrorExport.Text = "Find Errors";
            this.ErrorExport.UseVisualStyleBackColor = true;
            this.ErrorExport.Click += new System.EventHandler(this.ErrorExport_Click);
            // 
            // warningExport
            // 
            this.warningExport.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningExport.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.warningExport.Location = new System.Drawing.Point(248, 198);
            this.warningExport.Name = "warningExport";
            this.warningExport.Size = new System.Drawing.Size(114, 40);
            this.warningExport.TabIndex = 1;
            this.warningExport.Text = "Find Warnings";
            this.warningExport.UseVisualStyleBackColor = true;
            this.warningExport.Click += new System.EventHandler(this.WarningExport_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.statusLabel.Location = new System.Drawing.Point(12, 260);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(30, 17);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Idle";
            // 
            // windowTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Error_Hunter.Properties.Resources.kus3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(587, 286);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.warningExport);
            this.Controls.Add(this.ErrorExport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(603, 325);
            this.MinimumSize = new System.Drawing.Size(603, 325);
            this.Name = "windowTitle";
            this.Text = "Error Hunter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ErrorExport;
        private System.Windows.Forms.Button warningExport;
        private System.Windows.Forms.Label statusLabel;
    }
}

