using HackerrankCSharp._30DaysOfCode.exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp._30DaysOfCode
{
	class Calculator
	{
		public int power(int n, int p)
		{
			if (n < 0 || p < 0)
			{
				throw new MyException("n and p should be non-negative");
			}
			return  (int) Math.Pow(n,p);
		}
	}
}
