using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Инкримент и дикремент.Постфиксная и префексная форма.
 */
namespace _011_increment_decrement
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int a = 0;
			a++;
			Console.WriteLine("вывод\t\t" + a);
			Console.WriteLine("Постфикс\t" + a++);
			Console.WriteLine("вывод\t\t" + a);
			Console.WriteLine("Префикс\t\t" + ++a);
			Console.WriteLine("вывод\t\t" + a);
		}
	}
}
