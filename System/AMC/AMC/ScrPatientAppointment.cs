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
		int row;
		int appRow;
		public ScrPatientAppointment()
		{
			InitializeComponent();
			row = -1;
			appRow = -1;
			this.lblSelectedReference.Text = "";
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
				if(this.Tag != null)
				{
					if (this.Tag.GetType() == typeof(ScrHome))
					{
						ScrHome scr = this.Tag as ScrHome;
						scr.Show();
					}
					else
					{
						ScrCancelAppointment scr = this.Tag as ScrCancelAppointment;
						scr.Show();
					}
					
				}
				
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	//	String SelectedRefID;
		private void dgvPatient_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			this.row = e.RowIndex;
			this.FillAppointments();	
		}
		private void FillAppointments()
		{
			try
			{
				if (row != -1)
				{
					Operator op = new Operator();


					this.dgvAppointment.Rows.Clear();
					this.dgvPatient.Refresh();

					this.dgvAppointment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
					this.dgvAppointment.ColumnCount = 7;
					this.dgvAppointment.Columns[0].Name = "RefID";
					this.dgvAppointment.Columns[0].Visible = false;
					this.dgvAppointment.Columns[1].Name = "Doctor";
					this.dgvAppointment.Columns[2].Name = "Date";
					this.dgvAppointment.Columns[3].Name = "Time";
					this.dgvAppointment.Columns[4].Name = "Queue Number";
					this.dgvAppointment.Columns[5].Name = "Fee";
					//	this.lblSelectedReference.Text = this.dgvPatient.Rows[row].Cells[0].Value as String;
					MySqlDataReader rs = op.FindAppointmentByPatient(this.dgvPatient.Rows[row].Cells[0].Value as String);
					if (rs == null || !rs.HasRows)
					{
						Validation.valGeneral("No Appoinments Avaialable");
					}

					while (rs.Read())
					{
						String[] DataGridRow = { rs.GetString(0), rs.GetString(1), rs.GetString(2), rs.GetString(3), rs.GetString(4), rs.GetString(5) };

						this.dgvAppointment.Rows.Add(DataGridRow);
					}

					rs.Close();

				}
			}
			catch (Validation)
			{
			}	
		}
		private void button1_Click(object sender, EventArgs e)
		{
			if(row != -1)
			{
				ScrSetAppointment scr = new ScrSetAppointment();
				this.Tag = null;
				scr.Tag = new ScrHome();
				scr.setNICNo(this.dgvPatient.Rows[row].Cells[4].Value as String);
				scr.CallBtnCheck();
				scr.Show();
				this.Close();
			}
			else
			{
				MessageBox.Show("Please Select a Patient");
			}
			
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if(appRow != -1)
			{
				if(this.Tag.GetType() == typeof(ScrCancelAppointment))
				{
					ScrCancelAppointment scr = this.Tag as ScrCancelAppointment;
					scr.setRefID(this.lblSelectedReference.Text = this.dgvAppointment.Rows[appRow].Cells[0].Value as String);
					scr.callUpdate();
				}
				else
				{
					ScrCancelAppointment scr =new ScrCancelAppointment();
					scr.setRefID(this.lblSelectedReference.Text = this.dgvAppointment.Rows[appRow].Cells[0].Value as String);
					scr.callUpdate();
					scr.Tag = this.Tag;
					this.Tag = scr;
				}
				

				this.Close();
			}
			else
			{
				MessageBox.Show("Please select a Appointment");
			}
		}

		private void dgvAppointment_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			this.appRow = e.RowIndex;
			if(appRow != -1)
			{
				this.lblSelectedReference.Text = this.dgvAppointment.Rows[appRow].Cells[0].Value as String;
			}
			
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			if(this.appRow != -1)
			{
				Operator op = new Operator();
				op.CancelAppointment(this.lblSelectedReference.Text = this.dgvAppointment.Rows[appRow].Cells[0].Value as String);
				this.RefereshDataGrids();
			}
			else
			{
				MessageBox.Show("Please select a Appointment");
			}
		}

		private void RefereshDataGrids()
		{
			this.FillPatients();			
			this.FillAppointments();
			this.row = -1;
			this.appRow = -1;
		}
	}
}
