using System;
using System.Windows.Forms;

namespace Ex7_SimpleCalculator
{
	public partial class frmCalculator : Form
	{
		public frmCalculator()
		{
			InitializeComponent();
		}

		/* Calculate Method */

		private decimal calculate(Decimal a, String Operator, Decimal b)
		{
			Decimal result;

			switch (Operator[0])
			{
				case '+':
					result = a + b;
					return result;

				case '-':
					result = a - b;
					return result;

				case '*':
					result = a * b;
					return result;

				case '/':
					result = a / b;
					return result;

				default:
					MessageBox.Show("Check your calculation and try again.", "Calculation formatting error");
					return result = 0;
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			try
			{
				txtResult.TextAlign = HorizontalAlignment.Left;
				txtResult.Text = calculate(
				Decimal.Parse(txtOp1.Text),
				txtOperator.Text,
				Decimal.Parse(txtOp2.Text)).ToString("n4");
			}
			catch (DivideByZeroException)
			{
				txtResult.TextAlign = HorizontalAlignment.Center;
				txtResult.Text = "Cannot divide by zero.";
			}
			catch (FormatException)
			{
				MessageBox.Show("Check your calculation and try again.", "Calculation formatting error");
			}
			catch (OverflowException ex)
			{
				MessageBox.Show(ex.Message);
			}

			txtOp1.Focus();
		}

		/* Clear Result field upon text change */

		private void txtOp1_TextChanged(object sender, EventArgs e)
		{
			txtResult.Clear();
		}

		private void txtOperator_TextChanged(object sender, EventArgs e)
		{
			txtResult.Clear();
		}

		private void txtOp2_TextChanged(object sender, EventArgs e)
		{
			txtResult.Clear();
		}
	}
}