using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *      Логические опертаоры
 *      
 *      
 *      &&  Сокращенное И
 *      ||  Сокращенное ИЛИ
 *      &   И
 *      |   ИЛИ
 *      !   НЕ (унарный)
 */
namespace _014_Logical_Operators
{
	internal class Program
	{
		public static bool GetTemperature()
		{
			return true;
		}
		public static bool GetCoolingStatus()
		{
			return true;
		}

		static void Main(string[] args)
		{

			if (GetTemperature() | GetCoolingStatus())
			{
				Console.WriteLine("Угроза повреждения процессора");
			}





			//          !   НЕ
			bool isInfected = false;
			if (!isInfected)
			{
				Console.WriteLine("Персонаж здоров!");
			}
			else
			{
				Console.WriteLine("Персонаж инфицирован!");
			}

			//          &&   И
			bool isHighTemperature = true;
			bool hasNoCooling = false;
			if (isHighTemperature && hasNoCooling)
			{
				Console.WriteLine("&&     Угроза повреждения процессора");

			}

			//          ||   ИЛИ
			int fanSpeed = 3000;
			hasNoCooling = fanSpeed <= 0;
			if (isHighTemperature || hasNoCooling)
			{
				Console.WriteLine("||       Угроза повреждения процессора");

			}

			isHighTemperature = false;
			hasNoCooling = true;
			if (isHighTemperature & hasNoCooling)
			{
				Console.WriteLine("&     Угроза повреждения процессора");

			}


		}
	}
}
