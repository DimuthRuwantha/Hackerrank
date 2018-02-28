using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp._30DaysOfCode
{
	class Binary
	{
		public Binary()
		{
			int val = Convert.ToInt32(Console.ReadLine());
			string dVal = Convert.ToString(val, 2);
			Console.WriteLine(dVal);
			int count = 0;
			int cnt = 0;
			foreach (char c in dVal)
			{
				if (c == '1')
				{
					cnt++;
					if (cnt > count)
					{
						count = cnt;
					}
				}
				else
				{
					cnt = 0;
				}

			}
			Console.WriteLine(count);
		}
	}
}
