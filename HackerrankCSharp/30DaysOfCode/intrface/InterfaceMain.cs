using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp._30DaysOfCode.intrface
{
	class InterfaceMain
	{
		public InterfaceMain()
		{
			int n = Int32.Parse(Console.ReadLine());
			AdvancedArithmetic myCalculator = new Calculator();
			int sum = myCalculator.divisorSum(n);
			Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
		}
	}
}
