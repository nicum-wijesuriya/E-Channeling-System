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

		private int row;
		
		String SelectedNICNo;
		public ScrPatients()
		{
			InitializeComponent();
			this.dgvPatients.AllowUserToResizeColumns = false;
			this.dgvPatients.AllowUserToResizeRows = false;
			this.dgvPatients.AllowUserToDeleteRows = false;
			this.dgvPatients.AllowUserToAddRows = false;
			this.dgvPatients.ReadOnly = true;
			this.MaximizeBox = false;
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			row = -1;
			
			
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

			Operator op = new Operator();

			MySqlDataReader rs = op.SelectAllPatients();
			

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

		private void dgvPatients_MouseClick(object sender, MouseEventArgs e)
		{
			//if (e.Button == MouseButtons.Right)
			//{
			//	this.dgvPatients_RowContextMenuStripNeeded(sender, new DataGridViewRowContextMenuStripNeededEventArgs(this.dgvPatients.SelectedCells[0].RowIndex));
			//	//ContextMenu menu = new ContextMenu();
			//	//menu.MenuItems.Add("Opttion 1");
			//	//menu.MenuItems.Add("Opttion 2");
			//	//menu.MenuItems.Add("Opttion 3");

			//	//menu.Show(this.dgvPatients, new Point(e.X, e.Y));
			//}
		}

		private void dgvPatients_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			
		}

		private void dgvPatients_CellClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		

		private void dgvPatients_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			
				row = e.RowIndex;
				this.dgvPatients.Rows[row].Selected = true;

			//	ContextMenuStrip menu = new ContextMenuStrip();
			//	ToolStripMenuItem option1 = new ToolStripMenuItem("Option1");

			//	menu.Items.AddRange(new ToolStripItem[] { option1 });

			//	MessageBox.Show("Row : " + row);
			//	this.dgvPatients.ContextMenuStrip = menu;

				this.SelectedNICNo = dgvPatients.Rows[row].Cells[4].Value as String;
				this.lblTest.Text = this.SelectedNICNo;
				//MessageBox.Show(val);
				//this.dgvPatients.ContextMenuStrip.Show(e.X, e.Y);
			
		}

		private void btnSelect_Click(object sender, EventArgs e)
		{
			try
			{

				if (this.SelectedNICNo == null)
				{
					Validation.valGeneral("Please Select a Patient from the Table!");
				}


			}
			catch (Validation)	{	}
		}
	}
}
