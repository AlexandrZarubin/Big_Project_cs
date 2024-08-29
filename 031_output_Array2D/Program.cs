using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031_output_Array2D
{
	/*
	 * вывод двумерного массива
	 */
	internal class Program
	{
		static void Main(string[] args)
		{
			int[,] myArray = new int[,]
			{
				{2,45,12,51,51 },
				{6,7,8,3,1 },
				{1,5,65,78,13 },
				{6,3,151,5,65 }
			};
			//foreach (int i in myArray)
			//{
			//	Console.Write(i + " ");
			//}
			Console.WriteLine(myArray.Rank);//двухмерный
            Console.WriteLine(myArray.Length);//кол-во элементов
            Console.WriteLine(myArray.GetLength(0));//кол-во строк
            Console.WriteLine(myArray.GetLength(1));//кол-во столб
            Console.WriteLine();
            Console.WriteLine();
            int height=myArray.GetLength(0);
			int width=myArray.GetLength(1);
			
			for(int i = 0; i < height; i++)
			{
				for(int j = 0; j < width; j++)
				{
					Console.Write($"{myArray[i,j]}\t");
                }
                Console.WriteLine();
            }
        }
	}
}
