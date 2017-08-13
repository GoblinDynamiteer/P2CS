namespace trf
{
    partial class frmChangePassword
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
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblPasswordInfo = new System.Windows.Forms.Label();
            this.btnGenerateRandomPassword = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(15, 32);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '*';
            this.textBoxNewPassword.Size = new System.Drawing.Size(257, 20);
            this.textBoxNewPassword.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(115, 119);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblPasswordInfo
            // 
            this.lblPasswordInfo.AutoSize = true;
            this.lblPasswordInfo.Location = new System.Drawing.Point(12, 15);
            this.lblPasswordInfo.Name = "lblPasswordInfo";
            this.lblPasswordInfo.Size = new System.Drawing.Size(95, 13);
            this.lblPasswordInfo.TabIndex = 2;
            this.lblPasswordInfo.Text = "Ange nytt lösenord";
            // 
            // btnGenerateRandomPassword
            // 
            this.btnGenerateRandomPassword.Location = new System.Drawing.Point(197, 68);
            this.btnGenerateRandomPassword.Name = "btnGenerateRandomPassword";
            this.btnGenerateRandomPassword.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateRandomPassword.TabIndex = 3;
            this.btnGenerateRandomPassword.Text = "Generera";
            this.btnGenerateRandomPassword.UseVisualStyleBackColor = true;
            this.btnGenerateRandomPassword.Click += new System.EventHandler(this.btnGenerateRandomPassword_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(197, 118);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Avbryt";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(15, 72);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(93, 17);
            this.checkBoxShowPassword.TabIndex = 5;
            this.checkBoxShowPassword.Text = "Visa Lösenord";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // frmChangePassword
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 153);
            this.Controls.Add(this.checkBoxShowPassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGenerateRandomPassword);
            this.Controls.Add(this.lblPasswordInfo);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.textBoxNewPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangePassword";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblPasswordInfo;
        private System.Windows.Forms.Button btnGenerateRandomPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
    }
}