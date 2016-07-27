namespace AMC
{
	partial class ScrHome
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnCancelAppointment = new System.Windows.Forms.Button();
			this.btnSetAppointment = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnUpdateSchedule = new System.Windows.Forms.Button();
			this.btnAddSchedule = new System.Windows.Forms.Button();
			this.btnRegister = new System.Windows.Forms.Button();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnCancelAppointment);
			this.groupBox2.Controls.Add(this.btnSetAppointment);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(37, 44);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(279, 261);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Patient";
			// 
			// btnCancelAppointment
			// 
			this.btnCancelAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelAppointment.Location = new System.Drawing.Point(44, 153);
			this.btnCancelAppointment.Name = "btnCancelAppointment";
			this.btnCancelAppointment.Size = new System.Drawing.Size(194, 30);
			this.btnCancelAppointment.TabIndex = 1;
			this.btnCancelAppointment.Text = "Cancel Appointment";
			this.btnCancelAppointment.UseVisualStyleBackColor = true;
			this.btnCancelAppointment.Click += new System.EventHandler(this.btnCancelAppointment_Click);
			// 
			// btnSetAppointment
			// 
			this.btnSetAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSetAppointment.Location = new System.Drawing.Point(44, 85);
			this.btnSetAppointment.Name = "btnSetAppointment";
			this.btnSetAppointment.Size = new System.Drawing.Size(194, 30);
			this.btnSetAppointment.TabIndex = 0;
			this.btnSetAppointment.Text = "Appointment";
			this.btnSetAppointment.UseVisualStyleBackColor = true;
			this.btnSetAppointment.Click += new System.EventHandler(this.btnSetAppointment_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnUpdateSchedule);
			this.groupBox3.Controls.Add(this.btnAddSchedule);
			this.groupBox3.Controls.Add(this.btnRegister);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(358, 44);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(279, 261);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Doctor";
			// 
			// btnUpdateSchedule
			// 
			this.btnUpdateSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdateSchedule.Location = new System.Drawing.Point(44, 188);
			this.btnUpdateSchedule.Name = "btnUpdateSchedule";
			this.btnUpdateSchedule.Size = new System.Drawing.Size(194, 30);
			this.btnUpdateSchedule.TabIndex = 2;
			this.btnUpdateSchedule.Text = "Update Schedule";
			this.btnUpdateSchedule.UseVisualStyleBackColor = true;
			this.btnUpdateSchedule.Click += new System.EventHandler(this.btnUpdateSchedule_Click);
			// 
			// btnAddSchedule
			// 
			this.btnAddSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddSchedule.Location = new System.Drawing.Point(44, 118);
			this.btnAddSchedule.Name = "btnAddSchedule";
			this.btnAddSchedule.Size = new System.Drawing.Size(194, 30);
			this.btnAddSchedule.TabIndex = 1;
			this.btnAddSchedule.Text = "Add Schedule";
			this.btnAddSchedule.UseVisualStyleBackColor = true;
			this.btnAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click);
			// 
			// btnRegister
			// 
			this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegister.Location = new System.Drawing.Point(44, 49);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(194, 30);
			this.btnRegister.TabIndex = 0;
			this.btnRegister.Text = "Register";
			this.btnRegister.UseVisualStyleBackColor = true;
			this.btnRegister.Click += new System.EventHandler(this.button1_Click);
			// 
			// ScrHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(666, 340);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Name = "ScrHome";
			this.Text = "Home";
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.Button btnCancelAppointment;
		private System.Windows.Forms.Button btnSetAppointment;
		private System.Windows.Forms.Button btnUpdateSchedule;
		private System.Windows.Forms.Button btnAddSchedule;


	}
}

