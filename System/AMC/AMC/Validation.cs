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
		private int errorcode;

		public Validation(int errorcode)
		{
			switch (errorcode)
			{
				case 1:
					MessageBox.Show("Invalid Email");
					break;
				case 2:
					MessageBox.Show("Invalid Phone number");
					break;
				case 3:
					MessageBox.Show("Invalid ID");
					break;
				case 4:
					MessageBox.Show("Invalid NIC Number");
					break;
				case 5:
					MessageBox.Show("Invalid Fee");
					break;
				case 6:
					MessageBox.Show("Invalid No. of patients");
					break;
			}
		}


		public void valEmail(String email)
		{
			Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
			Match match = regex.Match(email);
			if (!(match.Success))
			{
				errorcode = 1;
				throw new Validation(errorcode);
			}

		}

		public void valMobile(String number)
		{
			Regex regex = new Regex(@"^07[0-9]{8}$");
			Match match = regex.Match(number);
			if (!(match.Success))
			{
				errorcode = 2;
				throw new Validation(errorcode);
			}
		}

		public void valLand(String number)
		{
			Regex regex = new Regex(@"^0[0-9]{9}$");
			Match match = regex.Match(number);
			if (!(match.Success))
			{
				errorcode = 2;
				throw new Validation(errorcode);
			}
		}

		public void valForeign(String number)
		{
			Regex regex = new Regex(@"^(00|+)[0-9]{7,13}$");
			Match match = regex.Match(number);
			if (!(match.Success))
			{
				errorcode = 2;
				throw new Validation(errorcode);
			}
		}

		public void valID(String ID)
		{
			Regex regex = new Regex(@"^[0-9]+$");
			Match match = regex.Match(ID);
			if (!(match.Success))
			{
				errorcode = 3;
				throw new Validation(errorcode);
			}
		}

		public void valNIC(String NIC)
		{
			Regex regex = new Regex(@"^([0-9]{9}(V|X)|[0-9]{12})+$");
			Match match = regex.Match(NIC);
			if (!(match.Success))
			{
				errorcode = 4;
				throw new Validation(errorcode);
			}
		}

		public void valMoney(String money)
		{
			Regex regex = new Regex(@"^([0-9]+|[0-9]+(.00)+$");
			Match match = regex.Match(money);
			if (!(match.Success))
			{
				errorcode = 5;
				throw new Validation(errorcode);
			}
		}

		public void valMaxPatients(String patients)
		{
			Regex regex = new Regex(@"^([0-9]+$");
			Match match = regex.Match(patients);
			if (!(match.Success))
			{
				errorcode = 6;
				throw new Validation(errorcode);
			}
		}




	}
}
