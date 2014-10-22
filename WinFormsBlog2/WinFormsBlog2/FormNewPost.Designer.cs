namespace WinFormsBlog2
{
	partial class FormNewPost
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
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.txtText = new System.Windows.Forms.TextBox();
			this.txtTags = new System.Windows.Forms.TextBox();
			this.btnBlogTitle = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(23, 110);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(400, 20);
			this.txtTitle.TabIndex = 3;
			this.txtTitle.Text = "Rubrik";
			// 
			// txtText
			// 
			this.txtText.Location = new System.Drawing.Point(23, 136);
			this.txtText.Multiline = true;
			this.txtText.Name = "txtText";
			this.txtText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtText.Size = new System.Drawing.Size(400, 478);
			this.txtText.TabIndex = 4;
			this.txtText.Text = "Inläggstext";
			// 
			// txtTags
			// 
			this.txtTags.Location = new System.Drawing.Point(23, 620);
			this.txtTags.Name = "txtTags";
			this.txtTags.Size = new System.Drawing.Size(400, 20);
			this.txtTags.TabIndex = 5;
			this.txtTags.Text = "Taggar, separera med kommatecken";
			// 
			// btnBlogTitle
			// 
			this.btnBlogTitle.Enabled = false;
			this.btnBlogTitle.Location = new System.Drawing.Point(23, 23);
			this.btnBlogTitle.Name = "btnBlogTitle";
			this.btnBlogTitle.Size = new System.Drawing.Size(538, 62);
			this.btnBlogTitle.TabIndex = 6;
			this.btnBlogTitle.Text = "Tant Nordh";
			this.btnBlogTitle.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(433, 110);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(128, 23);
			this.btnSave.TabIndex = 7;
			this.btnSave.Text = "Spara";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(433, 139);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(128, 23);
			this.btnBack.TabIndex = 8;
			this.btnBack.Text = "Tillbaka utan att spara";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// FormNewPost
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 711);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnBlogTitle);
			this.Controls.Add(this.txtTags);
			this.Controls.Add(this.txtText);
			this.Controls.Add(this.txtTitle);
			this.Name = "FormNewPost";
			this.Padding = new System.Windows.Forms.Padding(20, 20, 20, 10);
			this.Text = "FormNewPost";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.TextBox txtText;
		private System.Windows.Forms.TextBox txtTags;
		private System.Windows.Forms.Button btnBlogTitle;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnBack;
	}
}