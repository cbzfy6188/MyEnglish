﻿namespace MyEnglish
{
    partial class EditUnits
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
            this.labelEAUN = new System.Windows.Forms.Label();
            this.textBoxEAUN = new System.Windows.Forms.TextBox();
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
            // labelEAUN
            // 
            this.labelEAUN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelEAUN.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelEAUN.Location = new System.Drawing.Point(809, 13);
            this.labelEAUN.Name = "labelEAUN";
            this.labelEAUN.Size = new System.Drawing.Size(131, 18);
            this.labelEAUN.TabIndex = 15;
            this.labelEAUN.Text = "Enter a unit number:";
            // 
            // textBoxEAUN
            // 
            this.textBoxEAUN.Location = new System.Drawing.Point(809, 35);
            this.textBoxEAUN.Name = "textBoxEAUN";
            this.textBoxEAUN.Size = new System.Drawing.Size(131, 21);
            this.textBoxEAUN.TabIndex = 16;
            // 
            // EditUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 423);
            this.Controls.Add(this.textBoxEAUN);
            this.Controls.Add(this.labelEAUN);
            this.Controls.Add(this.buttonHome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditUnits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "EditUnits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Label labelEAUN;
        private System.Windows.Forms.TextBox textBoxEAUN;
    }
}