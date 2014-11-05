namespace Inloggningsruta
{
	partial class ShowUsersForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.userGrid = new System.Windows.Forms.DataGridView();
			this.quitBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.userGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// userGrid
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.LavenderBlush;
			this.userGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.userGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.userGrid.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.userGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.userGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.userGrid.DefaultCellStyle = dataGridViewCellStyle3;
			this.userGrid.Location = new System.Drawing.Point(12, 12);
			this.userGrid.Name = "userGrid";
			this.userGrid.RowHeadersVisible = false;
			this.userGrid.RowHeadersWidth = 40;
			this.userGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.userGrid.Size = new System.Drawing.Size(82, 200);
			this.userGrid.TabIndex = 0;
			// 
			// quitBtn
			// 
			this.quitBtn.Location = new System.Drawing.Point(13, 226);
			this.quitBtn.Name = "quitBtn";
			this.quitBtn.Size = new System.Drawing.Size(75, 23);
			this.quitBtn.TabIndex = 1;
			this.quitBtn.Text = "Avsluta";
			this.quitBtn.UseVisualStyleBackColor = true;
			this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
			// 
			// ShowUsersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(454, 261);
			this.Controls.Add(this.quitBtn);
			this.Controls.Add(this.userGrid);
			this.Name = "ShowUsersForm";
			this.Text = "ShowUsersForm";
			((System.ComponentModel.ISupportInitialize)(this.userGrid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView userGrid;
		private System.Windows.Forms.Button quitBtn;

	}
}