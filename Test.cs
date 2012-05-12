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
    public partial class Test : Form
    {
        private Main mainform = new Main();
        private int testRangeMode = 0;      //Auto:0,Single Unit:1,Multi Units:2

        public Test(Main main)
        {
            InitializeComponent();
            mainform = main;
            labelPrompt.Text = "Press 'Start' button to start testing.";
            testRangeMode = 0;
            radioButtonAT.Checked = true;
            textBoxEUN.Enabled = false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            labelPrompt.Text = "starting test.";
            getWordsToTesting(testRangeMode);
        }

        private void radioButtonAT_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAT.Checked == true)
            {
                testRangeMode = 0;
                textBoxEUN.Enabled = false;
            }
        }

        private void radioButtonSU_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSU.Checked == true)
            {
                testRangeMode = 1;
                textBoxEUN.Enabled = true;
            }
        }

        private void radioButtonMU_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMU.Checked == true)
            {
                testRangeMode = 2;
                textBoxEUN.Enabled = true;
            }

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

        private void getWordsToTesting(int mtestRangeMode)
        {
            switch (testRangeMode)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                default:
                    break;
            }
            
        }
    }
}
