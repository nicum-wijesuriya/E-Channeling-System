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
			this.setPatientToDefault();
			this.ToggleUpdate(false);
			this.cmbSchedule.Items.Add(new ComboBoxItem("0","Select a Schedule"));
			this.MaximizeBox = false;
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void txtRefID_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			String refID = txtRefID.Text;
			DBConnect db = DBConnect.Connect();

			Appointment app = new Appointment(db.Connection);

			MySqlCommand cmd2 = app.FindAppointment(refID);

			MySqlDataReader rs = db.ExecuteProcedure(cmd2, DBConnect.EXPECT_RESULT_SET);

			try
			{
				Validation.valID(refID);
				if (rs.HasRows)
				{
					rs.Close();
					//db.CloseConnection();
					db = DBConnect.Connect();
						app = new Appointment(db.Connection);
						MySqlCommand cmd = app.CancelAppointment(this.txtRefID.Text);
						db.ExecuteProcedure(cmd, DBConnect.DOES_NOT_EXPECT_RESULT_SET);

						db.CloseConnection();
				}
				else
				{
					Validation.valGeneral("Invalid Reference ID");
				}

			}
			catch (Validation) { }
			

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
			String refID = txtRefID.Text;
			DBConnect db = DBConnect.Connect();

			Appointment app = new Appointment(db.Connection);
			MySqlCommand cmd = app.FindAppointment(refID);

			MySqlDataReader rs = db.ExecuteProcedure(cmd, DBConnect.EXPECT_RESULT_SET);

		try
			{
				Validation.valID(refID);
				if (rs.HasRows) 
				{
					this.ToggleUpdate(true);
					this.FillDoctor();					
				}
				else
				{
					Validation.valGeneral("Invalid Reference ID");
				}

			}
			catch {}

		}
		private void FillDoctor()
		{
		

			DBConnect db = DBConnect.Connect();

			Operator op = new Operator();
			MySqlDataReader rs = op.AvailableDoctors();

			this.cmbDoctor.Items.Clear();

			this.cmbDoctor.Items.Add(new ComboBoxItem("0", "All"));
			while (rs.Read())
			{
				ComboBoxItem item = new ComboBoxItem(rs.GetString(0), rs.GetString(1));
				this.cmbDoctor.Items.Add(item);
			}
			rs.Close();

			this.cmbDoctor.SelectedIndex = 0;
		}
		private void btnSave_Click(object sender, EventArgs e)
		{

			Operator op = new Operator();
			String SchID = ((ComboBoxItem)this.cmbSchedule.SelectedItem).Value;
			
		

			try
			{
				if (cmbSchedule.SelectedIndex == 0)
				{
					Validation.valGeneral("Please select a schedule");
				}
				else
				{
					MySqlDataReader rs = op.UpdateAppointment(this.txtRefID.Text, SchID);
					this.FillPatientDetails();
				}
			}
			catch (Validation) { }


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

			

			Operator op = new Operator();
			String SchID = (String)this.cmbSchedule.SelectedValue;

			MySqlDataReader rs = op.SearchSchedule(DID + "", startDate, endDate);

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

		private void ScrCancelAppointment_Load(object sender, EventArgs e)
		{

		}

		private void txtRefID_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				this.FillPatientDetails();
			}
		}

		private void setPatientToDefault()
		{
			this.lblPatientNIC.Text = "N/A";
			this.lblDoctorName.Text = "N/A";
			this.lblScheduleDate.Text = "N/A";
			this.lblScheduleTime.Text = "N/A";
			this.lblQueueNo.Text = "N/A";
			this.lblRoom.Text = "N/A";
			this.lblFee.Text = "N/A";
			this.currentDID = -1;
		}

		private void FillPatientDetails()
		{
			this.ToggleUpdate(false);
			DBConnect db = DBConnect.Connect();

			Appointment app = new Appointment(db.Connection);

			MySqlCommand cmd = app.FindAppointment(this.txtRefID.Text);

			MySqlDataReader rs = db.ExecuteProcedure(cmd, DBConnect.EXPECT_RESULT_SET);
			if (rs != null && rs.Read())
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
			else
			{
				this.setPatientToDefault();
			}
		}

		private void setUpdateSecToDefault()
		{

			this.fillSchedule();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			this.FillDoctor();
			this.ToggleUpdate(this.UpdateStatus);			
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
		try
			{
				String refID = txtRefID.Text;
				Validation.valID(refID);
				this.FillPatientDetails();

			}
			catch (Validation) { }

		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			var scr = (ScrHome)Tag;
			scr.Show();
			this.Close();
		}

		private void ScrCancelAppointment_FormClosing(object sender, FormClosingEventArgs e)
		{
			var scr = (ScrHome)Tag;
			scr.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ScrPatientAppointment scr = new ScrPatientAppointment();
			scr.Tag = this;			
			scr.Show();
			this.Hide();
		}
	}
}
