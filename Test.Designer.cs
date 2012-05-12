namespace MyEnglish
{
    partial class Test
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
            this.buttonHome = new System.Windows.Forms.Button();
            this.labelShowWordTitle = new System.Windows.Forms.Label();
            this.labelEditWordTitle = new System.Windows.Forms.Label();
            this.labelShowWord = new System.Windows.Forms.Label();
            this.textEditWord = new System.Windows.Forms.TextBox();
            this.labelTestResult = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonSCA = new System.Windows.Forms.Button();
            this.labelCorrectAnswer = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.radioButtonR = new System.Windows.Forms.RadioButton();
            this.radioButtonSE = new System.Windows.Forms.RadioButton();
            this.radioButtonSC = new System.Windows.Forms.RadioButton();
            this.groupBoxTM = new System.Windows.Forms.GroupBox();
            this.checkBoxRTWW = new System.Windows.Forms.CheckBox();
            this.groupBoxTR = new System.Windows.Forms.GroupBox();
            this.radioButtonAT = new System.Windows.Forms.RadioButton();
            this.radioButtonSU = new System.Windows.Forms.RadioButton();
            this.radioButtonMU = new System.Windows.Forms.RadioButton();
            this.textBoxEUN = new System.Windows.Forms.TextBox();
            this.labelEUN = new System.Windows.Forms.Label();
            this.groupBoxMP = new System.Windows.Forms.GroupBox();
            this.labelPrompt = new System.Windows.Forms.Label();
            this.groupBoxTM.SuspendLayout();
            this.groupBoxTR.SuspendLayout();
            this.groupBoxMP.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(809, 334);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(131, 55);
            this.buttonHome.TabIndex = 14;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // labelShowWordTitle
            // 
            this.labelShowWordTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelShowWordTitle.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelShowWordTitle.Location = new System.Drawing.Point(26, 48);
            this.labelShowWordTitle.Name = "labelShowWordTitle";
            this.labelShowWordTitle.Size = new System.Drawing.Size(160, 31);
            this.labelShowWordTitle.TabIndex = 15;
            this.labelShowWordTitle.Text = "English Word:";
            // 
            // labelEditWordTitle
            // 
            this.labelEditWordTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelEditWordTitle.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelEditWordTitle.Location = new System.Drawing.Point(26, 171);
            this.labelEditWordTitle.Name = "labelEditWordTitle";
            this.labelEditWordTitle.Size = new System.Drawing.Size(160, 31);
            this.labelEditWordTitle.TabIndex = 16;
            this.labelEditWordTitle.Text = "Chinese Word:";
            // 
            // labelShowWord
            // 
            this.labelShowWord.AutoSize = true;
            this.labelShowWord.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelShowWord.Location = new System.Drawing.Point(228, 48);
            this.labelShowWord.Name = "labelShowWord";
            this.labelShowWord.Size = new System.Drawing.Size(64, 20);
            this.labelShowWord.TabIndex = 17;
            this.labelShowWord.Text = "Hello";
            // 
            // textEditWord
            // 
            this.textEditWord.Location = new System.Drawing.Point(232, 144);
            this.textEditWord.Multiline = true;
            this.textEditWord.Name = "textEditWord";
            this.textEditWord.Size = new System.Drawing.Size(160, 81);
            this.textEditWord.TabIndex = 18;
            // 
            // labelTestResult
            // 
            this.labelTestResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTestResult.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTestResult.Location = new System.Drawing.Point(453, 171);
            this.labelTestResult.Name = "labelTestResult";
            this.labelTestResult.Size = new System.Drawing.Size(100, 31);
            this.labelTestResult.TabIndex = 19;
            this.labelTestResult.Text = "Wrong!!!";
            // 
            // labelInfo
            // 
            this.labelInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelInfo.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelInfo.Location = new System.Drawing.Point(809, 13);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(131, 282);
            this.labelInfo.TabIndex = 20;
            this.labelInfo.Text = "Information:";
            // 
            // buttonSCA
            // 
            this.buttonSCA.Location = new System.Drawing.Point(667, 12);
            this.buttonSCA.Name = "buttonSCA";
            this.buttonSCA.Size = new System.Drawing.Size(112, 46);
            this.buttonSCA.TabIndex = 22;
            this.buttonSCA.Text = "Show Correct Answer";
            this.buttonSCA.UseVisualStyleBackColor = true;
            // 
            // labelCorrectAnswer
            // 
            this.labelCorrectAnswer.AutoSize = true;
            this.labelCorrectAnswer.ForeColor = System.Drawing.Color.Red;
            this.labelCorrectAnswer.Location = new System.Drawing.Point(451, 55);
            this.labelCorrectAnswer.Name = "labelCorrectAnswer";
            this.labelCorrectAnswer.Size = new System.Drawing.Size(89, 12);
            this.labelCorrectAnswer.TabIndex = 24;
            this.labelCorrectAnswer.Text = "Correct answer";
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(507, 12);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(112, 46);
            this.buttonStop.TabIndex = 25;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(180, 13);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(112, 46);
            this.buttonStart.TabIndex = 26;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(342, 13);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(112, 46);
            this.buttonPause.TabIndex = 27;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            // 
            // radioButtonR
            // 
            this.radioButtonR.AutoSize = true;
            this.radioButtonR.Location = new System.Drawing.Point(8, 20);
            this.radioButtonR.Name = "radioButtonR";
            this.radioButtonR.Size = new System.Drawing.Size(59, 16);
            this.radioButtonR.TabIndex = 30;
            this.radioButtonR.TabStop = true;
            this.radioButtonR.Text = "Random";
            this.radioButtonR.UseVisualStyleBackColor = true;
            // 
            // radioButtonSE
            // 
            this.radioButtonSE.AutoSize = true;
            this.radioButtonSE.Location = new System.Drawing.Point(8, 42);
            this.radioButtonSE.Name = "radioButtonSE";
            this.radioButtonSE.Size = new System.Drawing.Size(95, 16);
            this.radioButtonSE.TabIndex = 31;
            this.radioButtonSE.TabStop = true;
            this.radioButtonSE.Text = "Show English";
            this.radioButtonSE.UseVisualStyleBackColor = true;
            // 
            // radioButtonSC
            // 
            this.radioButtonSC.AutoSize = true;
            this.radioButtonSC.Location = new System.Drawing.Point(8, 64);
            this.radioButtonSC.Name = "radioButtonSC";
            this.radioButtonSC.Size = new System.Drawing.Size(95, 16);
            this.radioButtonSC.TabIndex = 32;
            this.radioButtonSC.TabStop = true;
            this.radioButtonSC.Text = "Show Chinese";
            this.radioButtonSC.UseVisualStyleBackColor = true;
            // 
            // groupBoxTM
            // 
            this.groupBoxTM.Controls.Add(this.radioButtonR);
            this.groupBoxTM.Controls.Add(this.radioButtonSC);
            this.groupBoxTM.Controls.Add(this.radioButtonSE);
            this.groupBoxTM.Location = new System.Drawing.Point(20, 269);
            this.groupBoxTM.Name = "groupBoxTM";
            this.groupBoxTM.Size = new System.Drawing.Size(124, 89);
            this.groupBoxTM.TabIndex = 33;
            this.groupBoxTM.TabStop = false;
            this.groupBoxTM.Text = "Test Mode";
            // 
            // checkBoxRTWW
            // 
            this.checkBoxRTWW.AutoSize = true;
            this.checkBoxRTWW.Location = new System.Drawing.Point(20, 373);
            this.checkBoxRTWW.Name = "checkBoxRTWW";
            this.checkBoxRTWW.Size = new System.Drawing.Size(132, 16);
            this.checkBoxRTWW.TabIndex = 34;
            this.checkBoxRTWW.Text = "Retest Wrong Words";
            this.checkBoxRTWW.UseVisualStyleBackColor = true;
            // 
            // groupBoxTR
            // 
            this.groupBoxTR.Controls.Add(this.radioButtonMU);
            this.groupBoxTR.Controls.Add(this.radioButtonSU);
            this.groupBoxTR.Controls.Add(this.radioButtonAT);
            this.groupBoxTR.Location = new System.Drawing.Point(20, 13);
            this.groupBoxTR.Name = "groupBoxTR";
            this.groupBoxTR.Size = new System.Drawing.Size(124, 94);
            this.groupBoxTR.TabIndex = 35;
            this.groupBoxTR.TabStop = false;
            this.groupBoxTR.Text = "Test Range";
            // 
            // radioButtonAT
            // 
            this.radioButtonAT.AutoSize = true;
            this.radioButtonAT.Location = new System.Drawing.Point(8, 21);
            this.radioButtonAT.Name = "radioButtonAT";
            this.radioButtonAT.Size = new System.Drawing.Size(47, 16);
            this.radioButtonAT.TabIndex = 0;
            this.radioButtonAT.TabStop = true;
            this.radioButtonAT.Text = "Auto";
            this.radioButtonAT.UseVisualStyleBackColor = true;
            this.radioButtonAT.CheckedChanged += new System.EventHandler(this.radioButtonAT_CheckedChanged);
            // 
            // radioButtonSU
            // 
            this.radioButtonSU.AutoSize = true;
            this.radioButtonSU.Location = new System.Drawing.Point(8, 44);
            this.radioButtonSU.Name = "radioButtonSU";
            this.radioButtonSU.Size = new System.Drawing.Size(89, 16);
            this.radioButtonSU.TabIndex = 1;
            this.radioButtonSU.TabStop = true;
            this.radioButtonSU.Text = "Single Unit";
            this.radioButtonSU.UseVisualStyleBackColor = true;
            this.radioButtonSU.CheckedChanged += new System.EventHandler(this.radioButtonSU_CheckedChanged);
            // 
            // radioButtonMU
            // 
            this.radioButtonMU.AutoSize = true;
            this.radioButtonMU.Location = new System.Drawing.Point(8, 67);
            this.radioButtonMU.Name = "radioButtonMU";
            this.radioButtonMU.Size = new System.Drawing.Size(89, 16);
            this.radioButtonMU.TabIndex = 2;
            this.radioButtonMU.TabStop = true;
            this.radioButtonMU.Text = "Multi Units";
            this.radioButtonMU.UseVisualStyleBackColor = true;
            this.radioButtonMU.CheckedChanged += new System.EventHandler(this.radioButtonMU_CheckedChanged);
            // 
            // textBoxEUN
            // 
            this.textBoxEUN.Location = new System.Drawing.Point(20, 145);
            this.textBoxEUN.Multiline = true;
            this.textBoxEUN.Name = "textBoxEUN";
            this.textBoxEUN.Size = new System.Drawing.Size(124, 80);
            this.textBoxEUN.TabIndex = 36;
            // 
            // labelEUN
            // 
            this.labelEUN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelEUN.Location = new System.Drawing.Point(20, 117);
            this.labelEUN.Name = "labelEUN";
            this.labelEUN.Size = new System.Drawing.Size(124, 19);
            this.labelEUN.TabIndex = 37;
            this.labelEUN.Text = "Enter Unit Numbers:";
            // 
            // groupBoxMP
            // 
            this.groupBoxMP.Controls.Add(this.labelShowWordTitle);
            this.groupBoxMP.Controls.Add(this.labelEditWordTitle);
            this.groupBoxMP.Controls.Add(this.labelShowWord);
            this.groupBoxMP.Controls.Add(this.labelCorrectAnswer);
            this.groupBoxMP.Controls.Add(this.labelTestResult);
            this.groupBoxMP.Controls.Add(this.textEditWord);
            this.groupBoxMP.Location = new System.Drawing.Point(180, 80);
            this.groupBoxMP.Name = "groupBoxMP";
            this.groupBoxMP.Size = new System.Drawing.Size(599, 260);
            this.groupBoxMP.TabIndex = 38;
            this.groupBoxMP.TabStop = false;
            this.groupBoxMP.Text = "Main Panel";
            // 
            // labelPrompt
            // 
            this.labelPrompt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPrompt.Location = new System.Drawing.Point(180, 365);
            this.labelPrompt.Name = "labelPrompt";
            this.labelPrompt.Size = new System.Drawing.Size(599, 24);
            this.labelPrompt.TabIndex = 39;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 423);
            this.Controls.Add(this.labelPrompt);
            this.Controls.Add(this.groupBoxMP);
            this.Controls.Add(this.labelEUN);
            this.Controls.Add(this.textBoxEUN);
            this.Controls.Add(this.groupBoxTR);
            this.Controls.Add(this.checkBoxRTWW);
            this.Controls.Add(this.groupBoxTM);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonSCA);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonHome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Test";
            this.groupBoxTM.ResumeLayout(false);
            this.groupBoxTM.PerformLayout();
            this.groupBoxTR.ResumeLayout(false);
            this.groupBoxTR.PerformLayout();
            this.groupBoxMP.ResumeLayout(false);
            this.groupBoxMP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Label labelShowWordTitle;
        private System.Windows.Forms.Label labelEditWordTitle;
        private System.Windows.Forms.Label labelShowWord;
        private System.Windows.Forms.TextBox textEditWord;
        private System.Windows.Forms.Label labelTestResult;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonSCA;
        private System.Windows.Forms.Label labelCorrectAnswer;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.RadioButton radioButtonR;
        private System.Windows.Forms.RadioButton radioButtonSE;
        private System.Windows.Forms.RadioButton radioButtonSC;
        private System.Windows.Forms.GroupBox groupBoxTM;
        private System.Windows.Forms.CheckBox checkBoxRTWW;
        private System.Windows.Forms.GroupBox groupBoxTR;
        private System.Windows.Forms.RadioButton radioButtonSU;
        private System.Windows.Forms.RadioButton radioButtonAT;
        private System.Windows.Forms.RadioButton radioButtonMU;
        private System.Windows.Forms.TextBox textBoxEUN;
        private System.Windows.Forms.Label labelEUN;
        private System.Windows.Forms.GroupBox groupBoxMP;
        private System.Windows.Forms.Label labelPrompt;
    }
}