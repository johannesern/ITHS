using System;
using System.Security.Cryptography;

class DataTransformations
{
    static void Main()
    {
        // Create the first data source.
        List<Student> students = new List<Student>()
        {
            new Student { First="Svetlana",
                Last="Omelchenko",
                ID=111,
                Street="123 Main Street",
                City="Seattle",
                Scores= new List<int> { 97, 92, 81, 60 } },
            new Student { First="Claire",
                Last="O’Donnell",
                ID=112,
                Street="124 Main Street",
                City="Redmond",
                Scores= new List<int> { 75, 84, 91, 39 } },
            new Student { First="Sven",
                Last="Mortensen",
                ID=113,
                Street="125 Main Street",
                City="Lake City",
                Scores= new List<int> { 88, 94, 65, 91 } },
        };

        // Create the second data source.
        List<Teacher> teachers = new List<Teacher>()
        {
            new Teacher { First="Ann", Last="Beebe", ID=945, City="Seattle" },
            new Teacher { First="Alex", Last="Robinson", ID=956, City="Redmond" },
            new Teacher { First="Michiyo", Last="Sato", ID=972, City="Tacoma" }
        };




		// =========== LINQ studenter vars efternamn börjar på "O" ===========

		//LINQ QUERY
		//var studentsLastWithO = from student in students
		//                        where student.Last[0] == 'O'
		//                        select student;

		//foreach(var student in studentsLastWithO)
		//{
		//    Console.WriteLine(student.Last);
		//}

		//LINQ One-liner
		//students.Where(student => student.Last[0] == 'O').ToList().ForEach(student => Console.WriteLine(student.Last));




		// =========== LINQ studenter med något poäng under 50 ===========

		//LINQ QUERY
		//var test = from student in students
		//           where student.Scores.Any(x => x < 50)
		//           select student;

		//foreach (var student in test)
		//{
		//    Console.WriteLine(student.First + " " + student.Last);
		//}

		//LINQ One-liner
		//students.Where(student => student.Scores.Any(x => x < 50)).ToList().ForEach(student => Console.WriteLine(student.First + " " + student.Last));




		// =========== LINQ studenter förnamn alfabetisk ordning och omvänd ordning ===========

		//LINQ QUERY
		//var studentsFirstInAscending = from student in students
		//                                     orderby student.First
		//                                     select student;

		//      foreach (var student in studentsFirstInAscending)
		//      {
		//          Console.WriteLine(student.First);
		//      }

		//LINQ One-liner
		//students.OrderBy(student => student.First).ToList().ForEach(student => Console.WriteLine(student.First));

		//LINQ QUERY
		//var studentsFirstInDescending = from student in students
		//                                     orderby student.First descending
		//                                     select student;

		//      foreach (var student in studentsFirstInDescending)
		//      {
		//          Console.WriteLine(student.First);
		//      }

		//LINQ One-liner
		//students.OrderByDescending(student => student.First).ToList().ForEach(student => Console.WriteLine(student.First));



		// Create the query.
		//var peopleInSeattle = (from student in students
		//                       where student.City == "Seattle"
		//                       select student.Last)
		//            .Concat(from teacher in teachers
		//                    where teacher.City == "Seattle"
		//                    select teacher.Last);

		//Console.WriteLine("The following students and teachers live in Seattle:");
		//// Execute the query.
		//foreach (var person in peopleInSeattle)
		//{
		//    Console.WriteLine(person);
		//}

		Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

	class Student
	{
		public string First { get; set; }
		public string Last { get; set; }
		public int ID { get; set; }
		public string Street { get; set; }
		public string City { get; set; }
		public List<int> Scores;
	}
	class Teacher
	{
		public string First { get; set; }
		public string Last { get; set; }
		public int ID { get; set; }
		public string City { get; set; }
	}
}
/* Output:
    The following students and teachers live in Seattle:
    Omelchenko
    Beebe
 */