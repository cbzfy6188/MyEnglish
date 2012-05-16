namespace MyEnglish
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.addNewUnit = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Button();
            this.editUnits = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addNewUnit
            // 
            this.addNewUnit.Location = new System.Drawing.Point(103, 83);
            this.addNewUnit.Name = "addNewUnit";
            this.addNewUnit.Size = new System.Drawing.Size(120, 61);
            this.addNewUnit.TabIndex = 0;
            this.addNewUnit.Text = "Add New Unit";
            this.addNewUnit.UseVisualStyleBackColor = true;
            this.addNewUnit.Click += new System.EventHandler(this.addNewUnit_Click);
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(765, 83);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(120, 61);
            this.test.TabIndex = 1;
            this.test.Text = "Test";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // editUnits
            // 
            this.editUnits.Location = new System.Drawing.Point(438, 83);
            this.editUnits.Name = "editUnits";
            this.editUnits.Size = new System.Drawing.Size(120, 61);
            this.editUnits.TabIndex = 2;
            this.editUnits.Text = "Edit Units";
            this.editUnits.UseVisualStyleBackColor = true;
            this.editUnits.Click += new System.EventHandler(this.editUnits_Click);
            // 
            // help
            // 
            this.help.Location = new System.Drawing.Point(103, 236);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(120, 61);
            this.help.TabIndex = 3;
            this.help.Text = "Help";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // about
            // 
            this.about.Location = new System.Drawing.Point(438, 236);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(120, 61);
            this.about.TabIndex = 4;
            this.about.Text = "About";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(765, 236);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(120, 61);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(966, 423);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.about);
            this.Controls.Add(this.help);
            this.Controls.Add(this.editUnits);
            this.Controls.Add(this.test);
            this.Controls.Add(this.addNewUnit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MyEnglish";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addNewUnit;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.Button editUnits;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button buttonExit;
    }
}

