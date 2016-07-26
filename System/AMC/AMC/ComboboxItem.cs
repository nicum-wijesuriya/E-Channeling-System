using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMC
{
	public class ComboBoxItem
	{
		public string Text
		{
			get;
			set;
		}
		public string Value
		{
			get;
			set;
		}
		public ComboBoxItem(String Value, String Text)
		{
			this.Text = Text;
			this.Value = Value;
		}
		public override string ToString()
		{
			return Text;
		}
	}
}
