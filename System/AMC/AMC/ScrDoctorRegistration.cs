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

		public ScrDoctorRegistration()
		{
			InitializeComponent();
			this.FillSpeciality();
			//this.radioProf.Checked = false;
			this.radioDr.Checked = true;

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
				Validation.valMobile(contactNo, "");

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
						perTitle = r.Text;
					}
				}

				String title = "";

				if (perTitle == "Mr.")
				{
					title = acTitle;
				}
				else
				{
					title = acTitle + "(" + perTitle + ")";
				}

				if (selectedSpecList.Count == 0)
				{
					Validation.valGeneral("Please add Specialization(s)");
				}
				DBConnect db = DBConnect.Connect();
				Operator op = new Operator();
				MySqlDataReader rs = op.AddDoctor(title, fName, lName, contactNo, email, fee);

				rs.Read();
				int DID = rs.GetInt32(0);
				rs.Close();

				db = DBConnect.Connect();
				foreach (Speciality sp in selectedSpecList)
				{

					rs = op.AddDocSpec(DID + "", sp.SID);
					
				}

				scrAddSchedule scrSch = new scrAddSchedule();
				scrSch.Tag = this;
				scrSch.Show();
				this.Hide();			
			}
			catch (Validation ex) { }
		}

		private void btnNewSpec_Click(object sender, EventArgs e)
		{
			try
			{
				String newSpec = this.txtNewSpec.Text;

				Validation.valEmptyField(newSpec, "Specialization cannot be empty");

				DBConnect db = DBConnect.Connect();

				Operator op = new Operator();

				MySqlDataReader rs = op.AddSpeciality(newSpec);

			

				rs.Read();
				String SID = rs.GetString(0);
				String name = rs.GetString(1);
				rs.Close();

				selectedSpecList.Add(new Speciality(SID, name));
				FillSelectedSpec(SID, name);

				this.txtNewSpec.Text = "";
			}
			catch (Validation ex) { }

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
			var scr = (ScrHome)Tag;
			scr.Show();
			this.Close();
		}

		private void cmbSpec_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void FillSpeciality()
		{
			DBConnect db = DBConnect.Connect();

			Operator op = new Operator();
			MySqlDataReader rs = op.GetSpeciality();

			this.cmbSpec.Items.Clear();

			this.cmbSpec.Items.Add(new ComboBoxItem("0", "Select"));
			while (rs.Read())
			{
				ComboBoxItem item = new ComboBoxItem(rs.GetString(0), rs.GetString(1));
				this.cmbSpec.Items.Add(item);
			}
			rs.Close();

			this.cmbSpec.SelectedIndex = 0;


		}

		private void btnAddSpec_Click(object sender, EventArgs e)
		{
			try
			{
				if (cmbSpec.SelectedIndex == 0 || (ComboBoxItem)this.cmbSpec.SelectedItem == null)
				{
					Validation.valGeneral("Please select a Specialization");
				}

				String SID = ((ComboBoxItem)this.cmbSpec.SelectedItem).Value;
				String name = ((ComboBoxItem)this.cmbSpec.SelectedItem).Text;

				foreach (Speciality s in selectedSpecList) {
					if (s.SID == SID)
					{
						Validation.valGeneral("Specialization already added");
					}
				}
				selectedSpecList.Add(new Speciality(SID, name));
				FillSelectedSpec(SID, name);
				this.cmbSelectedSpec.SelectedIndex = 0;
			}
			catch (Validation ex) { }


		}

		private void FillSelectedSpec(String SID, String name)
		{
			this.cmbSelectedSpec.Items.Add(new ComboBoxItem(SID, name));
		}

		private void cmbSpec_SelectedIndexChanged_1(object sender, EventArgs e)
		{

		}

		private void btnRemoveSpec_Click(object sender, EventArgs e)
		{
			selectedSpecList.RemoveAt(this.cmbSelectedSpec.SelectedIndex);
			this.cmbSelectedSpec.Items.RemoveAt(this.cmbSelectedSpec.SelectedIndex);
		}

		private void ScrDoctorRegistration_FormClosing(object sender, FormClosingEventArgs e)
		{
			var scr = (ScrHome)Tag;
			scr.Show();
		}

		private void txtFirstName_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtFirstName_Enter(object sender, EventArgs e)
		{
			txtFirstName.Text = "";
		}

		private void txtLastName_Enter(object sender, EventArgs e)
		{
			txtLastName.Text = "";

		}


	}
}
