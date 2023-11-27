using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace dell_fans_controller
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void lnkDev_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer", lnkDev.Text);
        }

        private void FormAbout_Load(object sender, EventArgs e) 
        {
            Version.Text = Program.version;
        }

        private void FormAbout_FormClosing(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
