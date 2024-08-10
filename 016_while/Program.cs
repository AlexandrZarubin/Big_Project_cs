using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/*
 * Цикл while
 */
namespace _016_while
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int count=0;
			int limit=int.Parse(Console.ReadLine());
			Console.Clear();
			while (count<limit)
			{
				Console.WriteLine("Выполняем действие:\t"+(count+1));
				count++;
			}
        }
	}
}
