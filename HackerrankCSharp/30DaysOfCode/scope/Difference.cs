using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp._30DaysOfCode.scope
{
	class Difference
	{
		private int[] elements;
		public int maximumDifference;

		public Difference(int[] elements)
		{
			this.elements = elements;
		}

		public void computeDifference()
		{
			for(int i=0; i<elements.Length; i++)
			{
				for(int j=i+1; j<elements.Length; j++)
				{
					int distLoc = Math.Abs(elements[i] - elements[j]);
					//Console.WriteLine($"{elements[i]} - {elements[j]}");
					if (maximumDifference < distLoc) maximumDifference = distLoc;
					
				}
			}
		}
	}
}
