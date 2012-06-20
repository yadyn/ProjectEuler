using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// http://projecteuler.net/problem=2

namespace ProjectEuler.Solutions
{
	public class Problem2 : IPESolver
	{
		public void Solve()
		{
			// Generate the example series
			//for (int i = 1; i < 10; i++)
			//    Console.WriteLine(GetFibValue(i));

			int i = 1;
			int sum = 0;
			int fibValue = 0;

			while (fibValue < 4000000)
			{
				fibValue = GetFibValue(i);
				if (fibValue % 2 == 0)
					sum += fibValue;
				i++;
			}

			Console.WriteLine(sum);
		}

		private int GetFibValue(int index)
		{
			if (index == 0)
				return 0;
			if (index < 2)
				return 1;
			else
			{
				var values = new int[] { 1, 1, 1 };

				for (int i = 2; i <= index; i++)
				{
					values[0] = values[1];
					values[1] = values[2];
					values[2] = values[0] + values[1];
				}

				return values[2];
			}
		}
	}
}
