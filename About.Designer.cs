namespace MyEnglish
{
    partial class About
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
            this.labelHelp = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
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
            // labelHelp
            // 
            this.labelHelp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelHelp.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelHelp.Location = new System.Drawing.Point(262, 41);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(380, 348);
            this.labelHelp.TabIndex = 16;
            // 
            // labelVersion
            // 
            this.labelVersion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelVersion.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelVersion.Location = new System.Drawing.Point(857, 41);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(83, 23);
            this.labelVersion.TabIndex = 17;
            this.labelVersion.Text = "V1.0.0";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 423);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelHelp);
            this.Controls.Add(this.buttonHome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "About";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Label labelHelp;
        private System.Windows.Forms.Label labelVersion;
    }
}