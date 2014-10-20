using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScoreCalculator
{
	public partial class frmScoreCalc : Form
	{
		public frmScoreCalc()
		{
			InitializeComponent();
		}

		private int total = 0;
		private List<int> scoresList = new List<int>();

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			try
			{
				int score = Convert.ToInt32(txtScore.Text);
				total += score;

				scoresList.Add(score);
				int count = scoresList.Count;

				int average = total / count;
				txtScoreTotal.Text = total.ToString();
				txtScoreCount.Text = count.ToString();
				txtAverage.Text = average.ToString();
				txtScore.Clear();
				txtScore.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.GetType().ToString());
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			total = 0;
			scoresList.Clear();

			txtScore.Text = "";
			txtScoreTotal.Text = "";
			txtScoreCount.Text = "";
			txtAverage.Text = "";
			txtScore.Focus();
		}

		private void btnDisplay_Click(object sender, EventArgs e)
		{
			String sortedList = null;

			scoresList.Sort();
			foreach (int x in scoresList)
			{
				sortedList += x.ToString() + "\n";
			}

			MessageBox.Show(sortedList, "Sorted scores");
		}
	}
}