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
            this.btnAddMember = new System.Windows.Forms.Button();
            this.listBoxMembers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName3 = new System.Windows.Forms.Label();
            this.btnRemoveMember = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.exporteraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoOmTigrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.membersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.membersDataGridView = new System.Windows.Forms.DataGridView();
            this.lblName1 = new System.Windows.Forms.Label();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membersDataSet = new trf.MembersDataSet();
            this.membersTableAdapter = new trf.MembersDataSetTableAdapters.MembersTableAdapter();
            this.tableAdapterManager = new trf.MembersDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblName2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingNavigator)).BeginInit();
            this.membersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(665, 416);
            this.btnAddMember.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(142, 33);
            this.btnAddMember.TabIndex = 0;
            this.btnAddMember.Text = "Lägg till ny medlem";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.AddMemberFormShow);
            // 
            // listBoxMembers
            // 
            this.listBoxMembers.FormattingEnabled = true;
            this.listBoxMembers.Items.AddRange(new object[] {
            "-"});
            this.listBoxMembers.Location = new System.Drawing.Point(517, 411);
            this.listBoxMembers.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxMembers.Name = "listBoxMembers";
            this.listBoxMembers.Size = new System.Drawing.Size(144, 173);
            this.listBoxMembers.TabIndex = 1;
            this.listBoxMembers.SelectedIndexChanged += new System.EventHandler(this.listBoxMembersSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Medlemmar";
            // 
            // lblName3
            // 
            this.lblName3.AutoSize = true;
            this.lblName3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblName3.Location = new System.Drawing.Point(794, 595);
            this.lblName3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName3.Name = "lblName3";
            this.lblName3.Size = new System.Drawing.Size(24, 13);
            this.lblName3.TabIndex = 3;
            this.lblName3.Text = "asd";
            // 
            // btnRemoveMember
            // 
            this.btnRemoveMember.Location = new System.Drawing.Point(665, 453);
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
            this.menuStrip1.Size = new System.Drawing.Size(1007, 24);
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
            // 
            // membersBindingNavigator
            // 
            this.membersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.membersBindingNavigator.BindingSource = this.membersBindingSource;
            this.membersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.membersBindingNavigator.CountItemFormat = "av {0}";
            this.membersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.membersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.membersBindingNavigatorSaveItem});
            this.membersBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.membersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.membersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.membersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.membersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.membersBindingNavigator.Name = "membersBindingNavigator";
            this.membersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.membersBindingNavigator.Size = new System.Drawing.Size(1007, 25);
            this.membersBindingNavigator.TabIndex = 7;
            this.membersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "av {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // membersBindingNavigatorSaveItem
            // 
            this.membersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.membersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("membersBindingNavigatorSaveItem.Image")));
            this.membersBindingNavigatorSaveItem.Name = "membersBindingNavigatorSaveItem";
            this.membersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.membersBindingNavigatorSaveItem.Text = "Save Data";
            this.membersBindingNavigatorSaveItem.Click += new System.EventHandler(this.membersBindingNavigatorSaveItem_Click);
            // 
            // membersDataGridView
            // 
            this.membersDataGridView.AllowUserToAddRows = false;
            this.membersDataGridView.AllowUserToDeleteRows = false;
            this.membersDataGridView.AutoGenerateColumns = false;
            this.membersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.membersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.membersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.membersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.membersDataGridView.DataSource = this.membersBindingSource;
            this.membersDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.membersDataGridView.GridColor = System.Drawing.SystemColors.Window;
            this.membersDataGridView.Location = new System.Drawing.Point(0, 49);
            this.membersDataGridView.MultiSelect = false;
            this.membersDataGridView.Name = "membersDataGridView";
            this.membersDataGridView.ReadOnly = true;
            this.membersDataGridView.Size = new System.Drawing.Size(1007, 346);
            this.membersDataGridView.TabIndex = 8;
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "FirstName", true));
            this.lblName1.Location = new System.Drawing.Point(12, 416);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(35, 13);
            this.lblName1.TabIndex = 9;
            this.lblName1.Text = "label2";
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "Members";
            this.membersBindingSource.DataSource = this.membersDataSet;
            // 
            // membersDataSet
            // 
            this.membersDataSet.DataSetName = "MembersDataSet";
            this.membersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membersTableAdapter
            // 
            this.membersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MembersTableAdapter = this.membersTableAdapter;
            this.tableAdapterManager.UpdateOrder = trf.MembersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 79;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "LastName", true));
            this.lblName2.Location = new System.Drawing.Point(83, 416);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(35, 13);
            this.lblName2.TabIndex = 10;
            this.lblName2.Text = "label2";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 676);
            this.Controls.Add(this.lblName2);
            this.Controls.Add(this.lblName1);
            this.Controls.Add(this.membersDataGridView);
            this.Controls.Add(this.membersBindingNavigator);
            this.Controls.Add(this.btnRemoveMember);
            this.Controls.Add(this.lblName3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxMembers);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingNavigator)).EndInit();
            this.membersBindingNavigator.ResumeLayout(false);
            this.membersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.ListBox listBoxMembers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName3;
        private System.Windows.Forms.Button btnRemoveMember;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporteraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoOmTigrarToolStripMenuItem;
        private MembersDataSet membersDataSet;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private MembersDataSetTableAdapters.MembersTableAdapter membersTableAdapter;
        private MembersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator membersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton membersBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView membersDataGridView;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label lblName2;
    }
}

