using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp.Algorithms
{
	class DevsDay
	{
		public DevsDay()
		{
			int year = Convert.ToInt32(Console.ReadLine());
			string result = solve(year);
			Console.WriteLine(result);
		}

		static string solve(int year)
		{
			int date = 13;
			int month = 09;
			bool val = year % 100 ==0;
			if(year < 1918 && year%4==0)
			{
				date--;
			}
			else if (year%400==0)
			{
				date--;
			}
			else if (year%4==0 && (year % 100) != 0)
			{
				date--;
			}
			return $"{date}.0{month}.{year}";
		}

	}
}
