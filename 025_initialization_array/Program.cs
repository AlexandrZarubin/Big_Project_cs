using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _025_initialization_array
{
	/*
	 * Массивы
	 * 
	 * одномерные массивы
	 * 
	 * способы инициализаций массива
	 */
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] myArray;
			myArray = new int[5];

			//int[]myArray2= new int[5]{5,6,7,8,9 };
			//int[]myArray2= new int[]{5,6,7,8,9 };
			int[] myArray2 = { 5, 6, 7, 8, 9 };

			int[]myarray3=Enumerable.Repeat(5,10).ToArray();
			int[]myarray4=Enumerable.Range(4,5).ToArray();


			foreach (var item in myArray2)
			{
				Console.WriteLine(item);
			}
            Console.WriteLine();
            foreach (var item in myarray3)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();
			foreach (var item in myarray4)
			{
				Console.WriteLine(item);
			}
		}
	}
}
