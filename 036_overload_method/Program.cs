using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036_overload_method
{
	/*
	 * Перегрузка методов
	 */
	internal class Program
	{
		static int Sum(int a, int b) 
		{
			return a + b;
		}
		static int Sum(int a,int b, int c)
		{
			return a + b + c;
		}
		static double Sum(double a, double b)
		{
			return (double)a + (double)b;
		}
		static void Main(string[] args)
		{
			Console.WriteLine(Sum(2,3));
			Console.WriteLine(Sum(2,3,6));
			Console.WriteLine(Sum(2.5,3));
        }
	}
}
