namespace Inloggningsruta2
{
	partial class LoginForm
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
			this.usernameLbl = new System.Windows.Forms.Label();
			this.passwordLbl = new System.Windows.Forms.Label();
			this.usernameBox = new System.Windows.Forms.TextBox();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.loginBtn = new System.Windows.Forms.Button();
			this.clearBtn = new System.Windows.Forms.Button();
			this.errorLbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// usernameLbl
			// 
			this.usernameLbl.AutoSize = true;
			this.usernameLbl.Location = new System.Drawing.Point(10, 10);
			this.usernameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.usernameLbl.Name = "usernameLbl";
			this.usernameLbl.Size = new System.Drawing.Size(58, 13);
			this.usernameLbl.TabIndex = 0;
			this.usernameLbl.Text = "Username:";
			// 
			// passwordLbl
			// 
			this.passwordLbl.AutoSize = true;
			this.passwordLbl.Location = new System.Drawing.Point(10, 32);
			this.passwordLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.passwordLbl.Name = "passwordLbl";
			this.passwordLbl.Size = new System.Drawing.Size(53, 13);
			this.passwordLbl.TabIndex = 1;
			this.passwordLbl.Text = "Password";
			// 
			// usernameBox
			// 
			this.usernameBox.Location = new System.Drawing.Point(73, 6);
			this.usernameBox.Margin = new System.Windows.Forms.Padding(2);
			this.usernameBox.Name = "usernameBox";
			this.usernameBox.Size = new System.Drawing.Size(96, 20);
			this.usernameBox.TabIndex = 2;
			// 
			// passwordBox
			// 
			this.passwordBox.Location = new System.Drawing.Point(73, 28);
			this.passwordBox.Margin = new System.Windows.Forms.Padding(2);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.Size = new System.Drawing.Size(96, 20);
			this.passwordBox.TabIndex = 3;
			this.passwordBox.UseSystemPasswordChar = true;
			// 
			// loginBtn
			// 
			this.loginBtn.Location = new System.Drawing.Point(51, 84);
			this.loginBtn.Margin = new System.Windows.Forms.Padding(2);
			this.loginBtn.Name = "loginBtn";
			this.loginBtn.Size = new System.Drawing.Size(56, 24);
			this.loginBtn.TabIndex = 4;
			this.loginBtn.Text = "Log in";
			this.loginBtn.UseVisualStyleBackColor = true;
			this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
			// 
			// clearBtn
			// 
			this.clearBtn.Location = new System.Drawing.Point(112, 84);
			this.clearBtn.Margin = new System.Windows.Forms.Padding(2);
			this.clearBtn.Name = "clearBtn";
			this.clearBtn.Size = new System.Drawing.Size(56, 24);
			this.clearBtn.TabIndex = 5;
			this.clearBtn.Text = "Clear";
			this.clearBtn.UseVisualStyleBackColor = true;
			this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
			// 
			// errorLbl
			// 
			this.errorLbl.AutoSize = true;
			this.errorLbl.Location = new System.Drawing.Point(10, 54);
			this.errorLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.errorLbl.Name = "errorLbl";
			this.errorLbl.Size = new System.Drawing.Size(0, 13);
			this.errorLbl.TabIndex = 6;
			this.errorLbl.Visible = false;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(182, 121);
			this.Controls.Add(this.errorLbl);
			this.Controls.Add(this.clearBtn);
			this.Controls.Add(this.loginBtn);
			this.Controls.Add(this.passwordBox);
			this.Controls.Add(this.usernameBox);
			this.Controls.Add(this.passwordLbl);
			this.Controls.Add(this.usernameLbl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "LoginForm";
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label usernameLbl;
		private System.Windows.Forms.Label passwordLbl;
		private System.Windows.Forms.TextBox usernameBox;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.Button loginBtn;
		private System.Windows.Forms.Button clearBtn;
		private System.Windows.Forms.Label errorLbl;
	}
}

