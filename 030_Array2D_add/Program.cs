using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * инициализация
 * 
 * обращение к элементам массива
 */
namespace _030_Array2D_add
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//тип_данных [,] имя_массива;

			int[] array1D = { };
			int[,] array2D = { };
			int[,] array2D1 = new int[3, 3];
			
			int[,] array2D3;
			array2D3 = new int[3, 3];

			array2D3[0, 2] = 99;
			Console.WriteLine(array2D3[0,2]);
			//Console.WriteLine(array2D3[10,5]);

			int[,]array2D4=new int[3, 3]
				{
					{1,2,3 },
					{4,5,6 },
					{7,8,9 }
				};
			int[,] array2D5 = new int[,]
				{
					{1,2,3 },
					{4,5,6 },
					{7,8,9 }
				};
			int[,] array2D6 =
				{
					{1,2,3 },
					{4,5,6 },
					{7,8,9 }
				};
		}
	}
}
