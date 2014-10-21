namespace WinFormsBlogFromScratch
{
	partial class FormCreateNewBlog
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
			this.lblNewBlogName = new System.Windows.Forms.Label();
			this.txtBoxNewBlogName = new System.Windows.Forms.TextBox();
			this.btnSaveNewBlog = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblNewBlogName
			// 
			this.lblNewBlogName.AutoSize = true;
			this.lblNewBlogName.Location = new System.Drawing.Point(12, 15);
			this.lblNewBlogName.Name = "lblNewBlogName";
			this.lblNewBlogName.Size = new System.Drawing.Size(38, 13);
			this.lblNewBlogName.TabIndex = 0;
			this.lblNewBlogName.Text = "Namn:";
			// 
			// txtBoxNewBlogName
			// 
			this.txtBoxNewBlogName.Location = new System.Drawing.Point(56, 12);
			this.txtBoxNewBlogName.Name = "txtBoxNewBlogName";
			this.txtBoxNewBlogName.Size = new System.Drawing.Size(135, 20);
			this.txtBoxNewBlogName.TabIndex = 1;
			// 
			// btnSaveNewBlog
			// 
			this.btnSaveNewBlog.Location = new System.Drawing.Point(197, 9);
			this.btnSaveNewBlog.Name = "btnSaveNewBlog";
			this.btnSaveNewBlog.Size = new System.Drawing.Size(75, 25);
			this.btnSaveNewBlog.TabIndex = 2;
			this.btnSaveNewBlog.Text = "Save";
			this.btnSaveNewBlog.UseVisualStyleBackColor = true;
			this.btnSaveNewBlog.Click += new System.EventHandler(this.btnSaveNewBlog_Click);
			// 
			// FormNewBlog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.btnSaveNewBlog);
			this.Controls.Add(this.txtBoxNewBlogName);
			this.Controls.Add(this.lblNewBlogName);
			this.Name = "FormNewBlog";
			this.Text = "Skapa ny blogg";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblNewBlogName;
		private System.Windows.Forms.TextBox txtBoxNewBlogName;
		private System.Windows.Forms.Button btnSaveNewBlog;
	}
}