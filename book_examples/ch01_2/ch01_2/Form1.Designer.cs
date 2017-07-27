namespace ch01_2
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
            this.tbPasswd = new System.Windows.Forms.TextBox();
            this.lbShowPasswd = new System.Windows.Forms.Label();
            this.btnShowMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPasswd
            // 
            this.tbPasswd.Location = new System.Drawing.Point(20, 25);
            this.tbPasswd.Name = "tbPasswd";
            this.tbPasswd.PasswordChar = '*';
            this.tbPasswd.Size = new System.Drawing.Size(245, 20);
            this.tbPasswd.TabIndex = 0;
            // 
            // lbShowPasswd
            // 
            this.lbShowPasswd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbShowPasswd.Location = new System.Drawing.Point(20, 75);
            this.lbShowPasswd.Name = "lbShowPasswd";
            this.lbShowPasswd.Size = new System.Drawing.Size(245, 20);
            this.lbShowPasswd.TabIndex = 1;
            // 
            // btnShowMe
            // 
            this.btnShowMe.Location = new System.Drawing.Point(90, 150);
            this.btnShowMe.Name = "btnShowMe";
            this.btnShowMe.Size = new System.Drawing.Size(100, 40);
            this.btnShowMe.TabIndex = 2;
            this.btnShowMe.Text = "Show Me";
            this.btnShowMe.UseVisualStyleBackColor = true;
            this.btnShowMe.Click += new System.EventHandler(this.btnShowMe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnShowMe);
            this.Controls.Add(this.lbShowPasswd);
            this.Controls.Add(this.tbPasswd);
            this.Name = "Form1";
            this.Text = "PasswdTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPasswd;
        private System.Windows.Forms.Label lbShowPasswd;
        private System.Windows.Forms.Button btnShowMe;
    }
}

