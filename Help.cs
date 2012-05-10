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
    public partial class Help : Form
    {
        private Main mainform = new Main();

        public Help(Main main)
        {
            InitializeComponent();
            mainform = main;
            String mhelp = "Help:\n";
            mhelp += "1.use 'Add New Uint' to add  words infomation.\n";
            mhelp += "2.use 'Edit Uint' to edit words infomation.\n";
            mhelp += "3.use 'Test' to test your learning outcomes.";
            labelHelp.Text = mhelp;
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
