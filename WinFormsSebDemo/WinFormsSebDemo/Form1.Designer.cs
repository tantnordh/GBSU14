namespace WinFormsSebDemo
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnKnapp = new System.Windows.Forms.Button();
			this.txtTextRuta = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnKnapp
			// 
			this.btnKnapp.Location = new System.Drawing.Point(12, 12);
			this.btnKnapp.Name = "btnKnapp";
			this.btnKnapp.Size = new System.Drawing.Size(75, 23);
			this.btnKnapp.TabIndex = 0;
			this.btnKnapp.Text = "Button1";
			this.btnKnapp.UseVisualStyleBackColor = true;
			this.btnKnapp.Click += new System.EventHandler(this.KnappKlick);
			this.btnKnapp.MouseLeave += new System.EventHandler(this.KnappMouseLeave);
			this.btnKnapp.MouseHover += new System.EventHandler(this.KnappHover);
			// 
			// txtTextRuta
			// 
			this.txtTextRuta.Location = new System.Drawing.Point(93, 12);
			this.txtTextRuta.Name = "txtTextRuta";
			this.txtTextRuta.Size = new System.Drawing.Size(100, 20);
			this.txtTextRuta.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.txtTextRuta);
			this.Controls.Add(this.btnKnapp);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnKnapp;
		private System.Windows.Forms.TextBox txtTextRuta;
	}
}

