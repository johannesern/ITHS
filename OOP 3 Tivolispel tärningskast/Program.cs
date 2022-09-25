namespace OOP_3_Tivolispel_tärnningskast
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DiceThrow diceThrow = new DiceThrow();
			Console.WriteLine("\n\t\t======= Välkommen till Tärningskastar'n 3000! =====");
			Console.WriteLine("\n\t\t   Tryck på valfri tangent för att börja spela!");
			Console.WriteLine("\n\t Du kommer att ha 3 kast på dig att nå 10 poäng eller mer för att vinna!");
			Console.Write("\n\t\t\t- ");
			Console.ReadKey();
			diceThrow.StartDiceGame();
		}

		public class DiceThrow
		{
			public void StartDiceGame()
			{
				int counter = 0;
				int diceSum = 0;
				Random random = new Random();
				bool run = true;
				do
				{			
					counter++;
					int temp = random.Next(1, 7);
					diceSum += temp;
					Console.WriteLine($"\n\t\t\tPå kast {counter} av 3 fick du {temp} och har {diceSum} poäng!");
					if (counter == 3)
					{
						run = false;
					}
					else
					{
						Console.WriteLine("\n\t\t\tTryck på valfri tangent för att kasta igen.");
						Console.Write("\n\t\t\t- ");
						Console.ReadKey();
					}
				} while (run);

				if (diceSum < 10)
				{
					Console.WriteLine("\n\t\tVilket otur! Du fick för lite poäng, bättre lycka nästa gång!");
				}
				else
				{
					Console.WriteLine("\n\t   Grattis! Du vann Tärningskastarn 3000 och får en liten mjukdjurshäst!");
				}
			}
		}
	}
}