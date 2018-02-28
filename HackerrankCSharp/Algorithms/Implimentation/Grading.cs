using HackerrankCSharp._30DaysOfCode.binaryTrees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp.Algorithms
{
	class Grading
	{
		public Grading()
		{
			int n = Convert.ToInt32(Console.ReadLine());
			int[] grades = new int[n];
			for (int grades_i = 0; grades_i < n; grades_i++)
			{
				grades[grades_i] = Convert.ToInt32(Console.ReadLine());
			}
			int[] result = solve(grades);
			Console.WriteLine(String.Join("\n", result));

		}

		static int[] solve(int[] grades)
		{
			// Complete this function
			for (int i = 0; i < grades.Length; i++)
			{
				if (grades[i] >= 38 && grades[i] % 5 >= 3)
				{
					//Console.WriteLine($"inside for n if i={i} & grades[{i}]={grades[i]}");
					decimal d = Convert.ToDecimal(grades[i] / 5);
					grades[i] = 5 * ((int)Math.Ceiling(d) + 1);
				}

			}
			return grades;
		}
	}
}
