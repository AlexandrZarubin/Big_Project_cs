using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Цикл for Особености
 * несколько переменых
 * цикл for в обраном порядке
 * несколько условий
 */
namespace _019_for_reverse
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int limit = int.Parse(Console.ReadLine());
			//потом проверяем//первая итерация сначала проверяем /сначала прибавляем
			for (int i = 0;i < limit;i++)
			{
				Console.WriteLine(i);
			}
            Console.WriteLine("-------------");
			int j = 0;
			for (;j<limit-3;j++) Console.WriteLine("for1: "+(j+1));
			for (;j<limit;j++) Console.WriteLine("for2: "+(j+1));
            Console.WriteLine("-------------------------------------");
            for (int i = int.Parse(Console.ReadLine());i>0;i--) Console.WriteLine(i);
            for (; ; )
			{
                Console.WriteLine("for is working");
				System.Threading.Thread.Sleep(300);
            }
		}
	}
}
