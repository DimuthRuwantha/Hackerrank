using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp.Algorithms.Strings
{
	class MarsExplore
	{
		public MarsExplore()
		{
			string s = Console.ReadLine();
			int result = marsExploration(s);
			Console.WriteLine(result);
		}

		static int marsExploration(string s)
		{
			int noise = 0;
			List<char> sos = new List<char>(s);	
			for (int i=0; i < sos.Count; )
			{
				if (0 != sos.ElementAt(i++) - 'S') noise++;
				if (0 != sos.ElementAt(i++) - 'O') noise++;
				if(0!= sos.ElementAt(i++) - 'S') noise++;
			}
			return noise;
		}
	}
}
