namespace trf
{
    partial class frmAddMember
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableAddMember = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxZipCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tableAddMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Förnamn";
            // 
            // tableAddMember
            // 
            this.tableAddMember.ColumnCount = 2;
            this.tableAddMember.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableAddMember.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableAddMember.Controls.Add(this.textBoxLastName, 1, 1);
            this.tableAddMember.Controls.Add(this.label2, 0, 1);
            this.tableAddMember.Controls.Add(this.label1, 0, 0);
            this.tableAddMember.Controls.Add(this.textBoxFirstName, 1, 0);
            this.tableAddMember.Controls.Add(this.label3, 0, 2);
            this.tableAddMember.Controls.Add(this.textBoxStreet, 1, 2);
            this.tableAddMember.Controls.Add(this.label4, 0, 3);
            this.tableAddMember.Controls.Add(this.textBoxZipCode, 1, 3);
            this.tableAddMember.Controls.Add(this.label5, 0, 4);
            this.tableAddMember.Controls.Add(this.textBoxCity, 1, 4);
            this.tableAddMember.Controls.Add(this.dateTimePickerBirth, 1, 5);
            this.tableAddMember.Controls.Add(this.label6, 0, 5);
            this.tableAddMember.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableAddMember.Location = new System.Drawing.Point(13, 17);
            this.tableAddMember.Name = "tableAddMember";
            this.tableAddMember.RowCount = 6;
            this.tableAddMember.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableAddMember.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableAddMember.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableAddMember.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableAddMember.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableAddMember.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableAddMember.Size = new System.Drawing.Size(612, 294);
            this.tableAddMember.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(186, 40);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(423, 31);
            this.textBoxLastName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Efternamn";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(186, 3);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(423, 31);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gata";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(186, 77);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(423, 31);
            this.textBoxStreet.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Postnummer";
            // 
            // textBoxZipCode
            // 
            this.textBoxZipCode.Location = new System.Drawing.Point(186, 114);
            this.textBoxZipCode.Name = "textBoxZipCode";
            this.textBoxZipCode.Size = new System.Drawing.Size(423, 31);
            this.textBoxZipCode.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ort";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(186, 151);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(423, 31);
            this.textBoxCity.TabIndex = 3;
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Location = new System.Drawing.Point(186, 188);
            this.dateTimePickerBirth.MaxDate = new System.DateTime(2017, 8, 6, 0, 0, 0, 0);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(200, 31);
            this.dateTimePickerBirth.TabIndex = 4;
            this.dateTimePickerBirth.Value = new System.DateTime(2017, 8, 6, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Födelsedatum";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(304, 336);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(158, 75);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Lägg till";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.AddMemberFromForm);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(468, 336);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(158, 75);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Avbryt";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.Cancel);
            // 
            // frmAddMember
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(686, 627);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tableAddMember);
            this.Name = "frmAddMember";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lägg till ny medlem";
            this.TopMost = true;
            this.tableAddMember.ResumeLayout(false);
            this.tableAddMember.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableAddMember;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxZipCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}