using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Конвертация строки
//класс Convert
namespace _006_convert
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string str = "5";
			string str2 = "2";
			Console.WriteLine(str + str2);
			int a = 5;
			int b = 2;
			Console.WriteLine(a + b);

			string str3 = "5";
			int c = Convert.ToInt32(str3);

			string str4;
			int d, e;
			Console.WriteLine("Введите число 1");
			str4 = Console.ReadLine();
			d = Convert.ToInt32(str4);
			Console.WriteLine("Введите число 2");
			str4 = Console.ReadLine();
			e = Convert.ToInt32(str4);
			int result = d + e;
			Console.WriteLine("Сумма чисел = " + result);

			string str5 = "1.9";
			NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
			{
				NumberDecimalSeparator = ".",
			};
			Convert.ToDouble(str5, numberFormatInfo);
			Console.WriteLine(str5);

		}
	}
}
