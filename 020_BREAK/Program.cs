using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Ключевое слово break
 */
namespace _020_BREAK
{
	internal class Program
	{
		static void Main(string[] args)
		{
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine(i);
				if (i == 7) break;
			}
		}
	}
}
