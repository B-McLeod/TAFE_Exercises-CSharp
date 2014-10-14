using System;
using System.Windows.Forms;

/*
 * 
 * Exercise 8 - Add a method and an event handler to the income tax calculator
 *
 */

namespace Ex6_TaxCalculator
{
	public partial class frmTaxCalculator : Form
	{
		// Tax Brackets
		private Decimal tax0pct = 10;

		private Decimal tax1pct = 15;
		private Decimal tax1pay = 870;
		private Decimal tax1low = 8701;
		private Decimal tax1high = 35350;

		private Decimal tax2pct = 25;
		private Decimal tax2pay = 4867;
		private Decimal tax2low = 35351;
		private Decimal tax2high = 85650;

		private Decimal tax3pct = 28;
		private Decimal tax3pay = 17442;
		private Decimal tax3low = 85651;
		private Decimal tax3high = 178650;

		private Decimal tax4pct = 33;
		private Decimal tax4pay = 43482;
		private Decimal tax4low = 178651;
		private Decimal tax4high = 388350;

		private Decimal tax5pct = 35;
		private Decimal tax5pay = 112683;
		private Decimal tax5low = 388351;

		public frmTaxCalculator()
		{
			InitializeComponent();
		}

		// Exit Button
		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Calculate Button
		private void btnCalculate_Click(object sender, EventArgs e)
		{
			Decimal income = Convert.ToDecimal(txtIncome.Text);
			Decimal owed = 0;

			owed = calculateTax(income);

			txtOwed.Text = owed.ToString("C");
		}

		private Decimal calculateTax(Decimal income)
		{
			Decimal taxOwed = 0;

			if (income >= tax5low)
			{
				taxOwed = income - tax5low;
				taxOwed = taxOwed * (tax5pct / 100);
				taxOwed += tax5pay;
			}
			else if (income >= tax4low && income <= tax4high)
			{
				taxOwed = income - tax4low;
				taxOwed = taxOwed * (tax4pct / 100);
				taxOwed += tax4pay;
			}
			else if (income >= tax3low && income <= tax3high)
			{
				taxOwed = income - tax3low;
				taxOwed = taxOwed * (tax3pct / 100);
				taxOwed += tax3pay;
			}
			else if (income >= tax2low && income <= tax2high)
			{
				taxOwed = income - tax2low;
				taxOwed = taxOwed * (tax2pct / 100);
				taxOwed += tax2pay;
			}
			else if (income >= tax1low && income <= tax1high)
			{
				taxOwed = income - tax1low;
				taxOwed = taxOwed * (tax1pct / 100);
				taxOwed += tax1pay;
			}
			else
			{
				taxOwed = income * (tax0pct / 100);
			}

			return taxOwed;
		}

		private void txtIncome_TextChanged(object sender, EventArgs e)
		{
			txtOwed.Text = "";
		}
	}
}