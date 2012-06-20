using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// http://projecteuler.net/problem=5

namespace ProjectEuler.Solutions
{
	public class Problem5 : IPESolver
	{
		public void Solve()
		{
			Console.WriteLine(GetSmallestEvenlyDivisible(20));
		}

		private int GetSmallestEvenlyDivisible(int number)
		{
			int result = 0;

			for (int i = number; i < Int32.MaxValue; i += number)
			{
				bool works = true;

				for (int j = 1; j <= number; j++)
				{
					if (i % j != 0)
					{
						works = false;
						break;
					}
				}

				if (works)
				{
					result = i;
					break;
				}
			}

			return result;
		}
	}
}
