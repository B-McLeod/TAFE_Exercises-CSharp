using System;
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
		private int count = 0;
		private int[] scoresArray = new int[20];

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

				scoresArray[count] = score;
				count += 1;

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
			count = 0;

			Array.Clear(scoresArray, 0, scoresArray.Length);

			txtScore.Text = "";
			txtScoreTotal.Text = "";
			txtScoreCount.Text = "";
			txtAverage.Text = "";
			txtScore.Focus();
		}

		private void btnDisplay_Click(object sender, EventArgs e)
		{
			int[] listArray = new int[count];
			String scoreList = null;

			for (int i = 0; i < count; i++)
			{
				listArray[i] = scoresArray[i];
			}

			Array.Sort(listArray);

			foreach (int x in listArray)
			{
				scoreList += x.ToString() + "\n";
			}

			MessageBox.Show(scoreList, "Sorted scores");
		}
	}
}