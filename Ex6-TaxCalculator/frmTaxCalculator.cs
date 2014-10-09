using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex6_TaxCalculator
{
	public partial class frmTaxCalculator : Form
	{
		// Tax Brackets
		Decimal tax0pct = 10;
		Decimal tax0high = 8700;

		Decimal tax1pct = 15;
		Decimal tax1pay = 870;
		Decimal tax1low = 8701;
		Decimal tax1high = 35350;

		Decimal tax2pct = 25;
		Decimal tax2pay = 4867;
		Decimal tax2low = 35351;
		Decimal tax2high = 85650;

		Decimal tax3pct = 28;
		Decimal tax3pay = 17442;
		Decimal tax3low = 85651;
		Decimal tax3high = 178650;

		Decimal tax4pct = 33;
		Decimal tax4pay = 43482;
		Decimal tax4low = 178651;
		Decimal tax4high = 388350;

		Decimal tax5pct = 35;
		Decimal tax5pay = 112683;
		Decimal tax5low = 388351;

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
	}
}
