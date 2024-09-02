using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * функций и методы в c#
 * 
 *	модификаторы тип_возвращаемого_значения навзание_метод(параметры)
 *	{
 *		тело метода
 *	}
 */

namespace _035_function_method
{
	internal class Program
	{
		static int Sum(int A,int B)
		{
			return A + B;
		}
		static void PrintLine()
		{
            Console.WriteLine("Метод PrintLine был вызван!");
        }
		static void PrintResult(int result)
		{
            Console.WriteLine("Результат сложения: "+result);
        }
		static void Main(string[] args)
		{
			int a, b, c;
			a=int.Parse(Console.ReadLine());
			b=int.Parse(Console.ReadLine());
			c = Sum(a,b);
            Console.WriteLine(c);
            Console.WriteLine("==========================");
			PrintLine();
			Random random=new Random();
			Console.WriteLine(random.Next());
			PrintResult(c);
		}
	}
}
