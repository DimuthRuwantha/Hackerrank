using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp._30DaysOfCode
{
	class BubbleSort
	{
		public BubbleSort()
		{
			int endPos = Convert.ToInt32(Console.ReadLine()) - 1;
			string[] tempArray = Console.ReadLine().Split(' ');
			int[] array = Array.ConvertAll(tempArray, Int32.Parse);

			int swapPos = 0;
			//int[] array = { 3, 2, 1 };
			//int endPos = array.Length-1;
			int numOfSwaps = 0;
			int temp = 0;
			while (endPos > 0)
			{
				swapPos = 0;
				for (int i = 0; i < endPos; i++)
				{
					if (array[i] > array[i + 1])
					{
						temp = array[i];
						array[i] = array[i + 1];
						array[i + 1] = temp;
						swapPos = i;
						numOfSwaps++;
					}
					printArray(array);
				}
				endPos = swapPos;
			}

			Console.WriteLine($"Array is sorted in {numOfSwaps} swaps.");
			Console.WriteLine($"First Element: {array[0]}");
			Console.WriteLine($"Last Element: {array[array.Length - 1]}");
			Console.ReadKey(true);
		}

		public static void printArray(int[] pArray)
		{
			for (int a = 0; a < pArray.Length; a++)
			{
				Console.Write($"{pArray[a]} ");
			}
			Console.WriteLine('\n');
		}
	}
}
