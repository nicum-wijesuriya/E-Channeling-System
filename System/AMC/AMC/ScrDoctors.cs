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
	public partial class ScrDoctors : Form
	{
		public ScrDoctors()
		{
			InitializeComponent();
			FillDoctor();

		}

		private void FillDoctor()
		{
			DBConnect db = DBConnect.Connect();

			Doctor doc = new Doctor(db.Connection);
			MySqlCommand cmd = doc.AllDoctors();

			MySqlDataReader rs = db.ExecuteProcedure(cmd, DBConnect.EXPECT_RESULT_SET);

			this.dgvDoctors.Rows.Clear();
			this.dgvDoctors.Refresh();

			this.dgvDoctors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDoctors.ColumnCount = 5;
			this.dgvDoctors.Columns[0].Name = "DID";
			this.dgvDoctors.Columns[1].Name = "Doctor";
			this.dgvDoctors.Columns[2].Name = "Contact No.";
			this.dgvDoctors.Columns[3].Name = "Email"; 
			this.dgvDoctors.Columns[4].Name = "Fee";


			while (rs.Read())
			{
				String[] row = { rs.GetString(0), rs.GetString(1), rs.GetString(2), rs.GetString(3), rs.GetString(4) };
				this.dgvDoctors.Rows.Add(row);
			}
			rs.Close();


			//this.dgvDoctors.Columns[1].Name = "Start Time";
			//this.dgvDoctors.Columns[2].Name = "End Time";
			
			
			//this.cmbDoctor.Items.Clear();

			//this.cmbDoctor.Items.Add(new ComboBoxItem("0", "-Select a Doctor-"));
			//while (rs.Read())
			//{
			//	ComboBoxItem item = new ComboBoxItem(rs.GetString(0), rs.GetString(1));
			//	this.cmbDoctor.Items.Add(item);
			//}
			//rs.Close();

			//this.cmbDoctor.SelectedIndex = 0;
		}
	}
}
