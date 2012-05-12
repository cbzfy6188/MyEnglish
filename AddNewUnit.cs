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

        public AddNewUnit(Main main)
        {
            InitializeComponent();
            mainform = main;
            dataFile_path = System.Windows.Forms.Application.StartupPath;
            dataFile_path += "\\data\\";
            datafile_name = dataFile_path + "DataFile";
            if (Directory.Exists(dataFile_path) == false)
            {
                Directory.CreateDirectory(dataFile_path);
            }
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

            String dataLine = "{";
            dataLine += "[Unit:" + dataStruct.getUnit() + "]";
            dataLine += "[EnglishWord:" + dataStruct.getEnglishWord() + "]";
            dataLine += "[ChineseWord1:" + dataStruct.getChineseWord1() + "]";
            dataLine += "[ChineseWord2:" + dataStruct.getChineseWord2() + "]";
            dataLine += "[ChineseWord3:" + dataStruct.getChineseWord3() + "]";
            dataLine += "[ChineseWord4:" + dataStruct.getChineseWord4() + "]";
            dataLine += "}";
            dataLine += "\n";

            datafile_name = dataFile_path + "DataFile";
            datafile_name += "_Unit";
            datafile_name += dataStruct.getUnit();
            File.AppendAllText(datafile_name, dataLine, Encoding.Default);

            labelWords.Text = "";
            DataStruct[] fliterData = string_fliter(File.ReadAllText(datafile_name, Encoding.Default));
            for (int i = 0; i < fliterData.Length;i++)
            {
                writeToLabelWords(fliterData[i]);
            }
            labelUnit.Text = "Unit:";
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
                textUnit.Text = textUnit.Text.Trim();
                try
                {
                    dataStruct.setUnit(Int32.Parse(textUnit.Text));
                }
                catch
                {
                    MessageBox.Show("You must fill in a number");
                    textUnit.Text = "";
                }
            }
        }

        private void textEnglishWord_TextChanged(object sender, EventArgs e)
        {
            textEnglishWord.Text = textEnglishWord.Text.Trim();
            dataStruct.setEnglishWord(textEnglishWord.Text);
        }

        private void textChineseWord1_TextChanged(object sender, EventArgs e)
        {
            textChineseWord1.Text = textChineseWord1.Text.Trim();
            dataStruct.setChineseWord1(textChineseWord1.Text);
        }

        private void textChineseWord2_TextChanged(object sender, EventArgs e)
        {
            textChineseWord2.Text = textChineseWord2.Text.Trim();
            dataStruct.setChineseWord2(textChineseWord2.Text);
        }

        private void textChineseWord3_TextChanged(object sender, EventArgs e)
        {
            textChineseWord3.Text = textChineseWord3.Text.Trim();
            dataStruct.setChineseWord3(textChineseWord3.Text);
        }

        private void textChineseWord4_TextChanged(object sender, EventArgs e)
        {
            textChineseWord4.Text = textChineseWord4.Text.Trim();
            dataStruct.setChineseWord4(textChineseWord4.Text);
        }

        private void home_Click(object sender, EventArgs e)
        {
            if (mainform != null)
            {
                mainform.SetDesktopLocation(this.DesktopLocation.X, this.DesktopLocation.Y);
                mainform.Show();
            }
            this.Close();
        }

        private DataStruct[] string_fliter(String source)
        {
            String tmp_data = source;
            string restult = "";
            String[] tmp_data_word_info = null;
            String[] tmp_data_word = tmp_data.Split('{');
            DataStruct[] data = new DataStruct[tmp_data_word.Length - 1];
            for (int i = 0; i < data.Length;i++)
            {
                data[i] = new DataStruct();
            }
            for (int i=1; i<tmp_data_word.Length; i++)
            {
                tmp_data_word_info = tmp_data_word[i].Split('[');
                for (int j=1; j<tmp_data_word_info.Length; j++)
                {
                    if (tmp_data_word_info[j].StartsWith("Unit:") && tmp_data_word_info[j].EndsWith("]"))
                    {
                        restult = tmp_data_word_info[j].Replace("Unit:", "");
                        restult = restult.Replace("]", "");
                        if (restult != "")
                        {
                            try
                            {
                                data[i - 1].setUnit(Int32.Parse(restult));
                            }
                            catch
                            {
                                MessageBox.Show("Unit is not a number");
                                break;
                            }
                        }
                    }
                    else if (tmp_data_word_info[j].StartsWith("EnglishWord:") && tmp_data_word_info[j].EndsWith("]"))
                    {
                        restult = tmp_data_word_info[j].Replace("EnglishWord:", "");
                        restult = restult.Replace("]", "");
                        data[i - 1].setEnglishWord(restult);
                    }
                    else if (tmp_data_word_info[j].StartsWith("ChineseWord1:") && tmp_data_word_info[j].EndsWith("]"))
                    {
                        restult = tmp_data_word_info[j].Replace("ChineseWord1:", "");
                        restult = restult.Replace("]", "");
                        data[i - 1].setChineseWord1(restult);
                    }
                    else if (tmp_data_word_info[j].StartsWith("ChineseWord2:") && tmp_data_word_info[j].EndsWith("]"))
                    {
                        restult = tmp_data_word_info[j].Replace("ChineseWord2:", "");
                        restult = restult.Replace("]", "");
                        data[i - 1].setChineseWord2(restult);
                    }
                    else if (tmp_data_word_info[j].StartsWith("ChineseWord3:") && tmp_data_word_info[j].EndsWith("]"))
                    {
                        restult = tmp_data_word_info[j].Replace("ChineseWord3:", "");
                        restult = restult.Replace("]", "");
                        data[i - 1].setChineseWord3(restult);
                    }
                    else if (tmp_data_word_info[j].StartsWith("ChineseWord4:") && tmp_data_word_info[j].EndsWith("]}\n"))
                    {
                        restult = tmp_data_word_info[j].Replace("ChineseWord4:", "");
                        restult = restult.Replace("]}\n", "");
                        data[i - 1].setChineseWord4(restult);
                    }
                }
            }
            return data;
        }

        private void writeToLabelWords(DataStruct data)
        {
            String dataLine_view = data.getEnglishWord();
            dataLine_view += "  ";
            if (data.getChineseWord1() != "")
            {
                dataLine_view += data.getChineseWord1();
                dataLine_view += "; ";
            }
            if (data.getChineseWord2() != "")
            {
                dataLine_view += data.getChineseWord2();
                dataLine_view += "; ";
            }
            if (data.getChineseWord3() != "")
            {
                dataLine_view += data.getChineseWord3();
                dataLine_view += "; ";
            }
            if (data.getChineseWord4() != "")
            {
                dataLine_view += data.getChineseWord4();
                dataLine_view += "; ";
            }
            dataLine_view += "\n";
            labelWords.Text += dataLine_view;
        }
    }
}
