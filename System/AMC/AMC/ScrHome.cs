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
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ScrDoctorRegistration scrDoc = new ScrDoctorRegistration();
			scrDoc.Visible = true;
			this.Visible = false;
		}

		private void btnAddSchedule_Click(object sender, EventArgs e)
		{
			scrAddSchedule scr = new scrAddSchedule();
			scr.Visible = true;
			this.Visible = false;
		}

		private void btnUpdateSchedule_Click(object sender, EventArgs e)
		{
			//Cancel the Schedule 
			//Inform all patients with that schedule

		}

		private void btnSetAppointment_Click(object sender, EventArgs e)
		{
			ScrSetAppointment scr = new ScrSetAppointment();
			scr.Visible = true;
			this.Visible = false;
		}

		private void btnCancelAppointment_Click(object sender, EventArgs e)
		{
			ScrCancelAppointment scr = new ScrCancelAppointment();
			scr.Visible = true;
			this.Visible = false;
		}
	}
}
