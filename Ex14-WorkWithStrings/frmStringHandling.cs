using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex14_WorkWithStrings
{
	public partial class frmStringHandling : Form
	{
		public frmStringHandling()
		{
			InitializeComponent();

			// Set default values to speed up testing
			txtEmail.Text = "blake@testemail.com";
			txtCity.Text = "Gold Coast";
			txtState.Text = "QLD";
			txtZipCode.Text = "4213";
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void parseEmail(object sender, EventArgs e)
		{
			if(txtEmail.Text.Contains("@"))
			{
				String[] email = txtEmail.Text.Trim().Split('@');
				String username = email[0];
				String domain = email[1];

				MessageBox.Show("Username: " + username + "\n" +
								"Domain: " + domain, "Parsed Email");
			}
			else
			{
				MessageBox.Show("Enter a valid email address.");
			}
		}

		private void formatAddress(object sender, EventArgs e)
		{
			String city = txtCity.Text.Trim();
			String state = txtState.Text.Trim();
			String zip = txtZipCode.Text.Trim();

			String address = city + ",\n" + state + "\n" + zip;

			MessageBox.Show("City, State, Zip: \n\n" + address);
		}
	}
}
