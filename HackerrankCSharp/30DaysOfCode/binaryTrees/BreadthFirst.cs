using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp._30DaysOfCode.binaryTrees
{
	class BreadthFirst
	{
		public BreadthFirst()
		{
			Node root = null;
			int T = Int32.Parse(Console.ReadLine());
			while (T-- > 0)
			{
				int data = Int32.Parse(Console.ReadLine());
				root = insert(root, data);
			}
			levelOrder(root);
		}

		static void levelOrder(Node root)
		{
			//Write your code here
		}

		static Node insert(Node root, int data)
		{
			if (root == null)
			{
				return new Node(data);
			}
			else
			{
				Node cur;
				if (data <= root.data)
				{
					cur = insert(root.left, data);
					root.left = cur;
				}
				else
				{
					cur = insert(root.right, data);
					root.right = cur;
				}
				return root;
			}
		}
	}
}
