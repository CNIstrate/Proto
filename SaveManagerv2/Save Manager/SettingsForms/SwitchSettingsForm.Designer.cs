
namespace Save_Manager.SettingsForms
{
    partial class SwitchSettingsForm
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
            this.OKButton = new System.Windows.Forms.Button();
            this.ExportToTitle = new System.Windows.Forms.Label();
            this.ChangePathButton = new System.Windows.Forms.Button();
            this.SavePath = new System.Windows.Forms.TextBox();
            this.SavePathBoxPadding = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.OKButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.OKButton.FlatAppearance.BorderSize = 0;
            this.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKButton.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.OKButton.Location = new System.Drawing.Point(435, 124);
            this.OKButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(69, 40);
            this.OKButton.TabIndex = 48;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ExportToTitle
            // 
            this.ExportToTitle.AutoSize = true;
            this.ExportToTitle.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportToTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.ExportToTitle.Location = new System.Drawing.Point(21, 21);
            this.ExportToTitle.Name = "ExportToTitle";
            this.ExportToTitle.Size = new System.Drawing.Size(147, 39);
            this.ExportToTitle.TabIndex = 46;
            this.ExportToTitle.Text = "Export to";
            // 
            // ChangePathButton
            // 
            this.ChangePathButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ChangePathButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ChangePathButton.FlatAppearance.BorderSize = 0;
            this.ChangePathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePathButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePathButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.ChangePathButton.Location = new System.Drawing.Point(435, 63);
            this.ChangePathButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ChangePathButton.Name = "ChangePathButton";
            this.ChangePathButton.Size = new System.Drawing.Size(69, 41);
            this.ChangePathButton.TabIndex = 45;
            this.ChangePathButton.Text = " •••";
            this.ChangePathButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangePathButton.UseVisualStyleBackColor = false;
            this.ChangePathButton.Click += new System.EventHandler(this.ChangePath_Click);
            // 
            // SavePath
            // 
            this.SavePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SavePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SavePath.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePath.ForeColor = System.Drawing.Color.Gray;
            this.SavePath.Location = new System.Drawing.Point(43, 73);
            this.SavePath.Name = "SavePath";
            this.SavePath.ReadOnly = true;
            this.SavePath.Size = new System.Drawing.Size(375, 20);
            this.SavePath.TabIndex = 44;
            // 
            // SavePathBoxPadding
            // 
            this.SavePathBoxPadding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SavePathBoxPadding.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SavePathBoxPadding.Enabled = false;
            this.SavePathBoxPadding.ForeColor = System.Drawing.Color.Gainsboro;
            this.SavePathBoxPadding.Location = new System.Drawing.Point(30, 63);
            this.SavePathBoxPadding.Multiline = true;
            this.SavePathBoxPadding.Name = "SavePathBoxPadding";
            this.SavePathBoxPadding.Size = new System.Drawing.Size(414, 41);
            this.SavePathBoxPadding.TabIndex = 47;
            // 
            // SwitchSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(534, 194);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ExportToTitle);
            this.Controls.Add(this.ChangePathButton);
            this.Controls.Add(this.SavePath);
            this.Controls.Add(this.SavePathBoxPadding);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SwitchSettingsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Save Manager - Switch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label ExportToTitle;
        private System.Windows.Forms.Button ChangePathButton;
        private System.Windows.Forms.TextBox SavePath;
        private System.Windows.Forms.TextBox SavePathBoxPadding;
    }
}