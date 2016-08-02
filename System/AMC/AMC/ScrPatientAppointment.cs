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
	public partial class ScrPatientAppointment : Form
	{
		public ScrPatientAppointment()
		{
			InitializeComponent();
		}

		private void ScrPatientAppointment_Load(object sender, EventArgs e)
		{
			this.FillPatients();
		}

		private void FillPatients()
		{
			DBConnect db = DBConnect.Connect();

			Operator op = new Operator();

			MySqlDataReader rs = op.SelectAllPatients();


			if (rs != null)
			{
				this.dgvPatient.Rows.Clear();
				this.dgvPatient.Refresh();

				this.dgvPatient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				this.dgvPatient.ColumnCount = 7;
				this.dgvPatient.Columns[0].Name = "PID";
				this.dgvPatient.Columns[0].Visible = false;
				this.dgvPatient.Columns[1].Name = "Name";
				this.dgvPatient.Columns[2].Name = "Address";
				this.dgvPatient.Columns[3].Name = "E-Mail";
				this.dgvPatient.Columns[4].Name = "NIC No";
				this.dgvPatient.Columns[5].Name = "Mobile";
				this.dgvPatient.Columns[6].Name = "Home";


				if (rs == null)
				{
					Validation.valGeneral("No Patients Registered");
				}

				while (rs.Read())
				{
					String[] row = { rs.GetString(0), rs.GetString(1), rs.GetString(2), rs.GetString(3), rs.GetString(4), rs.GetString(5), rs.GetString(6) };

					this.dgvPatient.Rows.Add(row);
				}

				rs.Close();
			}
		}

		private void ScrPatientAppointment_FormClosing(object sender, FormClosingEventArgs e)
		{
			if(this.Tag.GetType() == typeof(ScrCancelAppointment))
			{
				
			}
		}
	}
}
