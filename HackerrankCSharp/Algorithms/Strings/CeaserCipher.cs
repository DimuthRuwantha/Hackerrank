using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp.Algorithms
{
	class CeaserCipher
	{
		public CeaserCipher()
		{
			int n = Convert.ToInt32(Console.ReadLine());
			string s = Console.ReadLine();
			int k = Convert.ToInt32(Console.ReadLine());
			string result = caesarCipher(s, k);
			Console.WriteLine(result);
		}

		static string caesarCipher(string s, int k)
		{
			byte[] bytes = Encoding.ASCII.GetBytes(s);
			int[] result = Array.ConvertAll(bytes, Convert.ToInt32);
			StringBuilder sBuilder = new StringBuilder();
			int j;
			foreach (int i in result){			
				if(i>=65 && i <= 90){
					j = (i-65) + k;
					int a = j % 26;

					j = 65 + a;					
				}
				else if(i>=97 && i <= 122){
					j = (i-97)+ k;
					int a = j % 26;
					j = 97 + a;
				}
				else{
					j = i;
				}

				char s2 = Convert.ToChar(j);
				sBuilder.Append(s2);
			}
			string fString = sBuilder.ToString();
			return fString;
		}
	}
}
