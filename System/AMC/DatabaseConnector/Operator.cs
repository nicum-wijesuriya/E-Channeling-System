using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnector
{
	public class Operator
	{
		ParameterList parameterList;
		MySqlConnection con;

		public Operator (MySqlConnection con)
		{
			this.con = con;
		}

		public MySqlCommand SelectAllPatients()
		{
			MySqlCommand command = new MySqlCommand();
			command.Connection = this.con;
			command.CommandText = "SelectAllPatients";
			command.CommandType = CommandType.StoredProcedure;

			return command;
		}

		public MySqlCommand AddPatient(String vFName, String vLName, String vANumber, String vAStreet, String vACity, String vEmail, String vNICNo, String vTitle,
																												String vCMobile, String vCHome, String vIsLocal)
		{
			parameterList = new ParameterList();

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

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			return command;

		}

		public MySqlCommand UpdatePatient(String vPID, String vFName, String vLName, String vANumber, String vAStreet, String vACity, String vEmail, String vNICNo, String vTitle,
																												String vCMobile, String vCHome, String vIsLocal)
		{
			parameterList = new ParameterList();

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
			parameterList = new ParameterList();

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
			parameterList = new ParameterList();

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

		public MySqlCommand SelectPatient(String vNICNo)
		{
			parameterList = new ParameterList();

			parameterList.Add(new Parameter("vNICNo", vNICNo));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.con;
			command.CommandText = "SelectPatient";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			return command;
		}

		public MySqlCommand AddSchedule(String vDate, String vStartTime, String vEndTime, String vMaxPatients, String vStatus, String vDID, String vRoomID)
		{
			parameterList = new ParameterList();

			parameterList.Add(new Parameter("vDate", vDate));
			parameterList.Add(new Parameter("vStartTime", vStartTime));
			parameterList.Add(new Parameter("vEndTime", vEndTime));
			parameterList.Add(new Parameter("vMaxPatients", vMaxPatients));
			parameterList.Add(new Parameter("vStatus", vStatus));
			parameterList.Add(new Parameter("vDID", vDID));
			parameterList.Add(new Parameter("vRoomID", vRoomID));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.con;
			command.CommandText = "AddSchedule";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			return command;

		}

		public MySqlCommand UpdateSchedule(String vSchID, String vDate, String vStartTime, String vEndTime, String vMaxPatients, String vDID)
		{
			parameterList = new ParameterList();

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
			parameterList = new ParameterList();

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
			parameterList = new ParameterList();

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
			parameterList = new ParameterList();

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


		public MySqlCommand FindRooms(String vDateToFind, String searchStartTime, String searchEndTime)
		{
			parameterList = new ParameterList();

			parameterList.Add(new Parameter("vDateToFind", vDateToFind));
			parameterList.Add(new Parameter("searchStartTime", searchStartTime));
			parameterList.Add(new Parameter("searchEndTime", searchEndTime));


			MySqlCommand command = new MySqlCommand();
			command.Connection = this.con;
			command.CommandText = "FindRooms";
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
			parameterList = new ParameterList();

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

		public MySqlCommand AddSpeciality(String vName)
		{
			parameterList = new ParameterList();

			parameterList.Add(new Parameter("vName", vName));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.con;
			command.CommandText = "AddSpeciality";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			return command;

		}

		public MySqlCommand UpdateSpeciality(String vSID, String vName)
		{
			parameterList = new ParameterList();
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
			parameterList = new ParameterList();
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
			parameterList = new ParameterList();

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.con;
			command.CommandText = "GetAllSpeciality";
			command.CommandType = CommandType.StoredProcedure;

			return command;
		}

		public MySqlCommand AddDoctor(String vTitle, String vFName, String vLName, String vContact, String vEmail, String vFee)
		{

			parameterList = new ParameterList();
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
			parameterList = new ParameterList();

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
			parameterList = new ParameterList();
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

		public MySqlCommand AllDoctors()
		{
			MySqlCommand command = new MySqlCommand();
			command.Connection = this.con;
			command.CommandText = "AllDoctors";
			command.CommandType = CommandType.StoredProcedure;

			return command;
		}
		public MySqlCommand AvailableDoctorsForASpecialization(String vSID)
		{
			parameterList = new ParameterList();
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
			parameterList = new ParameterList();
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

		public MySqlCommand AddDocSpec(String vDID, String vSID)
		{
			parameterList = new ParameterList();
			parameterList.Add(new Parameter("vDID", vDID));
			parameterList.Add(new Parameter("vSID", vSID));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.con;
			command.CommandText = "InsertDocSpec";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			return command;

		}

		public MySqlCommand UpdateDocSpec(String vDID, String oldSID, String newSID)
		{
			parameterList = new ParameterList();
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
