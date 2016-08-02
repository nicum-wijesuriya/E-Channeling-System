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
			((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).BeginInit();
			this.grpPatients.SuspendLayout();
			this.grpAppointment.SuspendLayout();
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
			this.dgvPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPatient.Size = new System.Drawing.Size(838, 201);
			this.dgvPatient.TabIndex = 0;
			// 
			// dgvAppointment
			// 
			this.dgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAppointment.Location = new System.Drawing.Point(19, 31);
			this.dgvAppointment.Name = "dgvAppointment";
			this.dgvAppointment.Size = new System.Drawing.Size(838, 248);
			this.dgvAppointment.TabIndex = 0;
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
			this.btnUpdate.Location = new System.Drawing.Point(29, 591);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 3;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(197, 591);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(792, 591);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 5;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			// 
			// ScrPatientAppointment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(897, 626);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.grpAppointment);
			this.Controls.Add(this.grpPatients);
			this.Name = "ScrPatientAppointment";
			this.Text = "ScrPatientAppointment";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScrPatientAppointment_FormClosing);
			this.Load += new System.EventHandler(this.ScrPatientAppointment_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).EndInit();
			this.grpPatients.ResumeLayout(false);
			this.grpAppointment.ResumeLayout(false);
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
	}
}