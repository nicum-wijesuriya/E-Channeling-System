namespace AMC
{
	partial class ScrDoctorRegistration
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScrDoctorRegistration));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.radioMr = new System.Windows.Forms.RadioButton();
			this.radioMrs = new System.Windows.Forms.RadioButton();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.txtContactNo = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtFee = new System.Windows.Forms.TextBox();
			this.cmbSpec = new System.Windows.Forms.ComboBox();
			this.btnRegister = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cmbNewSpec = new System.Windows.Forms.TextBox();
			this.btnClearSpec = new System.Windows.Forms.Button();
			this.btnNewSpec = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnRemoveSpec = new System.Windows.Forms.Button();
			this.btnAddSpec = new System.Windows.Forms.Button();
			this.cmbSelectedSpec = new System.Windows.Forms.ComboBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.radioMs = new System.Windows.Forms.RadioButton();
			this.radioProf = new System.Windows.Forms.RadioButton();
			this.radioDr = new System.Windows.Forms.RadioButton();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Title";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Name";
			this.label2.Click += new System.EventHandler(this.label1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(20, 143);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Contact No";
			this.label3.Click += new System.EventHandler(this.label1_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(20, 185);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "E-Mail";
			this.label4.Click += new System.EventHandler(this.label1_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(20, 226);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(79, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Fee per Patient";
			this.label5.Click += new System.EventHandler(this.label1_Click);
			// 
			// radioMr
			// 
			this.radioMr.AutoSize = true;
			this.radioMr.Location = new System.Drawing.Point(21, 19);
			this.radioMr.Name = "radioMr";
			this.radioMr.Size = new System.Drawing.Size(40, 17);
			this.radioMr.TabIndex = 1;
			this.radioMr.TabStop = true;
			this.radioMr.Text = "Mr.";
			this.radioMr.UseVisualStyleBackColor = true;
			// 
			// radioMrs
			// 
			this.radioMrs.AutoSize = true;
			this.radioMrs.Location = new System.Drawing.Point(88, 19);
			this.radioMrs.Name = "radioMrs";
			this.radioMrs.Size = new System.Drawing.Size(45, 17);
			this.radioMrs.TabIndex = 1;
			this.radioMrs.TabStop = true;
			this.radioMrs.Text = "Mrs.";
			this.radioMrs.UseVisualStyleBackColor = true;
			this.radioMrs.CheckedChanged += new System.EventHandler(this.radioMrs_CheckedChanged);
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(111, 101);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(140, 20);
			this.txtFirstName.TabIndex = 2;
			this.txtFirstName.Text = "First Name";
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(279, 101);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(214, 20);
			this.txtLastName.TabIndex = 2;
			this.txtLastName.Text = "Last Name";
			// 
			// txtContactNo
			// 
			this.txtContactNo.Location = new System.Drawing.Point(112, 138);
			this.txtContactNo.Name = "txtContactNo";
			this.txtContactNo.Size = new System.Drawing.Size(168, 20);
			this.txtContactNo.TabIndex = 2;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(112, 180);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(168, 20);
			this.txtEmail.TabIndex = 2;
			// 
			// txtFee
			// 
			this.txtFee.Location = new System.Drawing.Point(112, 221);
			this.txtFee.Name = "txtFee";
			this.txtFee.Size = new System.Drawing.Size(168, 20);
			this.txtFee.TabIndex = 2;
			// 
			// cmbSpec
			// 
			this.cmbSpec.FormattingEnabled = true;
			this.cmbSpec.Location = new System.Drawing.Point(14, 23);
			this.cmbSpec.Name = "cmbSpec";
			this.cmbSpec.Size = new System.Drawing.Size(252, 21);
			this.cmbSpec.TabIndex = 3;
			// 
			// btnRegister
			// 
			this.btnRegister.Location = new System.Drawing.Point(69, 263);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(99, 23);
			this.btnRegister.TabIndex = 4;
			this.btnRegister.Text = "Register";
			this.btnRegister.UseVisualStyleBackColor = true;
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(211, 263);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(99, 23);
			this.btnClear.TabIndex = 4;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(355, 263);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(99, 23);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox6);
			this.groupBox1.Controls.Add(this.groupBox5);
			this.groupBox1.Controls.Add(this.txtLastName);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtFirstName);
			this.groupBox1.Controls.Add(this.txtContactNo);
			this.groupBox1.Controls.Add(this.txtEmail);
			this.groupBox1.Controls.Add(this.txtFee);
			this.groupBox1.Controls.Add(this.btnCancel);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.btnRegister);
			this.groupBox1.Controls.Add(this.btnClear);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Location = new System.Drawing.Point(12, 23);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(500, 315);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Doctor Details";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cmbNewSpec);
			this.groupBox2.Controls.Add(this.btnClearSpec);
			this.groupBox2.Controls.Add(this.btnNewSpec);
			this.groupBox2.Controls.Add(this.groupBox3);
			this.groupBox2.Controls.Add(this.groupBox4);
			this.groupBox2.Location = new System.Drawing.Point(519, 23);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(307, 315);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Specialization";
			// 
			// cmbNewSpec
			// 
			this.cmbNewSpec.Location = new System.Drawing.Point(28, 226);
			this.cmbNewSpec.Name = "cmbNewSpec";
			this.cmbNewSpec.Size = new System.Drawing.Size(253, 20);
			this.cmbNewSpec.TabIndex = 0;
			this.cmbNewSpec.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
			// 
			// btnClearSpec
			// 
			this.btnClearSpec.Location = new System.Drawing.Point(205, 263);
			this.btnClearSpec.Name = "btnClearSpec";
			this.btnClearSpec.Size = new System.Drawing.Size(76, 23);
			this.btnClearSpec.TabIndex = 4;
			this.btnClearSpec.Text = "Clear";
			this.btnClearSpec.UseVisualStyleBackColor = true;
			// 
			// btnNewSpec
			// 
			this.btnNewSpec.Location = new System.Drawing.Point(29, 263);
			this.btnNewSpec.Name = "btnNewSpec";
			this.btnNewSpec.Size = new System.Drawing.Size(76, 23);
			this.btnNewSpec.TabIndex = 4;
			this.btnNewSpec.Text = "Add New";
			this.btnNewSpec.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.btnRemoveSpec);
			this.groupBox3.Controls.Add(this.btnAddSpec);
			this.groupBox3.Controls.Add(this.cmbSelectedSpec);
			this.groupBox3.Controls.Add(this.cmbSpec);
			this.groupBox3.Location = new System.Drawing.Point(12, 22);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(280, 160);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Currently Available Specializations";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(14, 82);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(122, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Selected Specializations";
			// 
			// btnRemoveSpec
			// 
			this.btnRemoveSpec.Location = new System.Drawing.Point(14, 128);
			this.btnRemoveSpec.Name = "btnRemoveSpec";
			this.btnRemoveSpec.Size = new System.Drawing.Size(79, 23);
			this.btnRemoveSpec.TabIndex = 4;
			this.btnRemoveSpec.Text = "Remove";
			this.btnRemoveSpec.UseVisualStyleBackColor = true;
			// 
			// btnAddSpec
			// 
			this.btnAddSpec.Location = new System.Drawing.Point(14, 50);
			this.btnAddSpec.Name = "btnAddSpec";
			this.btnAddSpec.Size = new System.Drawing.Size(79, 23);
			this.btnAddSpec.TabIndex = 4;
			this.btnAddSpec.Text = "Add";
			this.btnAddSpec.UseVisualStyleBackColor = true;
			// 
			// cmbSelectedSpec
			// 
			this.cmbSelectedSpec.FormattingEnabled = true;
			this.cmbSelectedSpec.Location = new System.Drawing.Point(14, 101);
			this.cmbSelectedSpec.Name = "cmbSelectedSpec";
			this.cmbSelectedSpec.Size = new System.Drawing.Size(252, 21);
			this.cmbSelectedSpec.TabIndex = 3;
			// 
			// groupBox4
			// 
			this.groupBox4.Location = new System.Drawing.Point(12, 196);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(280, 110);
			this.groupBox4.TabIndex = 6;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "New Specialization";
			// 
			// radioMs
			// 
			this.radioMs.AutoSize = true;
			this.radioMs.Location = new System.Drawing.Point(160, 19);
			this.radioMs.Name = "radioMs";
			this.radioMs.Size = new System.Drawing.Size(42, 17);
			this.radioMs.TabIndex = 5;
			this.radioMs.TabStop = true;
			this.radioMs.Text = "Ms.";
			this.radioMs.UseVisualStyleBackColor = true;
			// 
			// radioProf
			// 
			this.radioProf.AutoSize = true;
			this.radioProf.Location = new System.Drawing.Point(14, 19);
			this.radioProf.Name = "radioProf";
			this.radioProf.Size = new System.Drawing.Size(47, 17);
			this.radioProf.TabIndex = 1;
			this.radioProf.TabStop = true;
			this.radioProf.Text = "Prof.";
			this.radioProf.UseVisualStyleBackColor = true;
			this.radioProf.CheckedChanged += new System.EventHandler(this.radioProf_CheckedChanged);
			// 
			// radioDr
			// 
			this.radioDr.AutoSize = true;
			this.radioDr.Location = new System.Drawing.Point(84, 18);
			this.radioDr.Name = "radioDr";
			this.radioDr.Size = new System.Drawing.Size(39, 17);
			this.radioDr.TabIndex = 1;
			this.radioDr.TabStop = true;
			this.radioDr.Text = "Dr.";
			this.radioDr.UseVisualStyleBackColor = true;
			this.radioDr.CheckedChanged += new System.EventHandler(this.radioDr_CheckedChanged);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.radioDr);
			this.groupBox5.Controls.Add(this.radioProf);
			this.groupBox5.Location = new System.Drawing.Point(98, 31);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(144, 51);
			this.groupBox5.TabIndex = 6;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Acadamic Title";
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.radioMs);
			this.groupBox6.Controls.Add(this.radioMrs);
			this.groupBox6.Controls.Add(this.radioMr);
			this.groupBox6.Location = new System.Drawing.Point(257, 31);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(236, 51);
			this.groupBox6.TabIndex = 7;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Personal Title";
			// 
			// ScrDoctorRegistration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(838, 349);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ScrDoctorRegistration";
			this.Text = "Register Doctor";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RadioButton radioMr;
		private System.Windows.Forms.RadioButton radioMrs;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.TextBox txtContactNo;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtFee;
		private System.Windows.Forms.ComboBox cmbSpec;
		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox cmbNewSpec;
		private System.Windows.Forms.Button btnClearSpec;
		private System.Windows.Forms.Button btnNewSpec;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnRemoveSpec;
		private System.Windows.Forms.Button btnAddSpec;
		private System.Windows.Forms.ComboBox cmbSelectedSpec;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.RadioButton radioMs;
		private System.Windows.Forms.RadioButton radioDr;
		private System.Windows.Forms.RadioButton radioProf;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.GroupBox groupBox5;
	}
}