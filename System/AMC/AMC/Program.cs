using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseConnector;

using MySql.Data.MySqlClient;

using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace AMC
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new ScrHome());
			//DBConnect db = DBConnect.Connect();
			
			//Patient p = new Patient(db.Connection);

		//	MySqlCommand cmd = p.AddPatient("as","ds","12","dascn","asd","nick@gmail.com", "911162580v", "Mr.", "0712583695","0112700556", "1");
		//	MySqlCommand cmd = p.UpdatePatient("2","ad", "ds", "12", "dascn", "asd", "nick@gmail.com", "911162580v", "Mr.", "0712583695", "0112700556", "1");
			//MySqlCommand cmd = p.DeletePatient("1");
			//db.ExecuteProcedure(cmd,1);

		}
	}
}
