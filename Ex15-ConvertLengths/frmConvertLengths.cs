using System;
using System.Windows.Forms;

namespace Ex15_ConvertLengths
{
	public partial class frmConvertLengths : Form
	{
		public frmConvertLengths()
		{
			InitializeComponent();

			for (int i = 0; i < conversionTable.GetLength(0); i++)
			{
				cboConversions.Items.Add(conversionTable[i, 0]);
			}

			cboConversions.SelectedIndex = 0;
		}

		// Label name, Text box identifiers 2, Multiplier
		private String[,] conversionTable = {
			{"Miles to kilometers", "Miles", "Kilometers", "1.6093"},
			{"Kilometers to miles", "Kilometers", "Miles", "0.6214"},
			{"Feet to meters", "Feet", "Meters", "0.3048"},
			{"Meters to feet", "Meters", "Feet", "3.2808"},
			{"Inches to centimeters", "Inches", "Centimeters", "2.54"},
			{"Centimeters to inches", "Centimeters", "Inches", "0.3937"}
		};

		public bool IsPresent(TextBox textBox, string name)
		{
			if (textBox.Text == "")
			{
				MessageBox.Show(name + " is a required field.", "Entry Error");
				textBox.Focus();
				return false;
			}
			return true;
		}

		public bool IsDecimal(TextBox textBox, string name)
		{
			try
			{
				Convert.ToDecimal(textBox.Text);
				return true;
			}
			catch (FormatException)
			{
				MessageBox.Show(name + " must be a decimal number.", "Entry Error");
				textBox.Focus();
				return false;
			}
		}

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void changeConversion(object sender, EventArgs e)
		{
			lblFromLength.Text = conversionTable[cboConversions.SelectedIndex, 1];
			lblToLength.Text = conversionTable[cboConversions.SelectedIndex, 2];
			txtLength.Clear();
			lblCalculatedLength.Text = "";
			txtLength.Focus();
		}

		private void calculateLength(object sender, EventArgs e)
		{
			decimal length;
			if (decimal.TryParse(txtLength.Text, out length))
			{
				length = length * decimal.Parse(conversionTable[cboConversions.SelectedIndex, 3]);
				lblCalculatedLength.Text = length.ToString();
			}
			else
			{
				MessageBox.Show("Enter a valid number.", "Entry Error");
			}
		}
	}
}