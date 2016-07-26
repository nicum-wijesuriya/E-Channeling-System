using DatabaseConnector;
using MySql.Data.MySqlClient;
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
	public partial class ScrCancelAppointment : Form
	{
		private Boolean UpdateStatus;
		int currentDID;
		public ScrCancelAppointment()
		{
			InitializeComponent();
			this.ToggleUpdate(false);
			this.cmbSchedule.Items.Add(new ComboBoxItem("0","Select a Schedule"));
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void txtRefID_TextChanged(object sender, EventArgs e)
		{
			this.ToggleUpdate(false);
			DBConnect db = DBConnect.Connect();

			Appointment app = new Appointment(db.Connection);
			
			MySqlCommand cmd = app.FindAppointment(this.txtRefID.Text);
		
			MySqlDataReader rs = db.ExecuteProcedure(cmd, DBConnect.EXPECT_RESULT_SET);
			if (rs.Read())
			{

				this.lblPatientNIC.Text = rs.GetString(0);
				this.lblDoctorName.Text = rs.GetString(1);
				this.lblScheduleDate.Text = rs.GetString(2);
				this.lblScheduleTime.Text = rs.GetString(3);
				this.lblQueueNo.Text = rs.GetString(4);
				this.lblRoom.Text = rs.GetString(5);
				this.lblFee.Text = rs.GetString(6);
				this.currentDID = rs.GetInt32(7);

				rs.Close();
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DBConnect db = DBConnect.Connect();

			Appointment app = new Appointment(db.Connection);
			MySqlCommand cmd = app.CancelAppointment(this.txtRefID.Text);

			db.ExecuteProcedure(cmd, DBConnect.DOES_NOT_EXPECT_RESULT_SET);
		}

		private void ToggleUpdate(Boolean value)
		{
			this.cmbDoctor.Enabled = value;
			this.dtpStartDate.Enabled = value;
			this.dtpEndDate.Enabled = value;
			this.cmbSchedule.Enabled = value;
			this.UpdateStatus = value;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			this.ToggleUpdate(true);

			DBConnect db = DBConnect.Connect();

			Doctor doc = new Doctor(db.Connection);
			MySqlCommand cmd = doc.AvailableDoctors();

			MySqlDataReader rs = db.ExecuteProcedure(cmd, DBConnect.EXPECT_RESULT_SET);

			this.cmbDoctor.Items.Clear();

			this.cmbDoctor.Items.Add(new ComboBoxItem("0","All"));
			while(rs.Read())
			{
				ComboBoxItem item = new ComboBoxItem(rs.GetString(0),rs.GetString(1));
				this.cmbDoctor.Items.Add(item);
			}
			rs.Close();

			this.cmbDoctor.SelectedIndex = 0;

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			DBConnect db = DBConnect.Connect();

			Appointment app = new Appointment(db.Connection);
			String SchID = (String)this.cmbSchedule.SelectedValue ;
			
			MySqlCommand cmd = app.UpdateAppointment(this.txtRefID.Text, SchID);

			db.ExecuteProcedure(cmd, DBConnect.DOES_NOT_EXPECT_RESULT_SET);
		}

		private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.fillSchedule();
		}

		private void fillSchedule()
		{
			int DID;
			String startDate;
			String endDate;

			if (((ComboBoxItem)this.cmbDoctor.SelectedItem).Text.Equals("All"))
			{
				DID = -1;
			}
			else
			{
				Int32.TryParse(((ComboBoxItem)this.cmbDoctor.SelectedItem).Value, out DID);
			}

			startDate = this.dtpStartDate.Value.Date.Year + "-" + this.dtpStartDate.Value.Date.Month + "-" + this.dtpStartDate.Value.Date.Day;
			endDate = this.dtpEndDate.Value.Date.Year + "-" + this.dtpEndDate.Value.Date.Month + "-" + this.dtpEndDate.Value.Date.Day;

			DBConnect db = DBConnect.Connect();

			Schedule sch = new Schedule(db.Connection);
			String SchID = (String)this.cmbSchedule.SelectedValue;

			MySqlCommand cmd = sch.SearchSchedule(DID + "", startDate, endDate);

			MySqlDataReader rs = db.ExecuteProcedure(cmd, DBConnect.EXPECT_RESULT_SET);

			this.cmbSchedule.Items.Clear();
			this.cmbSchedule.Items.Add(new ComboBoxItem("0", "Select a Schedule"));
			while (rs.Read())
			{
				this.cmbSchedule.Items.Add(new ComboBoxItem(rs.GetString(0), rs.GetString(1)));
			}

			rs.Close();

			this.cmbSchedule.SelectedIndex = 0;
		}

		private void dtpStartDate_ValueChanged(object sender, EventArgs e)
		{
			this.fillSchedule();
		}

		private void dtpEndDate_ValueChanged(object sender, EventArgs e)
		{
			this.fillSchedule();
		}
	}
}
