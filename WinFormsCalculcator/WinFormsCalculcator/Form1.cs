using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCalculcator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			txtNumbers.Text += ((Button)sender).Text;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			txtNumbers.Text += ((Button)sender).Text;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			txtNumbers.Text += ((Button)sender).Text;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			txtNumbers.Text += ((Button)sender).Text;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			txtNumbers.Text += ((Button)sender).Text;
		}

		private void button6_Click(object sender, EventArgs e)
		{
			txtNumbers.Text += ((Button)sender).Text;
		}

		private void button7_Click(object sender, EventArgs e)
		{
			txtNumbers.Text += ((Button)sender).Text;
		}

		private void button8_Click(object sender, EventArgs e)
		{
			txtNumbers.Text += ((Button)sender).Text;
		}

		private void button9_Click(object sender, EventArgs e)
		{
			txtNumbers.Text += ((Button)sender).Text;
		}

		private void button10_Click(object sender, EventArgs e)
		{
			txtNumbers.Text += ((Button)sender).Text;
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtNumbers.Text = null;
			txtSum.Text = null;
		}

		private void btnAddition_Click(object sender, EventArgs e)
		{
			txtNumbers.Text += ((Button)sender).Text;
		}

		private void btnSubtraction_Click(object sender, EventArgs e)
		{
			txtNumbers.Text += ((Button)sender).Text;
		}

		private void btnMultiplication_Click(object sender, EventArgs e)
		{
			txtNumbers.Text += ((Button)sender).Text;
		}

		private void btnDivision_Click(object sender, EventArgs e)
		{
			txtNumbers.Text += ((Button)sender).Text;
		}

		private void btnEquals_Click(object sender, EventArgs e)
		{
			txtSum.Text = Calculate(txtNumbers.Text).ToString();
		}

		private static int Calculate(string text)
		{
			if (text.Contains('+'))
			{
				string[] x = SplitText(text, '+');
				return Calculate(x[0]) + Calculate(x[1]);
			}

			if (text.Contains('-'))
			{
				string[] x = SplitText(text, '-');
				return Calculate(x[0]) - Calculate(x[1]);
			}

			if (text.Contains('*'))
			{
				string[] x = SplitText(text, '*');
				return Calculate(x[0]) * Calculate(x[1]);
			}

			if (text.Contains('/'))
			{
				string[] x = SplitText(text, '/');
				return Calculate(x[0]) / Calculate(x[1]);
			}

			return int.Parse(text);
		}

		private static string[] SplitText(string text, char p)
		{
			string[] splittedText = text.Split(new char[] { p }, 2);
			return splittedText;
		}
	}
}
