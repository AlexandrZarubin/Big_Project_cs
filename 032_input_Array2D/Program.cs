using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032_input_Array2D
{
	/*
	 * Заполнение двкмернго массива случайными числами 
	 * 
	 * заполнение двухменрного массива с клавиатуры
	 */
	internal class Program
	{
		static void Main(string[] args)
		{
			string[,] myArray = new string[10, 6];

			Random random=new Random();


			for (int i = 0; i < myArray.GetLength(0); i++)
			{
				for (int j = 0; j < myArray.GetLength(1); j++)
				{
					Console.WriteLine("i: " + i + " j: " + j);
					myArray[i, j] = Console.ReadLine();
				}

			}

			//for (int i = 0; i < myArray.GetLength(0); i++)
			//{
			//	for (int j = 0; j < myArray.GetLength(1); j++)
			//	{
			//                 Console.WriteLine("i: "+i+" j: "+j);
			//                 myArray[i, j] = int.Parse(Console.ReadLine());
			//	}

			//}

			//for (int i = 0; i < myArray.GetLength(0); i++)
			//{
			//	for (int j = 0; j < myArray.GetLength(1); j++)
			//	{
			//		myArray[i, j] = random.Next(0,10);
			//	}

			//}

			for (int i = 0; i < myArray.GetLength(0); i++)
			{
				for (int j = 0; j < myArray.GetLength(1); j++)
				{
					Console.Write($"{myArray[i, j]}\t");
				}
				Console.WriteLine();
			}
		}
	}
}
