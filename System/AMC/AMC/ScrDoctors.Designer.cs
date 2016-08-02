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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScrDoctors));
			this.dgvDoctors = new System.Windows.Forms.DataGridView();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnSelect = new System.Windows.Forms.Button();
			this.lblTest = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvDoctors
			// 
			this.dgvDoctors.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
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
			this.dgvDoctors.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDoctors_CellMouseClick);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(572, 320);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnSelect
			// 
			this.btnSelect.Location = new System.Drawing.Point(28, 320);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(75, 23);
			this.btnSelect.TabIndex = 2;
			this.btnSelect.Text = "Select";
			this.btnSelect.UseVisualStyleBackColor = true;
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// lblTest
			// 
			this.lblTest.AutoSize = true;
			this.lblTest.Location = new System.Drawing.Point(173, 325);
			this.lblTest.Name = "lblTest";
			this.lblTest.Size = new System.Drawing.Size(0, 13);
			this.lblTest.TabIndex = 3;
			// 
			// ScrDoctors
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(675, 361);
			this.Controls.Add(this.lblTest);
			this.Controls.Add(this.btnSelect);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.dgvDoctors);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ScrDoctors";
			this.Text = "ScrDoctors";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScrDoctors_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvDoctors;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnSelect;
		private System.Windows.Forms.Label lblTest;
	}
}