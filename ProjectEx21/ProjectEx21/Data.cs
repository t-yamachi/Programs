using System;

namespace ProjectEx21
{
	class Data
	{
		private static int num = 0;

		private int id;

		public Data(int id)
		{
			this.id = id;
			num++;
			Console.WriteLine ("値:{0} 数:{1}", this.id, num);
		}
		public static void ShowNumber()
		{
			Console.WriteLine ("Dateオブジェクトの数:{0}", num);
	}
	}
}

