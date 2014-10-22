namespace WinFormsBlog2
{
	partial class FormFindEntry
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
			this.comboBoxTitles = new System.Windows.Forms.ComboBox();
			this.btnBlogTitle = new System.Windows.Forms.Button();
			this.btnChooseFromCombo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// comboBoxTitles
			// 
			this.comboBoxTitles.FormattingEnabled = true;
			this.comboBoxTitles.Location = new System.Drawing.Point(23, 110);
			this.comboBoxTitles.Name = "comboBoxTitles";
			this.comboBoxTitles.Size = new System.Drawing.Size(400, 21);
			this.comboBoxTitles.TabIndex = 0;
			// 
			// btnBlogTitle
			// 
			this.btnBlogTitle.Enabled = false;
			this.btnBlogTitle.Location = new System.Drawing.Point(23, 23);
			this.btnBlogTitle.Name = "btnBlogTitle";
			this.btnBlogTitle.Size = new System.Drawing.Size(538, 62);
			this.btnBlogTitle.TabIndex = 7;
			this.btnBlogTitle.Text = "Tant Nordh";
			this.btnBlogTitle.UseVisualStyleBackColor = true;
			// 
			// btnChooseFromCombo
			// 
			this.btnChooseFromCombo.Location = new System.Drawing.Point(433, 110);
			this.btnChooseFromCombo.Name = "btnChooseFromCombo";
			this.btnChooseFromCombo.Size = new System.Drawing.Size(128, 23);
			this.btnChooseFromCombo.TabIndex = 8;
			this.btnChooseFromCombo.Text = "Välj";
			this.btnChooseFromCombo.UseVisualStyleBackColor = true;
			this.btnChooseFromCombo.Click += new System.EventHandler(this.btnChooseFromCombo_Click);
			// 
			// FormFindEntry
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 711);
			this.Controls.Add(this.btnChooseFromCombo);
			this.Controls.Add(this.btnBlogTitle);
			this.Controls.Add(this.comboBoxTitles);
			this.Name = "FormFindEntry";
			this.Padding = new System.Windows.Forms.Padding(20, 20, 20, 10);
			this.Text = "FormFindEntry";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxTitles;
		private System.Windows.Forms.Button btnBlogTitle;
		private System.Windows.Forms.Button btnChooseFromCombo;
	}
}