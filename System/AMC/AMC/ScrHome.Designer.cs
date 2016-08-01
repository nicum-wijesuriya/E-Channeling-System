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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScrHome));
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnCancelAppointment = new System.Windows.Forms.Button();
			this.btnSetAppointment = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnAddSchedule = new System.Windows.Forms.Button();
			this.btnRegister = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnDocDetails = new System.Windows.Forms.Button();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnCancelAppointment);
			this.groupBox2.Controls.Add(this.btnSetAppointment);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(33, 119);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(279, 270);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Patient";
			// 
			// btnCancelAppointment
			// 
			this.btnCancelAppointment.BackColor = System.Drawing.SystemColors.Control;
			this.btnCancelAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelAppointment.Location = new System.Drawing.Point(42, 161);
			this.btnCancelAppointment.Name = "btnCancelAppointment";
			this.btnCancelAppointment.Size = new System.Drawing.Size(194, 66);
			this.btnCancelAppointment.TabIndex = 1;
			this.btnCancelAppointment.Text = "Cancel Appointment";
			this.btnCancelAppointment.UseVisualStyleBackColor = false;
			this.btnCancelAppointment.Click += new System.EventHandler(this.btnCancelAppointment_Click);
			// 
			// btnSetAppointment
			// 
			this.btnSetAppointment.BackColor = System.Drawing.SystemColors.Control;
			this.btnSetAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSetAppointment.Location = new System.Drawing.Point(42, 57);
			this.btnSetAppointment.Name = "btnSetAppointment";
			this.btnSetAppointment.Size = new System.Drawing.Size(194, 66);
			this.btnSetAppointment.TabIndex = 0;
			this.btnSetAppointment.Text = "Appointment";
			this.btnSetAppointment.UseVisualStyleBackColor = false;
			this.btnSetAppointment.Click += new System.EventHandler(this.btnSetAppointment_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnAddSchedule);
			this.groupBox3.Controls.Add(this.btnRegister);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(354, 119);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(279, 270);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Doctor";
			// 
			// btnAddSchedule
			// 
			this.btnAddSchedule.BackColor = System.Drawing.SystemColors.Control;
			this.btnAddSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddSchedule.Location = new System.Drawing.Point(40, 161);
			this.btnAddSchedule.Name = "btnAddSchedule";
			this.btnAddSchedule.Size = new System.Drawing.Size(194, 66);
			this.btnAddSchedule.TabIndex = 1;
			this.btnAddSchedule.Text = "Add Schedule";
			this.btnAddSchedule.UseVisualStyleBackColor = false;
			this.btnAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click);
			// 
			// btnRegister
			// 
			this.btnRegister.BackColor = System.Drawing.SystemColors.Control;
			this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegister.Location = new System.Drawing.Point(40, 57);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(194, 66);
			this.btnRegister.TabIndex = 0;
			this.btnRegister.Text = "Register";
			this.btnRegister.UseVisualStyleBackColor = false;
			this.btnRegister.Click += new System.EventHandler(this.button1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(33, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(112, 111);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(151, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(500, 46);
			this.label1.TabIndex = 4;
			this.label1.Text = "ACME MEDICAL CENTER";
			// 
			// btnDocDetails
			// 
			this.btnDocDetails.BackColor = System.Drawing.SystemColors.Control;
			this.btnDocDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDocDetails.Location = new System.Drawing.Point(394, 405);
			this.btnDocDetails.Name = "btnDocDetails";
			this.btnDocDetails.Size = new System.Drawing.Size(194, 66);
			this.btnDocDetails.TabIndex = 6;
			this.btnDocDetails.Text = "Doctor Details";
			this.btnDocDetails.UseVisualStyleBackColor = false;
			this.btnDocDetails.Click += new System.EventHandler(this.btnDocDetails_Click);
			// 
			// ScrHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(659, 504);
			this.Controls.Add(this.btnDocDetails);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ScrHome";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Home";
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.Button btnCancelAppointment;
		private System.Windows.Forms.Button btnSetAppointment;
		private System.Windows.Forms.Button btnAddSchedule;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnDocDetails;


	}
}

