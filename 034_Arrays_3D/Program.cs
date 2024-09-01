using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
/*
 * Трехмерный и более массивы
 */
namespace _034_Arrays_3D
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[,,,] myArray = new int[3, 2, 5,5];
			//myArray[0,2,3] = 1;
            //Console.WriteLine(myArray[0,2,3]);
			int[,,] myArray2 =
			{
				{
					{ 2,3,5},
					{69,7,4 }
				},
				{
					{4,31,24 },
					{64,7,33 }
				},
				{
					{4,21,9 },
					{8,12,1 }
				},
				{
					{2,3,5 },
					{69,7,4 }
				}
			};
			Random random = new Random();
			for (int i = 0; i < myArray.GetLength(0); i++)
				for (int j = 0; j < myArray.GetLength(1); j++)
					for (int k = 0; k < myArray.GetLength(2); k++)
						for (int l = 0; l < myArray.GetLength(3);l++)
							myArray[i, j, k,l] = random.Next(20);
                    
			for (int i = 0; i < myArray.GetLength(0); i++)
			{
                Console.WriteLine($"==Book:\t{(i+1)}==");
                for (int j = 0; j < myArray.GetLength(1); j++)
				{
					 Console.WriteLine("Page №: "+(j+1));
					for (int k = 0; k < myArray.GetLength(2); k++)
					{
						for(int l = 0;l < myArray.GetLength(3); l++)
						{
						Console.Write($"{myArray[i, j, k,l]}\t"); 
						}
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine("=====================================================");
            int[][][] myArray3 = new int[random.Next(3,6)][][];
			for (int i = 0;i < myArray3.Length;i++)
			{
				myArray3[i]=new int[random.Next(2, 6)][];
				for (int j = 0;j < myArray3[i].Length;j++)
				{
					myArray3[i][j] = new int[random.Next(2, 6)];
					for (int k = 0;k < myArray3[i][j].Length;k++)
					{
						myArray3[i][j][k] = random.Next(100);
					}
				}
			}


			for (int i = 0; i < myArray3.Length; i++)
			{
                Console.WriteLine("Page N: "+(i+1));
				for (int j = 0; j < myArray3[i].Length; j++)
				{
					for (int k = 0; k < myArray3[i][j].Length; k++)
					{
						Console.Write(myArray3[i][j][k]+"\t"); 
					}
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

		}
	}
}
