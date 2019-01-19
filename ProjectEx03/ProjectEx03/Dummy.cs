using System;

namespace ProjectEx03
{
	public class Dummy
	{
		public Dummy ()
		{
			Console.WriteLine ("コンストラクタ");
		}
		~Dummy()
		{
			Console.WriteLine ("デストラクタ");
		}
	}
}

