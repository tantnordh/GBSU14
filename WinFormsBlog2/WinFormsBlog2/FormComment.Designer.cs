namespace WinFormsVersion
{
	partial class FormComment
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
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtComment = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(23, 23);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(201, 20);
			this.txtName.TabIndex = 0;
			this.txtName.Text = "Namn";
			// 
			// txtComment
			// 
			this.txtComment.Location = new System.Drawing.Point(23, 50);
			this.txtComment.Multiline = true;
			this.txtComment.Name = "txtComment";
			this.txtComment.Size = new System.Drawing.Size(201, 101);
			this.txtComment.TabIndex = 1;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(230, 20);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(112, 23);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Spara";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(230, 50);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(112, 23);
			this.btnBack.TabIndex = 3;
			this.btnBack.Text = "Ångra";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// FormComment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(364, 177);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtComment);
			this.Controls.Add(this.txtName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormComment";
			this.Padding = new System.Windows.Forms.Padding(20);
			this.Text = "FormComment";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtComment;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnBack;
	}
}