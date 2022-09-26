namespace Samlingsklasser_3___Kortlek
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<string> kortlek =	CreateCards();
			bool run = true;
			Random random = new Random();
			do
			{
				if(kortlek.Count == 0)
				{
					run = false;
				}
				else
				{
					int i = random.Next(0, kortlek.Count);
					Console.WriteLine(kortlek[i]);
					kortlek.RemoveAt(i);
				}
			}while (run);
		}

		public static List<string> CreateCards()
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