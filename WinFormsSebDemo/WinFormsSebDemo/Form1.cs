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
			//Control button = sender as Control;
			Button button = sender as Button;
			//(sender as Button) samma sak som ovan, typ

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

		private void LabelClick(object sender, EventArgs e)
		{
			label1.Text = DateTime.Now.ToString();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox box = sender as CheckBox;

			if (box.Checked)
			{
				label1.Text = "Boxen är checkad";
			}
			else
			{
				label1.Text = string.Empty;
			}
		}

		private void RadioClick(object sender, EventArgs e)
		{
			RadioButton radBut = sender as RadioButton;

			if (radBut.Checked)
			{
				radBut.Checked = false;
			}
		}

		private void RadioMouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Right)
			{

			}

			RadioButton radBut = sender as RadioButton;
		}


	}
}
