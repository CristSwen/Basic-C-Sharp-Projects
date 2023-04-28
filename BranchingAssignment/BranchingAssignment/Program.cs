using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to Package Express. Please follow the instructions below");

			Console.WriteLine("What is your package's weight?");
			decimal packageWeight = Convert.ToDecimal(Console.ReadLine());

			if (packageWeight > 50)
			{
				Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good Day");
				Console.ReadLine();
			}
			else
			{
				Console.WriteLine("What is the package's width?");
				decimal packageWidth = Convert.ToDecimal(Console.ReadLine());
				Console.WriteLine("What is the package's height?");
				decimal packageHeight = Convert.ToDecimal(Console.ReadLine());
				Console.WriteLine("What is the package's length?");
				decimal packageLength = Convert.ToDecimal(Console.ReadLine());

				decimal packageDimension = packageWidth + packageHeight + packageLength;
				if (packageDimension > 50)
				{
					Console.WriteLine("Package too big to be shipped via Package Express. Have a good Day");
					Console.ReadLine();
				}
				else
				{
					decimal packageTotal = ((packageWidth * packageHeight * packageLength) * packageWeight);
					decimal packagePrice = packageTotal / 100;
					Console.WriteLine("Your estimated total for shipping this package is: " + packagePrice);
					Console.WriteLine("Thank You");
					Console.ReadLine();
				}
			}
		}
	}
}
			
