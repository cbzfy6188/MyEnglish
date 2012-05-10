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
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
            this.SetDesktopLocation(100, 100);
        }

        private void addNewUnit_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNewUnit addNewUnitForm = new AddNewUnit(this);
            addNewUnitForm.SetDesktopLocation(this.DesktopLocation.X, this.DesktopLocation.Y);
            addNewUnitForm.Show();
        }

        private void editUnits_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditUnits editUnits = new EditUnits(this);
            editUnits.SetDesktopLocation(this.DesktopLocation.X, this.DesktopLocation.Y);
            editUnits.Show();
        }

        private void test_Click(object sender, EventArgs e)
        {
            this.Hide();
            Test test = new Test(this);
            test.SetDesktopLocation(this.DesktopLocation.X, this.DesktopLocation.Y);
            test.Show();
        }

        private void help_Click(object sender, EventArgs e)
        {
            this.Hide();
            Help help = new Help(this);
            help.SetDesktopLocation(this.DesktopLocation.X, this.DesktopLocation.Y);
            help.Show();
        }

        private void about_Click(object sender, EventArgs e)
        {
            this.Hide();
            About about = new About(this);
            about.SetDesktopLocation(this.DesktopLocation.X, this.DesktopLocation.Y);
            about.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}