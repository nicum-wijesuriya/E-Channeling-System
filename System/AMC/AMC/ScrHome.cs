using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMC
{
	public partial class ScrHome : Form
	{
		public ScrHome()
		{
			InitializeComponent();
			this.MaximizeBox = false;
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ScrDoctorRegistration scr = new ScrDoctorRegistration();
			//scrDoc.Visible = true;
			//this.RemoveThis();
			scr.Tag = this;
			scr.Show(this);
			this.Hide();
			
		}

		private void btnAddSchedule_Click(object sender, EventArgs e)
		{
			scrAddSchedule scr = new scrAddSchedule();
			scr.Tag = this;
			scr.Show(this);
			this.Hide();
		}

		private void btnUpdateSchedule_Click(object sender, EventArgs e)
		{
			//Cancel the Schedule 
			//Inform all patients with that schedule

		}

		private void btnSetAppointment_Click(object sender, EventArgs e)
		{
			ScrSetAppointment scr = new ScrSetAppointment();
			scr.Tag = this;
			scr.Show(this);
			this.Hide();
			
		}

		private void btnCancelAppointment_Click(object sender, EventArgs e)
		{
			ScrCancelAppointment scr = new ScrCancelAppointment();
			scr.Tag = this;
			scr.Show(this);
			this.Hide();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{

		}

		private void btnDocDetails_Click(object sender, EventArgs e)
		{
			ScrDoctors scr = new ScrDoctors();
			scr.Tag = this;
			scr.Show(this);
			this.Hide();
		}

	
	}
}
