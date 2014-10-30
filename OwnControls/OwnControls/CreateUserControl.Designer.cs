namespace OwnControls
{
	partial class CreateUserControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.nameLbl = new System.Windows.Forms.Label();
			this.nameBox = new System.Windows.Forms.TextBox();
			this.yesBtn = new OwnControls.SpecialButton();
			this.clearBtn = new OwnControls.SpecialButton();
			this.SuspendLayout();
			// 
			// nameLbl
			// 
			this.nameLbl.AutoSize = true;
			this.nameLbl.Location = new System.Drawing.Point(3, 9);
			this.nameLbl.Name = "nameLbl";
			this.nameLbl.Size = new System.Drawing.Size(49, 17);
			this.nameLbl.TabIndex = 0;
			this.nameLbl.Text = "Name:";
			// 
			// nameBox
			// 
			this.nameBox.Location = new System.Drawing.Point(57, 9);
			this.nameBox.Name = "nameBox";
			this.nameBox.Size = new System.Drawing.Size(151, 22);
			this.nameBox.TabIndex = 1;
			// 
			// yesBtn
			// 
			this.yesBtn.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(50)))));
			this.yesBtn.ButtonNumber = 99;
			this.yesBtn.Location = new System.Drawing.Point(6, 44);
			this.yesBtn.Name = "yesBtn";
			this.yesBtn.Size = new System.Drawing.Size(100, 23);
			this.yesBtn.TabIndex = 3;
			this.yesBtn.Text = "Yes";
			this.yesBtn.UseVisualStyleBackColor = true;
			this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
			// 
			// clearBtn
			// 
			this.clearBtn.BaseColour = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.clearBtn.ButtonNumber = 99;
			this.clearBtn.Location = new System.Drawing.Point(112, 44);
			this.clearBtn.Name = "clearBtn";
			this.clearBtn.Size = new System.Drawing.Size(100, 23);
			this.clearBtn.TabIndex = 4;
			this.clearBtn.Text = "Clear";
			this.clearBtn.UseVisualStyleBackColor = true;
			this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
			// 
			// CreateUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.clearBtn);
			this.Controls.Add(this.yesBtn);
			this.Controls.Add(this.nameBox);
			this.Controls.Add(this.nameLbl);
			this.Name = "CreateUserControl";
			this.Size = new System.Drawing.Size(220, 110);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label nameLbl;
		private System.Windows.Forms.TextBox nameBox;
		private SpecialButton yesBtn;
		private SpecialButton clearBtn;
	}
}
