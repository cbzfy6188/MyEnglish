﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyEnglish
{
    public partial class EditUnits : Form
    {
        private Main mainform = new Main();

        public EditUnits(Main main)
        {
            InitializeComponent();
            mainform = main;
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
