namespace OwnControls
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
			this.specialButton3 = new OwnControls.SpecialButton();
			this.specialButton2 = new OwnControls.SpecialButton();
			this.specialButton1 = new OwnControls.SpecialButton();
			this.createUserControl1 = new OwnControls.CreateUserControl();
			this.SuspendLayout();
			// 
			// specialButton3
			// 
			this.specialButton3.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(205)))));
			this.specialButton3.ButtonNumber = 150;
			this.specialButton3.Location = new System.Drawing.Point(65, 70);
			this.specialButton3.Name = "specialButton3";
			this.specialButton3.Size = new System.Drawing.Size(149, 23);
			this.specialButton3.TabIndex = 2;
			this.specialButton3.Text = "Special Three";
			this.specialButton3.UseVisualStyleBackColor = true;
			this.specialButton3.Click += new System.EventHandler(this.specialButton3_Click);
			// 
			// specialButton2
			// 
			this.specialButton2.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.specialButton2.ButtonNumber = 99;
			this.specialButton2.Location = new System.Drawing.Point(65, 41);
			this.specialButton2.Name = "specialButton2";
			this.specialButton2.Size = new System.Drawing.Size(149, 23);
			this.specialButton2.TabIndex = 1;
			this.specialButton2.Text = "Special Two";
			this.specialButton2.UseVisualStyleBackColor = true;
			// 
			// specialButton1
			// 
			this.specialButton1.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(50)))));
			this.specialButton1.ButtonNumber = 99;
			this.specialButton1.Location = new System.Drawing.Point(65, 12);
			this.specialButton1.Name = "specialButton1";
			this.specialButton1.Size = new System.Drawing.Size(149, 23);
			this.specialButton1.TabIndex = 0;
			this.specialButton1.Text = "Special One";
			// 
			// createUserControl1
			// 
			this.createUserControl1.Location = new System.Drawing.Point(31, 143);
			this.createUserControl1.Name = "createUserControl1";
			this.createUserControl1.Size = new System.Drawing.Size(220, 110);
			this.createUserControl1.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(282, 265);
			this.Controls.Add(this.createUserControl1);
			this.Controls.Add(this.specialButton3);
			this.Controls.Add(this.specialButton2);
			this.Controls.Add(this.specialButton1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private SpecialButton specialButton1;
		private SpecialButton specialButton2;
		private SpecialButton specialButton3;
		private CreateUserControl createUserControl1;
	}
}

