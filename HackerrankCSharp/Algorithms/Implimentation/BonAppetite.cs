using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp.Algorithms
{
	class BonAppetite
	{
		public BonAppetite()
		{
			string[] tmp1 = Console.ReadLine().Split(' ');
			int n = Convert.ToInt32(tmp1[0]);
			int k = Convert.ToInt32(tmp1[1]);
			string[] bill = Console.ReadLine().Split(' ');
			int[] iBill = Array.ConvertAll(bill, int.Parse);
			int sum = Convert.ToInt32(Console.ReadLine());
			int cost = 0;
			for(int i=0; i < n; i++)
			{
				if (i != k)
				{
					cost += iBill[i];
					//Console.WriteLine(i);
				}
			}
			int balance = sum - cost / 2;
			if (balance == 0) {
				Console.WriteLine("Bon Appetit");
			}
			else
			{
				Console.WriteLine(balance);
			}
		}
	}
}
