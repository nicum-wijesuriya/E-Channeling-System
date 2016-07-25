using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnector
{
	class Parameter
	{
		String parameterName;

		public String ParameterName
		{
			get
			{
				return parameterName;
			}
			set
			{
				parameterName = value;
			}
		}
		String parameterValue;

		public String ParameterValue
		{
			get
			{
				return parameterValue;
			}
			set
			{
				parameterValue = value;
			}
		}

		public Parameter(String Name, String Value)
		{
			this.parameterName = Name;
			this.parameterValue = Value;
		}
	}
}
