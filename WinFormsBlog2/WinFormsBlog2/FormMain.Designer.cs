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
			this.mainBox = new System.Windows.Forms.RichTextBox();
			this.comboBoxSearch = new System.Windows.Forms.ComboBox();
			this.btnQuit = new System.Windows.Forms.Button();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.comboBoxTitles = new System.Windows.Forms.ComboBox();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.txtTags = new System.Windows.Forms.TextBox();
			this.txtBodyText = new System.Windows.Forms.TextBox();
			this.btnSavePost = new System.Windows.Forms.Button();
			this.btnSaveChanges = new System.Windows.Forms.Button();
			this.backgroundBox = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// btnBlogTitle
			// 
			this.btnBlogTitle.BackColor = System.Drawing.Color.PaleVioletRed;
			this.btnBlogTitle.Enabled = false;
			this.btnBlogTitle.FlatAppearance.BorderSize = 0;
			this.btnBlogTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBlogTitle.Font = new System.Drawing.Font("Sitka Banner", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBlogTitle.ForeColor = System.Drawing.Color.White;
			this.btnBlogTitle.Location = new System.Drawing.Point(23, 23);
			this.btnBlogTitle.Margin = new System.Windows.Forms.Padding(0);
			this.btnBlogTitle.Name = "btnBlogTitle";
			this.btnBlogTitle.Size = new System.Drawing.Size(250, 62);
			this.btnBlogTitle.TabIndex = 0;
			this.btnBlogTitle.Text = "Bloggtitel";
			this.btnBlogTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBlogTitle.UseVisualStyleBackColor = false;
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(40, 257);
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
			this.btnStart.Location = new System.Drawing.Point(40, 228);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(128, 23);
			this.btnStart.TabIndex = 3;
			this.btnStart.Text = "Visa alla inlägg";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnShowSingle
			// 
			this.btnShowSingle.Location = new System.Drawing.Point(200, 144);
			this.btnShowSingle.Name = "btnShowSingle";
			this.btnShowSingle.Size = new System.Drawing.Size(44, 23);
			this.btnShowSingle.TabIndex = 4;
			this.btnShowSingle.Text = "Visa";
			this.btnShowSingle.UseVisualStyleBackColor = true;
			this.btnShowSingle.Click += new System.EventHandler(this.btnShowSingle_Click);
			// 
			// btnComment
			// 
			this.btnComment.Location = new System.Drawing.Point(40, 286);
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
			this.btnEdit.Location = new System.Drawing.Point(40, 315);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(128, 23);
			this.btnEdit.TabIndex = 6;
			this.btnEdit.Text = "Uppdatera";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Visible = false;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(40, 344);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(128, 23);
			this.btnDelete.TabIndex = 7;
			this.btnDelete.Text = "Radera";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Visible = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// mainBox
			// 
			this.mainBox.BackColor = System.Drawing.Color.White;
			this.mainBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.mainBox.Location = new System.Drawing.Point(335, 23);
			this.mainBox.Name = "mainBox";
			this.mainBox.ReadOnly = true;
			this.mainBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.mainBox.Size = new System.Drawing.Size(500, 595);
			this.mainBox.TabIndex = 8;
			this.mainBox.TabStop = false;
			this.mainBox.Text = "";
			this.mainBox.Enter += new System.EventHandler(this.ShiftFocus);
			// 
			// comboBoxSearch
			// 
			this.comboBoxSearch.FormattingEnabled = true;
			this.comboBoxSearch.Location = new System.Drawing.Point(40, 89);
			this.comboBoxSearch.Name = "comboBoxSearch";
			this.comboBoxSearch.Size = new System.Drawing.Size(204, 21);
			this.comboBoxSearch.TabIndex = 9;
			this.comboBoxSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearch_SelectedIndexChanged);
			// 
			// btnQuit
			// 
			this.btnQuit.Location = new System.Drawing.Point(40, 595);
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.Size = new System.Drawing.Size(128, 23);
			this.btnQuit.TabIndex = 10;
			this.btnQuit.Text = "Avsluta";
			this.btnQuit.UseVisualStyleBackColor = true;
			this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(40, 117);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(154, 20);
			this.txtSearch.TabIndex = 11;
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(200, 114);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(44, 23);
			this.btnSearch.TabIndex = 12;
			this.btnSearch.Text = "Sök";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// comboBoxTitles
			// 
			this.comboBoxTitles.FormattingEnabled = true;
			this.comboBoxTitles.Location = new System.Drawing.Point(40, 144);
			this.comboBoxTitles.Name = "comboBoxTitles";
			this.comboBoxTitles.Size = new System.Drawing.Size(154, 21);
			this.comboBoxTitles.TabIndex = 13;
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(335, 41);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(425, 20);
			this.txtTitle.TabIndex = 14;
			this.txtTitle.Text = "Rubrik";
			this.txtTitle.Visible = false;
			// 
			// txtTags
			// 
			this.txtTags.Location = new System.Drawing.Point(335, 539);
			this.txtTags.Name = "txtTags";
			this.txtTags.Size = new System.Drawing.Size(425, 20);
			this.txtTags.TabIndex = 16;
			this.txtTags.Text = "Taggar, separera med komma";
			this.txtTags.Visible = false;
			// 
			// txtBodyText
			// 
			this.txtBodyText.Location = new System.Drawing.Point(335, 67);
			this.txtBodyText.Multiline = true;
			this.txtBodyText.Name = "txtBodyText";
			this.txtBodyText.Size = new System.Drawing.Size(425, 466);
			this.txtBodyText.TabIndex = 15;
			this.txtBodyText.Text = "Text";
			this.txtBodyText.Visible = false;
			// 
			// btnSavePost
			// 
			this.btnSavePost.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnSavePost.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
			this.btnSavePost.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnSavePost.Location = new System.Drawing.Point(40, 257);
			this.btnSavePost.Name = "btnSavePost";
			this.btnSavePost.Size = new System.Drawing.Size(128, 23);
			this.btnSavePost.TabIndex = 17;
			this.btnSavePost.Text = "Spara";
			this.btnSavePost.UseVisualStyleBackColor = false;
			this.btnSavePost.Visible = false;
			this.btnSavePost.Click += new System.EventHandler(this.btnSavePost_Click);
			// 
			// btnSaveChanges
			// 
			this.btnSaveChanges.Location = new System.Drawing.Point(40, 315);
			this.btnSaveChanges.Name = "btnSaveChanges";
			this.btnSaveChanges.Size = new System.Drawing.Size(128, 23);
			this.btnSaveChanges.TabIndex = 18;
			this.btnSaveChanges.Text = "Spara ändringar";
			this.btnSaveChanges.UseVisualStyleBackColor = true;
			this.btnSaveChanges.Visible = false;
			this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
			// 
			// backgroundBox
			// 
			this.backgroundBox.BackColor = System.Drawing.Color.White;
			this.backgroundBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.backgroundBox.Location = new System.Drawing.Point(300, 0);
			this.backgroundBox.Name = "backgroundBox";
			this.backgroundBox.ReadOnly = true;
			this.backgroundBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.backgroundBox.Size = new System.Drawing.Size(600, 650);
			this.backgroundBox.TabIndex = 19;
			this.backgroundBox.TabStop = false;
			this.backgroundBox.Text = "";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleVioletRed;
			this.ClientSize = new System.Drawing.Size(900, 650);
			this.Controls.Add(this.btnSaveChanges);
			this.Controls.Add(this.btnSavePost);
			this.Controls.Add(this.txtBodyText);
			this.Controls.Add(this.txtTags);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.comboBoxTitles);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.btnQuit);
			this.Controls.Add(this.comboBoxSearch);
			this.Controls.Add(this.mainBox);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnComment);
			this.Controls.Add(this.btnShowSingle);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.btnBlogTitle);
			this.Controls.Add(this.backgroundBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormMain";
			this.Padding = new System.Windows.Forms.Padding(20, 20, 0, 0);
			this.Text = "Tant Nordhs Bloggverktyg";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnBlogTitle;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnShowSingle;
		private System.Windows.Forms.Button btnComment;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.RichTextBox mainBox;
		private System.Windows.Forms.ComboBox comboBoxSearch;
		private System.Windows.Forms.Button btnQuit;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.ComboBox comboBoxTitles;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.TextBox txtTags;
		private System.Windows.Forms.TextBox txtBodyText;
		private System.Windows.Forms.Button btnSavePost;
		private System.Windows.Forms.Button btnSaveChanges;
		private System.Windows.Forms.RichTextBox backgroundBox;

	}
}

