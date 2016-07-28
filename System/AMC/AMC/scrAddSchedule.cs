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
using System.Configuration;

namespace AMC
{
	public partial class scrAddSchedule : Form
	{
		public scrAddSchedule()
		{
			InitializeComponent();
			this.FillDoctor();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void dateTimePicker5_ValueChanged(object sender, EventArgs e)
		{

		}

		private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form scr = new Form();

			if (this.Tag.GetType() == typeof(ScrHome))
			{
				scr = (ScrHome)Tag;
			}

			if (this.Tag.GetType() == typeof(ScrDoctorRegistration))
			{
				scr = (ScrDoctorRegistration)Tag;
			}
			scr.Show();
			this.Close();
		}

		private void scrAddSchedule_FormClosing(object sender, FormClosingEventArgs e)
		{
			Form scr = new Form();

			if (this.Tag.GetType() == typeof(ScrHome))
			{
				scr = (ScrHome)Tag;
				scr.Show();
			}

			if (this.Tag.GetType() == typeof(ScrDoctorRegistration))
			{
				scr = (ScrDoctorRegistration)Tag;
				scr.Close();

			}
		}
		private void FillDoctor()
		{
			DBConnect db = DBConnect.Connect();

			Doctor doc = new Doctor(db.Connection);
			MySqlCommand cmd = doc.AllDoctors();

			MySqlDataReader rs = db.ExecuteProcedure(cmd, DBConnect.EXPECT_RESULT_SET);

			this.cmbDoctor.Items.Clear();

			this.cmbDoctor.Items.Add(new ComboBoxItem("0", "-Select a Doctor-"));
			while (rs.Read())
			{
				ComboBoxItem item = new ComboBoxItem(rs.GetString(0), rs.GetString(1));
				this.cmbDoctor.Items.Add(item);
			}
			rs.Close();

			this.cmbDoctor.SelectedIndex = 0;
		}

		private void FillAvailableTimeSlots()
		{

			DBConnect db = DBConnect.Connect();

			Schedule sch = new Schedule(db.Connection);
			String schDate = this.dtpDate.Value.Date.Year + "-" + this.dtpDate.Value.Date.Month + "-" + this.dtpDate.Value.Date.Day;
			//String searchStartTime = this.dtpTimeFrom.Value.Hour + "" + this.dtpTimeFrom.Value.Minute + "" + this.dtpTimeFrom.Value.Second;
			//String searchEndTime = this.dtpTimeTo.Value.Hour + "" + this.dtpTimeTo.Value.Minute + "" + this.dtpTimeTo.Value.Second;
			String searchStartTime = this.getTime(this.dtpTimeFrom.Value);
			String searchEndTime = this.getTime(this.dtpTimeTo.Value);
			MySqlCommand cmd = sch.GetFreeSlotsForADay(schDate,searchStartTime,searchEndTime);
		//	MessageBox.Show(searchStartTime + " End Time "+ searchEndTime);
			MySqlDataReader rs = db.ExecuteProcedure(cmd, DBConnect.EXPECT_RESULT_SET);
			if(rs!=null)
			{
				this.dgvTimeSlots.Rows.Clear();
				this.dgvTimeSlots.Refresh();

				this.dgvTimeSlots.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				this.dgvTimeSlots.ColumnCount = 4;
				this.dgvTimeSlots.Columns[0].Name = "Date";
				this.dgvTimeSlots.Columns[1].Name = "Start Time";
				this.dgvTimeSlots.Columns[2].Name = "End Time";
				this.dgvTimeSlots.Columns[3].Name = "Room";
				while(rs.Read())
				{
					//DataGridViewRow row = new DataGridViewRow();
					DateTime date = Convert.ToDateTime(rs.GetString(0));

					String dateValue = date.Year + "-" + date.Month + "-" + date.Day;
					String[] row = { dateValue, rs.GetString(1), rs.GetString(2), rs.GetString(3) };
					this.dgvTimeSlots.Rows.Add(row);	
				}
				
				rs.Close();
			}
		}

		private void dtpTimeFrom_ValueChanged(object sender, EventArgs e)
		{
			
		}

		private void btnCheck_Click(object sender, EventArgs e)
		{
			this.FillAvailableTimeSlots();
		}

		private String getTime(DateTime value)
		{
			int hours = value.Hour;
			int minutes = value.Minute;
			int seconds = value.Second;
			String output = "";
			if (hours < 10)
			{
				output += "0" + hours;
			}
			else
			{
				output += hours;
			}

			if(minutes < 10)
			{
				output += "0" + minutes;
			}
			else
			{
				output += minutes;
			}

			if (seconds < 10)
			{
				output += "0" + seconds;
			}
			else
			{
				output += seconds;
			}

			return output;
		}

		private void button1_Click(object sender, EventArgs e)
		{
		

		}

		private void btnAddSch_Click(object sender, EventArgs e)
		{
			try
			{
				if (cmbDoctor.SelectedIndex == 0 || (this.cmbDoctor.SelectedItem as ComboBoxItem) == null)
				{
					Validation.valGeneral("Please select a Doctor");
				}
				Validation.valMaxPatients(txtMaxPatients.Text);
				
				String date = this.dtpDate.Value.Year + "-" + this.dtpDate.Value.Month + "-" + this.dtpDate.Value.Day;
				String startTime = this.getTime(this.dtpScheduleFrom.Value);
				String endTime = this.getTime(this.dtpScheduleTo.Value);
				String DID = (this.cmbDoctor.SelectedItem as ComboBoxItem).Value;
				String MaxPatients = this.txtMaxPatients.Text;
				int Status = 2;
				DBConnect db = DBConnect.Connect();
				Schedule sch = new Schedule(db.Connection);

				MySqlCommand cmd = sch.AddSchedule(date,startTime,endTime,MaxPatients,Status + "",DID);
				db.ExecuteProcedure(cmd, DBConnect.DOES_NOT_EXPECT_RESULT_SET);

				MessageBox.Show("Schedule Added!");
			}
			catch (Validation ex){ }

		
		}
	}
}
