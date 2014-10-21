namespace WinFormsBlogFromScratch
{
	partial class FormMenu
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
		private void InitializeComponent(string name)
		{
			this.dataGridViewPosts = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosts)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewPosts
			// 
			this.dataGridViewPosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewPosts.Location = new System.Drawing.Point(12, 12);
			this.dataGridViewPosts.Name = "dataGridViewPosts";
			this.dataGridViewPosts.Size = new System.Drawing.Size(240, 150);
			this.dataGridViewPosts.TabIndex = 0;
			// 
			// FormMenu
			// 
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.dataGridViewPosts);
			this.Name = "FormMenu";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosts)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewPosts;
	}
}