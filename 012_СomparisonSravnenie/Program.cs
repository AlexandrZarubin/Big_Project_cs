using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *      Оператор отношений
 *      Оператор сравнения
 
 *          ==  Равно
 *          !=  Не равно
 *          >   Больше
 *          <   Меньше
 *          >=  Больше или равно
 *          <=  Меньше или равно
 */
namespace _012_СomparisonSravnenie
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int a = 5;
			int b = 6;
			Console.WriteLine(a == b);
			b = 5;
			Console.WriteLine(a == b);
			bool result = a == b;
			Console.WriteLine(result);
			Console.WriteLine(a != b);
			Console.WriteLine(a > b);
			Console.WriteLine(a < b);
			Console.WriteLine(a <= b);
			Console.WriteLine(a >= b);
		}
	}
}
