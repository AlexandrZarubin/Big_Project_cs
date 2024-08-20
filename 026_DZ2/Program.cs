using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026_DZ2
{
	/*
	 * Вывести массив в обратном порядке
	 */
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите кол-во элементов массива:\t");
			int elementsCount = int.Parse(Console.ReadLine());
			int[] myArray = new int[elementsCount];

			for (int i = 0; i < elementsCount; i++)
			{
				Console.Write($"Введите элемент массива под индексом {i + 1}:\t");
				myArray[i] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine("\nВывод массива");
			for (int i = 0; i < myArray.Length; i++)
			{
				Console.Write($"{myArray[i]}\t");
			}
            Console.WriteLine();
            for (int i = myArray.Length-1; i >= 0; i--)
			{
				Console.Write($"{myArray[i]}\t");
			}
		}
	}
}
