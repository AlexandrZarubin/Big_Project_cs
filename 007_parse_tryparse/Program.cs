using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//              конвертация строки
//              parse and tryparse
namespace _007_parse_tryparse
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*string str = "5.9";
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };
            double a=double.Parse(str,numberFormatInfo);
            Console.WriteLine(a);
            //int a=int.Parse(str);
            */



			/*string str = "1";
            try
            {
                int a = Convert.ToInt32(str);
                Console.WriteLine("Успешная конвертация");
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка при конвертаций");
            }
            //double a = double.Parse(str);
            */

			string str = "55";

			int a;
			bool result = int.TryParse(str, out a);
			if (result)
			{
				Console.WriteLine("Успешно = " + a);
			}
			else
			{
				Console.WriteLine("не успешно");
			}
		}
	}
}
