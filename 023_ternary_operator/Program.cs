using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_ternary_operator
{
	/*
	 * Тернарный оператор
	 * 
	 * [первый операнд - условие] ? [второй операнд if_true] : [третий операнд if_else]
	 */
	internal class Program
	{
		static void Main(string[] args)
		{
			int a = 0;
			a++; //унарный 1
			int b = 1;
			int c = a + b;//бинарный 2

			bool accessAllowed;

			string storedPassword = "qwerty";
			string enteredPassword=Console.ReadLine();
			//if(enteredPassword==storedPassword)
			//{
			//	accessAllowed = true;
			//}
			//else
			//{
			//	accessAllowed = false;
			//}
			accessAllowed = storedPassword == enteredPassword ? true : false;
            Console.WriteLine(accessAllowed);
            Console.WriteLine();

			int inputDate=int.Parse(Console.ReadLine());
			int outputDate = (inputDate < 0) ? 0 : inputDate;
            Console.WriteLine(outputDate);

        }
	}
}
