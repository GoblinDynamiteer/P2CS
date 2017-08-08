namespace trf
{
    partial class frmPassword
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
            this.btnPasswordOK = new System.Windows.Forms.Button();
            this.textBoxEnterPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPasswordInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPasswordOK
            // 
            this.btnPasswordOK.Location = new System.Drawing.Point(30, 120);
            this.btnPasswordOK.Name = "btnPasswordOK";
            this.btnPasswordOK.Size = new System.Drawing.Size(250, 80);
            this.btnPasswordOK.TabIndex = 0;
            this.btnPasswordOK.Text = "OK";
            this.btnPasswordOK.UseVisualStyleBackColor = true;
            this.btnPasswordOK.Click += new System.EventHandler(this.btnPasswordOK_Click);
            // 
            // textBoxEnterPassword
            // 
            this.textBoxEnterPassword.Location = new System.Drawing.Point(30, 65);
            this.textBoxEnterPassword.Name = "textBoxEnterPassword";
            this.textBoxEnterPassword.PasswordChar = '*';
            this.textBoxEnterPassword.Size = new System.Drawing.Size(520, 31);
            this.textBoxEnterPassword.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 80);
            this.button1.TabIndex = 2;
            this.button1.Text = "Avsluta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblPasswordInfo
            // 
            this.lblPasswordInfo.AutoSize = true;
            this.lblPasswordInfo.Location = new System.Drawing.Point(30, 30);
            this.lblPasswordInfo.Name = "lblPasswordInfo";
            this.lblPasswordInfo.Size = new System.Drawing.Size(392, 25);
            this.lblPasswordInfo.TabIndex = 3;
            this.lblPasswordInfo.Text = "Ange lösenord för att starta programmet";
            // 
            // frmPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 229);
            this.Controls.Add(this.lblPasswordInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxEnterPassword);
            this.Controls.Add(this.btnPasswordOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPassword";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPassword_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPasswordOK;
        private System.Windows.Forms.TextBox textBoxEnterPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPasswordInfo;
    }
}