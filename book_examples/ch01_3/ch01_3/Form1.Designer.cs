namespace ch01_3
{
    partial class Bartender
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
            this.grbDrink = new System.Windows.Forms.GroupBox();
            this.chkVodka = new System.Windows.Forms.CheckBox();
            this.chkGin = new System.Windows.Forms.CheckBox();
            this.grbGlass = new System.Windows.Forms.GroupBox();
            this.optShotGlass = new System.Windows.Forms.RadioButton();
            this.optCocktailGlass = new System.Windows.Forms.RadioButton();
            this.optVineGlass = new System.Windows.Forms.RadioButton();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnServ = new System.Windows.Forms.Button();
            this.grbDrink.SuspendLayout();
            this.grbGlass.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDrink
            // 
            this.grbDrink.Controls.Add(this.chkVodka);
            this.grbDrink.Controls.Add(this.chkGin);
            this.grbDrink.Location = new System.Drawing.Point(20, 25);
            this.grbDrink.Name = "grbDrink";
            this.grbDrink.Size = new System.Drawing.Size(150, 100);
            this.grbDrink.TabIndex = 0;
            this.grbDrink.TabStop = false;
            this.grbDrink.Text = "Drink";
            // 
            // chkVodka
            // 
            this.chkVodka.AutoSize = true;
            this.chkVodka.Location = new System.Drawing.Point(15, 30);
            this.chkVodka.Name = "chkVodka";
            this.chkVodka.Size = new System.Drawing.Size(57, 17);
            this.chkVodka.TabIndex = 1;
            this.chkVodka.Text = "Vodka";
            this.chkVodka.UseVisualStyleBackColor = true;
            // 
            // chkGin
            // 
            this.chkGin.AutoSize = true;
            this.chkGin.Location = new System.Drawing.Point(15, 60);
            this.chkGin.Name = "chkGin";
            this.chkGin.Size = new System.Drawing.Size(42, 17);
            this.chkGin.TabIndex = 2;
            this.chkGin.Text = "Gin";
            this.chkGin.UseVisualStyleBackColor = true;
            // 
            // grbGlass
            // 
            this.grbGlass.Controls.Add(this.optVineGlass);
            this.grbGlass.Controls.Add(this.optCocktailGlass);
            this.grbGlass.Controls.Add(this.optShotGlass);
            this.grbGlass.Location = new System.Drawing.Point(200, 25);
            this.grbGlass.Name = "grbGlass";
            this.grbGlass.Size = new System.Drawing.Size(200, 140);
            this.grbGlass.TabIndex = 3;
            this.grbGlass.TabStop = false;
            this.grbGlass.Text = "Choose Glass";
            // 
            // optShotGlass
            // 
            this.optShotGlass.AutoSize = true;
            this.optShotGlass.Location = new System.Drawing.Point(15, 30);
            this.optShotGlass.Name = "optShotGlass";
            this.optShotGlass.Size = new System.Drawing.Size(76, 17);
            this.optShotGlass.TabIndex = 4;
            this.optShotGlass.TabStop = true;
            this.optShotGlass.Text = "Shot Glass";
            this.optShotGlass.UseVisualStyleBackColor = true;
            // 
            // optCocktailGlass
            // 
            this.optCocktailGlass.AutoSize = true;
            this.optCocktailGlass.Location = new System.Drawing.Point(15, 60);
            this.optCocktailGlass.Name = "optCocktailGlass";
            this.optCocktailGlass.Size = new System.Drawing.Size(92, 17);
            this.optCocktailGlass.TabIndex = 5;
            this.optCocktailGlass.TabStop = true;
            this.optCocktailGlass.Text = "Cocktail Glass";
            this.optCocktailGlass.UseVisualStyleBackColor = true;
            // 
            // optVineGlass
            // 
            this.optVineGlass.AutoSize = true;
            this.optVineGlass.Location = new System.Drawing.Point(15, 90);
            this.optVineGlass.Name = "optVineGlass";
            this.optVineGlass.Size = new System.Drawing.Size(79, 17);
            this.optVineGlass.TabIndex = 6;
            this.optVineGlass.TabStop = true;
            this.optVineGlass.Text = "Wine Glass";
            this.optVineGlass.UseVisualStyleBackColor = true;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(460, 135);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 45);
            this.btnFinish.TabIndex = 4;
            this.btnFinish.Text = "Exit";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnServ
            // 
            this.btnServ.Location = new System.Drawing.Point(440, 30);
            this.btnServ.Name = "btnServ";
            this.btnServ.Size = new System.Drawing.Size(120, 70);
            this.btnServ.TabIndex = 5;
            this.btnServ.Text = "Serv";
            this.btnServ.UseVisualStyleBackColor = true;
            this.btnServ.Click += new System.EventHandler(this.btnServ_Click);
            // 
            // Bartender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 211);
            this.Controls.Add(this.btnServ);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.grbGlass);
            this.Controls.Add(this.grbDrink);
            this.Name = "Bartender";
            this.Text = "Bartender";
            this.grbDrink.ResumeLayout(false);
            this.grbDrink.PerformLayout();
            this.grbGlass.ResumeLayout(false);
            this.grbGlass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDrink;
        private System.Windows.Forms.CheckBox chkVodka;
        private System.Windows.Forms.CheckBox chkGin;
        private System.Windows.Forms.GroupBox grbGlass;
        private System.Windows.Forms.RadioButton optVineGlass;
        private System.Windows.Forms.RadioButton optCocktailGlass;
        private System.Windows.Forms.RadioButton optShotGlass;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnServ;
    }
}

