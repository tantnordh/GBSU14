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
	public partial class SpecialButton : Button
	{
		public event Action<SpecialButton, int> NumberIsTooGreat;
		public Color BaseColour { get; set; }
		public int ButtonNumber { get; set; }

		public SpecialButton()
		{
			ButtonNumber = 99;
			BaseColour = Color.FromArgb(50, Color.LimeGreen);
			InitializeComponent();
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);

			Brush brush = new SolidBrush(BaseColour);

			pe.Graphics.FillRectangle(brush, ClientRectangle);

			if (ButtonNumber > 100)
			{
				if (NumberIsTooGreat != null)
				{
					NumberIsTooGreat(this, ButtonNumber);
				}
			}
		}
	}
}
