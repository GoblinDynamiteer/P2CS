﻿namespace ch01_8
{
    partial class Form1
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
            this.browserWindow = new System.Windows.Forms.WebBrowser();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // browserWindow
            // 
            this.browserWindow.Location = new System.Drawing.Point(12, 12);
            this.browserWindow.MinimumSize = new System.Drawing.Size(20, 20);
            this.browserWindow.Name = "browserWindow";
            this.browserWindow.Size = new System.Drawing.Size(786, 385);
            this.browserWindow.TabIndex = 0;
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(12, 411);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(690, 20);
            this.tbURL.TabIndex = 1;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(723, 408);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 441);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.browserWindow);
            this.Name = "Form1";
            this.Text = "MyFirstWebBrowser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser browserWindow;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Button btnGo;
    }
}

