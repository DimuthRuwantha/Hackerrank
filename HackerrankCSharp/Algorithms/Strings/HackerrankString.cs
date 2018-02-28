using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp.Algorithms.Strings
{
	class HackerrankString
	{	

		public HackerrankString()
		{
			int q = Convert.ToInt32(Console.ReadLine());
			for (int a0 = 0; a0 < q; a0++)
			{
				string s = Console.ReadLine();
				string result = hackerrankInString(s);
				Console.WriteLine(result);
			}
		}

		static string hackerrankInString(string s)
		{
			Queue<char> hackerRank = new Queue<char>();

			hackerRank.Enqueue('h');
			hackerRank.Enqueue('a');
			hackerRank.Enqueue('c');
			hackerRank.Enqueue('k');
			hackerRank.Enqueue('e');
			hackerRank.Enqueue('r');
			hackerRank.Enqueue('r');
			hackerRank.Enqueue('a');
			hackerRank.Enqueue('n');
			hackerRank.Enqueue('k');

			foreach (char c in s)
			{			
				if (c == hackerRank.First())
				{
					hackerRank.Dequeue();
					if (hackerRank.Count == 0) return "YES";
				}
			}
			return "NO";
		}
	}
}
