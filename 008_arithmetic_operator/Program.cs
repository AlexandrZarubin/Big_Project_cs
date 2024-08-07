using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * ОПЕРАТОРЫ
 * 
 * Арифметические операций с ичислами
 */
namespace _008_arithmetic_operator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int a = 2;
			int b = 5;
			double result = (double)a / b;
			Console.WriteLine(result);
			int c = 10;
			int d = 3;
			int result1 = c % b;
			Console.WriteLine(result1);
		}
	}
}
