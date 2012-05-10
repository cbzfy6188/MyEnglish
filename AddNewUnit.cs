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
           // String dataLine = "[Unit:" + dataStruct.getUnit() + "][EnglishWord:" + dataStruct.getEnglishWord + "][ChineseWord1:" +
            //    dataStruct.getChineseWord1 + "][ChineseWord2:" + dataStruct.getChineseWord2 + "][ChineseWord3:" +
           //     dataStruct.getChineseWord3 + "][ChineseWord4:" + dataStruct.getChineseWord4 + "]";
           // mainform.dataFile.WriteLine(dataLine);
        }

        private void textUnit_TextChanged(object sender, EventArgs e)
        {
            //dataStruct.setUnit( ); 
        }

        private void textEnglishWord_TextChanged(object sender, EventArgs e)
        {
            //dataStruct.setEnglishWord( );
        }

        private void textChineseWord1_TextChanged(object sender, EventArgs e)
        {
            //dataStruct.setChineseWord1( );
        }

        private void textChineseWord2_TextChanged(object sender, EventArgs e)
        {
            //dataStruct.setChineseWord2( );
        }

        private void textChineseWord3_TextChanged(object sender, EventArgs e)
        {
            //dataStruct.setChineseWord3( );
        }

        private void textChineseWord4_TextChanged(object sender, EventArgs e)
        {
            //dataStruct.setChineseWord4( );
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
