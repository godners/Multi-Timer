using System;
using System.Drawing;
using System.Windows.Forms;
using Multi_Timer.Properties;
namespace Multi_Timer
{
    public partial class WinAuthor : Form
    {
        public WinAuthor()
        {
            InitializeComponent();
        }
        private Image[] imgPhoto;
        private void WinAuthor_Load(object sender, EventArgs e)
        {
            imgPhoto = new Image[3];
            imgPhoto[0] = Resources.imgPhoto0; imgPhoto[1] = Resources.imgPhoto1; imgPhoto[2] = Resources.imgPhoto2;
        }
        private void TmrAuthor_Tick(object sender, EventArgs e)
        {
            ptbPhoto.Image = imgPhoto[DateTime.Now.Second / 2 % 3];
        }
        private void WinAuthor_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
            this.Owner.Activate();
            this.Owner.ShowInTaskbar = true;
        }
        private void WinAuthor_Shown(object sender, EventArgs e)
        {
            ptbPhoto.Image = imgPhoto[DateTime.Now.Second / 2 % 3];
        }
        private void WinAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)13:
                case (char)27:
                    this.Close();
                    break;
            }
        }
        private void LlbOS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(llbOS.Text);
        }
    }
}
