using System;
using System.Windows.Forms;

namespace Ex5_Calculate_Factor
{
	public partial class frmFactorialCalculator : Form
	{
		public frmFactorialCalculator()
		{
			InitializeComponent();
		}

		// Exit Button
		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Calculate Button (Includes number formatting)
		private void btnCalculate_Click(object sender, EventArgs e)
		{
			int num = Convert.ToInt32(txtNumber.Text);
			long factor = GetFactor(num);

			txtFactorial.Text = String.Format("{0:n0}", factor);
		}

		// Recursion method to get factorial number.
		private static long GetFactor(int x)
		{
			if (x == 0)
			{
				return 1;
			}
			return x * GetFactor(x - 1);
		}
	}
}