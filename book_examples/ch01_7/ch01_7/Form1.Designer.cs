namespace ch01_7
{
    partial class TaxCalc
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
            this.tbCapital = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbInterestRate = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownYear)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capital";
            // 
            // tbCapital
            // 
            this.tbCapital.Location = new System.Drawing.Point(90, 27);
            this.tbCapital.Name = "tbCapital";
            this.tbCapital.Size = new System.Drawing.Size(160, 20);
            this.tbCapital.TabIndex = 1;
            this.tbCapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Interest Rate";
            // 
            // tbInterestRate
            // 
            this.tbInterestRate.Location = new System.Drawing.Point(90, 77);
            this.tbInterestRate.Name = "tbInterestRate";
            this.tbInterestRate.Size = new System.Drawing.Size(160, 20);
            this.tbInterestRate.TabIndex = 3;
            this.tbInterestRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(275, 25);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(90, 25);
            this.btnCompute.TabIndex = 4;
            this.btnCompute.Text = "Calculate";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Years";
            // 
            // numUpDownYear
            // 
            this.numUpDownYear.Location = new System.Drawing.Point(90, 127);
            this.numUpDownYear.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUpDownYear.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownYear.Name = "numUpDownYear";
            this.numUpDownYear.ReadOnly = true;
            this.numUpDownYear.Size = new System.Drawing.Size(160, 20);
            this.numUpDownYear.TabIndex = 6;
            this.numUpDownYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUpDownYear.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yearly Account Balance";
            // 
            // tbDisplay
            // 
            this.tbDisplay.Location = new System.Drawing.Point(20, 200);
            this.tbDisplay.Multiline = true;
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.ReadOnly = true;
            this.tbDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDisplay.Size = new System.Drawing.Size(350, 150);
            this.tbDisplay.TabIndex = 8;
            // 
            // TaxCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numUpDownYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.tbInterestRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCapital);
            this.Controls.Add(this.label1);
            this.Name = "TaxCalc";
            this.Text = "InterestCalculator";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCapital;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbInterestRate;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numUpDownYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDisplay;
    }
}

