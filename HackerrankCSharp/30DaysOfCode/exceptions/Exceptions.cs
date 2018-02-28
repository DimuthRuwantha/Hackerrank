using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp._30DaysOfCode
{
	class Exceptions
	{
		public Exceptions()
		{
			string S = Console.ReadLine();
			try
			{
				Console.WriteLine(Convert.ToInt32(S));
			}
			catch (FormatException e)
			{
				Console.WriteLine("Bad String");
			}
		}
	}
}
