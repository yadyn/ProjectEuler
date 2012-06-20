using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ProjectEuler.Solutions;

namespace ProjectEuler
{
	public class Program
	{
		static void Main(string[] args)
		{
			IPESolver solver = new Problem1();

			solver.Solve();
		}
	}
}
