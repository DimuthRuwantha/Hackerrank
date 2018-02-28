using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp._30DaysOfCode.scope
{
	class scopeMain
	{
		public scopeMain()
		{
			Convert.ToInt32(Console.ReadLine());

			int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

			Difference d = new Difference(a);

			d.computeDifference();

			Console.Write(d.maximumDifference);
			Console.ReadKey(true);
		}
	}
}
