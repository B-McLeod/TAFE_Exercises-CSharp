namespace Ex6_TaxCalculator
{
	partial class frmTaxCalculator
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
			this.btnCalculate = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.txtOwed = new System.Windows.Forms.TextBox();
			this.txtIncome = new System.Windows.Forms.TextBox();
			this.lblTaxableIncome = new System.Windows.Forms.Label();
			this.lblTaxOwed = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(73, 63);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(75, 23);
			this.btnCalculate.TabIndex = 0;
			this.btnCalculate.Text = "&Calculate";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// btnExit
			// 
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Location = new System.Drawing.Point(154, 63);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 1;
			this.btnExit.Text = "E&xit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// txtOwed
			// 
			this.txtOwed.Location = new System.Drawing.Point(115, 37);
			this.txtOwed.Name = "txtOwed";
			this.txtOwed.ReadOnly = true;
			this.txtOwed.Size = new System.Drawing.Size(114, 20);
			this.txtOwed.TabIndex = 2;
			// 
			// txtIncome
			// 
			this.txtIncome.Location = new System.Drawing.Point(115, 11);
			this.txtIncome.Name = "txtIncome";
			this.txtIncome.Size = new System.Drawing.Size(114, 20);
			this.txtIncome.TabIndex = 3;
			this.txtIncome.TextChanged += new System.EventHandler(this.txtIncome_TextChanged);
			// 
			// lblTaxableIncome
			// 
			this.lblTaxableIncome.AutoSize = true;
			this.lblTaxableIncome.Location = new System.Drawing.Point(23, 14);
			this.lblTaxableIncome.Name = "lblTaxableIncome";
			this.lblTaxableIncome.Size = new System.Drawing.Size(86, 13);
			this.lblTaxableIncome.TabIndex = 4;
			this.lblTaxableIncome.Text = "Taxable Income:";
			// 
			// lblTaxOwed
			// 
			this.lblTaxOwed.AutoSize = true;
			this.lblTaxOwed.Location = new System.Drawing.Point(12, 40);
			this.lblTaxOwed.Name = "lblTaxOwed";
			this.lblTaxOwed.Size = new System.Drawing.Size(97, 13);
			this.lblTaxOwed.TabIndex = 5;
			this.lblTaxOwed.Text = "Income Tax Owed:";
			// 
			// frmTaxCalculator
			// 
			this.AcceptButton = this.btnCalculate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(241, 95);
			this.Controls.Add(this.lblTaxOwed);
			this.Controls.Add(this.lblTaxableIncome);
			this.Controls.Add(this.txtIncome);
			this.Controls.Add(this.txtOwed);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnCalculate);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmTaxCalculator";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Income Tax Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.TextBox txtOwed;
		private System.Windows.Forms.TextBox txtIncome;
		private System.Windows.Forms.Label lblTaxableIncome;
		private System.Windows.Forms.Label lblTaxOwed;
	}
}

