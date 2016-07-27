namespace AMC
{
	partial class ScrCancelAppointment
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtRefID = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblPatientNIC = new System.Windows.Forms.Label();
			this.lblDoctorName = new System.Windows.Forms.Label();
			this.lblScheduleDate = new System.Windows.Forms.Label();
			this.lblScheduleTime = new System.Windows.Forms.Label();
			this.lblQueueNo = new System.Windows.Forms.Label();
			this.lblFee = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.lblRoom = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbDoctor = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
			this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbSchedule = new System.Windows.Forms.ComboBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Reference ID";
			// 
			// txtRefID
			// 
			this.txtRefID.Location = new System.Drawing.Point(101, 27);
			this.txtRefID.Name = "txtRefID";
			this.txtRefID.Size = new System.Drawing.Size(215, 20);
			this.txtRefID.TabIndex = 1;
			this.txtRefID.TextChanged += new System.EventHandler(this.txtRefID_TextChanged);
			this.txtRefID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRefID_KeyDown);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(328, 25);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(419, 25);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 2;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblPatientNIC);
			this.groupBox1.Controls.Add(this.lblDoctorName);
			this.groupBox1.Controls.Add(this.lblScheduleDate);
			this.groupBox1.Controls.Add(this.lblScheduleTime);
			this.groupBox1.Controls.Add(this.lblQueueNo);
			this.groupBox1.Controls.Add(this.lblFee);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.lblRoom);
			this.groupBox1.Controls.Add(this.label18);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Location = new System.Drawing.Point(27, 64);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(320, 262);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Appoinment Details";
			// 
			// lblPatientNIC
			// 
			this.lblPatientNIC.AutoSize = true;
			this.lblPatientNIC.Location = new System.Drawing.Point(146, 28);
			this.lblPatientNIC.Name = "lblPatientNIC";
			this.lblPatientNIC.Size = new System.Drawing.Size(61, 13);
			this.lblPatientNIC.TabIndex = 4;
			this.lblPatientNIC.Text = "Patient NIC";
			this.lblPatientNIC.Click += new System.EventHandler(this.label2_Click);
			// 
			// lblDoctorName
			// 
			this.lblDoctorName.AutoSize = true;
			this.lblDoctorName.Location = new System.Drawing.Point(146, 59);
			this.lblDoctorName.Name = "lblDoctorName";
			this.lblDoctorName.Size = new System.Drawing.Size(70, 13);
			this.lblDoctorName.TabIndex = 4;
			this.lblDoctorName.Text = "Doctor Name";
			this.lblDoctorName.Click += new System.EventHandler(this.label2_Click);
			// 
			// lblScheduleDate
			// 
			this.lblScheduleDate.AutoSize = true;
			this.lblScheduleDate.Location = new System.Drawing.Point(146, 90);
			this.lblScheduleDate.Name = "lblScheduleDate";
			this.lblScheduleDate.Size = new System.Drawing.Size(84, 13);
			this.lblScheduleDate.TabIndex = 4;
			this.lblScheduleDate.Text = "Scheduled Date";
			this.lblScheduleDate.Click += new System.EventHandler(this.label2_Click);
			// 
			// lblScheduleTime
			// 
			this.lblScheduleTime.AutoSize = true;
			this.lblScheduleTime.Location = new System.Drawing.Point(146, 121);
			this.lblScheduleTime.Name = "lblScheduleTime";
			this.lblScheduleTime.Size = new System.Drawing.Size(84, 13);
			this.lblScheduleTime.TabIndex = 4;
			this.lblScheduleTime.Text = "Scheduled Time";
			this.lblScheduleTime.Click += new System.EventHandler(this.label2_Click);
			// 
			// lblQueueNo
			// 
			this.lblQueueNo.AutoSize = true;
			this.lblQueueNo.Location = new System.Drawing.Point(146, 152);
			this.lblQueueNo.Name = "lblQueueNo";
			this.lblQueueNo.Size = new System.Drawing.Size(59, 13);
			this.lblQueueNo.TabIndex = 4;
			this.lblQueueNo.Text = "Queue No ";
			this.lblQueueNo.Click += new System.EventHandler(this.label2_Click);
			// 
			// lblFee
			// 
			this.lblFee.AutoSize = true;
			this.lblFee.Location = new System.Drawing.Point(146, 214);
			this.lblFee.Name = "lblFee";
			this.lblFee.Size = new System.Drawing.Size(25, 13);
			this.lblFee.TabIndex = 4;
			this.lblFee.Text = "Fee";
			this.lblFee.Click += new System.EventHandler(this.label2_Click);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(15, 214);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(25, 13);
			this.label16.TabIndex = 4;
			this.label16.Text = "Fee";
			this.label16.Click += new System.EventHandler(this.label2_Click);
			// 
			// lblRoom
			// 
			this.lblRoom.AutoSize = true;
			this.lblRoom.Location = new System.Drawing.Point(146, 183);
			this.lblRoom.Name = "lblRoom";
			this.lblRoom.Size = new System.Drawing.Size(35, 13);
			this.lblRoom.TabIndex = 4;
			this.lblRoom.Text = "Room";
			this.lblRoom.Click += new System.EventHandler(this.label2_Click);
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(15, 183);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(35, 13);
			this.label18.TabIndex = 4;
			this.label18.Text = "Room";
			this.label18.Click += new System.EventHandler(this.label2_Click);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(15, 152);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(59, 13);
			this.label14.TabIndex = 4;
			this.label14.Text = "Queue No ";
			this.label14.Click += new System.EventHandler(this.label2_Click);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(15, 121);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(84, 13);
			this.label12.TabIndex = 4;
			this.label12.Text = "Scheduled Time";
			this.label12.Click += new System.EventHandler(this.label2_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(15, 90);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(84, 13);
			this.label10.TabIndex = 4;
			this.label10.Text = "Scheduled Date";
			this.label10.Click += new System.EventHandler(this.label2_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(15, 59);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(70, 13);
			this.label8.TabIndex = 4;
			this.label8.Text = "Doctor Name";
			this.label8.Click += new System.EventHandler(this.label2_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(15, 28);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(81, 13);
			this.label6.TabIndex = 4;
			this.label6.Text = "Patient NIC No ";
			this.label6.Click += new System.EventHandler(this.label2_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(368, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Doctor";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// cmbDoctor
			// 
			this.cmbDoctor.FormattingEnabled = true;
			this.cmbDoctor.Location = new System.Drawing.Point(413, 81);
			this.cmbDoctor.Name = "cmbDoctor";
			this.cmbDoctor.Size = new System.Drawing.Size(294, 21);
			this.cmbDoctor.TabIndex = 5;
			this.cmbDoctor.SelectedIndexChanged += new System.EventHandler(this.cmbDoctor_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Start";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 52);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(26, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "End";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dtpEndDate);
			this.groupBox2.Controls.Add(this.dtpStartDate);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Location = new System.Drawing.Point(371, 108);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(336, 78);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Date";
			// 
			// dtpEndDate
			// 
			this.dtpEndDate.Location = new System.Drawing.Point(53, 46);
			this.dtpEndDate.Name = "dtpEndDate";
			this.dtpEndDate.Size = new System.Drawing.Size(267, 20);
			this.dtpEndDate.TabIndex = 7;
			this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
			// 
			// dtpStartDate
			// 
			this.dtpStartDate.Location = new System.Drawing.Point(53, 20);
			this.dtpStartDate.Name = "dtpStartDate";
			this.dtpStartDate.Size = new System.Drawing.Size(267, 20);
			this.dtpStartDate.TabIndex = 7;
			this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(368, 202);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Schedule";
			this.label5.Click += new System.EventHandler(this.label2_Click);
			// 
			// cmbSchedule
			// 
			this.cmbSchedule.FormattingEnabled = true;
			this.cmbSchedule.Location = new System.Drawing.Point(424, 199);
			this.cmbSchedule.Name = "cmbSchedule";
			this.cmbSchedule.Size = new System.Drawing.Size(283, 21);
			this.cmbSchedule.TabIndex = 5;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(395, 278);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(99, 25);
			this.btnSave.TabIndex = 8;
			this.btnSave.Text = "Save Changes";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(608, 278);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(99, 25);
			this.btnClear.TabIndex = 8;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			// 
			// ScrCancelAppointment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(719, 340);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.cmbSchedule);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cmbDoctor);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.txtRefID);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox2);
			this.Name = "ScrCancelAppointment";
			this.Text = "Cancel or Update Appointment";
			this.Load += new System.EventHandler(this.ScrCancelAppointment_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtRefID;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbDoctor;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DateTimePicker dtpEndDate;
		private System.Windows.Forms.DateTimePicker dtpStartDate;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbSchedule;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Label lblPatientNIC;
		private System.Windows.Forms.Label lblDoctorName;
		private System.Windows.Forms.Label lblScheduleDate;
		private System.Windows.Forms.Label lblScheduleTime;
		private System.Windows.Forms.Label lblQueueNo;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblFee;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label lblRoom;
		private System.Windows.Forms.Label label18;
	}
}