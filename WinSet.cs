using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Multi_Timer
{
    public partial class WinSet : Form
    {
        static public int intID;
        public WinSet()
        {
            InitializeComponent();
        }
        private void WinSet_Shown(object sender, EventArgs e)
        {
            this.Text = "Alarm " + intID.ToString() + " - Multi Timer";
        }
        private void WinSet_Closed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
            this.Owner.Activate();
        }      
    }
}
