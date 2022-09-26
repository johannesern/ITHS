namespace OOP_Arv_övning_1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Husdjurskatt husdjurskatt1 = new Husdjurskatt(false, 15, "Sverige", false);
			PrintCat(husdjurskatt1);
			Console.WriteLine();

			Husdjurskatt husdjurskatt2 = new Husdjurskatt(true, 5, "Danmark", true);
			PrintCat(husdjurskatt2);
		}
		public static void PrintCat(Husdjurskatt katt)
		{
			if (katt.gårPåLåda)
			{
				Console.WriteLine("Är katten rumsren? Ja, den klarar att vara hemma själv en stund.");
			}
			else
			{
				Console.WriteLine("Är katten rumsren? Nej! Ett jamande och ut ska den!");
			}
			Console.WriteLine($"Den är {katt.ålder} år gammal.");
			Console.WriteLine($"Den kommer från {katt.världsdel}.");
			if (katt.ärKöttätare)
			{
				Console.WriteLine("Den äter kött, släpp inte ihop den med er guldhamster.");
			}
			else
			{
				Console.WriteLine("Den äter endast torrfoder.");
			}
		}
	}

	public class Kattdjur
	{
		public string världsdel;
		public bool ärKöttätare;

		public Kattdjur(string världsdel, bool ärKöttätare)
		{
			this.världsdel = världsdel;
			this.ärKöttätare = ärKöttätare;
		}
	}

	public class Husdjurskatt : Kattdjur
	{
		public bool gårPåLåda;
		public int ålder;

		public Husdjurskatt(bool gårPåLåda, int ålder, string världsdel, bool ärKöttätare) : base(världsdel, ärKöttätare)
		{
			this.gårPåLåda = gårPåLåda;
			this.ålder = ålder;
		}
	}
}