using System;

namespace ProjectEx31
{
	class ExCalculator : Calculator
	{
		public void mu1()
		{
			Console.WriteLine ("{0}*{1}={2}", num1, num2, num1 * num2);
		}
		public void div()
		{
			Console.WriteLine ("{0}/{1}={2}", num1, num2, num1 / num2);
		}
	}
}

