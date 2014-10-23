using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsSebDemo
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void KnappKlick(object sender, EventArgs e)
		{
			Button button = sender as Button;
			//(sender as Button) samma sak som ovan

			button.Text = "KNAPP";
			txtTextRuta.Text = "Knappklick";
		}

		private void KnappHover(object sender, EventArgs e)
		{
			txtTextRuta.Text = "Mouse Hover";
		}

		private void KnappMouseLeave(object sender, EventArgs e)
		{
			txtTextRuta.Text = "Musen lämnar";
		}
	}
}
