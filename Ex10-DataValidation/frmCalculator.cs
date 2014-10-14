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

		/* Exit Button */

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		/* Calculate Button */

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			if (IsValidData(txtOp1, txtOp2, txtOperator))
			{
				try
				{
					txtResult.TextAlign = HorizontalAlignment.Left;
					txtResult.Text = calculate(
					Decimal.Parse(txtOp1.Text),
					txtOperator.Text,
					Decimal.Parse(txtOp2.Text)).ToString("n4");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, ex.GetType().ToString());
				}
				txtOp1.Focus();
			}
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

		private bool IsPresent(TextBox Op1, TextBox Op2, TextBox Operator)
		{
			if (Op1.Text == "")
			{
				MessageBox.Show("Value missing in Operator 1!", "Calculation Error");
				Op1.Focus();
				return false;
			}
			else if (Op2.Text == "")
			{
				MessageBox.Show("Value missing in Operator 2!", "Calculation Error");
				Op2.Focus();
				return false;
			}
			else if (Operator.Text == "")
			{
				MessageBox.Show("Value missing in Operator 1!", "Calculation Error");
				Operator.Focus();
				return false;
			}
			return true;
		}

		private bool IsDecimal(TextBox textbox, String name)
		{
			Decimal number = 0m;
			if (Decimal.TryParse(textbox.Text, out number))
			{
				return true;
			}
			else
			{
				MessageBox.Show(name + " must be a decimal value.", "Entry Error");
				textbox.Focus();
				return false;
			}
		}

		private bool IsWithinRange(TextBox textbox, String name, Decimal min, Decimal max)
		{
			decimal number = Convert.ToDecimal(textbox.Text);
			if (number < min || number > max)
			{
				MessageBox.Show(name + " must be between " + min.ToString() + " and " + max.ToString() + ".", "Entry Error");
				textbox.Focus();
				return false;
			}
			return true;
		}

		private bool IsOperator(TextBox textbox)
		{
			String Op = textbox.Text;

			switch (Op[0])
			{
				case '+':
					return true;

				case '-':
					return true;

				case '*':
					return true;

				case '/':
					return true;

				default:
					MessageBox.Show("Check the value of the operator.", "Entry Error");
					return false;
			}
		}

		private bool IsValidData(TextBox num1, TextBox num2, TextBox op)
		{
			String strNum1 = "Operator 1";
			String strNum2 = "Operator 2";
			Decimal min = 0;
			Decimal max = 1000000;

			if (IsDecimal(num1, strNum1) &&
				IsDecimal(num2, strNum2) &&
				IsWithinRange(num1, strNum1, min, max) &&
				IsWithinRange(num2, strNum2, min, max) &&
				IsOperator(op))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private void txtOperator_KeyDown(object sender, KeyEventArgs e)
		{
			txtOperator.Clear();
		}
	}
}