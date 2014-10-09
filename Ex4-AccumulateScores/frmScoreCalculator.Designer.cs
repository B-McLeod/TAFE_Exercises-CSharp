namespace Ex4_AccumulateScores
{
	partial class frmScoreCalculator
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
			this.lblScore = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.lblAverage = new System.Windows.Forms.Label();
			this.lblCount = new System.Windows.Forms.Label();
			this.txtScore = new System.Windows.Forms.TextBox();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.txtAverage = new System.Windows.Forms.TextBox();
			this.txtCount = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblScore
			// 
			this.lblScore.AutoSize = true;
			this.lblScore.Location = new System.Drawing.Point(46, 15);
			this.lblScore.Name = "lblScore";
			this.lblScore.Size = new System.Drawing.Size(38, 13);
			this.lblScore.TabIndex = 0;
			this.lblScore.Text = "Score:";
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Location = new System.Drawing.Point(19, 41);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(65, 13);
			this.lblTotal.TabIndex = 1;
			this.lblTotal.Text = "Score Total:";
			// 
			// lblAverage
			// 
			this.lblAverage.AutoSize = true;
			this.lblAverage.Location = new System.Drawing.Point(3, 67);
			this.lblAverage.Name = "lblAverage";
			this.lblAverage.Size = new System.Drawing.Size(81, 13);
			this.lblAverage.TabIndex = 2;
			this.lblAverage.Text = "Score Average:";
			// 
			// lblCount
			// 
			this.lblCount.AutoSize = true;
			this.lblCount.Location = new System.Drawing.Point(15, 93);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new System.Drawing.Size(69, 13);
			this.lblCount.TabIndex = 3;
			this.lblCount.Text = "Score Count:";
			// 
			// txtScore
			// 
			this.txtScore.Location = new System.Drawing.Point(90, 12);
			this.txtScore.Name = "txtScore";
			this.txtScore.Size = new System.Drawing.Size(56, 20);
			this.txtScore.TabIndex = 4;
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(90, 38);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.ReadOnly = true;
			this.txtTotal.Size = new System.Drawing.Size(56, 20);
			this.txtTotal.TabIndex = 5;
			// 
			// txtAverage
			// 
			this.txtAverage.Location = new System.Drawing.Point(90, 64);
			this.txtAverage.Name = "txtAverage";
			this.txtAverage.ReadOnly = true;
			this.txtAverage.Size = new System.Drawing.Size(56, 20);
			this.txtAverage.TabIndex = 6;
			// 
			// txtCount
			// 
			this.txtCount.Location = new System.Drawing.Point(90, 90);
			this.txtCount.Name = "txtCount";
			this.txtCount.ReadOnly = true;
			this.txtCount.Size = new System.Drawing.Size(56, 20);
			this.txtCount.TabIndex = 7;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(153, 9);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 8;
			this.btnAdd.Text = "&Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(71, 116);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 9;
			this.btnClear.Text = "&Clear Scores";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(153, 116);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 10;
			this.btnExit.Text = "E&xit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// frmScoreCalculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(240, 149);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtCount);
			this.Controls.Add(this.txtAverage);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.txtScore);
			this.Controls.Add(this.lblCount);
			this.Controls.Add(this.lblAverage);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.lblScore);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmScoreCalculator";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Score Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblScore;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label lblAverage;
		private System.Windows.Forms.Label lblCount;
		private System.Windows.Forms.TextBox txtScore;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.TextBox txtAverage;
		private System.Windows.Forms.TextBox txtCount;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnExit;
	}
}

