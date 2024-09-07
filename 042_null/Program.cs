using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Оператор условного null
 */
namespace _042_null
{
	internal class Program
	{
		static int[]GetArray()
		{
			int[] myArray = null;
			return myArray;
		}
		static void Main(string[] args)
		{
			int[]myArray=GetArray();
			
            Console.WriteLine("сумма элементов массива: "+(myArray?.Sum()??0));
			/*
			if (myArray == null)
			{
                Console.WriteLine("сумма элементов массива 0");
            }
			else
			{
            Console.WriteLine("сумма элементов массива: "+myArray.Sum());
			}
			*/
        }
	}
}
