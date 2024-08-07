using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *Конструкция if else
		* ================================
		* if (утверждение или выражение)
 * {
	*действие 1;
	* }
* else
	* {
	*действие 2;
	* }
*
*/
namespace _013_if_else
{
	internal class Program
	{
		static void Main(string[] args)
		{
			bool isInfected = false;
			if (isInfected)
			{
				Console.WriteLine("Персонаж инфицирован!");
			}
			else
			{
				Console.WriteLine("Персонаж здоров!");
			}

			Console.WriteLine("Введите число ");


			int a;
			a = int.Parse(Console.ReadLine());
			if (a == 5)
			{
				Console.WriteLine("а равно 5");
			}
			else
			{
				Console.WriteLine("а не равно 5");
			}
		}
	}
}
