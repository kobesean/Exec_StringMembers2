using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string name = "Allen";
			Console.WriteLine("輸入名字");
			string input = Console.ReadLine();
			if (name == input)
			{
				Console.WriteLine("名字一樣");
			}
			else
			{
				Console.WriteLine("名字不一樣");
			}
		}
	}
}
