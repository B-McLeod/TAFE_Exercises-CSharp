using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex13_CalculateReservationTotals
{
	public partial class frmReservationTotals : Form
    {
		private DateTime todaysDate = DateTime.Today;
		private DateTime arrivalDate;
		private DateTime departDate;		

        public frmReservationTotals()
        {
            InitializeComponent();
			txtArrivalDate.Text = todaysDate.ToShortDateString();
			departDate = todaysDate.AddDays(3);
			txtDepartureDate.Text = departDate.ToShortDateString();
        }

        //public bool IsValidData()
        //{

        //}

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

		public bool IsDateTime(TextBox textBox, String name)
		{
			try
			{
				DateTime date = DateTime.Parse(textBox.Text);

				if (date.ToString() == name)
				{
					return true;
				}
				else
				{
					MessageBox.Show(name + " is not a valid date.", "Entry Error");
					return false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.GetType().ToString());
				return false;
			}			
		}

        //public bool IsWithinRange(TextBox textBox, string name,
        //    DateTime min, DateTime max)
        //{

        //}

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			IsDateTime(txtArrivalDate, txtArrivalDate.Text);

			arrivalDate = DateTime.Parse(txtArrivalDate.Text);
			departDate = DateTime.Parse(txtDepartureDate.Text);

			TimeSpan stayLength = departDate - arrivalDate;
			Double nights = stayLength.Days;

			Double totalPrice = 0;

			for (var i = 1; i <= nights; i++)
			{
				var testDate = arrivalDate.AddDays(i);
				switch (testDate.DayOfWeek)
				{
					case DayOfWeek.Friday:
						totalPrice += 150;
						break;
					case DayOfWeek.Saturday:
						totalPrice += 150;
						break;
					default:
						totalPrice += 120;
						break;
				}
			}

			Double avgPrice = totalPrice / nights;

			txtNights.Text = nights.ToString();
			txtTotalPrice.Text = totalPrice.ToString("C");
			txtAvgPrice.Text = avgPrice.ToString("C");
		}
    }
}