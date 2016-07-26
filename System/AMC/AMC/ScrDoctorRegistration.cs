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
			res.Close();

			MessageBox.Show(""+SID);
		}
	}
}
