using System.Security.Cryptography.X509Certificates;

namespace LINQ_Aggregate
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Monster> monsterList = new List<Monster>()
			{
				new Monster("Gromp", 100, false),
				new Monster("Cranky", 120, true),
				new Monster("CoffeeSpiller", 35, false)
			};

			/*1. Använd SELECT och FOREACH för att skriva ut alla namn på monstrena (det är en bra
				 ide att lägga in alla monsternamn i en var eller List<string> om ni vill ha en
				 temporär variabel).*/
			////Query
			//var allMonsters = from monster in monsterList
			//					 select monster;
			//foreach(Monster monster in allMonsters)
			//{
			//	Console.WriteLine(monster.Name);
			//}

			////One-Liner
			//monsterList.ForEach(monster => Console.WriteLine(monster.Name));

			/*2. Använd WHERE, SELECT och FOREACH för att skriva ut alla monster med mer än 50
				 health.*/
			////Query
			//var monsterWithHealthMoreThan50 = from monster in monsterList
			//								  where monster.Health > 50
			//								  select monster;
			//foreach(var monster in monsterWithHealthMoreThan50)
			//{
			//	Console.WriteLine(monster.Name + " " + monster.Health);
			//}

			////One-Liner
			//monsterList.Where(monster => monster.Health > 50).ToList().ForEach(monster => Console.WriteLine(monster.Name + " " + monster.Health));

			/*3. Använd WHERE, SELECT och FOREACH för att skriva ut alla monster som inte är
				 döda.*/
			////Query
			//var monsterAlive = from monster in monsterList
			//				   where !monster.isDead
			//				   select monster;
			//foreach (var monster in monsterAlive)
			//{
			//	Console.WriteLine(monster.Name + " " + monster.isDead);
			//}

			////One-Liner
			//monsterList.Where(monster => !monster.isDead).ToList().ForEach(monster => Console.WriteLine(monster.Name + " " + monster.isDead));

			/*4. Använd SELECT, ORDERBY och FOREACH för att skriva ut alla namn i ascending
				 order.*/
			//Query
			//var monsterSorted = from monster in monsterList
			//					orderby monster.Name
			//					select monster;
			//foreach (var monster in monsterSorted)
			//{
			//	Console.WriteLine(monster.Name);
			//}

			////One-Liner
			//monsterList.OrderBy(monster => monster.Name).ToList().ForEach(monster => Console.WriteLine(monster.Name));

			//4. Omvänd sortering. (Descending)
			//var monsterSortedDescending = from monster in monsterList
			//					orderby monster.Name descending
			//					select monster;
			//foreach (var monster in monsterSortedDescending)
			//{
			//	Console.WriteLine(monster.Name);
			//}

			////One-Liner
			//monsterList.OrderByDescending(monster => monster.Name).ToList().ForEach(monster => Console.WriteLine(monster.Name));

			//5. Course-Generator
			/*Diskutera hur det ska gå till och skriv om denna så att
			  den använder en Aggregator.*/
			//string courseGenerator(string[] techniques)
			//{
			//	foreach (string technique in techniques)
			//	{
			//		string tmp = technique.Trim();
			//		kurser += "<p>" + tmp[0].ToString().ToUpper() +
			//		tmp.Substring(1).ToLower() + "</p>\n";
			//	}
			//	return kurser;
			//}
			//string[] techniques = { "   C#", "daTAbaser", "WebbuTVeCkling ", "clean Code   " };

			//string formattedTechnique = techniques.Aggregate("", (courseList, next) => 
			//{
			//	next = next.Trim();
			//	courseList += "\n<p> " + next.Substring(0, 1).ToUpper() + next.Substring(1).ToLower() + " <p/>";
			//	return courseList;
			//});
			//Console.WriteLine(formattedTechnique);

			//6. PrintWelcome
			/*Diskutera hur det ska gå till och skriv om denna så att
			  den använder en Aggregator.*/
			//string printWelcome(string className, string[] message)
			//{
			//string welcome = $"<h1> Välkomna {className}! </h1>";
			//string welcomeMessage = "";
			//foreach (string msg in message)
			//{
			//welcomeMessage +=
			//$"\n<p><b> Meddelande: </b> {msg} </p>";
			//}
			//return welcome + welcomeMessage;
			//}

			string[] messagesToClass = { "Glöm inte att övning ger färdighet!", "Öppna boken på sida 257." };
			string className = "ITHS .NET 2022";

			PrintWelcome(className, messagesToClass);
		}
		public static void PrintWelcome(string className, string[] message)
		{
			string welcome = $"<h1> Välkomna {className}! </h1>";

			string welcomeMessage = message.Aggregate("", (messageList, nextMessage) =>
			{
				messageList += $"\n<p><b> Meddelande: </b> {nextMessage} </p>";
				return messageList;
			});
			Console.WriteLine(welcomeMessage);
			//string welcomeMessage = "";
			//foreach (string msg in message)
			//{
			//	welcomeMessage += $"\n<p><b> Meddelande: </b> {msg} </p>";
			//}
			//return welcome + welcomeMessage;
		}

		class Monster
		{
			public string Name { get; set; }
			public int Health { get; set; }
			public bool isDead { get; set; }
			public Monster(string name, int health, bool isDead)
			{
				Name = name;
				Health = health;
				this.isDead = isDead;
			}
		}
	}
}