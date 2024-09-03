using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *		Область видимости, или контекст переменой
 *		Конфликты областей видимости
 */
namespace _037_scope
{
	internal class Program
	{
		int c = 10;
		static void Foo() 
		{
			int c = 1;
		}
		static void Main(string[] args)
		{
			int i = 0;
			for (; i < 10; i++) 
			{
				int b = 0;
			}
			//b = 5;
			Program program=new Program();
			program.c++;
            Console.WriteLine(program.c);
        }
	}
}
