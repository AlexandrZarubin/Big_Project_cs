using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Цикл for
 */
namespace _018_for
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int limit=int.Parse(Console.ReadLine());
			for (int i = 0;
				i<limit;//потом проверяем//первая итерация сначала проверяем 
				i++)//сначала прибавляем
			
			{
                Console.WriteLine(i);
            }
		}
	}
}
