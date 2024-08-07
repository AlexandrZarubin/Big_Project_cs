//#define TASK1 //	1.Напишите программу, вычисляющую среднее арифметическое двух чисел
//#define TASK2   //  2. Введите три числа и выведите на экран значение суммы и произведение этих чисел                                                                                       
#define TASK3	
/*
 *3.Напишите простой конвертор валют
 *(без возможности динамического выбора валюты пользователем)
 *Валюты заданы хардкодом и не изменяютсяю Тип валюты на выбор программиста.
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_DZ
{
	internal class Program
	{
		static void Main(string[] args)
		{

#if TASK1//	1.Напишите программу, вычисляющую среднее арифметическое двух чисел
			double FirstValue, SecondValue;

			Console.WriteLine("Введите число 1");

			FirstValue = double.Parse(Console.ReadLine());

			Console.WriteLine("Введите число 2");
			SecondValue = double.Parse(Console.ReadLine());

			double result = (FirstValue + SecondValue) / 2;

			Console.WriteLine("Среднее арифметическое двух чисел = " + result); 
#endif

#if TASK2   //  2. Введите три числа и выведите на экран значение суммы и произведение этих чисел
			double FirstValue, SecondValue, ThirdValue;

			Console.WriteLine("Введите число 1");
			FirstValue = double.Parse(Console.ReadLine());

			Console.WriteLine("Введите число 2");
			SecondValue = double.Parse(Console.ReadLine());

			Console.WriteLine("Введите число 3");
			ThirdValue = double.Parse(Console.ReadLine());

			double SumResult = FirstValue + SecondValue + ThirdValue;

			double MultResult = FirstValue * SecondValue * ThirdValue;

			Console.WriteLine("Сумма трех чиел = " + SumResult);
			Console.WriteLine("произведение трех чисел = " + MultResult); 
#endif

			/*
			 *3.Напишите простой конвертор валют
			 *(без возможности динамического выбора валюты пользователем)
			 *Валюты заданы хардкодом и не изменяютсяю Тип валюты на выбор программиста.
			 */
#if TASK3
			double UsdToRub = 93.43;
			double EurToRub = 99.73;

			double usd;
			double Eur;

			Console.WriteLine("Ввдети сумму в USD");

			usd = double.Parse(Console.ReadLine());

			Console.WriteLine("Ввдети сумму в Eur");
			Eur = double.Parse(Console.ReadLine());
			Console.WriteLine(usd + " USD В Rub = " + usd * UsdToRub);
			Console.WriteLine(Eur + " Eur В Rub = " + Eur * EurToRub); 
#endif
		}
	}
}
