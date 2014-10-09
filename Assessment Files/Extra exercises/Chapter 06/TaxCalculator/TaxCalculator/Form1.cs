using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal income = Convert.ToDecimal(txtIncome.Text);

            decimal tax = 0m;
            if (income <= 8700)
                tax = (int)(income * .10m);
            else if (income > 8700 && income <= 35350)
                tax = 870 + (int)((income - 8700) * .15m);
            else if (income > 35350 && income <= 85650)
                tax = 4867 + (int)((income - 35350) * .25m);
            else if (income > 85650 && income <= 178650)
                tax = 17442 + (int)((income - 85650) * .28m);
            else if (income > 178650 && income <= 388350)
                tax = 43482 + (int)((income - 178650) * .33m);
            else if (income > 388350)
                tax = 112683 + (int)((income - 388350) * .35m);

            txtTax.Text = tax.ToString();
        }
    }
}
