using System.Globalization;
using System.Threading;

namespace Samlingsklasser_4___Dictionary
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Första random
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