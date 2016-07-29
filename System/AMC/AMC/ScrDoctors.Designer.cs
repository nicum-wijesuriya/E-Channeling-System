namespace AMC
{
	partial class ScrDoctors
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
			this.dgvDoctors = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvDoctors
			// 
			this.dgvDoctors.AllowUserToAddRows = false;
			this.dgvDoctors.AllowUserToDeleteRows = false;
			this.dgvDoctors.AllowUserToResizeRows = false;
			this.dgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDoctors.Location = new System.Drawing.Point(28, 37);
			this.dgvDoctors.MultiSelect = false;
			this.dgvDoctors.Name = "dgvDoctors";
			this.dgvDoctors.ReadOnly = true;
			this.dgvDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDoctors.Size = new System.Drawing.Size(619, 269);
			this.dgvDoctors.TabIndex = 0;
			// 
			// ScrDoctors
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(675, 361);
			this.Controls.Add(this.dgvDoctors);
			this.Name = "ScrDoctors";
			this.Text = "ScrDoctors";
			((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvDoctors;
	}
}