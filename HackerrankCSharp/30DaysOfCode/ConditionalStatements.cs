﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp._30DaysOfCode
{
	class ConditionalStatements
	{
		public ConditionalStatements()
		{
			int N = Convert.ToInt32(Console.ReadLine());

			if(N % 2 != 0)
			{
				Console.WriteLine("Weird");
			}
			else if(2 <= N  && N <= 5)
			{
				Console.WriteLine("Not Weird");
			}
			else if(N <= 20)
			{
				Console.WriteLine("Weird");
			}
			else
			{
				Console.WriteLine("Not Weird");
			}
		}
	}
}
