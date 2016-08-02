namespace AMC
{
	partial class ScrPatientAppointment
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
			this.dgvPatient = new System.Windows.Forms.DataGridView();
			this.dgvAppointment = new System.Windows.Forms.DataGridView();
			this.grpPatients = new System.Windows.Forms.GroupBox();
			this.grpAppointment = new System.Windows.Forms.GroupBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lblSelectedReference = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).BeginInit();
			this.grpPatients.SuspendLayout();
			this.grpAppointment.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvPatient
			// 
			this.dgvPatient.AllowUserToAddRows = false;
			this.dgvPatient.AllowUserToDeleteRows = false;
			this.dgvPatient.AllowUserToResizeColumns = false;
			this.dgvPatient.AllowUserToResizeRows = false;
			this.dgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPatient.Location = new System.Drawing.Point(17, 28);
			this.dgvPatient.MultiSelect = false;
			this.dgvPatient.Name = "dgvPatient";
			this.dgvPatient.RowHeadersVisible = false;
			this.dgvPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPatient.Size = new System.Drawing.Size(838, 201);
			this.dgvPatient.TabIndex = 0;
			this.dgvPatient.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPatient_CellMouseClick);
			// 
			// dgvAppointment
			// 
			this.dgvAppointment.AllowUserToAddRows = false;
			this.dgvAppointment.AllowUserToDeleteRows = false;
			this.dgvAppointment.AllowUserToResizeColumns = false;
			this.dgvAppointment.AllowUserToResizeRows = false;
			this.dgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAppointment.Location = new System.Drawing.Point(19, 31);
			this.dgvAppointment.MultiSelect = false;
			this.dgvAppointment.Name = "dgvAppointment";
			this.dgvAppointment.RowHeadersVisible = false;
			this.dgvAppointment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvAppointment.Size = new System.Drawing.Size(838, 248);
			this.dgvAppointment.TabIndex = 0;
			this.dgvAppointment.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAppointment_CellMouseClick);
			// 
			// grpPatients
			// 
			this.grpPatients.Controls.Add(this.dgvPatient);
			this.grpPatients.Location = new System.Drawing.Point(12, 12);
			this.grpPatients.Name = "grpPatients";
			this.grpPatients.Size = new System.Drawing.Size(873, 261);
			this.grpPatients.TabIndex = 1;
			this.grpPatients.TabStop = false;
			this.grpPatients.Text = "Select Patient";
			// 
			// grpAppointment
			// 
			this.grpAppointment.Controls.Add(this.dgvAppointment);
			this.grpAppointment.Location = new System.Drawing.Point(10, 279);
			this.grpAppointment.Name = "grpAppointment";
			this.grpAppointment.Size = new System.Drawing.Size(874, 301);
			this.grpAppointment.TabIndex = 2;
			this.grpAppointment.TabStop = false;
			this.grpAppointment.Text = "Appointments";
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(113, 29);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 3;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(194, 29);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(792, 623);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 5;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(287, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Reference ID :";
			// 
			// lblSelectedReference
			// 
			this.lblSelectedReference.AutoSize = true;
			this.lblSelectedReference.Location = new System.Drawing.Point(372, 33);
			this.lblSelectedReference.Name = "lblSelectedReference";
			this.lblSelectedReference.Size = new System.Drawing.Size(53, 13);
			this.lblSelectedReference.TabIndex = 7;
			this.lblSelectedReference.Text = "label here";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(32, 28);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 8;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.lblSelectedReference);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.btnCancel);
			this.groupBox1.Controls.Add(this.btnUpdate);
			this.groupBox1.Location = new System.Drawing.Point(12, 590);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(459, 67);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Operations";
			// 
			// ScrPatientAppointment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(897, 669);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.grpAppointment);
			this.Controls.Add(this.grpPatients);
			this.Controls.Add(this.groupBox1);
			this.Name = "ScrPatientAppointment";
			this.Text = "ScrPatientAppointment";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScrPatientAppointment_FormClosing);
			this.Load += new System.EventHandler(this.ScrPatientAppointment_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).EndInit();
			this.grpPatients.ResumeLayout(false);
			this.grpAppointment.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvPatient;
		private System.Windows.Forms.DataGridView dgvAppointment;
		private System.Windows.Forms.GroupBox grpPatients;
		private System.Windows.Forms.GroupBox grpAppointment;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblSelectedReference;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}