using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_NESTED_LOOPS
{
	/*
	 * вложенные циклы
	 */
	internal class Program
	{
		static int[,] GetRandomArray(int rows, int columns)
		{
			Random random = new Random();
			var result =new int[rows, columns];
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					result[i, j] = random.Next(100);
				}
			}
			return result;
		}
		static void Main(string[] args)
		{
            for (int i = 0; i < 3; i++)
			{
                Console.WriteLine("цикл 1 итерация №: "+i);
				for (int j = 0; j < 4; j++)
				{
					Console.WriteLine("\tцикл 2 итерация №: "+j);
				}
            }

			Console.Clear();

            Console.Write("Введите высоту прямоугольника: ");
			int height=int.Parse(Console.ReadLine());
            Console.Write("Введите ширину прямоугольника: ");
			int width=int.Parse(Console.ReadLine());
            
			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < width; j++)
				{
					Console.Write("#");
				}
                Console.WriteLine();
            }
            Console.WriteLine();

			Console.Clear();

			int rows = 5;
			int columns=10;
			var myArray=GetRandomArray(rows, columns);
			for (int i = 0;i < rows; i++)
			{
				for(int j = 0;j < columns; j++)
				{
					Console.Write($"{myArray[i,j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
	}
}
