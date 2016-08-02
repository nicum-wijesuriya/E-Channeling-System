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
		int row;

		public ScrDoctors()
		{
			InitializeComponent();
			FillDoctor();
			row = -1;
		}

		private void FillDoctor()
		{
			Operator op = new Operator();
			MySqlDataReader rs = op.AllDoctors();

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


		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();

		}

		private void ScrDoctors_FormClosing(object sender, FormClosingEventArgs e)
		{
			var scr = (ScrHome)Tag;
			scr.Show();
		}

		private void dgvDoctors_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex != -1)
			{
				row = e.RowIndex;
			}

			this.dgvDoctors.Rows[row].Selected = true;

			this.SelectedNICNo = dgvPatients.Rows[row].Cells[4].Value as String;
			this.lblTest.Text = this.SelectedNICNo;
		}
	}
}
