using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *		написать метод для поиска индекса элемента массива (тип элементов в массиве - int)
 *		метод должен вернуть индекс первого найденого элемента(если он будет найден)
 */

namespace _035_DZ2
{
	internal class Program
	{
		static int IndexOf(int[]array,int value)
		{
			for (int i = 0;i<array.Length;i++)
			{
				if (array[i] == value)
					return i;
			}
			return -1;
		}
		static int[]GetRandomArray(uint lenght,int minValue,int maxValue)
		{
			int[]myArray = new int[lenght];
			Random random = new Random();
			for (int i = 0; i < myArray.Length; i++)
				myArray[i] = random.Next(minValue, maxValue);
			return myArray;
		}
		static void Main(string[] args)
		{
			//int[] myArray = {2,3,4,5,6,7};
			int[] myArray = GetRandomArray(10, -10, 10);
			int result=IndexOf(myArray, 5);
            Console.WriteLine(result);

        }
	}
}
