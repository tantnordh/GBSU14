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
			this.btnKnapp2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// btnKnapp
			// 
			this.btnKnapp.Location = new System.Drawing.Point(12, 55);
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
			this.txtTextRuta.Location = new System.Drawing.Point(12, 145);
			this.txtTextRuta.Name = "txtTextRuta";
			this.txtTextRuta.Size = new System.Drawing.Size(100, 20);
			this.txtTextRuta.TabIndex = 1;
			this.txtTextRuta.Text = "Hejsan";
			// 
			// btnKnapp2
			// 
			this.btnKnapp2.Location = new System.Drawing.Point(12, 84);
			this.btnKnapp2.Name = "btnKnapp2";
			this.btnKnapp2.Size = new System.Drawing.Size(75, 23);
			this.btnKnapp2.TabIndex = 2;
			this.btnKnapp2.Text = "Knapp Två";
			this.btnKnapp2.UseVisualStyleBackColor = true;
			this.btnKnapp2.Click += new System.EventHandler(this.LabelClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 129);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Labeltext som är fin";
			this.label1.Click += new System.EventHandler(this.LabelClick);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(151, 12);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 4;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(12, 12);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(75, 17);
			this.checkBox1.TabIndex = 5;
			this.checkBox1.Text = "CheckBox";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(151, 55);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(85, 17);
			this.radioButton1.TabIndex = 6;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "radioButton1";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.Click += new System.EventHandler(this.RadioClick);
			this.radioButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RadioMouseDown);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(151, 78);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(85, 17);
			this.radioButton2.TabIndex = 7;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "radioButton2";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.Click += new System.EventHandler(this.RadioClick);
			this.radioButton2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RadioMouseDown);
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Location = new System.Drawing.Point(151, 101);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(85, 17);
			this.radioButton3.TabIndex = 8;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "radioButton3";
			this.radioButton3.UseVisualStyleBackColor = true;
			this.radioButton3.Click += new System.EventHandler(this.RadioClick);
			this.radioButton3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RadioMouseDown);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnKnapp2);
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
		private System.Windows.Forms.Button btnKnapp2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
	}
}

