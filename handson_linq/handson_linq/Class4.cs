using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handson_linq
{public class Person
    {
		public string first_name;
		public string last_name;
		public int age;
		public Person(string first_name, string last_name, int age) {
			this.first_name =first_name;
			this.age = age;
			this.last_name =last_name;	
		}

	}
	internal class Class4
	{
		
		public void print()
		{
			var people = new List<Person>()
			{
				new Person("Bill", "Smith", 41),
				new Person("Sarah", "Jones", 22),
				new Person("Stacy", "Baker", 21),
				new Person("Vivianne", "Dexter", 19),
				new Person("Bob", "Smith", 49),
				new Person("Brett", "Baker", 51),
				new Person("Mark", "Parker", 19),
				new Person("Alice", "Thompson", 18),
				new Person("Evelyn", "Thompson", 58),
				new Person("Mort", "Martin", 58),
				new Person("Eugene", "DeLauter", 84),
				new Person("Gail", "Dawson", 19),
			};

			var r = from s in people
					where s.last_name.StartsWith("D")
					select s;
			foreach(var d in r)
            {
				Console.WriteLine(d.last_name);
            }
			int p = (from s in people
					where s.last_name.StartsWith("D")
					select s).Count();
			Console.WriteLine(p);
			var w = from s in people
					where ( s.age >40)
					select s;
			var k= from s in w
				   orderby s.first_name ascending
				   select s;	
			foreach(var m in k)
            {
				
				Console.WriteLine(m.first_name);
				Console.WriteLine(m.age);
			}

		}
	}
}
