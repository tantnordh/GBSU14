using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OwnControls
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void specialButtonPracticalClickEvent(SpecialButton sender, int number)
		{
			sender.Text = number.ToString();
			sender.ButtonNumber = 0;
		}

		private void specialButton3_Click(object sender, EventArgs e)
		{
			SpecialButton button = sender as SpecialButton;
			specialButtonPracticalClickEvent(button, button.ButtonNumber);
		}

	}
}
