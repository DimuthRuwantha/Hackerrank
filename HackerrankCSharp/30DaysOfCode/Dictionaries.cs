using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp._30DaysOfCode
{
	class Dictionaries
	{
		public Dictionaries()
		{
			Dictionary<string, int> dict = new Dictionary<string, int>();
			int n = Convert.ToInt32(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				string[] line = Console.ReadLine().Split(' ');
				dict.Add(line[0], Convert.ToInt32(line[1]));
			}
			string name;
			while ((name = Console.ReadLine()) != String.Empty)
			{
				try
				{
					int number = dict[name];
					Console.WriteLine($"{name}={number}");
				}
				catch (KeyNotFoundException e)
				{
					Console.WriteLine("Not found");
				}
			}
		}
	}
}
