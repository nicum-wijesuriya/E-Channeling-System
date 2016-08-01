using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnector
{
	public class Doc_Spec
	{
		ParameterList parameterList = new ParameterList();
		private MySqlConnection con;

		public Doc_Spec(MySqlConnection con)
		{
			this.con = con;
		}

	}
}
