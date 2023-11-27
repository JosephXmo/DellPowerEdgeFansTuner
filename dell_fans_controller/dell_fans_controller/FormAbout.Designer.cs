namespace dell_fans_controller
{
    partial class FormAbout
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
            this.VersionText = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.Developer = new System.Windows.Forms.Label();
            this.lnkDev = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // VersionText
            // 
            this.VersionText.AutoSize = true;
            this.VersionText.Location = new System.Drawing.Point(52, 61);
            this.VersionText.Name = "VersionText";
            this.VersionText.Size = new System.Drawing.Size(29, 12);
            this.VersionText.TabIndex = 0;
            this.VersionText.Text = "版本";
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Location = new System.Drawing.Point(142, 61);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(0, 12);
            this.Version.TabIndex = 1;
            this.Version.Text = "";
            // 
            // Developer
            // 
            this.Developer.AutoSize = true;
            this.Developer.Location = new System.Drawing.Point(52, 119);
            this.Developer.Name = "Developer";
            this.Developer.Size = new System.Drawing.Size(101, 12);
            this.Developer.TabIndex = 2;
            this.Developer.Text = "作者：    cw1997";
            // 
            // lnkDev
            // 
            this.lnkDev.AutoSize = true;
            this.lnkDev.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkDev.Location = new System.Drawing.Point(180, 119);
            this.lnkDev.Name = "lnkDev";
            this.lnkDev.Size = new System.Drawing.Size(113, 12);
            this.lnkDev.TabIndex = 3;
            this.lnkDev.TabStop = true;
            this.lnkDev.Text = "http://changwei.me";
            this.lnkDev.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDev_LinkClicked);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.lnkDev);
            this.Controls.Add(this.Developer);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.VersionText);
            this.Load += new System.EventHandler(this.FormAbout_Load);
            this.MaximumSize = new System.Drawing.Size(350, 250);
            this.MinimumSize = new System.Drawing.Size(350, 250);
            this.Name = "FormAbout";
            this.Text = "关于";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VersionText;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Label Developer;
        private System.Windows.Forms.LinkLabel lnkDev;
    }
}