using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnector
{
	public class ParameterList
	{
		private List<Parameter> list = new List<Parameter>();

		public List<Parameter> List
		{
			get
			{
				return list;
			}
			set
			{
				list = value;
			}
		}

		public ParameterList()
		{
			
		}

		public void Add(Parameter pToAdd)
		{
			List.Add(pToAdd);
		}

		public Parameter this[int index]
		{
			get
			{
				return List[index];
			}
			set
			{
				List[index] = value;
			}
		}
	}
}
