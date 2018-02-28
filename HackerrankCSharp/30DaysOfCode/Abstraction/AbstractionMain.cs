using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankCSharp._30DaysOfCode.Abstraction
{
	class AbstractionMain
	{
		public AbstractionMain()
		{
			String title = Console.ReadLine();
			String author = Console.ReadLine();
			int price = Int32.Parse(Console.ReadLine());
			Book new_novel = new MyBook(title, author, price);
			new_novel.display();
		}
	}
}
