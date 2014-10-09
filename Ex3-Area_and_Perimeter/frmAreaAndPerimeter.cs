using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3_Area_and_Perimeter
{
	public partial class frmAreaAndPerimeter : Form
	{
		public frmAreaAndPerimeter()
		{
			InitializeComponent();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			Decimal length = Convert.ToDecimal(txtLength.Text);
			Decimal width = Convert.ToDecimal(txtWidth.Text);
			Decimal area = 0;
			Decimal perimeter = 0;

			area = length * width;
			perimeter = (length * 2) + (width * 2);

			txtArea.Text = area.ToString();
			txtPerimeter.Text = perimeter.ToString();
		}
	}
}
