using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp.Algorithms
{
	class BdayChoc
	{
		public BdayChoc()
		{
			int n = Convert.ToInt32(Console.ReadLine());
			string[] s_temp = Console.ReadLine().Split(' ');
			int[] s = Array.ConvertAll(s_temp, Int32.Parse);
			string[] tokens_d = Console.ReadLine().Split(' ');
			int d = Convert.ToInt32(tokens_d[0]);
			int m = Convert.ToInt32(tokens_d[1]);
			int result = solve(n, s, d, m);
			Console.WriteLine(result);
		}

		static int solve(int n, int[] s, int d, int m)
		{
			int times = 0;
			for(int i=0; i<=n-m; i++)
			{
				Console.WriteLine($"from {s[i]}");
				int sum = 0;
				for(int j=0; j<m; j++)
				{
					sum += s[i + j];
					Console.Write($"{s[i+j]} ");
				}
				Console.WriteLine("Ewalute sum");
				if (sum == d) times++;
			}
			return times;
		}
	}
}
