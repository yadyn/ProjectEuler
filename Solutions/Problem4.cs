using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// http://projecteuler.net/problem=4

namespace ProjectEuler.Solutions
{
	public class Problem4 : IPESolver
	{
		public void Solve()
		{
			int number = 0;
			var palindrome = new Tuple<int, int, int>(0, 0, 0);

			// I realize stoping at 900 is cheating a bit
			for (int i = 999; i > 900; i--)
			{
				for (int j = 999; j > 0; j--)
				{
					number = i * j;

					if (IsPalindrome(number) && number > palindrome.Item3)
						palindrome = new Tuple<int, int, int>(i, j, number);
				}
			}

			Console.WriteLine(String.Format("{2} ({0} x {1})", palindrome.Item1, palindrome.Item2, palindrome.Item3));
		}

		private bool IsPalindrome(int number)
		{
			if (number < 10)
				return false;

			string numberText = number.ToString();

			if (numberText.Length % 2 != 0)
				return false;

			for (int i = 0; i < numberText.Length / 2; i++)
			{
				if (numberText[i] != numberText[numberText.Length - 1 - i])
					return false;
			}

			return true;
		}
	}
}
