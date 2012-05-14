using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyEnglish
{
    public partial class About : Form
    {
        private Main mainform = new Main();

        public About(Main main)
        {
            InitializeComponent();
            mainform = main;
            String mabout = "About us:\n";
            mabout += "This is a private software. Not for commercial use.\n";
            mabout += "This software developed by Jacob Cao. It is used for himself and his wife Josephine Zhu learning English.\n";
            mabout += "If you have any question, please send email to me(cbzfy6188@gmail.com).";
            labelHelp.Text = mabout;
            labelVersion.Text = "V1.0.0";
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            if (mainform != null)
            {
                mainform.SetDesktopLocation(this.DesktopLocation.X, this.DesktopLocation.Y);
                mainform.Show();
            }
            this.Close();
        }
    }
}
