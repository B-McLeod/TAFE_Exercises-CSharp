using System;
using System.Globalization;
using System.Windows.Forms;

namespace Ex13_CalculateReservationTotals
{
	public partial class frmReservationTotals : Form
	{
		private DateTime todaysDate = DateTime.Today;
		private DateTime arrivalDate;
		private DateTime departDate;
		private DateTime min = DateTime.Today;
		private DateTime max = DateTime.Today.AddYears(5);

		public frmReservationTotals()
		{
			InitializeComponent();
			txtArrivalDate.Text = DateTime.Now.ToShortDateString();
			txtDepartureDate.Text = DateTime.Now.AddDays(3).ToShortDateString();
		}

		public bool IsValidData()
		{
			if (IsPresent(txtArrivalDate, "Arrival Date") &&
				IsPresent(txtDepartureDate, "Departure Date") &&
				IsDateTime(txtArrivalDate, "Arrival Date") &&
				IsDateTime(txtDepartureDate, "Departure Date") &&
				IsWithinRange(txtArrivalDate, "Arrival Date", min, max) &&
				IsWithinRange(txtDepartureDate, "Departure Date", min, max))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

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
			String[] dateFormats = { "d/M/yyyy", "d-M-yyyy", "d/MM/yyyy", "d-MM-yyyy", "d/M/yy", "d-M-yy", "d/MM/yy", "d-MM-yy" };
			DateTime dateValue;

			try
			{
				if (DateTime.TryParseExact(textBox.Text, dateFormats,
							CultureInfo.CreateSpecificCulture("en-AU"),
							System.Globalization.DateTimeStyles.None,
							out dateValue))
				{
					return true;
				}
				else
				{
					MessageBox.Show(name + " is not valid.\nPreferred format = 'dd/MM/yyyy'", "Entry Error");
					return false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.GetType().ToString());
				return false;
			}
		}

		public bool IsWithinRange(TextBox textBox, String name,
			DateTime min, DateTime max)
		{
			DateTime dt = DateTime.Parse(textBox.Text);
			if (dt >= min && dt < max)
			{
				return true;
			}
			else
			{
				MessageBox.Show(name + " is not within date range (" + min.ToShortDateString() + " - " + max.ToShortDateString() + ")", "Entry Error");
				return false;
			}
		}

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			if (IsValidData())
			{
				DateTime arrivalDate = DateTime.Parse(txtArrivalDate.Text); ;
				DateTime departDate = DateTime.Parse(txtDepartureDate.Text);

				if (departDate > arrivalDate)
				{
					TimeSpan stayLength = departDate - arrivalDate;
					Double nights = stayLength.Days;

					Double totalPrice = 0;

					var testDate = arrivalDate;
					for (var i = 1; i <= nights; i++)
					{
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
						testDate = arrivalDate.AddDays(i);
					}

					Double avgPrice = totalPrice / nights;

					txtNights.Text = nights.ToString();
					txtTotalPrice.Text = totalPrice.ToString("C");
					txtAvgPrice.Text = avgPrice.ToString("C");
				}
				else
				{
					MessageBox.Show("Departure date must be greater than the arrival date!", "Entry Error");
				}
			}
		}
	}
}