using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * оператор присваивания объединения со значением null ??=
 */
namespace _041_association_assignments
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
			string str = null;
			str ??= string.Empty;
            Console.WriteLine("Кол-во символов в строке "+str.Length);

			int[]myArray = GetArray();
			myArray ??= new int[0];
            Console.WriteLine("Кол-во элементов в массиве " +myArray.Length);
        }
	}
}
