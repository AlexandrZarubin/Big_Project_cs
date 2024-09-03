using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *		оператор null-щбъекдинение ??
 */
namespace _040_ASSOCIATIONS_NULL
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string str = "test";

            Console.WriteLine(str);

			string str1 = null;
            Console.WriteLine("=================");

            Console.WriteLine(str1??"Нет данных");
			string result = str1 ?? string.Empty;
            Console.WriteLine("Кол-во символов в строке "+result.Length);
            Console.WriteLine("=================");
            if (str1 == null)
			{
				Console.WriteLine("Нет данных");
			}
			else
			{
				Console.WriteLine(str1);
			}
        }
	}
}
