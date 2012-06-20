using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// http://projecteuler.net/problem=3

namespace ProjectEuler.Solutions
{
	public class Problem3 : IPESolver
	{
		public void Solve()
		{
			//Example: 13195
			//Solve for: 600851475143
			Console.WriteLine(GetLargestPrimeFactor(600851475143));
		}

		private long GetLargestPrimeFactor(long value)
		{
			if (value <= 2)
				return value;

			long factor = GetSmallestPrimeFactor(value);
			long factoredValue = value;

			while (factor != factoredValue)
			{
				factoredValue /= factor;
				factor = GetSmallestPrimeFactor(factoredValue);
			}

			return factor;
		}
		private long GetSmallestPrimeFactor(long value)
		{
			if (value % 2 == 0)
				return 2;
			else if (value % 3 == 0)
				return 3;
			else if (value % 5 == 0)
				return 5;
			else
				for (int i = 7; i < value; i += 2)
					if (IsPrime(i) && value % i == 0)
						return i;

			return value;
		}
		private bool IsPrime(long number)
		{
			if (number <= 1) return false;

			for (long i = 2; i * i <= number; i++)
			{
				if (number % i == 0) return false;
			}

			return true;
		}
	}
}
