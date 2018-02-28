using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp._30DaysOfCode
{
	class Arrays
	{
		public Arrays()
		{
			int n = Convert.ToInt32(Console.ReadLine());
			string[] arr_temp = Console.ReadLine().Split(' ');
			int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

			Array.Reverse(arr);

			foreach (int a in arr)
			{
				Console.Write($"{a} ");
			}
			Console.Write('\b');
		}
	}
}
