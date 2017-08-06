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
            this.btnAddMember = new System.Windows.Forms.Button();
            this.listBoxMembers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnRemoveMember = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoOmTigrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporteraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(48, 461);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(285, 64);
            this.btnAddMember.TabIndex = 0;
            this.btnAddMember.Text = "Lägg till ny medlem";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.AddMemberFormShow);
            // 
            // listBoxMembers
            // 
            this.listBoxMembers.FormattingEnabled = true;
            this.listBoxMembers.ItemHeight = 25;
            this.listBoxMembers.Items.AddRange(new object[] {
            "-"});
            this.listBoxMembers.Location = new System.Drawing.Point(48, 110);
            this.listBoxMembers.Name = "listBoxMembers";
            this.listBoxMembers.Size = new System.Drawing.Size(285, 329);
            this.listBoxMembers.TabIndex = 1;
            this.listBoxMembers.SelectedIndexChanged += new System.EventHandler(this.listBoxMembersSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Medlemmar";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblName.Location = new System.Drawing.Point(378, 110);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 25);
            this.lblName.TabIndex = 3;
            // 
            // btnRemoveMember
            // 
            this.btnRemoveMember.Location = new System.Drawing.Point(48, 542);
            this.btnRemoveMember.Name = "btnRemoveMember";
            this.btnRemoveMember.Size = new System.Drawing.Size(285, 62);
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
            this.menuStrip1.Size = new System.Drawing.Size(1275, 40);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 36);
            this.fileToolStripMenuItem.Text = "&Fil";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(265, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.exitToolStripMenuItem.Text = "Avsluta";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.infoOmTigrarToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(82, 36);
            this.helpToolStripMenuItem.Text = "&Hjälp";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(293, 38);
            this.aboutToolStripMenuItem.Text = "&Om programmet";
            // 
            // infoOmTigrarToolStripMenuItem
            // 
            this.infoOmTigrarToolStripMenuItem.Name = "infoOmTigrarToolStripMenuItem";
            this.infoOmTigrarToolStripMenuItem.Size = new System.Drawing.Size(293, 38);
            this.infoOmTigrarToolStripMenuItem.Text = "Info om tigrar";
            // 
            // exporteraToolStripMenuItem
            // 
            this.exporteraToolStripMenuItem.Name = "exporteraToolStripMenuItem";
            this.exporteraToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.exporteraToolStripMenuItem.Text = "Exportera";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 809);
            this.Controls.Add(this.btnRemoveMember);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxMembers);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.ListBox listBoxMembers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnRemoveMember;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporteraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoOmTigrarToolStripMenuItem;
    }
}

