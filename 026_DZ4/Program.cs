using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026_DZ4
{
	internal class Program
	{
		/*
		 *	найти наименьшее число в массиве
		 */
		static void Main(string[] args)
		{
			int[] myArray = { 55, 66, 99, 49, 64, 77, 4, 42, 5 };
			int minValue = myArray[0];
			int maxValue = myArray[0];
			for (int i = 1;i<myArray.Length;i++)
			{
				if (myArray[i] < minValue)
				{
					minValue = myArray[i];
				}
				if (myArray[i] > maxValue)
				{
					maxValue = myArray[i];
				}
			}
            Console.WriteLine($"Минимальный элемент: {minValue}");
            Console.WriteLine($"Максимальный элемент: {maxValue}");
        }
	}
}
