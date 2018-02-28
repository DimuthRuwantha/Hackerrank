using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp.Algorithms
{
	class CamelCase
	{
		public CamelCase()
		{
			string s = Console.ReadLine();
			int result = camelcase(s);
			Console.WriteLine(result);
		}

		static int camelcase(string s)
		{
			int words = 1;
			// Complete this function
			foreach(char c in s)
			{
				if (c >= 65 && c <= 90) words++;
			}
			return words;
		}

	}
}
