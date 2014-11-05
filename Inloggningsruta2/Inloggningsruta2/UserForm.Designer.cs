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
			this.nameLbl = new System.Windows.Forms.Label();
			this.surnameLbl = new System.Windows.Forms.Label();
			this.ageLbl = new System.Windows.Forms.Label();
			this.userList = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// nameLbl
			// 
			this.nameLbl.AutoSize = true;
			this.nameLbl.Location = new System.Drawing.Point(145, 13);
			this.nameLbl.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.nameLbl.Name = "nameLbl";
			this.nameLbl.Size = new System.Drawing.Size(49, 17);
			this.nameLbl.TabIndex = 1;
			this.nameLbl.Text = "Name:";
			// 
			// surnameLbl
			// 
			this.surnameLbl.AutoSize = true;
			this.surnameLbl.Location = new System.Drawing.Point(145, 33);
			this.surnameLbl.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.surnameLbl.Name = "surnameLbl";
			this.surnameLbl.Size = new System.Drawing.Size(69, 17);
			this.surnameLbl.TabIndex = 2;
			this.surnameLbl.Text = "Surname:";
			// 
			// ageLbl
			// 
			this.ageLbl.AutoSize = true;
			this.ageLbl.Location = new System.Drawing.Point(145, 53);
			this.ageLbl.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.ageLbl.Name = "ageLbl";
			this.ageLbl.Size = new System.Drawing.Size(37, 17);
			this.ageLbl.TabIndex = 3;
			this.ageLbl.Text = "Age:";
			// 
			// userList
			// 
			this.userList.FormattingEnabled = true;
			this.userList.ItemHeight = 16;
			this.userList.Location = new System.Drawing.Point(12, 13);
			this.userList.Name = "userList";
			this.userList.Size = new System.Drawing.Size(120, 228);
			this.userList.TabIndex = 4;
			this.userList.SelectedIndexChanged += new System.EventHandler(this.ShowUserInfo);
			// 
			// UserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(625, 255);
			this.Controls.Add(this.userList);
			this.Controls.Add(this.ageLbl);
			this.Controls.Add(this.surnameLbl);
			this.Controls.Add(this.nameLbl);
			this.Name = "UserForm";
			this.Text = "UserForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label nameLbl;
		private System.Windows.Forms.Label surnameLbl;
		private System.Windows.Forms.Label ageLbl;
		private System.Windows.Forms.ListBox userList;
	}
}