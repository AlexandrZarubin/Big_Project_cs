using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026_output_array
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] myArray = { 10, 3, 2, 55 };
			//Console.WriteLine(myArray[0]);
			for (int i = 0; i < myArray.Length; i++)
			{
				Console.WriteLine(myArray[i]);
			}
        }
	}
}
