using System;

namespace Project32
{
	class Sub:Super
	{
		public Sub ()
		{
			Console.WriteLine ("Subのコンストラクタ(引数なし)");
		}
		public Sub(int param):base(param)
		{
			Console.WriteLine ("Subのコンストラクタ(引数:param={0})", param);
		}
		~Sub()
		{
			Console.WriteLine ("Subクラスのデストラクタ");

		}
	}
}

