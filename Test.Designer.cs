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
            this.labelShowWordTitle.Location = new System.Drawing.Point(153, 89);
            this.labelShowWordTitle.Name = "labelShowWordTitle";
            this.labelShowWordTitle.Size = new System.Drawing.Size(160, 31);
            this.labelShowWordTitle.TabIndex = 15;
            this.labelShowWordTitle.Text = "English Word:";
            // 
            // labelEditWordTitle
            // 
            this.labelEditWordTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelEditWordTitle.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelEditWordTitle.Location = new System.Drawing.Point(153, 241);
            this.labelEditWordTitle.Name = "labelEditWordTitle";
            this.labelEditWordTitle.Size = new System.Drawing.Size(160, 31);
            this.labelEditWordTitle.TabIndex = 16;
            this.labelEditWordTitle.Text = "Chinese Word:";
            // 
            // labelShowWord
            // 
            this.labelShowWord.AutoSize = true;
            this.labelShowWord.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelShowWord.Location = new System.Drawing.Point(388, 89);
            this.labelShowWord.Name = "labelShowWord";
            this.labelShowWord.Size = new System.Drawing.Size(64, 20);
            this.labelShowWord.TabIndex = 17;
            this.labelShowWord.Text = "Hello";
            // 
            // textEditWord
            // 
            this.textEditWord.Location = new System.Drawing.Point(392, 214);
            this.textEditWord.Multiline = true;
            this.textEditWord.Name = "textEditWord";
            this.textEditWord.Size = new System.Drawing.Size(160, 81);
            this.textEditWord.TabIndex = 18;
            // 
            // labelTestResult
            // 
            this.labelTestResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTestResult.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTestResult.Location = new System.Drawing.Point(648, 241);
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
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 423);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelTestResult);
            this.Controls.Add(this.textEditWord);
            this.Controls.Add(this.labelShowWord);
            this.Controls.Add(this.labelEditWordTitle);
            this.Controls.Add(this.labelShowWordTitle);
            this.Controls.Add(this.buttonHome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Test";
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
    }
}