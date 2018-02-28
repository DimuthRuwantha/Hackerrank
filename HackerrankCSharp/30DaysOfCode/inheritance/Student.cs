using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp._30DaysOfCode.inheritance
{
	class Student:Person
	{
		private int[] testScores;
		public Student(string firstName, string lastName, int id, int[] scores): base(firstName, lastName, id)
		{
			testScores = scores;
		}

		public char Calculate()
		{
			char result;
			double avgScore = testScores.Average();
			if (avgScore < 40) result = 'T';

			else if (avgScore < 55) result = 'D';

			else if (avgScore < 70) result = 'P';

			else if (avgScore < 80) result = 'A';

			else if (avgScore < 90) result = 'E';

			else result = 'O'; 	

			return result;
		}
	}
}
