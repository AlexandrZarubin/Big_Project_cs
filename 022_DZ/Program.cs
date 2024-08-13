//#define RECTANGLE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_DZ
{
	internal class Program
	{
			/*
			 *  Треугольники в консоли
			 */
		static void Main(string[] args)
		{
#if RECTANGLE
			Console.Write("Введите высоту прямоугольника: ");
			int height = int.Parse(Console.ReadLine());
			Console.Write("Введите ширину прямоугольника: ");
			int width = int.Parse(Console.ReadLine());

			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < width; j++)
				{
					Console.Write("#");
				}
				Console.WriteLine();
			}
			Console.WriteLine(); 
#endif

			Console.Write("Введите высоту треугольнки: ");
			int height = int.Parse(Console.ReadLine());
			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j <= i; j++)
				{
                    Console.Write("*");
                }
				Console.WriteLine();
			}
			Console.WriteLine();

			for (int i = 0; i < height; i++)
			{
				for (int j = height; j >i; j--)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			
			for (int i = 0; i < height; i++)
			{
				for (int j = height-1; j > i; j--)
				{
					Console.Write(" ");
				}
				for (int j = 0; j <=i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
			for (int i = 0; i < height; i++)
			{
				for (int j = height; j > i; j--)
				{
					Console.Write("*");
				}
				for (int j = 0; j <= i; j++)
				{
					Console.Write(" ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}
	}
}
