using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsSebDemo
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			YesNoForm yesNo = new YesNoForm();
			DialogResult resultat = yesNo.ShowDialog();

			if (resultat == DialogResult.Yes)
			{
				Application.Run(new Form1());
			}
		}
	}
}
