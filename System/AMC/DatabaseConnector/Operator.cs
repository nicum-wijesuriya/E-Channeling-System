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
		
		DBConnect db;

		public Operator ()
		{
			db = DBConnect.Connect();
		}

		public MySqlDataReader SelectAllPatients()
		{
			MySqlCommand command = new MySqlCommand();
			command.Connection = this.db.Connection;
			command.CommandText = "SelectAllPatients";
			command.CommandType = CommandType.StoredProcedure;
			MySqlDataReader rs = db.ExecuteProcedure(command, DBConnect.EXPECT_RESULT_SET);
			return rs;
		}

		public MySqlDataReader AddPatient(String vFName, String vLName, String vANumber, String vAStreet, String vACity, String vEmail, String vNICNo, String vTitle,
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
			command.Connection = this.db.Connection;
			command.CommandText = "AddPatient";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			MySqlDataReader rs = db.ExecuteProcedure(command, DBConnect.EXPECT_RESULT_SET);
			return rs;

		}

		public MySqlDataReader UpdatePatient(String vPID, String vFName, String vLName, String vANumber, String vAStreet, String vACity, String vEmail, String vNICNo, String vTitle,
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
			command.Connection = this.db.Connection;
			command.CommandText = "UpdatePatient";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			MySqlDataReader rs = db.ExecuteProcedure(command, DBConnect.DOES_NOT_EXPECT_RESULT_SET);
			return rs;
		}

		public MySqlDataReader DeletePatient(String vPID)
		{
			parameterList = new ParameterList();

			parameterList.Add(new Parameter("vPID", vPID));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.db.Connection;
			command.CommandText = "DeletePatient";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			MySqlDataReader rs = db.ExecuteProcedure(command, DBConnect.DOES_NOT_EXPECT_RESULT_SET);
			return rs;

		}

		public MySqlDataReader RecoverPatient(String vPID)
		{
			parameterList = new ParameterList();

			parameterList.Add(new Parameter("vPID", vPID));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.db.Connection;
			command.CommandText = "RecoverPatient";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			MySqlDataReader rs = db.ExecuteProcedure(command, DBConnect.DOES_NOT_EXPECT_RESULT_SET);
			return rs;

		}

		public MySqlDataReader SelectPatient(String vNICNo)
		{
			parameterList = new ParameterList();

			parameterList.Add(new Parameter("vNICNo", vNICNo));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.db.Connection;
			command.CommandText = "SelectPatient";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			MySqlDataReader rs = db.ExecuteProcedure(command, DBConnect.EXPECT_RESULT_SET);
			return rs;
		}

		public MySqlDataReader AddSchedule(String vDate, String vStartTime, String vEndTime, String vMaxPatients, String vStatus, String vDID, String vRoomID)
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
			command.Connection = this.db.Connection;
			command.CommandText = "AddSchedule";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			MySqlDataReader rs = db.ExecuteProcedure(command, DBConnect.DOES_NOT_EXPECT_RESULT_SET);
			return rs;

		}

		public MySqlDataReader UpdateSchedule(String vSchID, String vDate, String vStartTime, String vEndTime, String vMaxPatients, String vDID)
		{
			parameterList = new ParameterList();

			parameterList.Add(new Parameter("vSchID", vSchID));
			parameterList.Add(new Parameter("vDate", vDate));
			parameterList.Add(new Parameter("vStartTime", vStartTime));
			parameterList.Add(new Parameter("vEndTime", vEndTime));
			parameterList.Add(new Parameter("vMaxPatients", vMaxPatients));
			parameterList.Add(new Parameter("vDID", vDID));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.db.Connection;
			command.CommandText = "UpdateSchedule";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			MySqlDataReader rs = db.ExecuteProcedure(command, DBConnect.DOES_NOT_EXPECT_RESULT_SET);
			return rs;

		}

		public MySqlDataReader CancelSchedule(String vSchID)
		{
			parameterList = new ParameterList();

			parameterList.Add(new Parameter("vSchID", vSchID));


			MySqlCommand command = new MySqlCommand();
			command.Connection = this.db.Connection;
			command.CommandText = "CancelSchedule";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			MySqlDataReader rs = db.ExecuteProcedure(command, DBConnect.DOES_NOT_EXPECT_RESULT_SET);
			return rs;
		}

		public MySqlDataReader SetScheduleStatus(String vSchID, String vStatus)
		{
			parameterList = new ParameterList();

			parameterList.Add(new Parameter("vSchID", vSchID));
			parameterList.Add(new Parameter("vStatus", vStatus));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.db.Connection;
			command.CommandText = "CancelSchedule";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			MySqlDataReader rs = db.ExecuteProcedure(command, DBConnect.DOES_NOT_EXPECT_RESULT_SET);
			return rs;
		}

		public MySqlDataReader GetFreeSlotsForADay(String vDateToFind, String searchStartTime, String searchEndTime)
		{
			parameterList = new ParameterList();

			parameterList.Add(new Parameter("vDateToFind", vDateToFind));
			parameterList.Add(new Parameter("searchStartTime", searchStartTime));
			parameterList.Add(new Parameter("searchEndTime", searchEndTime));


			MySqlCommand command = new MySqlCommand();
			command.Connection = this.db.Connection;
			command.CommandText = "GetFreeSlotsForADay";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			MySqlDataReader rs = db.ExecuteProcedure(command, DBConnect.EXPECT_RESULT_SET);
			return rs;
		}


		public MySqlDataReader FindRooms(String vDateToFind, String searchStartTime, String searchEndTime)
		{
			parameterList = new ParameterList();

			parameterList.Add(new Parameter("vDateToFind", vDateToFind));
			parameterList.Add(new Parameter("searchStartTime", searchStartTime));
			parameterList.Add(new Parameter("searchEndTime", searchEndTime));


			MySqlCommand command = new MySqlCommand();
			command.Connection = this.db.Connection;
			command.CommandText = "FindRooms";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			MySqlDataReader rs = db.ExecuteProcedure(command, DBConnect.EXPECT_RESULT_SET);
			return rs;
		}

		public MySqlDataReader SearchSchedule(String vDID, String startDate, String endDate)
		{
			parameterList = new ParameterList();

			parameterList.Add(new Parameter("vDID", vDID));
			parameterList.Add(new Parameter("startDate", startDate));
			parameterList.Add(new Parameter("endDate", endDate));


			MySqlCommand command = new MySqlCommand();
			command.Connection = this.db.Connection;
			command.CommandText = "SearchSchedules";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}
			MySqlDataReader rs = db.ExecuteProcedure(command, DBConnect.EXPECT_RESULT_SET);
			return rs;
		}

		public MySqlDataReader AddSpeciality(String vName)
		{
			parameterList = new ParameterList();

			parameterList.Add(new Parameter("vName", vName));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.db.Connection;
			command.CommandText = "AddSpeciality";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			MySqlDataReader rs = db.ExecuteProcedure(command, DBConnect.EXPECT_RESULT_SET);
			return rs;
		}

		public MySqlDataReader UpdateSpeciality(String vSID, String vName)
		{
			parameterList = new ParameterList();
			parameterList.Add(new Parameter("vSID", vSID));
			parameterList.Add(new Parameter("vName", vName));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.db.Connection;
			command.CommandText = "UpdateSpeciality";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			MySqlDataReader rs = db.ExecuteProcedure(command, DBConnect.DOES_NOT_EXPECT_RESULT_SET);
			return rs;
		}

		public MySqlDataReader DeleteSpeciality(String vSID)
		{
			parameterList = new ParameterList();
			parameterList.Add(new Parameter("vSID", vSID));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.db.Connection;
			command.CommandText = "DeleteSpeciality";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			MySqlDataReader rs = db.ExecuteProcedure(command, DBConnect.DOES_NOT_EXPECT_RESULT_SET);
			return rs;

		}

		public MySqlDataReader GetSpeciality()
		{
			parameterList = new ParameterList();

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.db.Connection;
			command.CommandText = "GetAllSpeciality";
			command.CommandType = CommandType.StoredProcedure;

			MySqlDataReader rs = db.ExecuteProcedure(command, DBConnect.EXPECT_RESULT_SET);
			return rs;
		}

		public MySqlDataReader AddDoctor(String vTitle, String vFName, String vLName, String vContact, String vEmail, String vFee)
		{

			parameterList = new ParameterList();
			parameterList.Add(new Parameter("vTitle", vTitle));
			parameterList.Add(new Parameter("vFname", vFName));
			parameterList.Add(new Parameter("vLname", vLName));
			parameterList.Add(new Parameter("vContact", vContact));
			parameterList.Add(new Parameter("vEmail", vEmail));
			parameterList.Add(new Parameter("vFee", vFee));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.db.Connection;
			command.CommandText = "AddDoctor";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}
			try
			{
				MySqlDataReader rs = db.ExecuteProcedure(command, DBConnect.EXPECT_RESULT_SET);
				return rs;
			}
			catch (MySqlException)
			{
				throw;
			}
		}



		public MySqlDataReader UpdateDoctor(String vDID, String vTitle, String vFName, String vLName, String vContact, 
			String vEmail, String vFee)
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
			command.Connection = this.db.Connection;
			command.CommandText = "UpdateDoctor";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			MySqlDataReader rs = db.ExecuteProcedure(command, DBConnect.DOES_NOT_EXPECT_RESULT_SET);
			return rs;
		}

		public MySqlDataReader DeleteDoctor(String vDID)
		{
			parameterList = new ParameterList();
			parameterList.Add(new Parameter("vDID", vDID));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.db.Connection;
			command.CommandText = "DeleteDoctor";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			MySqlDataReader rs = db.ExecuteProcedure(command, DBConnect.DOES_NOT_EXPECT_RESULT_SET);
			return rs;
		}

		public MySqlDataReader AvailableDoctors()
		{
			
			MySqlCommand command = new MySqlCommand();
			command.Connection = this.db.Connection;
			command.CommandText = "AvailableDoctors";
			command.CommandType = CommandType.StoredProcedure;


			MySqlDataReader rs = db.ExecuteProcedure(command, DBConnect.EXPECT_RESULT_SET);
			return rs;
		}

		public MySqlDataReader AllDoctors()
		{
			MySqlCommand command = new MySqlCommand();
			command.Connection = this.db.Connection;
			command.CommandText = "AllDoctors";
			command.CommandType = CommandType.StoredProcedure;

			MySqlDataReader rs = db.ExecuteProcedure(command, DBConnect.EXPECT_RESULT_SET);
			return rs;
		}
		public MySqlDataReader AvailableDoctorsForASpecialization(String vSID)
		{
			parameterList = new ParameterList();
			parameterList.Add(new Parameter("vSID", vSID));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.db.Connection;
			command.CommandText = "AvailableDoctorsForSpecialization";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			MySqlDataReader rs = db.ExecuteProcedure(command, DBConnect.EXPECT_RESULT_SET);
			return rs;
		}

		public MySqlDataReader SpecializationForDoctor(String vDID)
		{
			parameterList = new ParameterList();
			parameterList.Add(new Parameter("vDID", vDID));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.db.Connection;
			command.CommandText = "SpecializationsForDoctor";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			MySqlDataReader rs = db.ExecuteProcedure(command, DBConnect.EXPECT_RESULT_SET);
			return rs;
		}

		public MySqlDataReader AddDocSpec(String vDID, String vSID)
		{
			parameterList = new ParameterList();
			parameterList.Add(new Parameter("vDID", vDID));
			parameterList.Add(new Parameter("vSID", vSID));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.db.Connection;
			command.CommandText = "InsertDocSpec";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			MySqlDataReader rs = db.ExecuteProcedure(command, DBConnect.DOES_NOT_EXPECT_RESULT_SET);
			return rs;

		}

		public MySqlDataReader UpdateDocSpec(String vDID, String oldSID, String newSID)
		{
			parameterList = new ParameterList();
			parameterList.Add(new Parameter("vDID", vDID));
			parameterList.Add(new Parameter("oldSID", oldSID));
			parameterList.Add(new Parameter("newSID", newSID));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.db.Connection;
			command.CommandText = "UpdateDoctorsSpeciality";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			MySqlDataReader rs = db.ExecuteProcedure(command, DBConnect.DOES_NOT_EXPECT_RESULT_SET);
			return rs;
		}
		public MySqlDataReader AddAppointment(String vPID, String vSchID)
		{
			parameterList.Add(new Parameter("vPID", vPID));
			parameterList.Add(new Parameter("vSchID", vSchID));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.db.Connection;
			command.CommandText = "AddAppointment";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			MySqlDataReader rs = db.ExecuteProcedure(command, DBConnect.DOES_NOT_EXPECT_RESULT_SET);
			return rs;
		}

		public MySqlDataReader UpdateAppointment(String vRefID, String vSchID)
		{
			parameterList.Add(new Parameter("vRefID", vRefID));
			parameterList.Add(new Parameter("vSchID", vSchID));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.db.Connection;
			command.CommandText = "UpdateAppointment";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			MySqlDataReader rs = db.ExecuteProcedure(command, DBConnect.DOES_NOT_EXPECT_RESULT_SET);
			return rs;
		}

		public MySqlDataReader CancelAppointment(String vRefID)
		{

			parameterList.Add(new Parameter("vRefID", vRefID));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.db.Connection;
			command.CommandText = "CancelAppointment";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			MySqlDataReader rs = db.ExecuteProcedure(command, DBConnect.DOES_NOT_EXPECT_RESULT_SET);
			return rs;
		}

		public MySqlDataReader CloseAppointment(String vRefID)
		{
			parameterList.Add(new Parameter("vRefID", vRefID));
			try
			{

				MySqlCommand command = new MySqlCommand();
				command.Connection = this.db.Connection;
				command.CommandText = "CloseAppointment";
				command.CommandType = CommandType.StoredProcedure;

				foreach (Parameter p in parameterList.List)
				{
					command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
					command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
				}
				MySqlDataReader rs = db.ExecuteProcedure(command, DBConnect.DOES_NOT_EXPECT_RESULT_SET);
				return rs;
			}
			catch (MySqlException ex)
			{
				Console.WriteLine(ex.ToString());
				return null;
			}

		}

		public MySqlDataReader FindAppointment(String vRefID)
		{
			parameterList.Add(new Parameter("vRefID", vRefID));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.db.Connection;
			command.CommandText = "FindAppoinment";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			MySqlDataReader rs = db.ExecuteProcedure(command, DBConnect.DOES_NOT_EXPECT_RESULT_SET);
			return rs;
		}

		public MySqlDataReader FindAppointmentByID(String vRefID)
		{
			parameterList.Add(new Parameter("vRefID", vRefID));

			MySqlCommand command = new MySqlCommand();
			command.Connection = this.db.Connection;
			command.CommandText = "FindAppointmentByID";
			command.CommandType = CommandType.StoredProcedure;

			foreach (Parameter p in parameterList.List)
			{
				command.Parameters.AddWithValue(p.ParameterName, p.ParameterValue);
				command.Parameters[p.ParameterName].Direction = ParameterDirection.Input;
			}

			MySqlDataReader rs = db.ExecuteProcedure(command, DBConnect.DOES_NOT_EXPECT_RESULT_SET);
			return rs;
		}
	}
}
