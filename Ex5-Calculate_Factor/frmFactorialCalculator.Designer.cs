﻿namespace Ex5_Calculate_Factor
{
	partial class frmFactorialCalculator
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
			this.lblNumber = new System.Windows.Forms.Label();
			this.txtNumber = new System.Windows.Forms.TextBox();
			this.lblFactorial = new System.Windows.Forms.Label();
			this.txtFactorial = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(115, 64);
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
			this.btnExit.Location = new System.Drawing.Point(196, 64);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 1;
			this.btnExit.Text = "E&xit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// lblNumber
			// 
			this.lblNumber.AutoSize = true;
			this.lblNumber.Location = new System.Drawing.Point(21, 15);
			this.lblNumber.Name = "lblNumber";
			this.lblNumber.Size = new System.Drawing.Size(47, 13);
			this.lblNumber.TabIndex = 2;
			this.lblNumber.Text = "Number:";
			// 
			// txtNumber
			// 
			this.txtNumber.Location = new System.Drawing.Point(74, 12);
			this.txtNumber.Name = "txtNumber";
			this.txtNumber.Size = new System.Drawing.Size(109, 20);
			this.txtNumber.TabIndex = 3;
			// 
			// lblFactorial
			// 
			this.lblFactorial.AutoSize = true;
			this.lblFactorial.Location = new System.Drawing.Point(18, 41);
			this.lblFactorial.Name = "lblFactorial";
			this.lblFactorial.Size = new System.Drawing.Size(50, 13);
			this.lblFactorial.TabIndex = 4;
			this.lblFactorial.Text = "Factorial:";
			// 
			// txtFactorial
			// 
			this.txtFactorial.Location = new System.Drawing.Point(74, 38);
			this.txtFactorial.Name = "txtFactorial";
			this.txtFactorial.ReadOnly = true;
			this.txtFactorial.Size = new System.Drawing.Size(197, 20);
			this.txtFactorial.TabIndex = 5;
			// 
			// frmFactorialCalculator
			// 
			this.AcceptButton = this.btnCalculate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(283, 96);
			this.Controls.Add(this.txtFactorial);
			this.Controls.Add(this.lblFactorial);
			this.Controls.Add(this.txtNumber);
			this.Controls.Add(this.lblNumber);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnCalculate);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmFactorialCalculator";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Factorial Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label lblNumber;
		private System.Windows.Forms.TextBox txtNumber;
		private System.Windows.Forms.Label lblFactorial;
		private System.Windows.Forms.TextBox txtFactorial;
	}
}

