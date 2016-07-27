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
		public ScrSetAppointment()
		{
			InitializeComponent();
			this.isRegistered = false;
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
			this.UpdatePatientFields();
		}

		public void UpdatePatientFields()
		{

			DBConnect db = DBConnect.Connect();

			Patient p = new Patient(db.Connection);

			MySqlCommand cmd = p.SelectPatient(this.txtNIC.Text);

			MySqlDataReader rs = db.ExecuteProcedure(cmd, DBConnect.EXPECT_RESULT_SET);
			Console.WriteLine("RS : "+rs);
			
			if (rs.Read())
			{
				this.isRegistered = true;

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
			
				Console.WriteLine("IsLocal : "+ isLocal);
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
				this.ClearPatientFields();
			}
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

		private void fillDoctors()
		{
			
		}

		private void checkTitles(String Title)
		{
			String[] titleParts = Title.Split('.');
			Console.WriteLine(titleParts.Length);
			foreach (String val in titleParts)
			{
				Console.WriteLine("Title Part :"+val);
			}
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

		}
	}
}
