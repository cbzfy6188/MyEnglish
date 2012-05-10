using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyEnglish
{
    class DataStruct
    {
        private int unit = 0;
        private String EnglishWord = "";
        private String ChineseWord1 = "";
        private String ChineseWord2 = "";
        private String ChineseWord3 = "";
        private String ChineseWord4 = "";
        private bool tested = false;

        public void setUnit(int munit)
        {
            unit = munit;
        }

        public int getUnit()
        {
            return unit;
        }

        public void setEnglishWord(String mEnglishWord)
        {
            EnglishWord = mEnglishWord;
        }

        public String getEnglishWord()
        {
            return EnglishWord;
        }

        public void setChineseWord1(String mChineseWord1)
        {
            ChineseWord1 = mChineseWord1;
        }

        public String getChineseWord1()
        {
            return ChineseWord1;
        }

        public void setChineseWord2(String mChineseWord2)
        {
            ChineseWord2 = mChineseWord2;
        }

        public String getChineseWord2()
        {
            return ChineseWord2;
        }

        public void setChineseWord3(String mChineseWord3)
        {
            ChineseWord3 = mChineseWord3;
        }

        public String getChineseWord3()
        {
            return ChineseWord3;
        }

        public void setChineseWord4(String mChineseWord4)
        {
            ChineseWord4 = mChineseWord4;
        }

        public String getChineseWord4()
        {
            return ChineseWord4;
        }

        public void setTested(bool mtested)
        {
            tested = mtested;
        }

        public bool getTested()
        {
            return tested;
        }
    }
}
