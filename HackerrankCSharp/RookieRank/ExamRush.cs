using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp.RookieRank
{
	class ExamRush
	{
		public ExamRush()
		{
			string[] tokens_n = Console.ReadLine().Split(' ');
			int n = Convert.ToInt32(tokens_n[0]);
			int t = Convert.ToInt32(tokens_n[1]);
			int[] tm = new int[n];
			for (int tm_i = 0; tm_i < n; tm_i++)
			{
				tm[tm_i] = Convert.ToInt32(Console.ReadLine());
			}
			int result = examRush(tm, t);
			Console.WriteLine(result);
		}

		static int examRush(int[] tm, int t)
		{
			Array.Sort(tm);
			int i = 0;
			while ((t -=tm[i])>=0)
			{
				i++;
			}
			return i;
		}
	}
}
