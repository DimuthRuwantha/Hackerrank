using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp._30DaysOfCode.intrface
{
	class Calculator : AdvancedArithmetic
	{
		public Calculator()
		{

		}

		public int divisorSum(int n)
		{
			int sum = 1;
			for(int i=1; i <= n/2; i++)
			{
				if (n % i == 0)
				{
					sum += (n/i);
					Console.WriteLine($"i={i} sum={sum}");
				}
			}
			return sum;
		}
	}
}
