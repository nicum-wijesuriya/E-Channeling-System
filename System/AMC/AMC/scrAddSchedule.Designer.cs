﻿namespace AMC
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scrAddSchedule));
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
			this.grpSchDetails = new System.Windows.Forms.GroupBox();
			this.txtMaxPatients = new System.Windows.Forms.TextBox();
			this.dtpScheduleFrom = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.dtpScheduleTo = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnAddSch = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btnShowAll = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvTimeSlots)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.grpSchDetails.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvTimeSlots
			// 
			this.dgvTimeSlots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTimeSlots.Location = new System.Drawing.Point(32, 30);
			this.dgvTimeSlots.MultiSelect = false;
			this.dgvTimeSlots.Name = "dgvTimeSlots";
			this.dgvTimeSlots.ReadOnly = true;
			this.dgvTimeSlots.RowHeadersVisible = false;
			this.dgvTimeSlots.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvTimeSlots.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvTimeSlots.Size = new System.Drawing.Size(514, 131);
			this.dgvTimeSlots.TabIndex = 0;
			this.dgvTimeSlots.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimeSlots_CellClick);
			this.dgvTimeSlots.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimeSlots_CellContentClick);
			this.dgvTimeSlots.SelectionChanged += new System.EventHandler(this.dgvTimeSlots_SelectionChanged);
			// 
			// Doctor
			// 
			this.Doctor.AutoSize = true;
			this.Doctor.Location = new System.Drawing.Point(12, 18);
			this.Doctor.Name = "Doctor";
			this.Doctor.Size = new System.Drawing.Size(39, 13);
			this.Doctor.TabIndex = 1;
			this.Doctor.Text = "Doctor";
			// 
			// cmbDoctor
			// 
			this.cmbDoctor.FormattingEnabled = true;
			this.cmbDoctor.Location = new System.Drawing.Point(68, 15);
			this.cmbDoctor.Name = "cmbDoctor";
			this.cmbDoctor.Size = new System.Drawing.Size(189, 21);
			this.cmbDoctor.TabIndex = 1;
			this.cmbDoctor.Click += new System.EventHandler(this.cmbDoctor_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(354, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Date";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// dtpDate
			// 
			this.dtpDate.Location = new System.Drawing.Point(390, 14);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(190, 20);
			this.dtpDate.TabIndex = 2;
			this.dtpDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dtpTimeFrom);
			this.groupBox1.Controls.Add(this.btnCheck);
			this.groupBox1.Controls.Add(this.dtpTimeTo);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(6, 50);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(574, 52);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Check Time";
			// 
			// dtpTimeFrom
			// 
			this.dtpTimeFrom.CustomFormat = "HH:mm";
			this.dtpTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpTimeFrom.Location = new System.Drawing.Point(62, 19);
			this.dtpTimeFrom.MinDate = new System.DateTime(2016, 7, 28, 8, 0, 0, 0);
			this.dtpTimeFrom.Name = "dtpTimeFrom";
			this.dtpTimeFrom.ShowUpDown = true;
			this.dtpTimeFrom.Size = new System.Drawing.Size(130, 20);
			this.dtpTimeFrom.TabIndex = 3;
			this.dtpTimeFrom.ValueChanged += new System.EventHandler(this.dtpTimeFrom_ValueChanged);
			// 
			// btnCheck
			// 
			this.btnCheck.BackColor = System.Drawing.SystemColors.Control;
			this.btnCheck.Location = new System.Drawing.Point(465, 18);
			this.btnCheck.Name = "btnCheck";
			this.btnCheck.Size = new System.Drawing.Size(98, 21);
			this.btnCheck.TabIndex = 5;
			this.btnCheck.Text = "Check";
			this.btnCheck.UseVisualStyleBackColor = false;
			this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
			// 
			// dtpTimeTo
			// 
			this.dtpTimeTo.CustomFormat = "HH:mm";
			this.dtpTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpTimeTo.Location = new System.Drawing.Point(300, 18);
			this.dtpTimeTo.Name = "dtpTimeTo";
			this.dtpTimeTo.ShowUpDown = true;
			this.dtpTimeTo.Size = new System.Drawing.Size(130, 20);
			this.dtpTimeTo.TabIndex = 4;
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
			// grpSchDetails
			// 
			this.grpSchDetails.Controls.Add(this.txtMaxPatients);
			this.grpSchDetails.Controls.Add(this.dtpScheduleFrom);
			this.grpSchDetails.Controls.Add(this.label6);
			this.grpSchDetails.Controls.Add(this.dtpScheduleTo);
			this.grpSchDetails.Controls.Add(this.label4);
			this.grpSchDetails.Controls.Add(this.label5);
			this.grpSchDetails.Location = new System.Drawing.Point(6, 305);
			this.grpSchDetails.Name = "grpSchDetails";
			this.grpSchDetails.Size = new System.Drawing.Size(574, 52);
			this.grpSchDetails.TabIndex = 6;
			this.grpSchDetails.TabStop = false;
			this.grpSchDetails.Text = "Schedule Details";
			// 
			// txtMaxPatients
			// 
			this.txtMaxPatients.Location = new System.Drawing.Point(383, 18);
			this.txtMaxPatients.Name = "txtMaxPatients";
			this.txtMaxPatients.Size = new System.Drawing.Size(47, 20);
			this.txtMaxPatients.TabIndex = 8;
			// 
			// dtpScheduleFrom
			// 
			this.dtpScheduleFrom.CustomFormat = "HH:mm";
			this.dtpScheduleFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpScheduleFrom.Location = new System.Drawing.Point(62, 19);
			this.dtpScheduleFrom.MinDate = new System.DateTime(2016, 7, 28, 8, 0, 0, 0);
			this.dtpScheduleFrom.Name = "dtpScheduleFrom";
			this.dtpScheduleFrom.ShowUpDown = true;
			this.dtpScheduleFrom.Size = new System.Drawing.Size(86, 20);
			this.dtpScheduleFrom.TabIndex = 6;
			this.dtpScheduleFrom.ValueChanged += new System.EventHandler(this.dateTimePicker4_ValueChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(286, 21);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(92, 13);
			this.label6.TabIndex = 7;
			this.label6.Text = "Maximum Patients";
			// 
			// dtpScheduleTo
			// 
			this.dtpScheduleTo.CustomFormat = "HH:mm";
			this.dtpScheduleTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpScheduleTo.Location = new System.Drawing.Point(189, 19);
			this.dtpScheduleTo.Name = "dtpScheduleTo";
			this.dtpScheduleTo.ShowUpDown = true;
			this.dtpScheduleTo.Size = new System.Drawing.Size(84, 20);
			this.dtpScheduleTo.TabIndex = 7;
			this.dtpScheduleTo.ValueChanged += new System.EventHandler(this.dateTimePicker5_ValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(161, 21);
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
			this.groupBox3.Location = new System.Drawing.Point(6, 108);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(574, 180);
			this.groupBox3.TabIndex = 7;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Select a  Time Slot";
			// 
			// btnAddSch
			// 
			this.btnAddSch.BackColor = System.Drawing.SystemColors.Control;
			this.btnAddSch.Location = new System.Drawing.Point(38, 364);
			this.btnAddSch.Name = "btnAddSch";
			this.btnAddSch.Size = new System.Drawing.Size(93, 23);
			this.btnAddSch.TabIndex = 9;
			this.btnAddSch.Text = "Add";
			this.btnAddSch.UseVisualStyleBackColor = false;
			this.btnAddSch.Click += new System.EventHandler(this.btnAddSch_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.Control;
			this.button2.Location = new System.Drawing.Point(487, 364);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(93, 23);
			this.button2.TabIndex = 10;
			this.button2.Text = "Close";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnShowAll
			// 
			this.btnShowAll.BackColor = System.Drawing.SystemColors.Control;
			this.btnShowAll.Location = new System.Drawing.Point(273, 12);
			this.btnShowAll.Name = "btnShowAll";
			this.btnShowAll.Size = new System.Drawing.Size(75, 24);
			this.btnShowAll.TabIndex = 11;
			this.btnShowAll.Text = "Doctor List";
			this.btnShowAll.UseVisualStyleBackColor = false;
			this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
			// 
			// scrAddSchedule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.ClientSize = new System.Drawing.Size(588, 399);
			this.Controls.Add(this.btnShowAll);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnAddSch);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.grpSchDetails);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dtpDate);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbDoctor);
			this.Controls.Add(this.Doctor);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "scrAddSchedule";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Schedule";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.scrAddSchedule_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.dgvTimeSlots)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.grpSchDetails.ResumeLayout(false);
			this.grpSchDetails.PerformLayout();
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
		private System.Windows.Forms.GroupBox grpSchDetails;
		private System.Windows.Forms.DateTimePicker dtpScheduleFrom;
		private System.Windows.Forms.DateTimePicker dtpScheduleTo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnCheck;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtMaxPatients;
		private System.Windows.Forms.DateTimePicker dtpTimeFrom;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnAddSch;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnShowAll;
	}
}