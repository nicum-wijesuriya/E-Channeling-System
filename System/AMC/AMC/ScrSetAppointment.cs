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
	public partial class ScrSetAppointment : Form
	{
		Boolean isRegistered;
		int currentPID;
		public ScrSetAppointment()
		{
			InitializeComponent();
			this.isRegistered = false;
			this.FillDoctor();
			this.FillSpeciality();
			this.MaximizeBox = false;
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void radioButton9_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void btnCheck_Click(object sender, EventArgs e)
		{
			try
			{
				Validation.valEmptyField(txtNIC.Text, "Enter NIC / Passport Number");
				this.UpdatePatientFields();
			}
			catch (Validation) { }
		}

		public void UpdatePatientFields()
		{

			DBConnect db = DBConnect.Connect();

			Operator p = new Operator();

			MySqlDataReader rs = p.SelectPatient(this.txtNIC.Text);
			////Console.WriteLine("RS : "+rs);
			
			if (rs.Read())
			{
				this.isRegistered = true;
				this.currentPID = rs.GetInt32(0);
				String Title = rs.GetString(8);
				this.checkTitles(Title);
				this.txtFirstName.Text = rs.GetString(1);
				this.txtLastName.Text = rs.GetString(2);
				this.txtANumber.Text = rs.GetString(3);
				this.txtAStreet.Text = rs.GetString(4);
				this.txtACity.Text = rs.GetString(5);
				this.txtEmail.Text = rs.GetString(6);
				this.txtMobileNo.Text = rs.GetString(9);
				this.txtHomeNo.Text = rs.GetString(10);

				int isLocal = rs.GetInt32(11);
			
				////Console.WriteLine("IsLocal : "+ isLocal);
				if (isLocal == 1)
				{
					this.radioLocal.Checked = true;
				}
				else
				{
					this.radioForeign.Checked = true;
				}
			}
			else
			{
				this.isRegistered = false;
				this.currentPID = -1;
				this.ClearPatientFields();
			}
		}
		public void setNICNo(String NICNo)
		{
			this.txtNIC.Text = NICNo;
		}

		public void CallBtnCheck()
		{
			this.btnCheck_Click(this,new EventArgs());
		}
		public void ClearPatientFields()
		{
			this.radioDr.Checked = false;
			this.radioProf.Checked = false;
			this.radioMr.Checked = false;
			this.radioMrs.Checked = false;
			this.radioMs.Checked = false;
			this.radioRev.Checked = false;
			this.radioLocal.Checked = false;
			this.radioForeign.Checked = false;

			this.txtFirstName.Text = "";
			this.txtLastName.Text = "";
			this.txtACity.Text = "";
			this.txtANumber.Text = "";
			this.txtAStreet.Text = "";

			this.txtEmail.Text = "";
			this.txtMobileNo.Text = "";
			this.txtHomeNo.Text = "";
		}


		private void checkTitles(String Title)
		{
			String[] titleParts = Title.Split('.');
		

			if (titleParts.Length == 3)
			{
				switch (titleParts[0].Trim())
				{
					case "Prof":
						this.radioProf.Checked = true;
						break;
					case "Dr":
						this.radioDr.Checked = true;
						break;
				}
				switch (titleParts[1].Trim())
				{
					case "Mr":
						this.radioMr.Checked = true;
						break;
					case "Mrs":
						this.radioMrs.Checked = true;
						break;
					case "Ms":
						this.radioMs.Checked = true;
						break;
					case "Rev":
						this.radioRev.Checked = true;
						break;
				}
			}
			else
			{
				this.radioNone.Checked = true;
				switch (titleParts[0].Trim())
				{
					case "Mr":
						this.radioMr.Checked = true;
						break;
					case "Mrs":
						this.radioMrs.Checked = true;
						break;
					case "Ms":
						this.radioMs.Checked = true;
						break;
					case "Rev":
						this.radioRev.Checked = true;
						break;
				}
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			this.FillDoctor();
			this.fillSchedule();
			this.ClearPatientFields();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				if (cmbSchedule.SelectedIndex == 0)
				{
					Validation.valGeneral("Please select a Schedule");
				}
				
				bool check = false;
				foreach (RadioButton r1 in grpAcademicTitle.Controls)
				{
					if (r1.Checked)
					{
						check = true;
					}
				}

				if (check == false)
				{
					Validation.valGeneral("Please enter Academic Title");
				}

				check = false;
				foreach (RadioButton r1 in grpPersonalTitle.Controls)
				{
					if (r1.Checked)
					{
						check = true;
					}
				}

				if (check == false)
				{
					Validation.valGeneral("Please enter Personal Title");
				} 
				


				//Validation.valName(txtFirstName.Text, "Please fill First Name");
				//Validation.valName(txtLastName.Text, "Please fill Last Name");
				//Validation.valEmptyField(txtANumber.Text, "Please fill Address Number");
				//Validation.valEmptyField(txtAStreet.Text, "Please fill Street Name");
				//Validation.valEmptyField(txtACity.Text, "Please fill City");
				//Validation.valMobile(txtMobileNo.Text, "Invalid Mobile Number");
				//Validation.valLand(txtHomeNo.Text, "Invalid Home Number");
				//Validation.valEmail(txtEmail.Text);
				
				check = false;
				foreach (RadioButton r1 in pnlNationality.Controls)
				{
					if (r1.Checked)
					{
						check = true;
					}
				}

				if (check == false)
				{
					Validation.valGeneral("Please enter Nationality");
				}

				if (radioLocal.Checked && !this.isRegistered)
				{
					Validation.valNIC(txtNIC.Text);
				}
				else
				{
					Validation.valRegex(txtNIC.Text, @"[a-zA-Z0-9]{4,20}", "Invalid Passport No.");
				}

				SaveDetails();
				ClearPatientFields();

			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void SaveDetails()
		{
			try
			{

				String academicTitle;
				String personalTitle;
				String title;
				int isLocal;


				if (this.radioLocal.Checked)
				{
					isLocal = 1;
				}
				else
				{
					isLocal = 0;
				}

				if (this.radioProf.Checked)
				{
					academicTitle = "Prof.";
				}
				else if (this.radioDr.Checked)
				{
					academicTitle = "Dr.";
				}
				else
				{
					academicTitle = "";
				}

				if (this.radioRev.Checked)
				{
					personalTitle = "Rev.";
				}
				else if (this.radioMrs.Checked)
				{
					personalTitle = "Mrs.";
				}
				else if (this.radioMs.Checked)
				{
					personalTitle = "Ms.";
				}
				else
				{
					personalTitle = "Mr.";
				}
				title = academicTitle + personalTitle;
				//Console.WriteLine("\n\nTitle : " + title + " Length :" + title.Length + "\n\n");
				DBConnect db = DBConnect.Connect();
				if (this.isRegistered)
				{
					Operator op = new Operator();
					MySqlDataReader rs = op.UpdatePatient(this.currentPID + "", this.txtFirstName.Text, this.txtLastName.Text, this.txtANumber.Text, this.txtAStreet.Text,
						this.txtACity.Text, this.txtEmail.Text, this.txtNIC.Text, title, this.txtMobileNo.Text, this.txtHomeNo.Text, isLocal + "");
					//db.CloseConnection();
				}
				else
				{
					Operator op = new Operator();

					MySqlDataReader rs = op.AddPatient(this.txtFirstName.Text, this.txtLastName.Text, this.txtANumber.Text, this.txtAStreet.Text, this.txtACity.Text
							, this.txtEmail.Text, this.txtNIC.Text, title, this.txtMobileNo.Text, this.txtHomeNo.Text, isLocal + "");


					rs.Read();
					this.currentPID = rs.GetInt32(0);
					rs.Close();
					//db.CloseConnection();
				}
				db = DBConnect.Connect();
				Appointment app = new Appointment(db.Connection);
				MySqlCommand command = app.AddAppointment(this.currentPID + "", (this.cmbSchedule.SelectedItem as ComboBoxItem).Value);
				MySqlDataReader result = db.ExecuteProcedure(command, DBConnect.EXPECT_RESULT_SET);
				result.Read();

				String RefID = result.GetString(0);

				result.Close();
				//db.CloseConnection();
				try
				{

					db = DBConnect.Connect();
					command = app.FindAppointmentByID(RefID + "");
					result = db.ExecuteProcedure(command, DBConnect.EXPECT_RESULT_SET);
					result.Read();
					String userEmail = result.GetString(6);
					//MessageBox.Show("User Email : "+ userEmail);
					StringBuilder message = new StringBuilder();
					message.Append("\nRefference Number : " + RefID);
					message.Append("\n Doctor : " + result.GetString(1));
					message.Append("\n Date : " + result.GetString(2));
					message.Append("\n Time : " + result.GetString(3));
					message.Append("\n Queue No : " + result.GetString(4));
					message.Append("\n Fee : " + result.GetString(5));

					result.Close();
					db.CloseConnection();

					Validation.sendMail(userEmail, message.ToString(), Validation.PATIENT);
					MessageBox.Show("E-Mail Sent Successfully!");
				}
				catch (Exception)
				{
					MessageBox.Show("Failed to Send E-Mail!");
				}
			}
			catch (Validation)
			{
			}
			catch (MySqlException)
			{
				throw;
			}			
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

		private void FillSpeciality()
		{
			DBConnect db = DBConnect.Connect();

			Operator op = new Operator();
			MySqlDataReader rs = op.GetSpeciality();

			this.cmbSpec.Items.Clear();

			this.cmbSpec.Items.Add(new ComboBoxItem("0", "All"));
			while (rs.Read())
			{
				ComboBoxItem item = new ComboBoxItem(rs.GetString(0), rs.GetString(1));
				this.cmbSpec.Items.Add(item);
			}
			rs.Close();

			this.cmbSpec.SelectedIndex = 0;
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

			startDate = this.dtpDateFrom.Value.Date.Year + "-" + this.dtpDateFrom.Value.Date.Month + "-" + this.dtpDateFrom.Value.Date.Day;
			endDate = this.dtpDateTo.Value.Date.Year + "-" + this.dtpDateTo.Value.Date.Month + "-" + this.dtpDateTo.Value.Date.Day;

			
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

		private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.fillSchedule();
		}

		private void dtpDateFrom_ValueChanged(object sender, EventArgs e)
		{
			this.fillSchedule();
		}

		private void dtpDateTo_ValueChanged(object sender, EventArgs e)
		{
			this.fillSchedule();
		}

		private void txtNIC_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				this.UpdatePatientFields();
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			var scr = (ScrHome)Tag;
			scr.Show();
			this.Close();
		}

		private void ScrSetAppointment_FormClosing(object sender, FormClosingEventArgs e)
		{
			var scr = (ScrHome)Tag;
			scr.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ScrPatients scr = new ScrPatients();
			scr.Tag = this;
			scr.Show();
			this.Hide();
		}

		private void cmbDoctor_Click(object sender, EventArgs e)
		{
			cmbDoctor.DroppedDown = true;

		}

		private void cmbSpec_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void cmbSpec_Click(object sender, EventArgs e)
		{
			cmbSpec.DroppedDown = true;
		}

		private void cmbSchedule_Click(object sender, EventArgs e)
		{
			cmbSchedule.DroppedDown = true;
		}

		

	}
}
