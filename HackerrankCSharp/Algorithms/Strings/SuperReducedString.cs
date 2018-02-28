using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HackerrankCSharp.Algorithms
{
	class SuperReducedString
	{
		public SuperReducedString()
		{
			string s = Console.ReadLine();
			string result = super_reduced_string(s);
			Console.WriteLine(result);
		}

		public string super_reduced_string(string s)
		{
			string regx = @"(.)\1{1}";

			MatchCollection mc = Regex.Matches(s, regx);
			StringBuilder builber = new StringBuilder();
			do
			{
				foreach(Match m in mc)
				{
					s = s.Replace(m.Value, "");
					//Console.WriteLine(m);
				}
				mc = Regex.Matches(s, regx);
			}
			while (mc.Count != 0);		
			
			if (s == "") return "Empty String";
			return s;
		}
	}
}
