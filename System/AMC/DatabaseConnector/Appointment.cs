using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnector
{
	public class Appointment
	{

		ParameterList parameterList = new ParameterList();
		private MySqlConnection con;

		public Appointment(MySqlConnection con)
		{
			this.con = con;
		}

		public MySqlCommand AddAppointment(String vPID, String	vSchID )
		{
			parameterList.Add(new Parameter("vPID", vPID));
			parameterList.Add(new Parameter("vSchID", vSchID));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.con;
			command.CommandText = "AddAppointment";
			command.CommandType = CommandType.StoredProcedure;
			
			foreach(Parameter p in parameterList.List)
			{				
				command.Parameters.AddWithValue(p.ParameterName,p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			return command;
			
		}

		public MySqlCommand UpdateAppointment(String vRefID, String vSchID)
		{
			parameterList.Add(new Parameter("vRefID", vRefID));
			parameterList.Add(new Parameter("vSchID", vSchID));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.con;
			command.CommandText = "UpdateAppointment";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			return command;

		}

		public MySqlCommand CancelAppointment(String vRefID)
		{
			parameterList.Add(new Parameter("vRefID", vRefID));
			
			MySqlCommand command = new MySqlCommand();
			command.Connection = this.con;
			command.CommandText = "CancelAppointment";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			return command;
		}

		public MySqlCommand CloseAppointment(String vRefID)
		{
			parameterList.Add(new Parameter("vRefID", vRefID));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.con;
			command.CommandText = "CloseAppointment";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			return command;
		}

		public MySqlCommand FindAppointment(String vRefID)
		{
			parameterList.Add(new Parameter("vRefID", vRefID));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.con;
			command.CommandText = "FindAppoinment";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			return command;
		}

		public MySqlCommand FindAppointmentByID(String vRefID)
		{
			parameterList.Add(new Parameter("vRefID", vRefID));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.con;
			command.CommandText = "FindAppointmentByID";
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
