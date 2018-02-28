using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp._30DaysOfCode.Abstraction
{
	class MyBook: Book
	{
		readonly int price;
		public MyBook(String title, String author, int price): base(title, author)
		{
			this.price = price;
		}

		public override void display()
		{
			Console.WriteLine($"Title: {title}");
			Console.WriteLine($"Author: {author}");
			Console.WriteLine($"Price: {price}");
		}
	}
}

//Title: The Alchemist
//Author: Paulo Coelho
//Price: 248