using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net.Mail;

namespace AMC
{
	class Validation : ApplicationException
	{
		private static int errorcode;
		private static String errorMsg;
		public const int PATIENT = 1;
		public const int DOCTOR = 2;

		public Validation(int errorcode)
		{
			switch (errorcode)
			{
				case 0:
					if (errorMsg == "")
					{
						errorMsg = "Invalid Entry";
					}
					MessageBox.Show(errorMsg);
					break;
				case 1:
					if (errorMsg == "")
					{
						errorMsg = "Invalid Entry";
					}
					MessageBox.Show(errorMsg);
					break;
				case 2:
					if (errorMsg == "")
					{
						errorMsg = "Invalid Phone number";
					}
					MessageBox.Show(errorMsg);
					break;
				case 3:
					errorMsg = "Invalid ID";
					MessageBox.Show(errorMsg);
					break;
				case 4:
					errorMsg = "Invalid NIC Number";
					MessageBox.Show(errorMsg);
					break;
				case 5:
					errorMsg = "Invalid Fee";
					MessageBox.Show(errorMsg);
					break;
				case 6:
					errorMsg = "Invalid No. of patients";
					MessageBox.Show(errorMsg);
					break;
				case 7:
					if (errorMsg == "")
					{
						errorMsg = "Cannot keep field empty";
					}
					MessageBox.Show(errorMsg);
					break;
				case 8:
					if (errorMsg == "")
					{
						errorMsg = "Cannot keep Name empty";
					}
					MessageBox.Show(errorMsg);
					break;
				case 9:
					errorMsg = "Invalid Email";
					MessageBox.Show(errorMsg);
					break;
			}

			
		}

		public static void valGeneral(String msg)
		{
			errorMsg = msg;
			errorcode = 0;
			throw new Validation(errorcode);
		}

		public static void valRegex(String toCheck, String reg, String msg )
		{
			errorMsg = msg;
			Regex regex = new Regex(reg);

			Match match = regex.Match(toCheck);
			if (!(match.Success))
			{
				errorcode = 1;
				throw new Validation(errorcode);
			}
		}

		public static void valMobile(String number, String msg)
		{
			errorMsg = msg;
			Regex regex = new Regex(@"^0{0,1}7[0-9]{8}$");
			Match match = regex.Match(number);
			if (!(match.Success))
			{
				errorcode = 2;
				throw new Validation(errorcode);
			}
		}

		public static void valLand(String number, String msg)
		{
			errorMsg = msg;
			Regex regex = new Regex(@"^0{0,1}[0-9]{9}$");
			Match match = regex.Match(number);
			if (!(match.Success))
			{
				errorcode = 2;
				throw new Validation(errorcode);
			}
		}

		public static void valForeign(String number)
		{
			Regex regex = new Regex(@"^(00|+)[0-9]{7,13}$");
			Match match = regex.Match(number);
			if (!(match.Success))
			{
				errorcode = 2;
				throw new Validation(errorcode);
			}
		}

		public static void valID(String ID)
		{
			Regex regex = new Regex(@"^[0-9]+$");
			Match match = regex.Match(ID);
			if (!(match.Success))
			{
				errorcode = 3;
				throw new Validation(errorcode);
			}
		}

		public static void valNIC(String NIC)
		{
			Regex regex = new Regex(@"^([0-9]{9}(V|X|v|x)|[0-9]{12})+$");
			Match match = regex.Match(NIC);
			if (!(match.Success))
			{
				errorcode = 4;
				throw new Validation(errorcode);
			}
		}

		public static void valMoney(String money)
		{
			Regex regex = new Regex(@"(^[0-9]+)|([0-9]+(.00)+)$");
			Match match = regex.Match(money);
			if (!(match.Success))
			{
				errorcode = 5;
				throw new Validation(errorcode);
			}
		}

		public static void valMaxPatients(String patients)
		{
			Regex regex = new Regex(@"^[0-9]+$");
			Match match = regex.Match(patients);
			
			int maxPatients;
			Int32.TryParse(patients, out maxPatients);
			if (!(match.Success) || maxPatients == 0)
			{
				errorcode = 6;
				throw new Validation(errorcode);
			}
		}

		public static void valEmptyField(String fieldData, String msg)
		{
			errorMsg = msg;
			Regex regex = new Regex(@"\s$");
			Match match = regex.Match(fieldData);
			if (match.Success | fieldData == "")
			{
				errorcode = 7;
				throw new Validation(errorcode);
			}
		}
		
		public static void valName(String fieldData, String msg)
		{
			errorMsg = msg;
			Regex regex = new Regex(@"[a-zA-Z]+[\ a-zA-Z]*$");
			Match match = regex.Match(fieldData);
			if (!match.Success | fieldData == "")
			{
				errorcode = 8;
				throw new Validation(errorcode);
			}
		}

		public static void valEmail(String email)
		{
			Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
			Match match = regex.Match(email);
			if (!(match.Success))
			{
				errorcode = 9;
				throw new Validation(errorcode);
			}

		}


		public static void sendMail(String mailTo, String AppointmentDetails, int senderType)
		{
			MailMessage mail = new MailMessage("amdmedcenter@gmail.com", mailTo);
			SmtpClient client = new SmtpClient();
			client.Port = 587;
			client.EnableSsl = true;
			client.DeliveryMethod = SmtpDeliveryMethod.Network;
			//client.UseDefaultCredentials = false;
			client.Credentials = new System.Net.NetworkCredential("amdmedcenter@gmail.com", "amcmedcenter123");
			client.Host = "smtp.google.com";
			client.Timeout = 20000;
			StringBuilder message = new StringBuilder();
			switch(senderType)
			{
				case 1:
					mail.Subject = "Appointment at AMC Medical Center";
					message.Append("Dear Patient,");
					message.Append("\n \nThank you for setting an Appointment with us. Following is the information about your appointment : \n");
					message.Append("\n");
					message.Append(AppointmentDetails);
					message.Append("\n\nThank you.");
					mail.Body = message.ToString();
					break;
				case 2:
				default:
					mail.Subject = "Appointments at AMC medical Center";
					message.Append("Dear Doctor,");
					message.Append("\n\nThis is an update of your current patients.");
					message.Append(AppointmentDetails);
					message.Append("\n\n Thank You.");
					mail.Body = message.ToString();
					break;

			}
			
			client.Send(mail);
		}




	}
}
