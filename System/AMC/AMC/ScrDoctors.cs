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
		ComboBoxItem SelectedDoctor;
		public ScrDoctors()
		{
			InitializeComponent();
			FillDoctor();
			row = -1;
			SelectedDoctor = null;
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
			Form scr;
			if(this.SelectedDoctor == null)
			{
				if (this.Tag.GetType() == typeof(scrAddSchedule))
				{
					scr = this.Tag as scrAddSchedule;
				}	
				else
				{
					scr = this.Tag as ScrHome;
				}				
			}
			else
			{
				
				//scr.SelectDoctor(this.SelectedDoctor);
				if (this.Tag.GetType() == typeof(ScrHome))
				{
					scr = new scrAddSchedule();
					scr.Tag = this.Tag as ScrHome;
				}
				else
				{
					scr = this.Tag as scrAddSchedule;
				}				
			}
			scr.Show();
		}

		private void dgvDoctors_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex != -1)
			{
				row = e.RowIndex;
			}

			this.dgvDoctors.Rows[row].Selected = true;

			this.SelectedDoctor = new ComboBoxItem(this.dgvDoctors.Rows[row].Cells[0].Value as String, this.dgvDoctors.Rows[row].Cells[1].Value as String);
			this.lblTest.Text = this.SelectedDoctor.ToString();
		}

		private void btnSelect_Click(object sender, EventArgs e)
		{
			if(this.SelectedDoctor != null)
			{
				this.Close();
			}
			else
			{
				MessageBox.Show("Please Select a Doctor from the List");
			}
			
		}
	}
}
