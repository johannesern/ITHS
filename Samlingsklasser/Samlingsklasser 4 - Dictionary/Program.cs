using System.Globalization;
using System.Threading;

//Övning 4
//Bygg vidare på Övning 3 men använd en Dictionary istället. 
//Som nyckel använder du "k5" etc eftersom dessa är unika i en kortlek på 52 kort. 
//Som värde lagrar du int, Ess = 1, Kung = 13, etc. 
//Dra nu två kort åt gången utan att "minska" kortleken och skriv ut "PAR" de gånger du drar två lika kort, dvs att värdet är lika. 
//För att lösa detta måste du slumpvis kunna välja en nyckel i Dictionary vilket du kan genom att gå på Keys i Dictionary som i sig är en lista. 
//Försök till sist beräkna hur många gånger det blir "PAR" om du gör 1000 dragningar.

namespace Samlingsklasser_4___Dictionary
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Random random1 = new Random();
			int firstCard = random1.Next(1, 53);
			Dictionary<string, int> dictionary = CreateDictionary();
			Random random2 = new Random();
			int parCounter = 0;
			for (int i = 0; i < 1000; i++)
			{
				//Andra random efter att programmet fått jobba lite,
				//ligger båda random direkt efter varandra finns risken
				//att man får två random tal i serie och inte olika värde.
				int secondCard = random2.Next(0, 52);
				if (firstCard != secondCard)
				{
					if(dictionary.ElementAt(firstCard).Value == dictionary.ElementAt(secondCard).Value)
					{
						Console.WriteLine("PAR!");
						Console.WriteLine(i);
						parCounter++;
					}
				}
				firstCard = random1.Next(0, 52);
			}
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\nAv 1000 test erhölls Par " + parCounter + " gånger.");
			Console.ForegroundColor = ConsoleColor.Gray;
		}

		public static Dictionary<string, int> CreateDictionary()
		{
			List<string> kortlek = CreateCardDeck();
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			int counter1 = 0;
			int counter2 = 1;
			bool run = true;
			do
			{
				if (counter1 == 52)
				{
					run = false;
				}
				else
				{
					dictionary.Add(kortlek[counter1], counter2);
					counter1++;
					counter2++;
					if (counter2 == 14)
					{
						counter2 = 1;
					}
				}
			} while (run);
			return dictionary;
		}

		public static List<string> CreateCardDeck()
		{
			List<string> kortlek = new List<string>();
			string[] kortTyp = new string[] { "h", "k", "r", "s" };
			foreach (string typ in kortTyp)
			{
				foreach (string card in CardColor(typ))
				{
					kortlek.Add(card);
				}
			}
			return kortlek;
		}

		public static string[] CardColor(string x)
		{
			string[] arr = new string[13];
			arr[0] = x + "E";
			for (int i = 1; i < 10; i++)
			{
				arr[i] = x + (i + 1);
			}
			arr[10] = x + "Kn";
			arr[11] = x + "D";
			arr[12] = x + "K";
			return arr;
		}
	}
}