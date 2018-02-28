using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp.Algorithms
{
	class CommanBirds
	{
		public CommanBirds()
		{
			int n = Convert.ToInt32(Console.ReadLine());
			string[] ar_temp = Console.ReadLine().Split(' ');
			int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
			int result = migratoryBirds(n, ar);
			Console.WriteLine(result);
		}

		static int migratoryBirds(int n, int[] ar)
		{
			Dictionary<int, int> map = new Dictionary<int, int>();
			int maxNum = 0;
			int maxType = 0;
			foreach(int type in ar)
			{
				try
				{
					map[type] = map[type] + 1;
				}
				catch(KeyNotFoundException e)
				{
					map[type] = 1;
				}
				if (maxNum < map[type])
				{
					maxNum = map[type];
					maxType = type;
				}
				else if(maxNum == map[type] && maxType > type)
				{
					maxType = type;
				}
			}
			return maxType;
		}
	}
}
