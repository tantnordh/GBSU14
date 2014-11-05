namespace Inloggningsruta2
{
	partial class UserForm
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
			this.userList = new System.Windows.Forms.ListBox();
			this.deleteBtn = new System.Windows.Forms.Button();
			this.blockBtn = new System.Windows.Forms.Button();
			this.unblockBtn = new System.Windows.Forms.Button();
			this.usernameBox = new System.Windows.Forms.TextBox();
			this.firstnameBox = new System.Windows.Forms.TextBox();
			this.surnameBox = new System.Windows.Forms.TextBox();
			this.ageBox = new System.Windows.Forms.TextBox();
			this.usernameLbl = new System.Windows.Forms.Label();
			this.firstnameLbl = new System.Windows.Forms.Label();
			this.surnameLbl = new System.Windows.Forms.Label();
			this.agelbl = new System.Windows.Forms.Label();
			this.passwordLbl = new System.Windows.Forms.Label();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.adminLbl = new System.Windows.Forms.Label();
			this.yesBtn = new System.Windows.Forms.RadioButton();
			this.noBtn = new System.Windows.Forms.RadioButton();
			this.saveBtn = new System.Windows.Forms.Button();
			this.userInfoBox = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// userList
			// 
			this.userList.FormattingEnabled = true;
			this.userList.Location = new System.Drawing.Point(9, 11);
			this.userList.Margin = new System.Windows.Forms.Padding(2);
			this.userList.Name = "userList";
			this.userList.Size = new System.Drawing.Size(90, 186);
			this.userList.TabIndex = 4;
			this.userList.SelectedIndexChanged += new System.EventHandler(this.userList_SelectedIndexChanged);
			// 
			// deleteBtn
			// 
			this.deleteBtn.Location = new System.Drawing.Point(106, 174);
			this.deleteBtn.Name = "deleteBtn";
			this.deleteBtn.Size = new System.Drawing.Size(134, 23);
			this.deleteBtn.TabIndex = 6;
			this.deleteBtn.Text = "Delete";
			this.deleteBtn.UseVisualStyleBackColor = true;
			this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
			// 
			// blockBtn
			// 
			this.blockBtn.Location = new System.Drawing.Point(106, 116);
			this.blockBtn.Name = "blockBtn";
			this.blockBtn.Size = new System.Drawing.Size(134, 23);
			this.blockBtn.TabIndex = 7;
			this.blockBtn.Text = "Block";
			this.blockBtn.UseVisualStyleBackColor = true;
			this.blockBtn.Click += new System.EventHandler(this.blockBtn_Click);
			// 
			// unblockBtn
			// 
			this.unblockBtn.Location = new System.Drawing.Point(106, 145);
			this.unblockBtn.Name = "unblockBtn";
			this.unblockBtn.Size = new System.Drawing.Size(134, 23);
			this.unblockBtn.TabIndex = 8;
			this.unblockBtn.Text = "Unblock";
			this.unblockBtn.UseVisualStyleBackColor = true;
			this.unblockBtn.Click += new System.EventHandler(this.unblockBtn_Click);
			// 
			// usernameBox
			// 
			this.usernameBox.Location = new System.Drawing.Point(312, 8);
			this.usernameBox.Name = "usernameBox";
			this.usernameBox.Size = new System.Drawing.Size(100, 20);
			this.usernameBox.TabIndex = 9;
			// 
			// firstnameBox
			// 
			this.firstnameBox.Location = new System.Drawing.Point(312, 34);
			this.firstnameBox.Name = "firstnameBox";
			this.firstnameBox.Size = new System.Drawing.Size(100, 20);
			this.firstnameBox.TabIndex = 10;
			// 
			// surnameBox
			// 
			this.surnameBox.Location = new System.Drawing.Point(312, 60);
			this.surnameBox.Name = "surnameBox";
			this.surnameBox.Size = new System.Drawing.Size(100, 20);
			this.surnameBox.TabIndex = 11;
			// 
			// ageBox
			// 
			this.ageBox.Location = new System.Drawing.Point(312, 86);
			this.ageBox.Name = "ageBox";
			this.ageBox.Size = new System.Drawing.Size(100, 20);
			this.ageBox.TabIndex = 12;
			// 
			// usernameLbl
			// 
			this.usernameLbl.AutoSize = true;
			this.usernameLbl.Location = new System.Drawing.Point(246, 11);
			this.usernameLbl.Name = "usernameLbl";
			this.usernameLbl.Size = new System.Drawing.Size(55, 13);
			this.usernameLbl.TabIndex = 13;
			this.usernameLbl.Text = "Username";
			// 
			// firstnameLbl
			// 
			this.firstnameLbl.AutoSize = true;
			this.firstnameLbl.Location = new System.Drawing.Point(246, 37);
			this.firstnameLbl.Name = "firstnameLbl";
			this.firstnameLbl.Size = new System.Drawing.Size(55, 13);
			this.firstnameLbl.TabIndex = 14;
			this.firstnameLbl.Text = "First name";
			// 
			// surnameLbl
			// 
			this.surnameLbl.AutoSize = true;
			this.surnameLbl.Location = new System.Drawing.Point(246, 63);
			this.surnameLbl.Name = "surnameLbl";
			this.surnameLbl.Size = new System.Drawing.Size(49, 13);
			this.surnameLbl.TabIndex = 15;
			this.surnameLbl.Text = "Surname";
			// 
			// agelbl
			// 
			this.agelbl.AutoSize = true;
			this.agelbl.Location = new System.Drawing.Point(246, 89);
			this.agelbl.Name = "agelbl";
			this.agelbl.Size = new System.Drawing.Size(26, 13);
			this.agelbl.TabIndex = 16;
			this.agelbl.Text = "Age";
			// 
			// passwordLbl
			// 
			this.passwordLbl.AutoSize = true;
			this.passwordLbl.Location = new System.Drawing.Point(246, 115);
			this.passwordLbl.Name = "passwordLbl";
			this.passwordLbl.Size = new System.Drawing.Size(53, 13);
			this.passwordLbl.TabIndex = 17;
			this.passwordLbl.Text = "Password";
			// 
			// passwordBox
			// 
			this.passwordBox.Location = new System.Drawing.Point(312, 112);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.Size = new System.Drawing.Size(100, 20);
			this.passwordBox.TabIndex = 18;
			// 
			// adminLbl
			// 
			this.adminLbl.AutoSize = true;
			this.adminLbl.Location = new System.Drawing.Point(246, 140);
			this.adminLbl.Name = "adminLbl";
			this.adminLbl.Size = new System.Drawing.Size(36, 13);
			this.adminLbl.TabIndex = 19;
			this.adminLbl.Text = "Admin";
			// 
			// yesBtn
			// 
			this.yesBtn.AutoSize = true;
			this.yesBtn.Location = new System.Drawing.Point(312, 138);
			this.yesBtn.Name = "yesBtn";
			this.yesBtn.Size = new System.Drawing.Size(43, 17);
			this.yesBtn.TabIndex = 20;
			this.yesBtn.TabStop = true;
			this.yesBtn.Text = "Yes";
			this.yesBtn.UseVisualStyleBackColor = true;
			// 
			// noBtn
			// 
			this.noBtn.AutoSize = true;
			this.noBtn.Location = new System.Drawing.Point(361, 138);
			this.noBtn.Name = "noBtn";
			this.noBtn.Size = new System.Drawing.Size(39, 17);
			this.noBtn.TabIndex = 21;
			this.noBtn.TabStop = true;
			this.noBtn.Text = "No";
			this.noBtn.UseVisualStyleBackColor = true;
			// 
			// saveBtn
			// 
			this.saveBtn.Location = new System.Drawing.Point(312, 174);
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Size = new System.Drawing.Size(100, 23);
			this.saveBtn.TabIndex = 22;
			this.saveBtn.Text = "Save New User";
			this.saveBtn.UseVisualStyleBackColor = true;
			// 
			// userInfoBox
			// 
			this.userInfoBox.BackColor = System.Drawing.Color.White;
			this.userInfoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.userInfoBox.Location = new System.Drawing.Point(106, 13);
			this.userInfoBox.Name = "userInfoBox";
			this.userInfoBox.Size = new System.Drawing.Size(134, 96);
			this.userInfoBox.TabIndex = 23;
			this.userInfoBox.Text = "";
			// 
			// UserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(422, 211);
			this.Controls.Add(this.userInfoBox);
			this.Controls.Add(this.saveBtn);
			this.Controls.Add(this.noBtn);
			this.Controls.Add(this.yesBtn);
			this.Controls.Add(this.adminLbl);
			this.Controls.Add(this.passwordBox);
			this.Controls.Add(this.passwordLbl);
			this.Controls.Add(this.agelbl);
			this.Controls.Add(this.surnameLbl);
			this.Controls.Add(this.firstnameLbl);
			this.Controls.Add(this.usernameLbl);
			this.Controls.Add(this.ageBox);
			this.Controls.Add(this.surnameBox);
			this.Controls.Add(this.firstnameBox);
			this.Controls.Add(this.usernameBox);
			this.Controls.Add(this.unblockBtn);
			this.Controls.Add(this.blockBtn);
			this.Controls.Add(this.deleteBtn);
			this.Controls.Add(this.userList);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "UserForm";
			this.Text = "UserForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox userList;
		private System.Windows.Forms.Button deleteBtn;
		private System.Windows.Forms.Button blockBtn;
		private System.Windows.Forms.Button unblockBtn;
		private System.Windows.Forms.TextBox usernameBox;
		private System.Windows.Forms.TextBox firstnameBox;
		private System.Windows.Forms.TextBox surnameBox;
		private System.Windows.Forms.TextBox ageBox;
		private System.Windows.Forms.Label usernameLbl;
		private System.Windows.Forms.Label firstnameLbl;
		private System.Windows.Forms.Label surnameLbl;
		private System.Windows.Forms.Label agelbl;
		private System.Windows.Forms.Label passwordLbl;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.Label adminLbl;
		private System.Windows.Forms.RadioButton yesBtn;
		private System.Windows.Forms.RadioButton noBtn;
		private System.Windows.Forms.Button saveBtn;
		private System.Windows.Forms.RichTextBox userInfoBox;
	}
}