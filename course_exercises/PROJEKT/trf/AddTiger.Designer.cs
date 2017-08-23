namespace trf
{
    partial class frmAddTiger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddTiger));
            this.btnCancel = new System.Windows.Forms.Button();
            this.comboBoxTigerType = new System.Windows.Forms.ComboBox();
            this.textBoxTigerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.btnAddTiger = new System.Windows.Forms.Button();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.errorIconName = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorIconName)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(110, 142);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Avbryt";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // comboBoxTigerType
            // 
            this.comboBoxTigerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTigerType.FormattingEnabled = true;
            this.comboBoxTigerType.Items.AddRange(new object[] {
            "Bengalisk",
            "Malaya",
            "Sibirisk",
            "Sumatra",
            "Sydkinesisk"});
            this.comboBoxTigerType.Location = new System.Drawing.Point(64, 57);
            this.comboBoxTigerType.Name = "comboBoxTigerType";
            this.comboBoxTigerType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTigerType.Sorted = true;
            this.comboBoxTigerType.TabIndex = 2;
            // 
            // textBoxTigerName
            // 
            this.textBoxTigerName.Location = new System.Drawing.Point(64, 28);
            this.textBoxTigerName.MaxLength = 20;
            this.textBoxTigerName.Name = "textBoxTigerName";
            this.textBoxTigerName.Size = new System.Drawing.Size(121, 20);
            this.textBoxTigerName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Namn";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(19, 60);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(20, 13);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "Art";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(19, 90);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(26, 13);
            this.lblGender.TabIndex = 8;
            this.lblGender.Text = "Kön";
            // 
            // btnAddTiger
            // 
            this.btnAddTiger.Location = new System.Drawing.Point(22, 142);
            this.btnAddTiger.Name = "btnAddTiger";
            this.btnAddTiger.Size = new System.Drawing.Size(75, 23);
            this.btnAddTiger.TabIndex = 9;
            this.btnAddTiger.Text = "Lägg till";
            this.btnAddTiger.UseVisualStyleBackColor = true;
            this.btnAddTiger.Click += new System.EventHandler(this.btnAddTiger_Click);
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Checked = true;
            this.radioButtonMale.Location = new System.Drawing.Point(64, 88);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(51, 17);
            this.radioButtonMale.TabIndex = 10;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Hane";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            this.radioButtonMale.CheckedChanged += new System.EventHandler(this.radioButtonGenderSwap);
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(64, 109);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(51, 17);
            this.radioButtonFemale.TabIndex = 11;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Hona";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            this.radioButtonFemale.CheckedChanged += new System.EventHandler(this.radioButtonGenderSwap);
            // 
            // errorIconName
            // 
            this.errorIconName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.errorIconName.Image = ((System.Drawing.Image)(resources.GetObject("errorIconName.Image")));
            this.errorIconName.Location = new System.Drawing.Point(190, 28);
            this.errorIconName.Name = "errorIconName";
            this.errorIconName.Size = new System.Drawing.Size(20, 20);
            this.errorIconName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.errorIconName.TabIndex = 12;
            this.errorIconName.TabStop = false;
            // 
            // frmAddTiger
            // 
            this.AcceptButton = this.btnAddTiger;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(217, 186);
            this.Controls.Add(this.errorIconName);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.btnAddTiger);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTigerName);
            this.Controls.Add(this.comboBoxTigerType);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddTiger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTiger";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.errorIconName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox comboBoxTigerType;
        private System.Windows.Forms.TextBox textBoxTigerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Button btnAddTiger;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.PictureBox errorIconName;
    }
}