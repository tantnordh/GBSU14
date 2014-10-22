namespace WinFormsBlog2
{
	partial class FormMain
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
			this.btnBlogTitle = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnShowSingle = new System.Windows.Forms.Button();
			this.btnComment = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// btnBlogTitle
			// 
			this.btnBlogTitle.Enabled = false;
			this.btnBlogTitle.Location = new System.Drawing.Point(23, 23);
			this.btnBlogTitle.Name = "btnBlogTitle";
			this.btnBlogTitle.Size = new System.Drawing.Size(538, 62);
			this.btnBlogTitle.TabIndex = 0;
			this.btnBlogTitle.Text = "Tant Nordh";
			this.btnBlogTitle.UseVisualStyleBackColor = true;
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(433, 168);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(128, 23);
			this.btnCreate.TabIndex = 2;
			this.btnCreate.Text = "Skapa inlägg";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// btnStart
			// 
			this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnStart.Location = new System.Drawing.Point(433, 110);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(128, 23);
			this.btnStart.TabIndex = 3;
			this.btnStart.Text = "Visa alla inlägg";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnShowSingle
			// 
			this.btnShowSingle.Location = new System.Drawing.Point(433, 139);
			this.btnShowSingle.Name = "btnShowSingle";
			this.btnShowSingle.Size = new System.Drawing.Size(128, 23);
			this.btnShowSingle.TabIndex = 4;
			this.btnShowSingle.Text = "Visa ett inlägg";
			this.btnShowSingle.UseVisualStyleBackColor = true;
			this.btnShowSingle.Click += new System.EventHandler(this.btnShowSingle_Click);
			// 
			// btnComment
			// 
			this.btnComment.Location = new System.Drawing.Point(433, 197);
			this.btnComment.Name = "btnComment";
			this.btnComment.Size = new System.Drawing.Size(128, 23);
			this.btnComment.TabIndex = 5;
			this.btnComment.Text = "Kommentera";
			this.btnComment.UseVisualStyleBackColor = true;
			this.btnComment.Visible = false;
			this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(433, 226);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(128, 23);
			this.btnEdit.TabIndex = 6;
			this.btnEdit.Text = "Uppdatera";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Visible = false;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(433, 255);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(128, 23);
			this.btnDelete.TabIndex = 7;
			this.btnDelete.Text = "Radera";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Visible = false;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Enabled = false;
			this.richTextBox1.Location = new System.Drawing.Point(23, 110);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.richTextBox1.Size = new System.Drawing.Size(400, 530);
			this.richTextBox1.TabIndex = 8;
			this.richTextBox1.Text = "";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 711);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnComment);
			this.Controls.Add(this.btnShowSingle);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.btnBlogTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FormMain";
			this.Padding = new System.Windows.Forms.Padding(20, 20, 20, 10);
			this.Text = "Tant Nordhs Bloggverktyg";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnBlogTitle;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnShowSingle;
		private System.Windows.Forms.Button btnComment;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.RichTextBox richTextBox1;

	}
}

