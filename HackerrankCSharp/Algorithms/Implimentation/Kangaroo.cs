using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp.Algorithms
{
	class Kangaroo
	{
		public Kangaroo()
		{
			string[] tokens_x1 = Console.ReadLine().Split(' ');
			int x1 = Convert.ToInt32(tokens_x1[0]);
			int v1 = Convert.ToInt32(tokens_x1[1]);
			int x2 = Convert.ToInt32(tokens_x1[2]);
			int v2 = Convert.ToInt32(tokens_x1[3]);
			string result = kangaroo(x1, v1, x2, v2);
			Console.WriteLine(result);
		}

		static string kangaroo(int x1, int v1, int x2, int v2)
		{
			string condition = "NO";
			// Complete this function
			if (v1 <= v2)
			{
				return condition;
			}
			else
			{
				int d1=x1, d2 = x2;
				int jumps = 0;
				while (d1 < d2)
				{
					jumps++;
					d1 += v1;
					d2 += v2;
					if (d1 == d2) condition="YES";
				}
			}
			return condition;
		}
	}
}
