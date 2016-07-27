using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AMC
{
	class Validation : ApplicationException
	{
		private static int errorcode;
		private static String errorMsg;

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
					errorMsg = "Invalid Email";
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
			}

			
		}

		public static void valGeneral(String msg)
		{
			errorMsg = msg;
			errorcode = 0;
			throw new Validation(errorcode);
		}

		public static void valEmail(String email)
		{
			Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
			Match match = regex.Match(email);
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
			Regex regex = new Regex(@"^([0-9]{9}(V|X)|[0-9]{12})+$");
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




	}
}
