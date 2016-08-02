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
		int RoomID;
		int count;
		public scrAddSchedule()
		{
			InitializeComponent();
			this.FillDoctor();
			RoomID = -1;
			count = 0;
			this.MaximizeBox = false;
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void dateTimePicker5_ValueChanged(object sender, EventArgs e)
		{
			//this.FillRoom();
		}

		private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
		{
			//this.FillRoom();
		}

		//private void FillRoom()
		//{
		//	DBConnect db = DBConnect.Connect();

		//	Schedule sch = new Schedule(db.Connection);
		//	String schDate = this.dtpDate.Value.Date.Year + "-" + this.dtpDate.Value.Date.Month + "-" + this.dtpDate.Value.Date.Day;			
		//	String searchStartTime = this.getTime(this.dtpTimeFrom.Value);
		//	String searchEndTime = this.getTime(this.dtpTimeTo.Value);

		//	MySqlCommand cmd = sch.FindRooms(schDate, searchStartTime, searchEndTime);

		//	MySqlDataReader rs = db.ExecuteProcedure(cmd, DBConnect.EXPECT_RESULT_SET);

		//	this.CmbRoom.Items.Clear();

		//	this.CmbRoom.Items.Add(new ComboBoxItem("0", "-Select a Room-"));
		//	while (rs.Read())
		//	{
		//		ComboBoxItem item = new ComboBoxItem(rs.GetString(0), rs.GetString(1));
		//		this.CmbRoom.Items.Add(item);
		//	}
		//	rs.Close();

		//	this.CmbRoom.SelectedIndex = 0;
		//}

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

			Operator op = new Operator();
			MySqlDataReader rs = op.AllDoctors();

			

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
			Operator op = new Operator();
			String schDate = this.dtpDate.Value.Date.Year + "-" + this.dtpDate.Value.Date.Month + "-" + this.dtpDate.Value.Date.Day;
			String searchStartTime = this.getTime(this.dtpTimeFrom.Value);
			String searchEndTime = this.getTime(this.dtpTimeTo.Value);
			MySqlDataReader rs =op.GetFreeSlotsForADay(schDate,searchStartTime,searchEndTime);

			if (rs == null)
			{
				Validation.valGeneral("No available Time Slots");
			}			
			else
			{
				this.dgvTimeSlots.Rows.Clear();
				this.dgvTimeSlots.Refresh();

				this.dgvTimeSlots.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				this.dgvTimeSlots.ColumnCount = 5;
				this.dgvTimeSlots.Columns[0].Name = "Date";
				this.dgvTimeSlots.Columns[1].Name = "Start Time";
				this.dgvTimeSlots.Columns[2].Name = "End Time";
				this.dgvTimeSlots.Columns[3].Name = "Room";
				this.dgvTimeSlots.Columns[4].Name = "Room ID";
				this.dgvTimeSlots.Columns[4].Visible = false;

				this.dgvTimeSlots.AllowUserToDeleteRows = false;
				this.dgvTimeSlots.AllowUserToAddRows = false;
				this.dgvTimeSlots.AllowUserToResizeRows = false;
				this.dgvTimeSlots.ReadOnly = true;


				while(rs.Read())
				{					
					DateTime date = Convert.ToDateTime(rs.GetString(0));

					if (!(rs.GetString(1).Equals(null) || rs.GetString(2).Equals(null)))
					{
						String dateValue = date.Year + "-" + date.Month + "-" + date.Day;
						String[] row = { dateValue, rs.GetString(1), rs.GetString(2), rs.GetString(3), rs.GetString(4) };
					
						this.dgvTimeSlots.Rows.Add(row);	
					}


				}
				
				rs.Close();
				//this.dgvTimeSlots.Rows[0].Selected = false;
				this.RoomID = -1;

			}
		}

		private void dtpTimeFrom_ValueChanged(object sender, EventArgs e)
		{
			
		}

		private void btnCheck_Click(object sender, EventArgs e)
		{
			this.FillAvailableTimeSlots();
			this.ActiveControl = this.btnAddSch;
			dgvTimeSlots.ClearSelection();


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

				if (dgvTimeSlots== null || dgvTimeSlots.SelectedRows == null)
				{
					Validation.valGeneral("Select a Time Slot");
				}
				DataGridViewRow row = this.dgvTimeSlots.SelectedRows[0];
				String RID = (String)row.Cells[4].Value;
				Int32.TryParse(RID, out this.RoomID);

				String sStartTime = (String)row.Cells[1].Value;
				String sEndTime = (String)row.Cells[2].Value;
				DateTime selectedStartTime = Convert.ToDateTime(sStartTime);
				DateTime selectedEndTime = Convert.ToDateTime(sEndTime);


				if (selectedStartTime > this.dtpScheduleFrom.Value)
				{
					Validation.valGeneral("Start Time is less than Selected start time");
				}

				if (selectedEndTime < this.dtpScheduleTo.Value)
				{
					Validation.valGeneral("End Time is higher than Selected End time");
				}

				//MessageBox.Show("Selected Room ID : " + RID);				
				Operator op = new Operator();

				MySqlDataReader rs  = op.AddSchedule(date, startTime, endTime, MaxPatients, Status + "", DID, RID);

				MessageBox.Show("Schedule Added!");
			}
			catch (Validation){ }
		}

		private void dgvTimeSlots_SelectionChanged(object sender, EventArgs e)
		{
			
		}

		private void btnShowAll_Click(object sender, EventArgs e)
		{
			ScrDoctors scr = new ScrDoctors();
			scr.Tag = this;
			scr.Show();
			this.Hide();
		}
	}
}
