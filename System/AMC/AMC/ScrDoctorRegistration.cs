using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseConnector;
using MySql.Data.MySqlClient;

namespace AMC
{
	public partial class ScrDoctorRegistration : Form
	{
		List<Speciality> selectedSpecList = new List<Speciality>(); //Specialities selected by the doctor
		List<Speciality> specList = new List<Speciality>(); // All Specialities

		public ScrDoctorRegistration()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{

		}

		private void radioDr_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void radioProf_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void radioMrs_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			try
			{
				// start validation
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
				

				String fName = txtFirstName.Text;
				if (fName == "First Name")
				{
					Validation.valGeneral("Please fill First Name");
				}
				Validation.valEmptyField(fName, "Please fill First Name");

				String lName = txtLastName.Text;
				if (lName == "Last Name")
				{
					Validation.valGeneral("Please fill Last Name");
				}
				Validation.valEmptyField(lName, "Please fill Last Name");

				String contactNo = txtContactNo.Text;
				Validation.valMobile(contactNo);

				String email = txtEmail.Text;
				Validation.valEmail(email);

				String fee = txtFee.Text;
				Validation.valMoney(fee);

				// end validation

				String acTitle = "";
				foreach (RadioButton r in grpAcademicTitle.Controls)
				{
					if (r.Checked)
					{
						acTitle = r.Text;
					}
				}

				String perTitle = "";
				foreach (RadioButton r in grpPersonalTitle.Controls)
				{
					if (r.Checked)
					{
						acTitle = r.Text;
					}
				}

				String title = "";

				if (perTitle == "Mr.")
				{
					title = acTitle;
				}
				else
				{
					title = acTitle + " (" + perTitle + ")";
				}

				DBConnect db = DBConnect.Connect();

				Doctor doc = new Doctor(db.Connection);
				MySqlCommand cmd = doc.AddDoctor(title, fName, lName, contactNo, email, fee);

				ScrHome scrH = new ScrHome();
				scrH.Visible = true;
				this.Visible = false;
			}
			catch (Validation ex) { }
		}

		private void btnNewSpec_Click(object sender, EventArgs e)
		{
			String newSpec = this.txtNewSpec.Text;

			DBConnect db = DBConnect.Connect();

			Speciality spec = new Speciality(db.Connection);

			MySqlCommand cmd = spec.AddSpeciality(newSpec);

			MySqlDataReader res =  db.ExecuteProcedure(cmd, DBConnect.EXPECT_RESULT_SET);

			res.Read();
			int SID = res.GetInt32(0);
			String name = res.GetString(1);
			res.Close();

			selectedSpecList.Add(new Speciality(SID, name));


		}



		private void btnClearSpec_Click(object sender, EventArgs e)
		{
			this.txtNewSpec.Text = "";
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			radioProf.Checked = false;
			radioDr.Checked = false;
			radioMr.Checked = false;
			radioMrs.Checked = false;
			radioMs.Checked = false;
			txtFirstName.Text = "";
			txtLastName.Text = "";
			txtContactNo.Text = "";
			txtEmail.Text = "";
			txtFee.Text = "";
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			ScrHome scrH = new ScrHome();
			scrH.Visible = true;
			this.Visible = false;
		}

		private void cmbSpec_SelectedIndexChanged(object sender, EventArgs e)
		{


		}
	
		private void SearchSpeciality()
		{
			int SID;
			String name;

			
			DBConnect db = DBConnect.Connect();
			Speciality spec = new Speciality(db.Connection);

			MySqlCommand cmd = spec.GetAllSpeciality();
			MySqlDataReader rs = db.ExecuteProcedure(cmd, DBConnect.EXPECT_RESULT_SET);

			while (rs.Read())
			{
				SID = rs.GetInt32(0);
				name = rs.GetString(1);
				Speciality sp = new Speciality(SID, name);
				specList.Add(sp);
			}



		}
	}
}
