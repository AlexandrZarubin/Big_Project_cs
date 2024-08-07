using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Переменная в C#
 * 
 * Объявление (создание) переменных
 * 
 * инициализация переменных
 * 
 * Присвоение значение переменной(помещение данных)
 */
namespace _004_variable
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Тип_данных имя_переменной
			int a = 5;
			//a = 5;
			//int b;
			//b = 6;
			//int a, b;
			// a = 5;
			//b = 5;
			Console.WriteLine(a);
			bool variable = false;
			bool variable2 = true;
			Console.WriteLine(variable);
			Console.WriteLine(variable2);

			double c = 1.33;
			Console.WriteLine(c);

			char v = '#';
			Console.WriteLine(v);

			string x = "adsadsadsa";
			Console.WriteLine(x);

			int t = 5;
			Console.WriteLine(t);
			t = 3;
			Console.WriteLine(t);


		}
	}
}
