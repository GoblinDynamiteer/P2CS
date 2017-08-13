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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddMember));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxZipCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.tableAddMember = new System.Windows.Forms.TableLayoutPanel();
            this.errorIconFirstName = new System.Windows.Forms.PictureBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorIconLastName = new System.Windows.Forms.PictureBox();
            this.errorIconStreet = new System.Windows.Forms.PictureBox();
            this.errorIconZipCode = new System.Windows.Forms.PictureBox();
            this.errorIconCity = new System.Windows.Forms.PictureBox();
            this.errorIconCountry = new System.Windows.Forms.PictureBox();
            this.tableAddMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIconFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIconLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIconStreet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIconZipCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIconCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIconCountry)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(5, 210);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 39);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Lägg till";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(87, 210);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 39);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Avbryt";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textBoxCity
            // 
            this.textBoxCity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxCity.Location = new System.Drawing.Point(97, 129);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCity.MaxLength = 30;
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(187, 20);
            this.textBoxCity.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ort";
            // 
            // textBoxZipCode
            // 
            this.textBoxZipCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxZipCode.Location = new System.Drawing.Point(208, 98);
            this.textBoxZipCode.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxZipCode.MaxLength = 6;
            this.textBoxZipCode.Name = "textBoxZipCode";
            this.textBoxZipCode.Size = new System.Drawing.Size(76, 20);
            this.textBoxZipCode.TabIndex = 3;
            this.textBoxZipCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Postnummer";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxStreet.Location = new System.Drawing.Point(97, 67);
            this.textBoxStreet.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStreet.MaxLength = 30;
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(187, 20);
            this.textBoxStreet.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gata";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxFirstName.Location = new System.Drawing.Point(97, 5);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFirstName.MaxLength = 30;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(187, 20);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Förnamn";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Efternamn";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxLastName.Location = new System.Drawing.Point(97, 36);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLastName.MaxLength = 30;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(187, 20);
            this.textBoxLastName.TabIndex = 3;
            // 
            // tableAddMember
            // 
            this.tableAddMember.ColumnCount = 3;
            this.tableAddMember.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableAddMember.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableAddMember.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableAddMember.Controls.Add(this.errorIconFirstName, 2, 0);
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
            this.tableAddMember.Controls.Add(this.textBoxCountry, 1, 5);
            this.tableAddMember.Controls.Add(this.label6, 0, 5);
            this.tableAddMember.Controls.Add(this.errorIconLastName, 2, 1);
            this.tableAddMember.Controls.Add(this.errorIconStreet, 2, 2);
            this.tableAddMember.Controls.Add(this.errorIconZipCode, 2, 3);
            this.tableAddMember.Controls.Add(this.errorIconCity, 2, 4);
            this.tableAddMember.Controls.Add(this.errorIconCountry, 2, 5);
            this.tableAddMember.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableAddMember.Location = new System.Drawing.Point(6, 9);
            this.tableAddMember.Margin = new System.Windows.Forms.Padding(2);
            this.tableAddMember.Name = "tableAddMember";
            this.tableAddMember.RowCount = 6;
            this.tableAddMember.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableAddMember.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableAddMember.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableAddMember.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableAddMember.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableAddMember.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableAddMember.Size = new System.Drawing.Size(319, 188);
            this.tableAddMember.TabIndex = 1;
            // 
            // errorIconFirstName
            // 
            this.errorIconFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.errorIconFirstName.Image = ((System.Drawing.Image)(resources.GetObject("errorIconFirstName.Image")));
            this.errorIconFirstName.Location = new System.Drawing.Point(289, 5);
            this.errorIconFirstName.Name = "errorIconFirstName";
            this.errorIconFirstName.Size = new System.Drawing.Size(20, 20);
            this.errorIconFirstName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.errorIconFirstName.TabIndex = 4;
            this.errorIconFirstName.TabStop = false;
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxCountry.Location = new System.Drawing.Point(97, 161);
            this.textBoxCountry.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCountry.MaxLength = 30;
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(187, 20);
            this.textBoxCountry.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 165);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Land";
            // 
            // errorIconLastName
            // 
            this.errorIconLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.errorIconLastName.Image = ((System.Drawing.Image)(resources.GetObject("errorIconLastName.Image")));
            this.errorIconLastName.Location = new System.Drawing.Point(289, 36);
            this.errorIconLastName.Name = "errorIconLastName";
            this.errorIconLastName.Size = new System.Drawing.Size(20, 20);
            this.errorIconLastName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.errorIconLastName.TabIndex = 4;
            this.errorIconLastName.TabStop = false;
            // 
            // errorIconStreet
            // 
            this.errorIconStreet.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.errorIconStreet.Image = ((System.Drawing.Image)(resources.GetObject("errorIconStreet.Image")));
            this.errorIconStreet.Location = new System.Drawing.Point(289, 67);
            this.errorIconStreet.Name = "errorIconStreet";
            this.errorIconStreet.Size = new System.Drawing.Size(20, 20);
            this.errorIconStreet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.errorIconStreet.TabIndex = 4;
            this.errorIconStreet.TabStop = false;
            // 
            // errorIconZipCode
            // 
            this.errorIconZipCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.errorIconZipCode.Image = ((System.Drawing.Image)(resources.GetObject("errorIconZipCode.Image")));
            this.errorIconZipCode.Location = new System.Drawing.Point(289, 98);
            this.errorIconZipCode.Name = "errorIconZipCode";
            this.errorIconZipCode.Size = new System.Drawing.Size(20, 20);
            this.errorIconZipCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.errorIconZipCode.TabIndex = 4;
            this.errorIconZipCode.TabStop = false;
            // 
            // errorIconCity
            // 
            this.errorIconCity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.errorIconCity.Image = ((System.Drawing.Image)(resources.GetObject("errorIconCity.Image")));
            this.errorIconCity.Location = new System.Drawing.Point(289, 129);
            this.errorIconCity.Name = "errorIconCity";
            this.errorIconCity.Size = new System.Drawing.Size(20, 20);
            this.errorIconCity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.errorIconCity.TabIndex = 4;
            this.errorIconCity.TabStop = false;
            // 
            // errorIconCountry
            // 
            this.errorIconCountry.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.errorIconCountry.Image = ((System.Drawing.Image)(resources.GetObject("errorIconCountry.Image")));
            this.errorIconCountry.Location = new System.Drawing.Point(289, 161);
            this.errorIconCountry.Name = "errorIconCountry";
            this.errorIconCountry.Size = new System.Drawing.Size(20, 20);
            this.errorIconCountry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.errorIconCountry.TabIndex = 4;
            this.errorIconCountry.TabStop = false;
            // 
            // frmAddMember
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(344, 281);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tableAddMember);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAddMember";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lägg till ny medlem";
            this.TopMost = true;
            this.tableAddMember.ResumeLayout(false);
            this.tableAddMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIconFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIconLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIconStreet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIconZipCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIconCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIconCountry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxZipCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TableLayoutPanel tableAddMember;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox errorIconFirstName;
        private System.Windows.Forms.PictureBox errorIconLastName;
        private System.Windows.Forms.PictureBox errorIconStreet;
        private System.Windows.Forms.PictureBox errorIconZipCode;
        private System.Windows.Forms.PictureBox errorIconCity;
        private System.Windows.Forms.PictureBox errorIconCountry;
    }
}