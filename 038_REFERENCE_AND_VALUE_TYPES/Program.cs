using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *		Сылочные(reference types) и значимые (value types)типы
 *		
 *		Стек(stack) и куча (heap)
 */
namespace _038_REFERENCE_AND_VALUE_TYPES
{
	internal class Program
	{
		
		static void Main(string[] args)
		{
			int a = 5;//struct stack
			Random rnd = new Random();//class		 heap

			int[] arr = new int[10];//наследник class	 heap
			
		}
	}
}
