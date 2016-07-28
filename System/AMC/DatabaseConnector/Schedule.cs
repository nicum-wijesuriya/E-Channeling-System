using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnector
{
	public class Schedule
	{
		ParameterList parameterList = new ParameterList();
		private MySqlConnection con;

		public Schedule(MySqlConnection con)
		{
			this.con = con;
		}

		public MySqlCommand AddSchedule(String vDate, String vStartTime, String vEndTime,String vMaxPatients,String vStatus, String vDID)
		{
			parameterList.Add(new Parameter("vDate", vDate));
			parameterList.Add(new Parameter("vStartTime", vStartTime));
			parameterList.Add(new Parameter("vEndTime", vEndTime));
			parameterList.Add(new Parameter("vMaxPatients", vMaxPatients));
			parameterList.Add(new Parameter("vStatus", vStatus));
			parameterList.Add(new Parameter("vDID", vDID));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.con;
			command.CommandText = "AddSchedule";
			command.CommandType = CommandType.StoredProcedure;
			
			foreach(Parameter p in parameterList.List)
			{				
				command.Parameters.AddWithValue(p.ParameterName,p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			return command;
			
		}

		public MySqlCommand UpdateSchedule(String vSchID, String vDate, String vStartTime, String vEndTime, String vMaxPatients, String vDID)
		{
			parameterList.Add(new Parameter("vSchID", vSchID));
			parameterList.Add(new Parameter("vDate", vDate));
			parameterList.Add(new Parameter("vStartTime", vStartTime));
			parameterList.Add(new Parameter("vEndTime", vEndTime));
			parameterList.Add(new Parameter("vMaxPatients", vMaxPatients));			
			parameterList.Add(new Parameter("vDID", vDID));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.con;
			command.CommandText = "UpdateSchedule";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			return command;

		}

		public MySqlCommand CancelSchedule(String vSchID)
		{
			parameterList.Add(new Parameter("vSchID", vSchID));
			

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.con;
			command.CommandText = "CancelSchedule";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			return command;
		}

		public MySqlCommand SetScheduleStatus(String vSchID, String vStatus)
		{
			parameterList.Add(new Parameter("vSchID", vSchID));
			parameterList.Add(new Parameter("vStatus", vStatus));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.con;
			command.CommandText = "CancelSchedule";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			return command;
		}

		public MySqlCommand GetFreeSlotsForADay(String vDateToFind, String searchStartTime, String searchEndTime)
		{
			parameterList.Add(new Parameter("vDateToFind", vDateToFind));
			parameterList.Add(new Parameter("searchStartTime", searchStartTime));
			parameterList.Add(new Parameter("searchEndTime", searchEndTime));


			MySqlCommand command = new MySqlCommand();
			command.Connection = this.con;
			command.CommandText = "GetFreeSlotsForADay";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			return command;
		}

		public MySqlCommand SearchSchedule(String vDID, String startDate, String endDate)
		{
			parameterList.Add(new Parameter("vDID", vDID));
			parameterList.Add(new Parameter("startDate", startDate));
			parameterList.Add(new Parameter("endDate", endDate));


			MySqlCommand command = new MySqlCommand();
			command.Connection = this.con;
			command.CommandText = "SearchSchedules";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}
			//Console.WriteLine("Query : "+command.ToString());
			return command;
		}
	}
}
