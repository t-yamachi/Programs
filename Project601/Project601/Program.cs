using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project601
{
	class Program
	{
		static void Main(string[] args)
		{
			Person p1, p2;
			p1 = new Person ();
			p2 = new Person ();
			p1.SetAgeAndName ("山田太郎", 19);
			p2.SetAgeAndName ("佐藤花子", 23);
			p1.ShowAgeAndName ();
			p2.ShowAgeAndName ();
		}
	}
}

