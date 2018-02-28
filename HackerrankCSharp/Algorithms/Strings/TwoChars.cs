using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp.Algorithms
{
	class TwoChars
	{
		public TwoChars()
		{
			int l = Convert.ToInt32(Console.ReadLine());
			string s = Console.ReadLine();
			int result = twoCharaters(s);
			Console.WriteLine(result);
		}

		static int twoCharaters(string s){
			HashSet<char> chars = new HashSet<char>(s);
			List<char> pattern;
			List<char> fString = new List<char>();

			for (int i=0; i<chars.Count-1; i++){
				char a = chars.ElementAt(i);

				for (int j=i+1; j < chars.Count; j++){
					pattern = new List<char>();
					char b = chars.ElementAt(j);

					for(int k=0; k< s.Length; k++){
						char temp = s.ElementAt(k);

						if (temp==a || temp == b){
							if (pattern.Count == 0)
							{
								pattern.Add(temp);
							}
							else if (pattern.Last() != temp)
							{
								pattern.Add(temp);
							}
							else {
								break; }							
						}
						if(k== s.Length - 1 && fString.Count < pattern.Count)
						{
							fString = pattern;
						}
					}
				}
			}
			return fString.Count;
		}
	}
}
