using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp._30DaysOfCode
{
	class Review
	{
		public Review()
		{
			int n = Convert.ToInt32(Console.ReadLine());
			StringBuilder sb1 = new StringBuilder();
			StringBuilder sb2 = new StringBuilder();
			for (int k = 0; k < n; k++)
			{

				string str = Console.ReadLine();
				int sLength = str.Length;
				for (int i = 0; i < sLength; i++)
				{
					if (i % 2 == 0)
					{
						sb2.Append(str[i]);
					}
					else
					{
						sb1.Append(str[i]);
					}
				}
				Console.WriteLine($"{sb2.ToString()} {sb1.ToString()}");
				sb2.Clear();
				sb1.Clear();
			}
		}
	}
}
