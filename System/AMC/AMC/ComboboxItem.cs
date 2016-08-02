using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMC
{
	public class ComboBoxItem
	{
		private String text;

		public String Text
		{
			get
			{
				return text;
			}
			set
			{
				text = value;
			}
		}

		private String value;

		public String Value
		{
			get
			{
				return this.value;
			}
			set
			{
				this.value = value;
			}
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

		public Boolean Equals(ComboBoxItem item)
		{
			return (this.Value.Equals(item.Value) && this.text.Equals(item.Text));
		}
	}
}
