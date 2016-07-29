using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;


namespace DatabaseConnector
{
	public class Doctor
	{
		ParameterList parameterList = new ParameterList();
		private MySqlConnection con;

		public Doctor(MySqlConnection con)
		{
			this.con = con;
		}



	}
}
