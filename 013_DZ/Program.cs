using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Проверка числа на четность

namespace _013_DZ
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int a;

			a = int.Parse(Console.ReadLine());

			int temp = a % 2;
			bool result = temp == 0;
			//if (result)
			if (a % 2 == 0)
			{
				Console.WriteLine("число чётное");
			}
			else
			{
				Console.WriteLine("число нечётное");
			}
		}
	}
}
