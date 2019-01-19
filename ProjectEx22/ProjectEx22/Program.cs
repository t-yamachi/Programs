using System;

namespace ProjectEx22
{
	class Program
	{
		private static int snum=100;

		public int inum = 200;

		public static void foo()
		{
			Console.WriteLine ("fooメソッド (staticメソッド)");
		}
		public void bar()
		{
			Console.WriteLine ("barメソッド (インスタンスメソッド)");
		}
		static void Main(string[] args)
		{
			Program p = new Program ();
				Console.WriteLine("pのインスタンスフィールド:inum={0}",p.inum);
			Console.WriteLine ("Programのクラスフィールド:snum={0}", snum);
			foo ();
			p.bar ();
		}
	}
}
