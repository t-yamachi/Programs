﻿using System;

namespace ProjectEx31
{
	class Program
	{
		static void Main (string[] args)
		{
			Calculator c1 = new Calculator ();
			c1.Num1 = 10;
			c1.Num2 = 3;
			c1.add ();
			c1.sub ();
			ExCalculator c2 = new ExCalculator ();
			c2.Num1 = 10;
			c2.Num2 = 3;
			c2.add ();
			c2.sub ();
			c2.mu1 ();
			c2.div ();
		}
	}
}
