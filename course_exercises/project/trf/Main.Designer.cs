namespace trf
{
    partial class Main
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
            "None"});
            this.listBoxMembers.Location = new System.Drawing.Point(48, 35);
            this.listBoxMembers.Name = "listBoxMembers";
            this.listBoxMembers.Size = new System.Drawing.Size(285, 404);
            this.listBoxMembers.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 809);
            this.Controls.Add(this.listBoxMembers);
            this.Controls.Add(this.btnAddMember);
            this.Name = "Main";
            this.Text = "TRF - Tigerälskarnas Riksförbund";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.ListBox listBoxMembers;
    }
}

