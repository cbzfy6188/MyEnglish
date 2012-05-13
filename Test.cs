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
    public partial class Test : Form
    {
        private Main mainform = new Main();
        private string dataFile_path = "C:\\Program Files\\MyEnglish\\data\\";
        private string datafile_name = "DataFile";
        private List<int> testRange = new List<int>();
        private List<DataStruct> dataStruct = new List<DataStruct>();
        private List<int> randomIndex = new List<int>();
        private int index_testing = 0;
        private int testRangeMode = 0;      //Auto:0,Single Unit:1,Multi Units:2
        private int testMode = 0;      //Random:0,Show English:1,Show Chinese:2
        private int testMode_tmp = 0; //Show English:0,Show Chinese:1
        private bool retestWrongWords = true;

        public Test(Main main)
        {
            InitializeComponent();
            mainform = main;
            dataFile_path = System.Windows.Forms.Application.StartupPath;
            dataFile_path += "\\data\\";
            datafile_name = dataFile_path + "DataFile";
            labelPrompt.Text = "Press 'Start' button to start testing.";
            testRangeMode = 0;
            radioButtonAT.Checked = true;
            textBoxEUN.Enabled = false;
            buttonStart.Enabled = true;
            buttonPause.Enabled = false;
            buttonStop.Enabled = false;
            buttonSCA.Enabled = false;
            radioButtonR.Checked = true;
            checkBoxRWW.Checked = true;
            retestWrongWords = true;
            groupBoxMP.Enabled = false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            labelPrompt.Text = "starting test.";
            getWordsToTesting();/*
            for(int i=0;i<dataStruct.Count;i++)
            {
                for (int j = 0; j < 8;j++ )
                {
                    if (j == 0)
                        MessageBox.Show(dataStruct[i].getUnit().ToString());
                    if (j == 1)
                        MessageBox.Show(dataStruct[i].getEnglishWord().ToString());
                    if (j == 2)
                        MessageBox.Show(dataStruct[i].getChineseWord1().ToString());
                    if (j == 3)
                        MessageBox.Show(dataStruct[i].getChineseWord2().ToString());
                    if (j == 4)
                        MessageBox.Show(dataStruct[i].getChineseWord3().ToString());
                    if (j == 5)
                        MessageBox.Show(dataStruct[i].getChineseWord4().ToString());
                    if (j == 6)
                        MessageBox.Show(dataStruct[i].getTested().ToString());
                    if (j == 7)
                        MessageBox.Show(dataStruct[i].getTestResult().ToString());
                }
            }*/
            Random random_index = new Random();
            int tmp_index1 = 0;
            int tmp_index2 = 0;
            int tmp_data1 = 0;
            int tmp_data2 = 0;
            for (int i = 0; i < dataStruct.Count;i++ )
            {
                randomIndex.Add(i);
            }
            for(int i=0;i<dataStruct.Count;i++)
            {
                tmp_index2 = random_index.Next(dataStruct.Count);
                tmp_data1 = randomIndex[tmp_index1];
                tmp_data2 = randomIndex[tmp_index2];
                randomIndex.Remove(tmp_data1);
                randomIndex.Insert(tmp_index2, tmp_data1);
                randomIndex.Remove(tmp_data2);
                randomIndex.Insert(tmp_index1, tmp_data2);
                tmp_index1 = tmp_index2;
            }
            showTestingWord();

            buttonStart.Enabled = false;
            buttonPause.Enabled = true;
            buttonStop.Enabled = true;
            buttonSCA.Enabled = true;
            groupBoxTR.Enabled = false;
            textBoxEUN.Enabled = false;
            groupBoxMP.Enabled = true;
            buttonHome.Enabled = false;
            labelPrompt.Text = "Start Testing.";
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {

            labelPrompt.Text = "Pause Testing.";
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            stopTesting();
        }

        private void buttonSCA_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonAT_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAT.Checked == true)
            {
                labelPrompt.Text = "Test range is Auto.";
                testRangeMode = 0;
                textBoxEUN.Enabled = false;
                buttonStart.Enabled = true;
            }
        }

        private void radioButtonSU_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSU.Checked == true)
            {
                labelPrompt.Text = "Test range is single unit, You need to enter a unit number.";
                testRangeMode = 1;
                textBoxEUN.Enabled = true;
                if (textBoxEUN.Text != "")
                {
                    buttonStart.Enabled = true;
                }
                else
                {
                    buttonStart.Enabled = false;
                }
            }
        }

        private void radioButtonMU_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMU.Checked == true)
            {
                labelPrompt.Text = "Test range is multi units, You need to enter the unit numbers, separated by commas between the numbers";
                testRangeMode = 2;
                textBoxEUN.Enabled = true;
                if (textBoxEUN.Text != "")
                {
                    buttonStart.Enabled = true;
                }
                else
                {
                    buttonStart.Enabled = false;
                }
            }

        }

        private void textBoxEUN_TextChanged(object sender, EventArgs e)
        {
            textBoxEUN.Text = textBoxEUN.Text.Trim();
            if (textBoxEUN.Text != "")
            {
                if ((radioButtonSU.Checked == true) || (radioButtonMU.Checked == true))
                {
                    buttonStart.Enabled = true;
                }
                else
                {
                    buttonStart.Enabled = false;
                }
            }
            else
            {
                buttonStart.Enabled = false;
            }
        }

        private void radioButtonR_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonR.Checked == true)
            {
                labelPrompt.Text = "Set to range mode.";
                testMode = 0;
            }
        }

        private void radioButtonSE_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSE.Checked == true)
            {
                labelPrompt.Text = "Set to show English mode.";
                testMode = 1;
            }
        }

        private void radioButtonSC_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSC.Checked == true)
            {
                labelPrompt.Text = "Set to show Chinese mode.";
                testMode = 2;
            }
        }

        private void checkBoxRWW_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxRWW.Checked == true)
            {
                labelPrompt.Text = "Enable 'retest wrong words' mode.";
                retestWrongWords = true;
            }
            else
            {
                labelPrompt.Text = "Disable 'retest wrong words' mode.";
                retestWrongWords = false;
            }
        }

        private void textEditWord_TextChanged(object sender, EventArgs e)
        {
            if (textEditWord.Text == "")
            {
                return;
            }
            if ((textEditWord.Text == returnAnswer()[0]) || (textEditWord.Text == returnAnswer()[1])
                || (textEditWord.Text == returnAnswer()[2]) || (textEditWord.Text == returnAnswer()[3]))
            {
                dataStruct[randomIndex[index_testing]].setTested(true);
                dataStruct[randomIndex[index_testing]].setTestResult(true);
                if (textEditWord.Text != "")
                {
                    index_testing++;
                }
                if (index_testing < dataStruct.Count)
                {
                    showTestingWord();
                }
                else
                {
                    stopTesting();
                }
                textEditWord.Text = "";
            }
            else
            {
                dataStruct[randomIndex[index_testing]].setTestResult(false);
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

        private void getWordsToTesting()
        {
            List<DataStruct> tmp_dataStruct = new List<DataStruct>();
            switch (testRangeMode)
            {
                case 0:
                    List<int> Units = new List<int>();
                    DirectoryInfo _Directory = new DirectoryInfo(dataFile_path);
                    FileInfo[] _FileList = _Directory.GetFiles("DataFile_Unit*", SearchOption.AllDirectories);
                    for (int i = 0; i != _FileList.Length; i++)
                    {
                        if(_FileList[i].Name.StartsWith("DataFile_Unit"))
                        {
                            Units.Add(Int32.Parse(_FileList[i].Name.Replace("DataFile_Unit", "")));
                        }
                    }
                    Units.Sort();
                    if (Units.Count <= 7)
                    {
                        testRange = Units;
                    }
                    else
                    {
                        for (int i = Units.Count - 1; i > Units.Count - 8; i--)
                        {
                            testRange.Add(Units[i]);
                        }
                    }
                    break;
                case 1:
                case 2:
                    testRange = getTestRange();
                    break;
            }

            for (int i = 0; i < testRange.Count; i++)
            {
                datafile_name = dataFile_path + "DataFile";
                datafile_name += "_Unit";
                datafile_name += testRange[i];
                tmp_dataStruct = getwords(File.ReadAllText(datafile_name, Encoding.Default));
                for (int j = 0; j < tmp_dataStruct.Count; j++)
                {
                    dataStruct.Add(tmp_dataStruct[j]);
                }
            }
        }

        private List<int> getTestRange()
        {
            List<int> tmp_testRange = new List<int>();
            if (textBoxEUN.Text != "")
            {
                if (testRangeMode == 1)
                {
                    try
                    {
                        tmp_testRange.Add(Int32.Parse(textBoxEUN.Text));
                    }
                    catch
                    {
                        labelPrompt.Text = "You Must enter a number.";
                        textBoxEUN.Text = "";
                    }
                }
                else if (testRangeMode == 2)
                {
                    String[] tmp_units = textBoxEUN.Text.Split(',');
                    for (int i = 0; i < tmp_units.Length; i++)
                    {
                        try
                        {
                            tmp_testRange.Add(Int32.Parse(tmp_units[i]));
                        }
                        catch
                        {
                            labelPrompt.Text = "You Must enter numbers.";
                            textBoxEUN.Text = "";
                        }
                    }
                }
            }
            else
            {
                labelPrompt.Text = "You Must enter a unit number.";
            }
            return tmp_testRange;
        }

        private List<DataStruct> getwords(String source)
        {
            List<DataStruct> tmp_dataList = new List<DataStruct>();
            string restult = "";
            String[] tmp_data_word_info = null;
            String[] tmp_data_word = source.Split('{');
            for (int i = 1; i < tmp_data_word.Length; i++)
            {
                DataStruct tmp_data = new DataStruct();
                tmp_data_word_info = tmp_data_word[i].Split('[');
                for (int j = 1; j < tmp_data_word_info.Length; j++)
                {
                    if (tmp_data_word_info[j].StartsWith("Unit:") && tmp_data_word_info[j].EndsWith("]"))
                    {
                        restult = tmp_data_word_info[j].Replace("Unit:", "");
                        restult = restult.Replace("]", "");
                        if (restult != "")
                        {
                            try
                            {
                                tmp_data.setUnit(Int32.Parse(restult));
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
                        tmp_data.setEnglishWord(restult);
                    }
                    else if (tmp_data_word_info[j].StartsWith("ChineseWord1:") && tmp_data_word_info[j].EndsWith("]"))
                    {
                        restult = tmp_data_word_info[j].Replace("ChineseWord1:", "");
                        restult = restult.Replace("]", "");
                        tmp_data.setChineseWord1(restult);
                    }
                    else if (tmp_data_word_info[j].StartsWith("ChineseWord2:") && tmp_data_word_info[j].EndsWith("]"))
                    {
                        restult = tmp_data_word_info[j].Replace("ChineseWord2:", "");
                        restult = restult.Replace("]", "");
                        tmp_data.setChineseWord2(restult);
                    }
                    else if (tmp_data_word_info[j].StartsWith("ChineseWord3:") && tmp_data_word_info[j].EndsWith("]"))
                    {
                        restult = tmp_data_word_info[j].Replace("ChineseWord3:", "");
                        restult = restult.Replace("]", "");
                        tmp_data.setChineseWord3(restult);
                    }
                    else if (tmp_data_word_info[j].StartsWith("ChineseWord4:") && tmp_data_word_info[j].EndsWith("]"))
                    {
                        restult = tmp_data_word_info[j].Replace("ChineseWord4:", "");
                        restult = restult.Replace("]", "");
                        tmp_data.setChineseWord4(restult);
                    }
                    else if (tmp_data_word_info[j].StartsWith("Tested:") && tmp_data_word_info[j].EndsWith("]"))
                    {
                        restult = tmp_data_word_info[j].Replace("Tested:", "");
                        restult = restult.Replace("]", "");
                        tmp_data.setTested(bool.Parse(restult));
                    }
                    else if (tmp_data_word_info[j].StartsWith("TestResult:") && tmp_data_word_info[j].EndsWith("]}\n"))
                    {
                        restult = tmp_data_word_info[j].Replace("TestResult:", "");
                        restult = restult.Replace("]}\n", "");
                        tmp_data.setTestResult(bool.Parse(restult));
                    }
                }
                tmp_dataList.Add(tmp_data);
            }
            return tmp_dataList;
        }

        private void addWrongWords()
        {
            for (int i = 0; i < dataStruct.Count; i++)
            {
                if (dataStruct[i].getTestResult() == false)
                {
                    dataStruct[i].setTested(false);
                }
            }
        }

        private void removeWrongWords()
        {
            for (int i = 0; i < dataStruct.Count; i++)
            {
                if (dataStruct[i].getTestResult() == false)
                {
                    dataStruct[i].setTested(true);
                }
            }
        }

        private void showTestingWord()
        {
            Random random = new Random();
            List<String> index_c = new List<String>();
            switch (testMode)
            {
                case 0:
                    Random random_mode = new Random();
                    if (random_mode.Next(0,100)%2 == 0)
                    {
                        labelPrompt.Text = "Please enter a Chinese word.";
                        labelShowWordTitle.Text = "English Word:";
                        labelEditWordTitle.Text = "Chinese Word:";
                        labelShowWord.Text = dataStruct[randomIndex[index_testing]].getEnglishWord();
                        testMode_tmp = 0;
                    }
                    else
                    {
                        labelPrompt.Text = "Please enter a English word.";
                        labelShowWordTitle.Text = "Chinese Word:";
                        labelEditWordTitle.Text = "English Word:";
                        if (dataStruct[randomIndex[index_testing]].getChineseWord1() != "")
                        {
                            index_c.Add(dataStruct[randomIndex[index_testing]].getChineseWord1());
                        }
                        else if (dataStruct[randomIndex[index_testing]].getChineseWord2() != "")
                        {
                            index_c.Add(dataStruct[randomIndex[index_testing]].getChineseWord2());
                        }
                        else if (dataStruct[randomIndex[index_testing]].getChineseWord3() != "")
                        {
                            index_c.Add(dataStruct[randomIndex[index_testing]].getChineseWord3());
                        }
                        else if (dataStruct[randomIndex[index_testing]].getChineseWord4() != "")
                        {
                            index_c.Add(dataStruct[randomIndex[index_testing]].getChineseWord4());
                        }
                        labelShowWord.Text = index_c[random.Next(index_c.Count)];
                        testMode_tmp = 1;
                    }
                    break;
                case 1:
                    labelPrompt.Text = "Please enter a Chinese word.";
                    labelShowWordTitle.Text = "English Word:";
                    labelEditWordTitle.Text = "Chinese Word:";
                    labelShowWord.Text = dataStruct[randomIndex[index_testing]].getEnglishWord();
                    testMode_tmp = 0;
                    break;
                case 2:
                    labelPrompt.Text = "Please enter a English word.";
                    labelShowWordTitle.Text = "Chinese Word:";
                    labelEditWordTitle.Text = "English Word:";
                    if (dataStruct[randomIndex[index_testing]].getChineseWord1() != "")
                    {
                        index_c.Add(dataStruct[randomIndex[index_testing]].getChineseWord1());
                    }
                    else if (dataStruct[randomIndex[index_testing]].getChineseWord2() != "")
                    {
                        index_c.Add(dataStruct[randomIndex[index_testing]].getChineseWord2());
                    }
                    else if (dataStruct[randomIndex[index_testing]].getChineseWord3() != "")
                    {
                        index_c.Add(dataStruct[randomIndex[index_testing]].getChineseWord3());
                    }
                    else if (dataStruct[randomIndex[index_testing]].getChineseWord4() != "")
                    {
                        index_c.Add(dataStruct[randomIndex[index_testing]].getChineseWord4());
                    }
                    labelShowWord.Text = index_c[random.Next(index_c.Count)];
                    testMode_tmp = 1;
                    break;
            }
        }

        private String[] returnAnswer()
        {
            String[] answer = new String[4];
            if (testMode_tmp == 0)
            {
                answer[0] = dataStruct[randomIndex[index_testing]].getChineseWord1();
                answer[1] = dataStruct[randomIndex[index_testing]].getChineseWord2();
                answer[2] = dataStruct[randomIndex[index_testing]].getChineseWord3();
                answer[3] = dataStruct[randomIndex[index_testing]].getChineseWord4();
            }
            else
            {
                answer[0] = dataStruct[randomIndex[index_testing]].getEnglishWord();
            }
            return answer;
        }

        private void stopTesting()
        {
            testRange.Clear();
            dataStruct.Clear();
            randomIndex.Clear();
            index_testing = 0;

            buttonStart.Enabled = true;
            buttonPause.Enabled = false;
            buttonStop.Enabled = false;
            buttonSCA.Enabled = false;
            groupBoxTR.Enabled = true;
            groupBoxMP.Enabled = false;
            buttonHome.Enabled = true;
            if ((radioButtonSU.Checked == true) || (radioButtonMU.Checked == true))
            {
                textBoxEUN.Enabled = true;
            }
            labelPrompt.Text = "Stop Testing.";
            
        }
    }
}
