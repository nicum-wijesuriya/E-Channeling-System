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

		private int sID;

		public int SID
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

		public Speciality(int SID, String name)
		{
			this.SID = SID;
			this.Name = name;
		}

		public MySqlCommand AddSpeciality(String vName)
		{

			parameterList.Add(new Parameter("vName", vName));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.con;
			command.CommandText = "AddSpeciality";
			command.CommandType = CommandType.StoredProcedure;
			
			foreach(Parameter p in parameterList.List)
			{				
				command.Parameters.AddWithValue(p.ParameterName,p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			return command;
			
		}

		public MySqlCommand UpdateSpeciality(String vSID, String vName)
		{
			parameterList.Add(new Parameter("vSID", vSID));
			parameterList.Add(new Parameter("vName", vName));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.con;
			command.CommandText = "UpdateSpeciality";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			return command;

		}

		public MySqlCommand DeleteSpeciality(String vSID)
		{
			parameterList.Add(new Parameter("vSID", vSID));			

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.con;
			command.CommandText = "DeleteSpeciality";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			return command;

		}

		public MySqlCommand GetSpeciality()
		{
			
			MySqlCommand command = new MySqlCommand();
			command.Connection = this.con;
			command.CommandText = "GetAllSpeciality";
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
