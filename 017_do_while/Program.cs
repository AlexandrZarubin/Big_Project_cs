using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Цикл do while
 */
namespace _017_do_while
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int count = 0;
			int limit = int.Parse(Console.ReadLine());
			Console.Clear();
			do
			{
				Console.WriteLine("Выполняем действие:\t" + (count + 1));
				count++; 
			} while (count<limit);
			
		}
	}
}
