using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *		Что такое null
 */
namespace _039_null
{
	internal class Program
	{
		class MyClass
		{

		}
		struct MyStruct 
		{ 

		}
		static void Foo()
		{
			int[] a = new int[10];//сылка удалится данные остануться,сборщик муссора сработает
		}
		static void Main(string[] args)
		{
			bool b;

			int a;

			double d;

			Random random;//null

			int[] arr;//null

			MyClass myClass;//null

			MyStruct myStruct;

			int[] arr2; //сылка в стеке
			arr2 = new int[10];// данные в куче

			Foo();
		}
	}
}
