namespace SaveManager
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Menuxb = new System.Windows.Forms.Button();
            this.MenuNSW = new System.Windows.Forms.Button();
            this.MenuPS4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Menuxb
            // 
            this.Menuxb.BackColor = System.Drawing.Color.ForestGreen;
            this.Menuxb.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menuxb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Menuxb.Location = new System.Drawing.Point(12, 12);
            this.Menuxb.Name = "Menuxb";
            this.Menuxb.Size = new System.Drawing.Size(310, 73);
            this.Menuxb.TabIndex = 0;
            this.Menuxb.Text = "XBOX";
            this.Menuxb.UseVisualStyleBackColor = false;
            this.Menuxb.Click += new System.EventHandler(this.Menuxb_Click);
            // 
            // MenuNSW
            // 
            this.MenuNSW.BackColor = System.Drawing.Color.Crimson;
            this.MenuNSW.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuNSW.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MenuNSW.Location = new System.Drawing.Point(12, 94);
            this.MenuNSW.Name = "MenuNSW";
            this.MenuNSW.Size = new System.Drawing.Size(310, 73);
            this.MenuNSW.TabIndex = 1;
            this.MenuNSW.Text = "NINTENDO SWITCH";
            this.MenuNSW.UseVisualStyleBackColor = false;
            // 
            // MenuPS4
            // 
            this.MenuPS4.BackColor = System.Drawing.Color.RoyalBlue;
            this.MenuPS4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuPS4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MenuPS4.Location = new System.Drawing.Point(12, 176);
            this.MenuPS4.Name = "MenuPS4";
            this.MenuPS4.Size = new System.Drawing.Size(310, 73);
            this.MenuPS4.TabIndex = 2;
            this.MenuPS4.Text = "PS4";
            this.MenuPS4.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.MenuPS4);
            this.Controls.Add(this.MenuNSW);
            this.Controls.Add(this.Menuxb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(350, 300);
            this.MinimumSize = new System.Drawing.Size(350, 300);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaveManager";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Menuxb;
        private System.Windows.Forms.Button MenuNSW;
        private System.Windows.Forms.Button MenuPS4;
    }
}