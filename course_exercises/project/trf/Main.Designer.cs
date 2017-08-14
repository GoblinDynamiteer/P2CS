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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporteraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verktygToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ändaLösenordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoOmTigrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset = new trf.MembersDataSet();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblName = new System.Windows.Forms.Label();
            this.adapterMembers = new trf.MembersDataSetTableAdapters.MembersTableAdapter();
            this.tableAdapterManager = new trf.MembersDataSetTableAdapters.TableAdapterManager();
            this.adapterTigers = new trf.MembersDataSetTableAdapters.TigersTableAdapter();
            this.tigersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tigersListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTigersOwned = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblipCode = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.btnRemoveTiger = new System.Windows.Forms.Button();
            this.btnAddTiger = new System.Windows.Forms.Button();
            this.groupBoxTigerInfo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTigerName = new System.Windows.Forms.Label();
            this.lblTigerGender = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumberOfMembers = new System.Windows.Forms.Label();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.textBoxTigerID = new System.Windows.Forms.TextBox();
            this.textBoxMemberId = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tigersBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxTigerInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemoveMember
            // 
            this.btnRemoveMember.Location = new System.Drawing.Point(16, 266);
            this.btnRemoveMember.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveMember.Name = "btnRemoveMember";
            this.btnRemoveMember.Size = new System.Drawing.Size(142, 32);
            this.btnRemoveMember.TabIndex = 4;
            this.btnRemoveMember.Text = "Radera medlem";
            this.btnRemoveMember.UseVisualStyleBackColor = true;
            this.btnRemoveMember.Click += new System.EventHandler(this.btnRemoveMember_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.verktygToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip.Size = new System.Drawing.Size(676, 24);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exporteraToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(31, 22);
            this.fileToolStripMenuItem.Text = "&Fil";
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // verktygToolStripMenuItem
            // 
            this.verktygToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ändaLösenordToolStripMenuItem});
            this.verktygToolStripMenuItem.Name = "verktygToolStripMenuItem";
            this.verktygToolStripMenuItem.Size = new System.Drawing.Size(58, 22);
            this.verktygToolStripMenuItem.Text = "&Verktyg";
            // 
            // ändaLösenordToolStripMenuItem
            // 
            this.ändaLösenordToolStripMenuItem.Name = "ändaLösenordToolStripMenuItem";
            this.ändaLösenordToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.ändaLösenordToolStripMenuItem.Text = "Ändra lösenord";
            this.ändaLösenordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
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
            this.membersBindingSource.DataSource = this.dataset;
            // 
            // dataset
            // 
            this.dataset.DataSetName = "MembersDataSet";
            this.dataset.EnforceConstraints = false;
            this.dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataView
            // 
            this.dataView.AllowUserToAddRows = false;
            this.dataView.AllowUserToDeleteRows = false;
            this.dataView.AllowUserToResizeColumns = false;
            this.dataView.AllowUserToResizeRows = false;
            this.dataView.AutoGenerateColumns = false;
            this.dataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataView.DataSource = this.membersBindingSource;
            this.dataView.GridColor = System.Drawing.SystemColors.Window;
            this.dataView.Location = new System.Drawing.Point(25, 62);
            this.dataView.MultiSelect = false;
            this.dataView.Name = "dataView";
            this.dataView.ReadOnly = true;
            this.dataView.RowHeadersVisible = false;
            this.dataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataView.Size = new System.Drawing.Size(231, 290);
            this.dataView.TabIndex = 8;
            this.dataView.SelectionChanged += new System.EventHandler(this.dataView_SelectionChanged);
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
            this.lblName.Location = new System.Drawing.Point(13, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(140, 18);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Förnamn Efternamn";
            // 
            // adapterMembers
            // 
            this.adapterMembers.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MembersTableAdapter = this.adapterMembers;
            this.tableAdapterManager.TigersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = trf.MembersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // adapterTigers
            // 
            this.adapterTigers.ClearBeforeFill = true;
            // 
            // tigersBindingSource
            // 
            this.tigersBindingSource.DataMember = "Tigers";
            this.tigersBindingSource.DataSource = this.dataset;
            // 
            // tigersListBox
            // 
            this.tigersListBox.DataSource = this.tigersBindingSource;
            this.tigersListBox.DisplayMember = "Name";
            this.tigersListBox.FormattingEnabled = true;
            this.tigersListBox.Location = new System.Drawing.Point(24, 22);
            this.tigersListBox.Name = "tigersListBox";
            this.tigersListBox.Size = new System.Drawing.Size(110, 108);
            this.tigersListBox.TabIndex = 10;
            this.tigersListBox.ValueMember = "Id";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTigersOwned);
            this.groupBox1.Controls.Add(this.lblCountry);
            this.groupBox1.Controls.Add(this.lblStreet);
            this.groupBox1.Controls.Add(this.lblipCode);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblCity);
            this.groupBox1.Controls.Add(this.btnRemoveMember);
            this.groupBox1.Location = new System.Drawing.Point(280, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 312);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medlem";
            // 
            // lblTigersOwned
            // 
            this.lblTigersOwned.AutoSize = true;
            this.lblTigersOwned.Location = new System.Drawing.Point(13, 117);
            this.lblTigersOwned.Name = "lblTigersOwned";
            this.lblTigersOwned.Size = new System.Drawing.Size(70, 13);
            this.lblTigersOwned.TabIndex = 10;
            this.lblTigersOwned.Text = "Antal tigrar: X";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "Country", true));
            this.lblCountry.Location = new System.Drawing.Point(13, 78);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 0;
            this.lblCountry.Text = "Country";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "Street", true));
            this.lblStreet.Location = new System.Drawing.Point(13, 48);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(35, 13);
            this.lblStreet.TabIndex = 0;
            this.lblStreet.Text = "Street";
            // 
            // lblipCode
            // 
            this.lblipCode.AutoSize = true;
            this.lblipCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "ZipCode", true));
            this.lblipCode.Location = new System.Drawing.Point(13, 63);
            this.lblipCode.Name = "lblipCode";
            this.lblipCode.Size = new System.Drawing.Size(37, 13);
            this.lblipCode.TabIndex = 0;
            this.lblipCode.Text = "12345";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "City", true));
            this.lblCity.Location = new System.Drawing.Point(54, 63);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "City";
            // 
            // btnRemoveTiger
            // 
            this.btnRemoveTiger.Location = new System.Drawing.Point(24, 266);
            this.btnRemoveTiger.Name = "btnRemoveTiger";
            this.btnRemoveTiger.Size = new System.Drawing.Size(110, 32);
            this.btnRemoveTiger.TabIndex = 19;
            this.btnRemoveTiger.Text = "Ta bort tiger";
            this.btnRemoveTiger.UseVisualStyleBackColor = true;
            this.btnRemoveTiger.Click += new System.EventHandler(this.btnRemoveTiger_Click);
            // 
            // btnAddTiger
            // 
            this.btnAddTiger.Location = new System.Drawing.Point(24, 228);
            this.btnAddTiger.Name = "btnAddTiger";
            this.btnAddTiger.Size = new System.Drawing.Size(110, 32);
            this.btnAddTiger.TabIndex = 18;
            this.btnAddTiger.Text = "Lägg till tiger";
            this.btnAddTiger.UseVisualStyleBackColor = true;
            this.btnAddTiger.Click += new System.EventHandler(this.btnAddTiger_Click);
            // 
            // groupBoxTigerInfo
            // 
            this.groupBoxTigerInfo.Controls.Add(this.label3);
            this.groupBoxTigerInfo.Controls.Add(this.lblTigerName);
            this.groupBoxTigerInfo.Controls.Add(this.lblTigerGender);
            this.groupBoxTigerInfo.Controls.Add(this.lblType);
            this.groupBoxTigerInfo.Controls.Add(this.label1);
            this.groupBoxTigerInfo.Location = new System.Drawing.Point(24, 139);
            this.groupBoxTigerInfo.Name = "groupBoxTigerInfo";
            this.groupBoxTigerInfo.Size = new System.Drawing.Size(110, 83);
            this.groupBoxTigerInfo.TabIndex = 17;
            this.groupBoxTigerInfo.TabStop = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Typ:";
            // 
            // lblNumberOfMembers
            // 
            this.lblNumberOfMembers.AutoSize = true;
            this.lblNumberOfMembers.Location = new System.Drawing.Point(22, 40);
            this.lblNumberOfMembers.Name = "lblNumberOfMembers";
            this.lblNumberOfMembers.Size = new System.Drawing.Size(100, 13);
            this.lblNumberOfMembers.TabIndex = 13;
            this.lblNumberOfMembers.Text = "Antal medlemmar: X";
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(25, 369);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(105, 36);
            this.btnAddMember.TabIndex = 14;
            this.btnAddMember.Text = "Ny Medlem";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // textBoxTigerID
            // 
            this.textBoxTigerID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tigersBindingSource, "Id", true));
            this.textBoxTigerID.Location = new System.Drawing.Point(364, 369);
            this.textBoxTigerID.Name = "textBoxTigerID";
            this.textBoxTigerID.ReadOnly = true;
            this.textBoxTigerID.Size = new System.Drawing.Size(100, 20);
            this.textBoxTigerID.TabIndex = 20;
            // 
            // textBoxMemberId
            // 
            this.textBoxMemberId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "Id", true));
            this.textBoxMemberId.Location = new System.Drawing.Point(364, 395);
            this.textBoxMemberId.Name = "textBoxMemberId";
            this.textBoxMemberId.Size = new System.Drawing.Size(100, 20);
            this.textBoxMemberId.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tigersListBox);
            this.groupBox2.Controls.Add(this.btnRemoveTiger);
            this.groupBox2.Controls.Add(this.groupBoxTigerInfo);
            this.groupBox2.Controls.Add(this.btnAddTiger);
            this.groupBox2.Location = new System.Drawing.Point(495, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 312);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tigrar";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(519, 360);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(110, 36);
            this.btnQuit.TabIndex = 23;
            this.btnQuit.Text = "Avsluta";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(136, 385);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(120, 20);
            this.textBoxFilter.TabIndex = 24;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            this.textBoxFilter.DoubleClick += new System.EventHandler(this.textBoxFilter_DoubleClick);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(134, 370);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(45, 13);
            this.lblFilter.TabIndex = 25;
            this.lblFilter.Text = "Sökfilter";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 423);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBoxMemberId);
            this.Controls.Add(this.textBoxTigerID);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.lblNumberOfMembers);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tigersBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxTigerInfo.ResumeLayout(false);
            this.groupBoxTigerInfo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRemoveMember;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporteraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoOmTigrarToolStripMenuItem;
        private MembersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Label lblName;
        private MembersDataSetTableAdapters.TigersTableAdapter adapterTigers;
        private System.Windows.Forms.BindingSource tigersBindingSource;
        private System.Windows.Forms.ListBox tigersListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private MembersDataSet dataset;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private MembersDataSetTableAdapters.MembersTableAdapter adapterMembers;
        private System.Windows.Forms.Label lblNumberOfMembers;
        private System.Windows.Forms.Button btnAddMember;
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
        private System.Windows.Forms.Button btnRemoveTiger;
        private System.Windows.Forms.Button btnAddTiger;
        private System.Windows.Forms.TextBox textBoxTigerID;
        private System.Windows.Forms.TextBox textBoxMemberId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTigersOwned;
        private System.Windows.Forms.ToolStripMenuItem verktygToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ändaLösenordToolStripMenuItem;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Label lblFilter;
    }
}

