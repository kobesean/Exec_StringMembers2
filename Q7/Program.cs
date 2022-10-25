using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//計算兩數之和,並只呈現小數二位數
			Console.WriteLine("輸入第一個數字");
			string input = Console.ReadLine();
			Console.WriteLine("輸入第一個數字");
			string input2 = Console.ReadLine();
			double num1 = Convert.ToDouble(input);
			double num2 = Convert.ToDouble(input2);
			Console.WriteLine($"兩數相加為{num1}+{num2}={num1+num2}");
			//後面沒想法


		}
	}
}
