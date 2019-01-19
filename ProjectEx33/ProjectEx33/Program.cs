using System;

namespace ProjectEx33
{
	class Program
	{
		public static void Main (string[] args)
		{
			Parent p = new Parent ();

			Child c = new Child ();

			p.Foo ();
			c.Foo ();
		}
	}
}
