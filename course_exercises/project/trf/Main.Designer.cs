namespace trf
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnRemoveMember = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.exporteraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoOmTigrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membersDataSet = new trf.MembersDataSet();
            this.membersDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblName = new System.Windows.Forms.Label();
            this.membersTableAdapter = new trf.MembersDataSetTableAdapters.MembersTableAdapter();
            this.tableAdapterManager = new trf.MembersDataSetTableAdapters.TableAdapterManager();
            this.tigersTableAdapter = new trf.MembersDataSetTableAdapters.TigersTableAdapter();
            this.tigersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tigersListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTigerGender = new System.Windows.Forms.Label();
            this.lblTigerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblipCode = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblNumberOfMembers = new System.Windows.Forms.Label();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.groupBoxTigerInfo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tigersBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxTigerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemoveMember
            // 
            this.btnRemoveMember.Location = new System.Drawing.Point(16, 188);
            this.btnRemoveMember.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveMember.Name = "btnRemoveMember";
            this.btnRemoveMember.Size = new System.Drawing.Size(142, 32);
            this.btnRemoveMember.TabIndex = 4;
            this.btnRemoveMember.Text = "Radera medlem";
            this.btnRemoveMember.UseVisualStyleBackColor = true;
            this.btnRemoveMember.Click += new System.EventHandler(this.btnRemoveMember_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(676, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator,
            this.exporteraToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(31, 22);
            this.fileToolStripMenuItem.Text = "&Fil";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(120, 6);
            // 
            // exporteraToolStripMenuItem
            // 
            this.exporteraToolStripMenuItem.Name = "exporteraToolStripMenuItem";
            this.exporteraToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exporteraToolStripMenuItem.Text = "Exportera";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exitToolStripMenuItem.Text = "Avsluta";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.infoOmTigrarToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 22);
            this.helpToolStripMenuItem.Text = "&Hjälp";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.aboutToolStripMenuItem.Text = "&Om programmet";
            // 
            // infoOmTigrarToolStripMenuItem
            // 
            this.infoOmTigrarToolStripMenuItem.Name = "infoOmTigrarToolStripMenuItem";
            this.infoOmTigrarToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.infoOmTigrarToolStripMenuItem.Text = "Info om tigrar";
            this.infoOmTigrarToolStripMenuItem.Click += new System.EventHandler(this.infoOmTigrarToolStripMenuItem_Click);
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "Members";
            this.membersBindingSource.DataSource = this.membersDataSet;
            // 
            // membersDataSet
            // 
            this.membersDataSet.DataSetName = "MembersDataSet";
            this.membersDataSet.EnforceConstraints = false;
            this.membersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membersDataGridView
            // 
            this.membersDataGridView.AllowUserToAddRows = false;
            this.membersDataGridView.AllowUserToDeleteRows = false;
            this.membersDataGridView.AllowUserToResizeColumns = false;
            this.membersDataGridView.AllowUserToResizeRows = false;
            this.membersDataGridView.AutoGenerateColumns = false;
            this.membersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.membersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.membersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.membersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.membersDataGridView.DataSource = this.membersBindingSource;
            this.membersDataGridView.GridColor = System.Drawing.SystemColors.Window;
            this.membersDataGridView.Location = new System.Drawing.Point(25, 57);
            this.membersDataGridView.MultiSelect = false;
            this.membersDataGridView.Name = "membersDataGridView";
            this.membersDataGridView.ReadOnly = true;
            this.membersDataGridView.RowHeadersVisible = false;
            this.membersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.membersDataGridView.Size = new System.Drawing.Size(231, 335);
            this.membersDataGridView.TabIndex = 8;
            this.membersDataGridView.SelectionChanged += new System.EventHandler(this.membersDataGridView_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 22;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Förnamn";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Efternamn";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(13, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(140, 18);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Förnamn Efternamn";
            // 
            // membersTableAdapter
            // 
            this.membersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MembersTableAdapter = this.membersTableAdapter;
            this.tableAdapterManager.TigersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = trf.MembersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tigersTableAdapter
            // 
            this.tigersTableAdapter.ClearBeforeFill = true;
            // 
            // tigersBindingSource
            // 
            this.tigersBindingSource.DataMember = "Tigers";
            this.tigersBindingSource.DataSource = this.membersDataSet;
            // 
            // tigersListBox
            // 
            this.tigersListBox.DataSource = this.tigersBindingSource;
            this.tigersListBox.DisplayMember = "Name";
            this.tigersListBox.FormattingEnabled = true;
            this.tigersListBox.Location = new System.Drawing.Point(227, 62);
            this.tigersListBox.Name = "tigersListBox";
            this.tigersListBox.Size = new System.Drawing.Size(110, 69);
            this.tigersListBox.TabIndex = 10;
            this.tigersListBox.ValueMember = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tigrar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxTigerInfo);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tigersListBox);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnRemoveMember);
            this.groupBox1.Location = new System.Drawing.Point(280, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 237);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medlemsinformation";
            // 
            // lblTigerGender
            // 
            this.lblTigerGender.AutoSize = true;
            this.lblTigerGender.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tigersBindingSource, "Gender", true));
            this.lblTigerGender.Location = new System.Drawing.Point(41, 55);
            this.lblTigerGender.Name = "lblTigerGender";
            this.lblTigerGender.Size = new System.Drawing.Size(50, 13);
            this.lblTigerGender.TabIndex = 16;
            this.lblTigerGender.Text = "TigerKön";
            // 
            // lblTigerName
            // 
            this.lblTigerName.AutoSize = true;
            this.lblTigerName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tigersBindingSource, "Name", true));
            this.lblTigerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTigerName.Location = new System.Drawing.Point(6, 16);
            this.lblTigerName.Name = "lblTigerName";
            this.lblTigerName.Size = new System.Drawing.Size(84, 20);
            this.lblTigerName.TabIndex = 15;
            this.lblTigerName.Text = "Tigernamn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Typ:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tigersBindingSource, "Type", true));
            this.lblType.Location = new System.Drawing.Point(41, 38);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(49, 13);
            this.lblType.TabIndex = 13;
            this.lblType.Text = "TigerTyp";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCountry);
            this.groupBox2.Controls.Add(this.lblStreet);
            this.groupBox2.Controls.Add(this.lblipCode);
            this.groupBox2.Controls.Add(this.lblCity);
            this.groupBox2.Location = new System.Drawing.Point(16, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 87);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adress";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "Country", true));
            this.lblCountry.Location = new System.Drawing.Point(8, 51);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 0;
            this.lblCountry.Text = "Country";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "Street", true));
            this.lblStreet.Location = new System.Drawing.Point(8, 25);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(35, 13);
            this.lblStreet.TabIndex = 0;
            this.lblStreet.Text = "Street";
            // 
            // lblipCode
            // 
            this.lblipCode.AutoSize = true;
            this.lblipCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "ZipCode", true));
            this.lblipCode.Location = new System.Drawing.Point(8, 38);
            this.lblipCode.Name = "lblipCode";
            this.lblipCode.Size = new System.Drawing.Size(37, 13);
            this.lblipCode.TabIndex = 0;
            this.lblipCode.Text = "12345";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "Country", true));
            this.lblCity.Location = new System.Drawing.Point(49, 38);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "City";
            // 
            // lblNumberOfMembers
            // 
            this.lblNumberOfMembers.AutoSize = true;
            this.lblNumberOfMembers.Location = new System.Drawing.Point(25, 35);
            this.lblNumberOfMembers.Name = "lblNumberOfMembers";
            this.lblNumberOfMembers.Size = new System.Drawing.Size(100, 13);
            this.lblNumberOfMembers.TabIndex = 13;
            this.lblNumberOfMembers.Text = "Antal medlemmar: X";
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(25, 408);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(105, 36);
            this.btnAddMember.TabIndex = 14;
            this.btnAddMember.Text = "Ny Medlem";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // groupBoxTigerInfo
            // 
            this.groupBoxTigerInfo.Controls.Add(this.label3);
            this.groupBoxTigerInfo.Controls.Add(this.lblTigerName);
            this.groupBoxTigerInfo.Controls.Add(this.lblTigerGender);
            this.groupBoxTigerInfo.Controls.Add(this.lblType);
            this.groupBoxTigerInfo.Controls.Add(this.label1);
            this.groupBoxTigerInfo.Location = new System.Drawing.Point(227, 137);
            this.groupBoxTigerInfo.Name = "groupBoxTigerInfo";
            this.groupBoxTigerInfo.Size = new System.Drawing.Size(110, 83);
            this.groupBoxTigerInfo.TabIndex = 17;
            this.groupBoxTigerInfo.TabStop = false;
            this.groupBoxTigerInfo.Text = "Tigerinfo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Kön:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 463);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.lblNumberOfMembers);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.membersDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tigersBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxTigerInfo.ResumeLayout(false);
            this.groupBoxTigerInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRemoveMember;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporteraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoOmTigrarToolStripMenuItem;
        private MembersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView membersDataGridView;
        private System.Windows.Forms.Label lblName;
        private MembersDataSetTableAdapters.TigersTableAdapter tigersTableAdapter;
        private System.Windows.Forms.BindingSource tigersBindingSource;
        private System.Windows.Forms.ListBox tigersListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        public MembersDataSet membersDataSet;
        public System.Windows.Forms.BindingSource membersBindingSource;
        public MembersDataSetTableAdapters.MembersTableAdapter membersTableAdapter;
        private System.Windows.Forms.Label lblNumberOfMembers;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblipCode;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblTigerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTigerGender;
        private System.Windows.Forms.GroupBox groupBoxTigerInfo;
        private System.Windows.Forms.Label label3;
    }
}

