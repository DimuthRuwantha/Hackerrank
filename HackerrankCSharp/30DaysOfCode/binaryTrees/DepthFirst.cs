using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp._30DaysOfCode.binaryTrees
{
	class DepthFirst
	{
		public DepthFirst()
		{
			Node root = null;
			int T = Int32.Parse(Console.ReadLine());
			while (T-- > 0)
			{
				int data = Int32.Parse(Console.ReadLine());
				root = insert(root, data);
			}
			int height = getHeight(root);
			Console.WriteLine(height);
			Console.ReadKey(true);
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

		static int getHeight(Node node)
		{
			if (node == null)
			{
				return (-1); // an empty tree  has height −1
			}
			else
			{
				// compute the depth of each subtree
				int leftDepth = getHeight(node.left);
				int rightDepth = getHeight(node.right);
				// use the larger one
				if (leftDepth > rightDepth)
					return (leftDepth + 1);
				else
					return (rightDepth + 1);
			}
		}
	}
}
