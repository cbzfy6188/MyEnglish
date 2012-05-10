namespace MyEnglish
{
    partial class AddNewUnit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textEnglishWord = new System.Windows.Forms.TextBox();
            this.textChineseWord1 = new System.Windows.Forms.TextBox();
            this.textChineseWord2 = new System.Windows.Forms.TextBox();
            this.textChineseWord3 = new System.Windows.Forms.TextBox();
            this.textChineseWord4 = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textUnit = new System.Windows.Forms.TextBox();
            this.labelUnitNumber = new System.Windows.Forms.Label();
            this.labelEnglishWord = new System.Windows.Forms.Label();
            this.labelChineseWord1 = new System.Windows.Forms.Label();
            this.labelChineseWord2 = new System.Windows.Forms.Label();
            this.labelChineseWord3 = new System.Windows.Forms.Label();
            this.labelChineseWord4 = new System.Windows.Forms.Label();
            this.buttonHome = new System.Windows.Forms.Button();
            this.labelUnit = new System.Windows.Forms.Label();
            this.labelWords = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textEnglishWord
            // 
            this.textEnglishWord.Location = new System.Drawing.Point(841, 58);
            this.textEnglishWord.Multiline = true;
            this.textEnglishWord.Name = "textEnglishWord";
            this.textEnglishWord.Size = new System.Drawing.Size(99, 52);
            this.textEnglishWord.TabIndex = 0;
            this.textEnglishWord.TextChanged += new System.EventHandler(this.textEnglishWord_TextChanged);
            // 
            // textChineseWord1
            // 
            this.textChineseWord1.Location = new System.Drawing.Point(646, 158);
            this.textChineseWord1.Multiline = true;
            this.textChineseWord1.Name = "textChineseWord1";
            this.textChineseWord1.Size = new System.Drawing.Size(131, 52);
            this.textChineseWord1.TabIndex = 1;
            this.textChineseWord1.TextChanged += new System.EventHandler(this.textChineseWord1_TextChanged);
            // 
            // textChineseWord2
            // 
            this.textChineseWord2.Location = new System.Drawing.Point(809, 158);
            this.textChineseWord2.Multiline = true;
            this.textChineseWord2.Name = "textChineseWord2";
            this.textChineseWord2.Size = new System.Drawing.Size(131, 52);
            this.textChineseWord2.TabIndex = 2;
            this.textChineseWord2.TextChanged += new System.EventHandler(this.textChineseWord2_TextChanged);
            // 
            // textChineseWord3
            // 
            this.textChineseWord3.Location = new System.Drawing.Point(646, 251);
            this.textChineseWord3.Multiline = true;
            this.textChineseWord3.Name = "textChineseWord3";
            this.textChineseWord3.Size = new System.Drawing.Size(131, 52);
            this.textChineseWord3.TabIndex = 3;
            this.textChineseWord3.TextChanged += new System.EventHandler(this.textChineseWord3_TextChanged);
            // 
            // textChineseWord4
            // 
            this.textChineseWord4.Location = new System.Drawing.Point(809, 251);
            this.textChineseWord4.Multiline = true;
            this.textChineseWord4.Name = "textChineseWord4";
            this.textChineseWord4.Size = new System.Drawing.Size(131, 52);
            this.textChineseWord4.TabIndex = 4;
            this.textChineseWord4.TextChanged += new System.EventHandler(this.textChineseWord4_TextChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(646, 334);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(131, 55);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textUnit
            // 
            this.textUnit.Location = new System.Drawing.Point(841, 12);
            this.textUnit.Name = "textUnit";
            this.textUnit.Size = new System.Drawing.Size(99, 21);
            this.textUnit.TabIndex = 6;
            this.textUnit.TextChanged += new System.EventHandler(this.textUnit_TextChanged);
            // 
            // labelUnitNumber
            // 
            this.labelUnitNumber.AutoSize = true;
            this.labelUnitNumber.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelUnitNumber.Location = new System.Drawing.Point(706, 14);
            this.labelUnitNumber.Name = "labelUnitNumber";
            this.labelUnitNumber.Size = new System.Drawing.Size(116, 16);
            this.labelUnitNumber.TabIndex = 7;
            this.labelUnitNumber.Text = "Unit Number:";
            // 
            // labelEnglishWord
            // 
            this.labelEnglishWord.AutoSize = true;
            this.labelEnglishWord.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelEnglishWord.Location = new System.Drawing.Point(706, 78);
            this.labelEnglishWord.Name = "labelEnglishWord";
            this.labelEnglishWord.Size = new System.Drawing.Size(125, 16);
            this.labelEnglishWord.TabIndex = 8;
            this.labelEnglishWord.Text = "English Word:";
            // 
            // labelChineseWord1
            // 
            this.labelChineseWord1.AutoSize = true;
            this.labelChineseWord1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelChineseWord1.Location = new System.Drawing.Point(643, 127);
            this.labelChineseWord1.Name = "labelChineseWord1";
            this.labelChineseWord1.Size = new System.Drawing.Size(134, 16);
            this.labelChineseWord1.TabIndex = 9;
            this.labelChineseWord1.Text = "Chinese Word1:";
            // 
            // labelChineseWord2
            // 
            this.labelChineseWord2.AutoSize = true;
            this.labelChineseWord2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelChineseWord2.Location = new System.Drawing.Point(806, 127);
            this.labelChineseWord2.Name = "labelChineseWord2";
            this.labelChineseWord2.Size = new System.Drawing.Size(134, 16);
            this.labelChineseWord2.TabIndex = 10;
            this.labelChineseWord2.Text = "Chinese Word2:";
            // 
            // labelChineseWord3
            // 
            this.labelChineseWord3.AutoSize = true;
            this.labelChineseWord3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelChineseWord3.Location = new System.Drawing.Point(643, 222);
            this.labelChineseWord3.Name = "labelChineseWord3";
            this.labelChineseWord3.Size = new System.Drawing.Size(134, 16);
            this.labelChineseWord3.TabIndex = 11;
            this.labelChineseWord3.Text = "Chinese Word3:";
            // 
            // labelChineseWord4
            // 
            this.labelChineseWord4.AutoSize = true;
            this.labelChineseWord4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelChineseWord4.Location = new System.Drawing.Point(806, 222);
            this.labelChineseWord4.Name = "labelChineseWord4";
            this.labelChineseWord4.Size = new System.Drawing.Size(134, 16);
            this.labelChineseWord4.TabIndex = 12;
            this.labelChineseWord4.Text = "Chinese Word4:";
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(809, 334);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(131, 55);
            this.buttonHome.TabIndex = 13;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.home_Click);
            // 
            // labelUnit
            // 
            this.labelUnit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelUnit.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelUnit.Location = new System.Drawing.Point(13, 12);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(601, 21);
            this.labelUnit.TabIndex = 14;
            this.labelUnit.Text = "Unit:";
            // 
            // labelWords
            // 
            this.labelWords.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelWords.Location = new System.Drawing.Point(13, 58);
            this.labelWords.Name = "labelWords";
            this.labelWords.Size = new System.Drawing.Size(601, 331);
            this.labelWords.TabIndex = 15;
            // 
            // AddNewUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 423);
            this.Controls.Add(this.labelWords);
            this.Controls.Add(this.labelUnit);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.labelChineseWord4);
            this.Controls.Add(this.labelChineseWord3);
            this.Controls.Add(this.labelChineseWord2);
            this.Controls.Add(this.labelChineseWord1);
            this.Controls.Add(this.labelEnglishWord);
            this.Controls.Add(this.labelUnitNumber);
            this.Controls.Add(this.textUnit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textChineseWord4);
            this.Controls.Add(this.textChineseWord3);
            this.Controls.Add(this.textChineseWord2);
            this.Controls.Add(this.textChineseWord1);
            this.Controls.Add(this.textEnglishWord);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewUnit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AddNewUnit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textEnglishWord;
        private System.Windows.Forms.TextBox textChineseWord1;
        private System.Windows.Forms.TextBox textChineseWord2;
        private System.Windows.Forms.TextBox textChineseWord3;
        private System.Windows.Forms.TextBox textChineseWord4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textUnit;
        private System.Windows.Forms.Label labelUnitNumber;
        private System.Windows.Forms.Label labelEnglishWord;
        private System.Windows.Forms.Label labelChineseWord1;
        private System.Windows.Forms.Label labelChineseWord2;
        private System.Windows.Forms.Label labelChineseWord3;
        private System.Windows.Forms.Label labelChineseWord4;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.Label labelWords;
    }
}