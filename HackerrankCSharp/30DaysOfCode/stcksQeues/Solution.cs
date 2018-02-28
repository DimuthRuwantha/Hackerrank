using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp._30DaysOfCode.stcksQeues
{
	class Solution
	{
		Stack<char> stack;
		Queue<char> queue;

		public Solution()
		{
			stack = new Stack<char>();
			queue = new Queue<char>();
		}

		public void pushCharacter(char c)
		{
			stack.Push(c);
		}

		public char popCharacter()
		{
			return stack.Pop();
		}

		public void enqueueCharacter(char c)
		{
			queue.Enqueue(c);
		}

		public char dequeueCharacter()
		{
			return queue.Dequeue();
		}
	}
}
