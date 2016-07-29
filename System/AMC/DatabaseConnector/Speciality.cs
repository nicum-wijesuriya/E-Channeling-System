using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnector
{
	public class Speciality
	{
		ParameterList parameterList = new ParameterList();
		private MySqlConnection con;

		private String sID;

		public String SID
		{
			get { return sID; }
			set { sID = value; }
		}

		private String name;

		public String Name
		{
			get { return name; }
			set { name = value; }
		}

		public Speciality(MySqlConnection con)
		{
			this.con = con;
		}

		public Speciality(String SID, String name)
		{
			this.SID = SID;
			this.Name = name;
		}

		
	}
}
