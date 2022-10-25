using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string value = "aLLeN kUO";
			string[] value1 = value.ToLower().Split(' ');
			for (int i = 0; i < value1.Length; i++)
			{
				value1[i] = value1[i].Substring(0, 1).ToUpper() + value1[i].Substring(1);

			}
			string value2 = string.Join(" ", value1);
			Console.WriteLine(value2);
		}
	}
}
