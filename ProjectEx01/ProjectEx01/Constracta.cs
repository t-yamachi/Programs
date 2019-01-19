using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEx01
{
	class Constracta
	{
		static void Main(string[] args)
		{
			Person p1, p2;
			p1 = new Person ();
			p2 = new Person ("山田太郎", 29);
			p1.Name="鈴木花子";
			p1.Age = 22;
			p1.ShowAgeAndName ();
			p2.ShowAgeAndName ();
		}
	}
}

