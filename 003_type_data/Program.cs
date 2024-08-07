using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_type_data
{
	internal class Program
	{
		static readonly string delimiter = "\n---------------------------------------------------------------------------\n";
		static void Main(string[] args)
		{
		Console.Title = "Introduction to .NET";

			string msg = "{0,-8} |{1,-15}| {2}\t| {3,-40}";
			string delimiter1 = new string('-', 90);

			Console.WriteLine(msg, "Тип", ".Net", "Размер (в байтах)", "Диапазон значений");
			Console.WriteLine(delimiter1);
			//Console.WriteLine(delimiter);
			Console.WriteLine(string.Format(msg, "byte", typeof(byte), sizeof(byte), $"{byte.MinValue} до {byte.MaxValue}"));
			Console.WriteLine(string.Format(msg, "sbyte", typeof(sbyte), sizeof(sbyte), $"{sbyte.MinValue} до {sbyte.MaxValue}"));
			Console.WriteLine(string.Format(msg, "short", typeof(short), sizeof(short), $"{short.MinValue} до {short.MaxValue}"));
			Console.WriteLine(string.Format(msg, "ushort", typeof(ushort), sizeof(ushort), $"{ushort.MinValue} до {ushort.MaxValue}"));
			Console.WriteLine(string.Format(msg, "int", typeof(int), sizeof(int), $"{int.MinValue} до {int.MaxValue}"));
			Console.WriteLine(string.Format(msg, "uint", typeof(uint), sizeof(uint), $"{uint.MinValue} до {uint.MaxValue}"));
			Console.WriteLine(string.Format(msg, "long", typeof(long), sizeof(long), $"{long.MinValue} до {long.MaxValue}"));
			Console.WriteLine(string.Format(msg, "ulong", typeof(ulong), sizeof(ulong), $"{ulong.MinValue} до {ulong.MaxValue}"));
			Console.WriteLine(delimiter1);
			Console.WriteLine(string.Format(msg, "float", typeof(float), sizeof(float), $"{float.MinValue} до {float.MaxValue}"));
			Console.WriteLine(string.Format(msg, "double", typeof(double), sizeof(double), $"{double.MinValue} до {double.MaxValue}"));
			Console.WriteLine(string.Format(msg, "decimal", typeof(decimal), sizeof(decimal), $"{decimal.MinValue} до {decimal.MaxValue}"));
			Console.WriteLine(delimiter1);
			Console.WriteLine(string.Format(msg, "char", typeof(char), sizeof(char), $"{(int)char.MinValue} до {(int)char.MaxValue}"));
			Console.WriteLine(delimiter1);
			Console.WriteLine(string.Format(msg, "bool", typeof(bool), sizeof(bool), $"{bool.FalseString} или {bool.TrueString}"));

			/*
			 * float	4byte	0,(38)	точность 7
			 * double	8byte	0,(308)	точность 15
			 * decimal	16byte	0,(28)	точность 728
			 */

		}
	}
}
