namespace _028_index_ranges1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] myArray = { 55, 66, 99, 49, 64, 77, 4, 42, 5, 89 };
			Console.WriteLine(myArray[8]);
			Console.WriteLine(myArray[myArray.Length - 1]);
			Console.WriteLine(myArray[^1]);//.core

			int[] myArray2 = myArray[1..4];//.core
			Index myIndex = 3;
			Console.WriteLine(myArray[myIndex]);
            Console.WriteLine($"value {myIndex.Value} isFromEnd {myIndex.IsFromEnd}");
			Index myIndex2 =new Index(3,true);
            Console.WriteLine($"value {myIndex2.Value} isFromEnd {myIndex2.IsFromEnd}");

			Range myRange = 1..4;//1,4
			int[] myArray3 = myArray[myRange];
			Range myRange2 = ^4..^1;
			int[] myArray4 = myArray[myRange2];

			string str = "Hello World!! =)";
			Console.WriteLine(str[1..3]);
			Console.WriteLine(str[^2..]);
			Console.WriteLine(str[0..6]);
			Console.WriteLine("\n");

            foreach (var item in myArray[..4])
                Console.WriteLine($"{item}");
			Console.WriteLine("\n");
			
			foreach (var item in myArray[4..])
				Console.WriteLine($"{item}");
			Console.WriteLine("\n");

			foreach (var item in myArray[5..7])
				Console.WriteLine($"{item}");
			Console.WriteLine("\n");

		}
	}
}