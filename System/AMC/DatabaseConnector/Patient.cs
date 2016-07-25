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
	public class Patient
	{
		ParameterList parameterList = new ParameterList();
		private MySqlConnection con;

		public Patient(MySqlConnection con)
		{
			this.con = con;
		}

		public MySqlCommand AddPatient(String vFName,String vLName,String vANumber,String vAStreet,String vACity,String vEmail,String vNICNo,String vTitle,
																												String vCMobile, String vCHome, String vIsLocal)
		{

			parameterList.Add(new Parameter("vFname", vFName));
			parameterList.Add(new Parameter("vLname", vLName));
			parameterList.Add(new Parameter("vANumber", vANumber));
			parameterList.Add(new Parameter("vAStreet", vAStreet));
			parameterList.Add(new Parameter("vACity", vACity));
			parameterList.Add(new Parameter("vEmail", vEmail));
			parameterList.Add(new Parameter("vNICNo", vNICNo));
			parameterList.Add(new Parameter("vTitle", vTitle));
			parameterList.Add(new Parameter("vCMobile", vCMobile));
			parameterList.Add(new Parameter("vCHome", vCHome));
			parameterList.Add(new Parameter("vIsLocal", vIsLocal));
			



			MySqlCommand command = new MySqlCommand();
			command.Connection = this.con;
			command.CommandText = "AddPatient";
			command.CommandType = CommandType.StoredProcedure;
			
			foreach(Parameter p in parameterList.List)
			{				
				command.Parameters.AddWithValue(p.ParameterName,p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			return command;
			
		}

		public MySqlCommand UpdatePatient(String vPID,String vFName, String vLName, String vANumber, String vAStreet, String vACity, String vEmail, String vNICNo, String vTitle,
																												String vCMobile, String vCHome, String vIsLocal)
		{
			parameterList.Add(new Parameter("vPID", vPID));
			parameterList.Add(new Parameter("vFname", vFName));
			parameterList.Add(new Parameter("vLname", vLName));
			parameterList.Add(new Parameter("vANumber", vANumber));
			parameterList.Add(new Parameter("vAStreet", vAStreet));
			parameterList.Add(new Parameter("vACity", vACity));
			parameterList.Add(new Parameter("vEmail", vEmail));
			parameterList.Add(new Parameter("vNICNo", vNICNo));
			parameterList.Add(new Parameter("vTitle", vTitle));
			parameterList.Add(new Parameter("vCMobile", vCMobile));
			parameterList.Add(new Parameter("vCHome", vCHome));
			parameterList.Add(new Parameter("vIsLocal", vIsLocal));




			MySqlCommand command = new MySqlCommand();
			command.Connection = this.con;
			command.CommandText = "UpdatePatient";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			return command;

		}

		public MySqlCommand DeletePatient(String vPID)
		{
			parameterList.Add(new Parameter("vPID", vPID));


			MySqlCommand command = new MySqlCommand();
			command.Connection = this.con;
			command.CommandText = "DeletePatient";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			return command;

		}

		public MySqlCommand RecoverPatient(String vPID)
		{
			parameterList.Add(new Parameter("vPID", vPID));


			MySqlCommand command = new MySqlCommand();
			command.Connection = this.con;
			command.CommandText = "RecoverPatient";
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
