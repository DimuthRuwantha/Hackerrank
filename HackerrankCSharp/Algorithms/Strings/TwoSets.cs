using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp.Algorithms
{
	class TwoSets
	{
		public TwoSets()
		{
			string[] tokens_n = Console.ReadLine().Split(' ');
			int n = Convert.ToInt32(tokens_n[0]);
			int m = Convert.ToInt32(tokens_n[1]);
			string[] a_temp = Console.ReadLine().Split(' ');
			int[] a = Array.ConvertAll(a_temp, Int32.Parse);
			string[] b_temp = Console.ReadLine().Split(' ');
			int[] b = Array.ConvertAll(b_temp, Int32.Parse);
			int total = getTotalX(a, b);
			Console.WriteLine(total);
		}

		static int getTotalX(int[] a, int[] b)
		{
			List<int> multiples = getCommanMultiplications(a, b.Min());
			List<int> factors = getFactors(multiples, b);
			return factors.Count;
		}

		private static List<int> getFactors(List<int> multiples, int[] b)
		{
			List<int> rSet = new List<int>();
			foreach(int val in multiples)
			{
				bool allDivisble = true;
				foreach(int bval in b)
				{
					if (bval % val != 0)
					{
						allDivisble = false;
						break;
					}
				}
				if(allDivisble) rSet.Add(val);
			}
			return rSet;
		}

		public static List<int> getCommanMultiplications(int[] a, int limit)
		{
			int mx = a.Max();
			int mn = limit;
			int i = 1;
			int temp = mx;
			List<int> set = new List<int>();
			Console.WriteLine("While loop started");
			while (temp <= mn)
			{
				bool isMultiple = true;
				Console.WriteLine($"foreach started temp= {temp}");

				foreach (int element in a)
				{
					if (temp % element != 0)
					{
						isMultiple = false;
						break;
					}
				}
				Console.WriteLine($"temp = {mx} * {i}");
				if(isMultiple) set.Add(temp);
				i++;
				temp = mx * i;
			}
			return set;
		}
	}
}
