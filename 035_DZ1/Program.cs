using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *		написать метод который выводит на экран строку
 *		сивол из которых состоит строка и их кол-во вводится пользовотелем
 */
namespace _035_DZ1
{
	internal class Program
	{
		static void PrintLine(string symbol,uint symbolsCount)
		{
			for (int i = 0; i < symbolsCount; i++) 
			{
				Console.Write(symbol);
			}
		}
		static void PrintLine(char symbol, uint symbolsCount)
		{
			for (int i = 0; i < symbolsCount; i++)
			{
				Console.Write(symbol);
			}
		}
		static void Main(string[] args)
		{
			PrintLine("#", 10);
            Console.WriteLine();
			PrintLine("(V)_(O)(O)_(V)\t", 10);
            Console.WriteLine();
            Console.WriteLine("\nВведите символ");
            
            //string symbol=Console.ReadLine();
            char symbol=Console.ReadKey().KeyChar;
            Console.WriteLine("\nВведите кол-во символов: ");
			uint symbolsCount=uint.Parse(Console.ReadLine());
			PrintLine(symbol, symbolsCount);
        }
	}
}
