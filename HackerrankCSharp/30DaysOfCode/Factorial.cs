using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp._30DaysOfCode
{
	class Factorial
	{
		static int factorial(int k)
		{
			if (k <= 1)
			{
				return 1;
			}
			return k * factorial(k - 1);
		}
	}
}
