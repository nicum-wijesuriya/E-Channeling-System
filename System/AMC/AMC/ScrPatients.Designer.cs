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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScrPatients));
			this.dgvPatients = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.lblTest = new System.Windows.Forms.Label();
			this.btnSelect = new System.Windows.Forms.Button();
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
			this.dgvPatients.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPatients_CellMouseClick);
			this.dgvPatients.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPatients_CellMouseDown);
			this.dgvPatients.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPatients_MouseClick);
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
			// lblTest
			// 
			this.lblTest.AutoSize = true;
			this.lblTest.Location = new System.Drawing.Point(449, 354);
			this.lblTest.Name = "lblTest";
			this.lblTest.Size = new System.Drawing.Size(35, 13);
			this.lblTest.TabIndex = 2;
			this.lblTest.Text = "label1";
			// 
			// btnSelect
			// 
			this.btnSelect.Location = new System.Drawing.Point(13, 358);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(75, 23);
			this.btnSelect.TabIndex = 3;
			this.btnSelect.Text = "Select";
			this.btnSelect.UseVisualStyleBackColor = true;
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// ScrPatients
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(760, 409);
			this.Controls.Add(this.btnSelect);
			this.Controls.Add(this.lblTest);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dgvPatients);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ScrPatients";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Registered Patients";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScrPatients_FormClosing);
			this.Load += new System.EventHandler(this.ScrPatients_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvPatients;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lblTest;
		private System.Windows.Forms.Button btnSelect;
	}
}