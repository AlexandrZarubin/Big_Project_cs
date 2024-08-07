using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Ввод данных в консоль
 */
namespace _005_input_data
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string data;
            //date = "adssadsa";
            Console.WriteLine("Введите что нибудь");
            data = Console.ReadLine();

			Console.WriteLine("Привет " + data + "!!!");

		}
	}
}
