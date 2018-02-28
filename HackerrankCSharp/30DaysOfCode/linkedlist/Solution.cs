using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp._30DaysOfCode.linkedlist
{
	class Solution
	{
		public Solution()
		{
			Node head = null;
			int T = Int32.Parse(Console.ReadLine());
			while (T-- > 0)
			{
				int data = int.Parse(Console.ReadLine());
				head = insert(head, data);
			}
			display(head);
			Console.ReadKey(true);
		}

		public static Node insert(Node head, int data)
		{
			//Complete this method
			if (head == null)
			{
				return new Node(data);
			}
			else if (head.next != null)
			{
				insert(head.next, data);
			}
			else
			{
				head.next = new Node(data);
			}
			return head;
		}

		public static void display(Node head)
		{
			Node start = head;
			while (start != null)
			{
				Console.Write(start.data + " ");
				start = start.next;
			}
		}
	}
}
