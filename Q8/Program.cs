using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("輸入手機");
			string input = Console.ReadLine();
			string phone = input.Substring(0, 4) + new string('*', 4) + input.Substring(8, 2);
			Console.WriteLine(phone);
		}
	}
}
