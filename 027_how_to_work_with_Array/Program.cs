using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027_how_to_work_with_Array
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] myArray = { 55, 66, 99, 49, 64, 77, 4, 42, 5 };
			int result = myArray.Min();
			Console.WriteLine(result);
			int result2 = myArray.Max();
			Console.WriteLine(result2);
			Console.WriteLine(myArray.Min());
			Console.WriteLine(myArray.Max());
			Console.WriteLine(myArray.Sum());
			Console.WriteLine(myArray.Where(i => i % 2 == 0).Sum());
			Console.WriteLine(myArray.Where(i => i % 2 != 0).Min());

			int[] result3 = myArray.Distinct().ToArray();
			int[] result4 = myArray.OrderBy(i => i).ToArray();
			int[] result5 = myArray.OrderByDescending(i => i).ToArray();
			//myArray.Length
			Array.Sort(result3);
			int[] fin = Array.FindAll(myArray, i => i < 70);
            Console.WriteLine($"------{Array.Find(myArray, i => i < 70)}");
			int result6 = Array.FindIndex(myArray, i => i == 77);
			Array.Reverse(myArray);
			int[] result7 = myArray.Where(i => i < 70).ToArray();
			int result8 = myArray.Where(i => i < 70).First();
			int result9=myArray.Where(i=>i<0).FirstOrDefault();
        }
	}
}
