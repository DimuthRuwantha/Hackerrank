﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp._30DaysOfCode.binaryTrees
{
	class Node
	{
		public Node left, right;
		public int data;
		public Node(int data)
		{
			this.data = data;
			left = right = null;
		}
	}
}
