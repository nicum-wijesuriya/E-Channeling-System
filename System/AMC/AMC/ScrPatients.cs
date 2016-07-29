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
	public partial class ScrPatients : Form
	{
		public ScrPatients()
		{
			InitializeComponent();
			this.dgvPatients.AllowUserToResizeColumns = false;
			this.dgvPatients.AllowUserToResizeRows = false;
		}

		private void ScrPatients_Load(object sender, EventArgs e)
		{
			this.FillPatients();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			this.Close();
		}

		private void ScrPatients_FormClosing(object sender, FormClosingEventArgs e)
		{
			Form scr = (ScrSetAppointment)this.Tag;
			scr.Show();
		}


		private void FillPatients()
		{
			DBConnect db = DBConnect.Connect();

			Operator op = new Operator(db.Connection);

			MySqlCommand cmd = op.SelectAllPatients();
			MySqlDataReader rs = db.ExecuteProcedure(cmd, DBConnect.EXPECT_RESULT_SET);

			if (rs != null)
			{
				this.dgvPatients.Rows.Clear();
				this.dgvPatients.Refresh();

				this.dgvPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				this.dgvPatients.ColumnCount = 7;
				this.dgvPatients.Columns[0].Name = "PID";
				this.dgvPatients.Columns[0].Visible = false;
				this.dgvPatients.Columns[1].Name = "Name";
				this.dgvPatients.Columns[2].Name = "Address";
				this.dgvPatients.Columns[3].Name = "E-Mail";
				this.dgvPatients.Columns[4].Name = "NIC No";
				this.dgvPatients.Columns[5].Name = "Mobile";
				this.dgvPatients.Columns[6].Name = "Home";


				if (rs == null)
				{
					Validation.valGeneral("No Patients Registered");
				}

				while (rs.Read())
				{
					String[] row = { rs.GetString(0), rs.GetString(1), rs.GetString(2), rs.GetString(3), rs.GetString(4), rs.GetString(5), rs.GetString(6) };

					this.dgvPatients.Rows.Add(row);
				}

				rs.Close();


			}
		}
	}
}
