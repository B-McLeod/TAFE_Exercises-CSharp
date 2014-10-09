namespace Ex1_Design_a_simple_form
{
	partial class frmCalculateLetterGrade
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
			this.lblNumberGrade = new System.Windows.Forms.Label();
			this.txtNumberGrade = new System.Windows.Forms.TextBox();
			this.txtLetterGrade = new System.Windows.Forms.TextBox();
			this.lblLetterGrade = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnCalculate
			// 
			this.btnCalculate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCalculate.Location = new System.Drawing.Point(82, 69);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(75, 23);
			this.btnCalculate.TabIndex = 2;
			this.btnCalculate.Text = "Calculate";
			this.btnCalculate.UseVisualStyleBackColor = true;
			// 
			// btnExit
			// 
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Location = new System.Drawing.Point(163, 69);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "E&xit";
			this.btnExit.UseVisualStyleBackColor = true;
			// 
			// lblNumberGrade
			// 
			this.lblNumberGrade.AutoSize = true;
			this.lblNumberGrade.Location = new System.Drawing.Point(12, 9);
			this.lblNumberGrade.Name = "lblNumberGrade";
			this.lblNumberGrade.Size = new System.Drawing.Size(77, 13);
			this.lblNumberGrade.TabIndex = 1;
			this.lblNumberGrade.Text = "&Number grade:";
			// 
			// txtNumberGrade
			// 
			this.txtNumberGrade.Location = new System.Drawing.Point(95, 6);
			this.txtNumberGrade.Name = "txtNumberGrade";
			this.txtNumberGrade.Size = new System.Drawing.Size(143, 20);
			this.txtNumberGrade.TabIndex = 0;
			// 
			// txtLetterGrade
			// 
			this.txtLetterGrade.Location = new System.Drawing.Point(95, 32);
			this.txtLetterGrade.Name = "txtLetterGrade";
			this.txtLetterGrade.ReadOnly = true;
			this.txtLetterGrade.Size = new System.Drawing.Size(143, 20);
			this.txtLetterGrade.TabIndex = 0;
			this.txtLetterGrade.TabStop = false;
			// 
			// lblLetterGrade
			// 
			this.lblLetterGrade.AutoSize = true;
			this.lblLetterGrade.Location = new System.Drawing.Point(22, 35);
			this.lblLetterGrade.Name = "lblLetterGrade";
			this.lblLetterGrade.Size = new System.Drawing.Size(67, 13);
			this.lblLetterGrade.TabIndex = 0;
			this.lblLetterGrade.Text = "Letter grade:";
			// 
			// frmCalculateLetterGrade
			// 
			this.AcceptButton = this.btnCalculate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(250, 104);
			this.Controls.Add(this.txtLetterGrade);
			this.Controls.Add(this.lblLetterGrade);
			this.Controls.Add(this.txtNumberGrade);
			this.Controls.Add(this.lblNumberGrade);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnCalculate);
			this.Name = "frmCalculateLetterGrade";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calculate Letter Grade";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label lblNumberGrade;
		private System.Windows.Forms.TextBox txtNumberGrade;
		private System.Windows.Forms.TextBox txtLetterGrade;
		private System.Windows.Forms.Label lblLetterGrade;
	}
}

