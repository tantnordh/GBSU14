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

			List<Day> dagar = new List<Day>()
			{
				Day.Monday,
				Day.Tuesday,
				Day.Wednesday,
				Day.Thursday,
				Day.Friday,
				Day.Saturday,
				Day.Sunday
			};

			comboBox1.DataSource = dagar;
			listBox1.DataSource = dagar;

			dataGridView1.DataSource = new List<Person>
			{
				new Person("Erik", 12),
				new Person("Göran", 19),
				new Person("Knud", 29),
				new Person("Mats", 39),
				new Person("Sven", 22)
			};
		}

		private void KnappKlick(object sender, EventArgs e)
		{
			Button button = sender as Button;

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
		}

		private void RadioMouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Right)
			{
				RadioButton radBut = sender as RadioButton;
				radBut.Checked = false;
			}
		}

		private void ComboBoxSelectionChanged(object sender, EventArgs e)
		{
			ComboBox box = sender as ComboBox;

			if (box != null)
			{
				Day dagen = (Day)box.SelectedItem;

				label1.Text = dagen + " - " + (int)dagen;
			}
		}
	}
}
