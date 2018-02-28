using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp._30DaysOfCode
{
	class TwoDArray
	{
		static int[][] arr;
		public TwoDArray()
		{
			arr = new int[6][];
			int fSum = -70;
			for (int arr_i = 0; arr_i < 6; arr_i++)
			{
				string[] arr_temp = Console.ReadLine().Split(' ');
				arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
			}
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					int sum = calculateSum(i, j);
					if (fSum < sum)
					{
						fSum = sum;
					}
				}
			}
			Console.WriteLine(fSum);
			Console.ReadKey(true);
		}

		static int calculateSum(int x, int y)
		{
			int sum = arr[x][y] + arr[x][y + 1] + arr[x][y + 2] + arr[x + 1][y + 1] + arr[x + 2][y] + arr[x + 2][y + 1] + arr[x + 2][y + 2];
			return sum;
		}
	}
}