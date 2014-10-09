using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4_AccumulateScores
{
	public partial class frmScoreCalculator : Form
	{
		Decimal score;
		Decimal total;
		Decimal average;
		Decimal count;
		List<Decimal> scores = new List<Decimal>();

		public frmScoreCalculator()
		{
			InitializeComponent();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			score = Convert.ToDecimal(txtScore.Text);
			scores.Add(score);

			updateForm();
		}

		private void updateForm()
		{
			count = scores.Count();
			txtCount.Text = count.ToString();
			
			// Get Total
			total += score;
			txtTotal.Text = total.ToString();

			// Get Average
			average = total / count;
			txtAverage.Text = average.ToString();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			// Reset all variables back to 0.
			score = 0;
			total = 0;
			average = 0;
			count = 0;
			scores.Clear();

			// Clear text boxes.
			txtScore.Text = "";
			txtTotal.Text = "";
			txtAverage.Text = "";
			txtCount.Text = "";

			// Refocus on scores textbox.
			txtScore.Focus();
		}
	}
}
