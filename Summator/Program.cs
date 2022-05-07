using System;

namespace Summator
{
	class Program
	{
		static void Main(string[] args)
		{
			Summator summator = new Summator();

			long result = summator.Sum(new int[] { 1, 2, 3, 4, 5, 6, });
			if (result == 21) {
				Console.WriteLine("TEST PASS");
			}
			else {
				Console.WriteLine("TEST FAIL");
			}

			double average = summator.Avarage(new double[] {5, 10, 15});
			
			if (average == 10)
			{
				Console.WriteLine("TEST PASS");
			}
			else
			{
				Console.WriteLine("TEST FAIL");
			}
		}
	}
}
