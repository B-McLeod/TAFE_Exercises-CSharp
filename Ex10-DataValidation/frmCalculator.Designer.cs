namespace Ex7_SimpleCalculator
{
	partial class frmCalculator
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
			this.lblOperand1 = new System.Windows.Forms.Label();
			this.lblOperator = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblResult = new System.Windows.Forms.Label();
			this.txtOp1 = new System.Windows.Forms.TextBox();
			this.txtOperator = new System.Windows.Forms.TextBox();
			this.txtOp2 = new System.Windows.Forms.TextBox();
			this.txtResult = new System.Windows.Forms.TextBox();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblOperand1
			// 
			this.lblOperand1.AutoSize = true;
			this.lblOperand1.Location = new System.Drawing.Point(12, 45);
			this.lblOperand1.Name = "lblOperand1";
			this.lblOperand1.Size = new System.Drawing.Size(60, 13);
			this.lblOperand1.TabIndex = 0;
			this.lblOperand1.Text = "Operand 1:";
			// 
			// lblOperator
			// 
			this.lblOperator.AutoSize = true;
			this.lblOperator.Location = new System.Drawing.Point(21, 71);
			this.lblOperator.Name = "lblOperator";
			this.lblOperator.Size = new System.Drawing.Size(51, 13);
			this.lblOperator.TabIndex = 1;
			this.lblOperator.Text = "Operator:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Operand 2:";
			// 
			// lblResult
			// 
			this.lblResult.AutoSize = true;
			this.lblResult.Location = new System.Drawing.Point(12, 9);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(40, 13);
			this.lblResult.TabIndex = 3;
			this.lblResult.Text = "Result:";
			// 
			// txtOp1
			// 
			this.txtOp1.Location = new System.Drawing.Point(78, 42);
			this.txtOp1.Name = "txtOp1";
			this.txtOp1.Size = new System.Drawing.Size(100, 20);
			this.txtOp1.TabIndex = 4;
			this.txtOp1.TextChanged += new System.EventHandler(this.txtOp1_TextChanged);
			// 
			// txtOperator
			// 
			this.txtOperator.Location = new System.Drawing.Point(78, 68);
			this.txtOperator.MaxLength = 1;
			this.txtOperator.Name = "txtOperator";
			this.txtOperator.Size = new System.Drawing.Size(43, 20);
			this.txtOperator.TabIndex = 5;
			this.txtOperator.TextChanged += new System.EventHandler(this.txtOperator_TextChanged);
			this.txtOperator.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOperator_KeyDown);
			// 
			// txtOp2
			// 
			this.txtOp2.Location = new System.Drawing.Point(78, 94);
			this.txtOp2.Name = "txtOp2";
			this.txtOp2.Size = new System.Drawing.Size(100, 20);
			this.txtOp2.TabIndex = 6;
			this.txtOp2.TextChanged += new System.EventHandler(this.txtOp2_TextChanged);
			// 
			// txtResult
			// 
			this.txtResult.Location = new System.Drawing.Point(58, 6);
			this.txtResult.Name = "txtResult";
			this.txtResult.ReadOnly = true;
			this.txtResult.Size = new System.Drawing.Size(187, 20);
			this.txtResult.TabIndex = 7;
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(57, 143);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(75, 23);
			this.btnCalculate.TabIndex = 8;
			this.btnCalculate.Text = "&Calculate";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// btnExit
			// 
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Location = new System.Drawing.Point(138, 143);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 9;
			this.btnExit.Text = "E&xit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// frmCalculator
			// 
			this.AcceptButton = this.btnCalculate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(276, 178);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.txtResult);
			this.Controls.Add(this.txtOp2);
			this.Controls.Add(this.txtOperator);
			this.Controls.Add(this.txtOp1);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblOperator);
			this.Controls.Add(this.lblOperand1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCalculator";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Simple Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblOperand1;
		private System.Windows.Forms.Label lblOperator;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblResult;
		private System.Windows.Forms.TextBox txtOp1;
		private System.Windows.Forms.TextBox txtOperator;
		private System.Windows.Forms.TextBox txtOp2;
		private System.Windows.Forms.TextBox txtResult;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.Button btnExit;
	}
}

