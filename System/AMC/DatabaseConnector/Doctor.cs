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

		public MySqlCommand AddDoctor(String vTitle, String vFName, String vLName, String vContact, String vEmail, String vFee)
		{

			parameterList.Add(new Parameter("vTitle", vTitle));
			parameterList.Add(new Parameter("vFname", vFName));
			parameterList.Add(new Parameter("vLname", vLName));
			parameterList.Add(new Parameter("vContact", vContact));
			parameterList.Add(new Parameter("vEmail", vEmail));
			parameterList.Add(new Parameter("vFee", vFee));





			MySqlCommand command = new MySqlCommand();
			command.Connection = this.con;
			command.CommandText = "AddDoctor";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			return command;

		}



		public MySqlCommand UpdateDoctor(String vDID, String vTitle, String vFName, String vLName, String vContact, String vEmail, String vFee)
		{

			parameterList.Add(new Parameter("vDID", vDID));
			parameterList.Add(new Parameter("vTitle", vTitle));
			parameterList.Add(new Parameter("vFname", vFName));
			parameterList.Add(new Parameter("vLname", vLName));
			parameterList.Add(new Parameter("vContact", vContact));
			parameterList.Add(new Parameter("vEmail", vEmail));
			parameterList.Add(new Parameter("vFee", vFee));





			MySqlCommand command = new MySqlCommand();
			command.Connection = this.con;
			command.CommandText = "UpdateDoctor";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			return command;

		}

		public MySqlCommand DeleteDoctor(String vDID)
		{

			parameterList.Add(new Parameter("vDID", vDID));
			
			MySqlCommand command = new MySqlCommand();
			command.Connection = this.con;
			command.CommandText = "DeleteDoctor";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			return command;

		}

		public MySqlCommand AvailableDoctors()
		{
			

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.con;
			command.CommandText = "AvailableDoctors";
			command.CommandType = CommandType.StoredProcedure;

			
			return command;
		}

		public MySqlCommand AvailableDoctorsForASpecialization(String vSID)
		{
			parameterList.Add(new Parameter("vSID", vSID));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.con;
			command.CommandText = "AvailableDoctorsForSpecialization";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			return command;
		}

		public MySqlCommand SpecializationForDoctor(String vDID)
		{
			parameterList.Add(new Parameter("vDID", vDID));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.con;
			command.CommandText = "SpecializationsForDoctor";
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
