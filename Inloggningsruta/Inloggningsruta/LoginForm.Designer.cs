namespace Inloggningsruta
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
			this.usernameBox = new System.Windows.Forms.TextBox();
			this.loginBtn = new System.Windows.Forms.Button();
			this.passwordLbl = new System.Windows.Forms.Label();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.clearBtn = new System.Windows.Forms.Button();
			this.usernameMessageLbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// usernameLbl
			// 
			this.usernameLbl.AutoSize = true;
			this.usernameLbl.Location = new System.Drawing.Point(13, 13);
			this.usernameLbl.Name = "usernameLbl";
			this.usernameLbl.Size = new System.Drawing.Size(58, 13);
			this.usernameLbl.TabIndex = 0;
			this.usernameLbl.Text = "Username:";
			// 
			// usernameBox
			// 
			this.usernameBox.Location = new System.Drawing.Point(97, 10);
			this.usernameBox.Name = "usernameBox";
			this.usernameBox.Size = new System.Drawing.Size(100, 20);
			this.usernameBox.TabIndex = 1;
			// 
			// loginBtn
			// 
			this.loginBtn.Location = new System.Drawing.Point(41, 98);
			this.loginBtn.Name = "loginBtn";
			this.loginBtn.Size = new System.Drawing.Size(75, 23);
			this.loginBtn.TabIndex = 2;
			this.loginBtn.Text = "Login";
			this.loginBtn.UseVisualStyleBackColor = true;
			this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
			// 
			// passwordLbl
			// 
			this.passwordLbl.AutoSize = true;
			this.passwordLbl.Location = new System.Drawing.Point(14, 39);
			this.passwordLbl.Name = "passwordLbl";
			this.passwordLbl.Size = new System.Drawing.Size(56, 13);
			this.passwordLbl.TabIndex = 3;
			this.passwordLbl.Text = "Password:";
			// 
			// passwordBox
			// 
			this.passwordBox.Location = new System.Drawing.Point(97, 36);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.Size = new System.Drawing.Size(100, 20);
			this.passwordBox.TabIndex = 2;
			// 
			// clearBtn
			// 
			this.clearBtn.Location = new System.Drawing.Point(122, 98);
			this.clearBtn.Name = "clearBtn";
			this.clearBtn.Size = new System.Drawing.Size(75, 23);
			this.clearBtn.TabIndex = 5;
			this.clearBtn.Text = "Clear";
			this.clearBtn.UseVisualStyleBackColor = true;
			this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
			// 
			// usernameMessageLbl
			// 
			this.usernameMessageLbl.AutoSize = true;
			this.usernameMessageLbl.ForeColor = System.Drawing.Color.DarkRed;
			this.usernameMessageLbl.Location = new System.Drawing.Point(14, 68);
			this.usernameMessageLbl.Name = "usernameMessageLbl";
			this.usernameMessageLbl.Size = new System.Drawing.Size(0, 13);
			this.usernameMessageLbl.TabIndex = 6;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(220, 140);
			this.Controls.Add(this.usernameMessageLbl);
			this.Controls.Add(this.clearBtn);
			this.Controls.Add(this.passwordBox);
			this.Controls.Add(this.passwordLbl);
			this.Controls.Add(this.loginBtn);
			this.Controls.Add(this.usernameBox);
			this.Controls.Add(this.usernameLbl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "LoginForm";
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label usernameLbl;
		private System.Windows.Forms.TextBox usernameBox;
		private System.Windows.Forms.Button loginBtn;
		private System.Windows.Forms.Label passwordLbl;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.Button clearBtn;
		private System.Windows.Forms.Label usernameMessageLbl;
	}
}

