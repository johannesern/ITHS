using System.Globalization;

namespace Samlingsklasser_4___Dictionary
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Random random1 = new Random();
			Dictionary<string, int> dictionary = CreateDictionary();
			Random random2 = new Random();
			int firstCard = random1.Next(1, 53); //Keyvaluepair någonting, kolla csharpexercise, jämföra 2 kort

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