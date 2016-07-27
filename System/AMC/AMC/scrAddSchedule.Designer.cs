namespace AMC
{
	partial class scrAddSchedule
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
			this.dgvTimeSlots = new System.Windows.Forms.DataGridView();
			this.Doctor = new System.Windows.Forms.Label();
			this.cmbDoctor = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dtpTimeFrom = new System.Windows.Forms.DateTimePicker();
			this.btnCheck = new System.Windows.Forms.Button();
			this.dtpTimeTo = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtMaxPatients = new System.Windows.Forms.TextBox();
			this.dtpScheduleFrom = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.dtpScheduleTo = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvTimeSlots)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvTimeSlots
			// 
			this.dgvTimeSlots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTimeSlots.Location = new System.Drawing.Point(32, 19);
			this.dgvTimeSlots.Name = "dgvTimeSlots";
			this.dgvTimeSlots.Size = new System.Drawing.Size(514, 131);
			this.dgvTimeSlots.TabIndex = 0;
			// 
			// Doctor
			// 
			this.Doctor.AutoSize = true;
			this.Doctor.Location = new System.Drawing.Point(57, 54);
			this.Doctor.Name = "Doctor";
			this.Doctor.Size = new System.Drawing.Size(39, 13);
			this.Doctor.TabIndex = 1;
			this.Doctor.Text = "Doctor";
			// 
			// cmbDoctor
			// 
			this.cmbDoctor.FormattingEnabled = true;
			this.cmbDoctor.Location = new System.Drawing.Point(113, 51);
			this.cmbDoctor.Name = "cmbDoctor";
			this.cmbDoctor.Size = new System.Drawing.Size(189, 21);
			this.cmbDoctor.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(348, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Date";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// dtpDate
			// 
			this.dtpDate.Location = new System.Drawing.Point(409, 48);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(189, 20);
			this.dtpDate.TabIndex = 4;
			this.dtpDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dtpTimeFrom);
			this.groupBox1.Controls.Add(this.btnCheck);
			this.groupBox1.Controls.Add(this.dtpTimeTo);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(51, 95);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(574, 52);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Check Time";
			// 
			// dtpTimeFrom
			// 
			this.dtpTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtpTimeFrom.Location = new System.Drawing.Point(62, 19);
			this.dtpTimeFrom.Name = "dtpTimeFrom";
			this.dtpTimeFrom.ShowUpDown = true;
			this.dtpTimeFrom.Size = new System.Drawing.Size(130, 20);
			this.dtpTimeFrom.TabIndex = 5;
			// 
			// btnCheck
			// 
			this.btnCheck.Location = new System.Drawing.Point(465, 18);
			this.btnCheck.Name = "btnCheck";
			this.btnCheck.Size = new System.Drawing.Size(98, 21);
			this.btnCheck.TabIndex = 4;
			this.btnCheck.Text = "Check";
			this.btnCheck.UseVisualStyleBackColor = true;
			// 
			// dtpTimeTo
			// 
			this.dtpTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtpTimeTo.Location = new System.Drawing.Point(300, 18);
			this.dtpTimeTo.Name = "dtpTimeTo";
			this.dtpTimeTo.ShowUpDown = true;
			this.dtpTimeTo.Size = new System.Drawing.Size(130, 20);
			this.dtpTimeTo.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(244, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(20, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "To";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "From";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtMaxPatients);
			this.groupBox2.Controls.Add(this.dtpScheduleFrom);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.dtpScheduleTo);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Location = new System.Drawing.Point(51, 360);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(574, 52);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Schedule Details";
			// 
			// txtMaxPatients
			// 
			this.txtMaxPatients.Location = new System.Drawing.Point(498, 18);
			this.txtMaxPatients.Name = "txtMaxPatients";
			this.txtMaxPatients.Size = new System.Drawing.Size(49, 20);
			this.txtMaxPatients.TabIndex = 8;
			// 
			// dtpScheduleFrom
			// 
			this.dtpScheduleFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtpScheduleFrom.Location = new System.Drawing.Point(62, 19);
			this.dtpScheduleFrom.Name = "dtpScheduleFrom";
			this.dtpScheduleFrom.Size = new System.Drawing.Size(130, 20);
			this.dtpScheduleFrom.TabIndex = 3;
			this.dtpScheduleFrom.Visible = false;
			this.dtpScheduleFrom.ValueChanged += new System.EventHandler(this.dateTimePicker4_ValueChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(400, 21);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(92, 13);
			this.label6.TabIndex = 7;
			this.label6.Text = "Maximum Patients";
			// 
			// dtpScheduleTo
			// 
			this.dtpScheduleTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtpScheduleTo.Location = new System.Drawing.Point(247, 19);
			this.dtpScheduleTo.Name = "dtpScheduleTo";
			this.dtpScheduleTo.Size = new System.Drawing.Size(130, 20);
			this.dtpScheduleTo.TabIndex = 2;
			this.dtpScheduleTo.Visible = false;
			this.dtpScheduleTo.ValueChanged += new System.EventHandler(this.dateTimePicker5_ValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(217, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(20, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "To";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 21);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(30, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "From";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dgvTimeSlots);
			this.groupBox3.Location = new System.Drawing.Point(51, 163);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(574, 180);
			this.groupBox3.TabIndex = 7;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Available Time Slots";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(83, 419);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(93, 23);
			this.button1.TabIndex = 8;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(532, 419);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(93, 23);
			this.button2.TabIndex = 8;
			this.button2.Text = "Close";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// scrAddSchedule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(664, 480);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dtpDate);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbDoctor);
			this.Controls.Add(this.Doctor);
			this.Name = "scrAddSchedule";
			this.Text = "Add Schedule";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.scrAddSchedule_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.dgvTimeSlots)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvTimeSlots;
		private System.Windows.Forms.Label Doctor;
		private System.Windows.Forms.ComboBox cmbDoctor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpDate;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dtpTimeTo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DateTimePicker dtpScheduleFrom;
		private System.Windows.Forms.DateTimePicker dtpScheduleTo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnCheck;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtMaxPatients;
		private System.Windows.Forms.DateTimePicker dtpTimeFrom;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}