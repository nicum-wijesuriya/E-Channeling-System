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

		public MySqlCommand AddDocSpec(String vDID, String vSID)
		{
			parameterList.Add(new Parameter("vDID", vDID));
			parameterList.Add(new Parameter("vSID", vSID));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.con;
			command.CommandText = "InsertDocSpec";
			command.CommandType = CommandType.StoredProcedure;
			
			foreach(Parameter p in parameterList.List)
			{				
				command.Parameters.AddWithValue(p.ParameterName,p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			return command;
			
		}

		public MySqlCommand UpdateDocSpec(String vDID, String oldSID, String newSID)
		{
			parameterList.Add(new Parameter("vDID", vDID));
			parameterList.Add(new Parameter("oldSID", oldSID));
			parameterList.Add(new Parameter("newSID", newSID));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.con;
			command.CommandText = "UpdateDoctorsSpeciality";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			return command;

		}
	}
}
