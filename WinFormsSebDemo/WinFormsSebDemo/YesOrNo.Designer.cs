﻿namespace WinFormsSebDemo
{
	partial class YesOrNo
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
			this.btnYes = new System.Windows.Forms.Button();
			this.btnNo = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnYes
			// 
			this.btnYes.Location = new System.Drawing.Point(47, 48);
			this.btnYes.Name = "btnYes";
			this.btnYes.Size = new System.Drawing.Size(75, 23);
			this.btnYes.TabIndex = 0;
			this.btnYes.Text = "YES";
			this.btnYes.UseVisualStyleBackColor = true;
			this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
			// 
			// btnNo
			// 
			this.btnNo.Location = new System.Drawing.Point(152, 48);
			this.btnNo.Name = "btnNo";
			this.btnNo.Size = new System.Drawing.Size(75, 23);
			this.btnNo.TabIndex = 1;
			this.btnNo.Text = "NO";
			this.btnNo.UseVisualStyleBackColor = true;
			this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(68, 110);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Vill du att saker ska hända?";
			// 
			// YesOrNo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MintCream;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnNo);
			this.Controls.Add(this.btnYes);
			this.Name = "YesOrNo";
			this.Size = new System.Drawing.Size(272, 203);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnYes;
		private System.Windows.Forms.Button btnNo;
		private System.Windows.Forms.Label label1;
	}
}
