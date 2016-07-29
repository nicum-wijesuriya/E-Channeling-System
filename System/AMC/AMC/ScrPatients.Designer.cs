namespace AMC
{
	partial class ScrPatients
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
			this.dgvPatients = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvPatients
			// 
			this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPatients.Location = new System.Drawing.Point(12, 12);
			this.dgvPatients.MultiSelect = false;
			this.dgvPatients.Name = "dgvPatients";
			this.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPatients.Size = new System.Drawing.Size(736, 339);
			this.dgvPatients.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(673, 370);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Close";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ScrPatients
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(760, 409);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dgvPatients);
			this.Name = "ScrPatients";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Registered Patients";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScrPatients_FormClosing);
			this.Load += new System.EventHandler(this.ScrPatients_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvPatients;
		private System.Windows.Forms.Button button1;
	}
}