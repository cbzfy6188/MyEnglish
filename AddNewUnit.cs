using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MyEnglish
{
    public partial class AddNewUnit : Form
    {
        private Main mainform = new Main();
        private DataStruct dataStruct = new DataStruct();
        private string dataFile_path = "C:\\Program Files\\MyEnglish\\data\\";
        private string datafile_name = "DataFile";
        private System.IO.StreamWriter dataFile;        				//data file handle for writing data file(DataFile.txt)

        public AddNewUnit(Main main)
        {
            InitializeComponent();
            mainform = main;
            dataFile_path = System.Windows.Forms.Application.StartupPath;
            dataFile_path += "\\data\\";
            datafile_name = dataFile_path + "DataFile" + ".txt";
            if (Directory.Exists(dataFile_path) == false)
            {
                Directory.CreateDirectory(dataFile_path);
            }
            dataFile = new System.IO.StreamWriter(datafile_name);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (dataStruct.getUnit() == 0)
            {
                MessageBox.Show("You must fill in the unit number");
                return;
            }
            if (dataStruct.getEnglishWord() == "")
            {
                MessageBox.Show("You must fill in the English word");
                return;
            }
            if ((dataStruct.getChineseWord1() == "") && 
                (dataStruct.getChineseWord2() == "") && 
                (dataStruct.getChineseWord3() == "") && 
                (dataStruct.getChineseWord4() == ""))
            {
                MessageBox.Show("You have to fill at least one Chinese word");
                return;
            }
            
            String dataLine = "[Unit:" + dataStruct.getUnit() + "]";
            dataLine += "[EnglishWord:" + dataStruct.getEnglishWord() + "]";
            dataLine += "[ChineseWord1:" + dataStruct.getChineseWord1() + "]";
            dataLine += "[ChineseWord2:" + dataStruct.getChineseWord1() + "]";
            dataLine += "[ChineseWord3:" + dataStruct.getChineseWord1() + "]";
            dataLine += "[ChineseWord4:" + dataStruct.getChineseWord1() + "]";

            dataFile.WriteLine(dataLine);
            
            labelWords.Text = dataLine;
            labelUnit.Text += dataStruct.getUnit();

            textUnit.Text = "";
            textEnglishWord.Text = "";
            textChineseWord1.Text = "";
            textChineseWord2.Text = "";
            textChineseWord3.Text = "";
            textChineseWord4.Text = "";
        }

        private void textUnit_TextChanged(object sender, EventArgs e)
        {
            if (textUnit.Text != "")
            {
                dataStruct.setUnit(Int32.Parse(textUnit.Text));
            }
        }

        private void textEnglishWord_TextChanged(object sender, EventArgs e)
        {
            dataStruct.setEnglishWord(textEnglishWord.Text);
        }

        private void textChineseWord1_TextChanged(object sender, EventArgs e)
        {
            dataStruct.setChineseWord1(textChineseWord1.Text);
        }

        private void textChineseWord2_TextChanged(object sender, EventArgs e)
        {
            dataStruct.setChineseWord2(textChineseWord2.Text);
        }

        private void textChineseWord3_TextChanged(object sender, EventArgs e)
        {
            dataStruct.setChineseWord3(textChineseWord3.Text);
        }

        private void textChineseWord4_TextChanged(object sender, EventArgs e)
        {
            dataStruct.setChineseWord4(textChineseWord4.Text);
        }

        private void home_Click(object sender, EventArgs e)
        {
            if (dataFile != null)
            {
                dataFile.Close();
            }
            if (mainform != null)
            {
                mainform.SetDesktopLocation(this.DesktopLocation.X, this.DesktopLocation.Y);
                mainform.Show();
            }
            this.Close();
        }
    }
}
