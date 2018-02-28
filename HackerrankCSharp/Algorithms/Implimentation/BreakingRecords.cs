using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp.Algorithms
{
	class BreakingRecords
	{
		public BreakingRecords()
		{
			int n = Convert.ToInt32(Console.ReadLine());
			string[] score_temp = Console.ReadLine().Split(' ');
			int[] score = Array.ConvertAll(score_temp, Int32.Parse);
			int[] result = breakingRecords(score);
			Console.WriteLine(String.Join(" ", result));
		}

		static int[] breakingRecords(int[] score)
		{
			int[] times = new int[2];
			int min = score[0];
			int max = score[0];
			int rMin = 0;
			int rMax = 0;
			for (int i=1; i<score.Length; i++) {
				if(score[i] < min)
				{
					rMin++;
					min = score[i];
				}
				else if(score[i] > max)
				{
					rMax++;
					max = score[i];
				}
			}
			times[0] = rMax;
			times[1] = rMin;
			return times;
		}
	}
}
