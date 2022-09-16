namespace Demo_och_Arv
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Bil newBil = new Bil(4, 6, "ABC123");
			newBil.type = "Sedan";
			newBil.usage = "Bruksbil";
			Båt eka = new Båt(true, false, 30);
			eka.type = "Eka";
			eka.usage = "Åka på sjön";
			Console.WriteLine("Typ: " + newBil.type);
			Console.WriteLine("Användningsområde: " + newBil.usage);
			Console.WriteLine("Antal hjul: " + newBil.amountWheels);
			Console.WriteLine("Antal rutor: " + newBil.amountWindows);
			Console.WriteLine("Registreringsnummer: " + newBil.registrationNumber + "\n");
			Console.WriteLine("Typ: " + eka.type);
			Console.WriteLine("Användningsområde: " + eka.usage);
			if (eka.hasExternalEngine)
				Console.WriteLine("Har båten utombordare: Ja");
			else
				Console.WriteLine("Har båten utombordare: Nej");
			if (eka.hasCabin)
				Console.WriteLine("Har båten hytt: Ja");
			else
				Console.WriteLine("Har båten hytt: Nej");
			Console.WriteLine("Hur många knop gör den: " + eka.knots);
			Console.ReadLine();
		}
	}
	public class Fordon
	{
		public string type;
		public string usage;
	}

	public class Bil : Fordon
	{
		public int amountWheels;
		public int amountWindows;
		public string registrationNumber;

		public Bil(int amountWheels, int amountWindows, string registrationNumber)
		{
			this.amountWheels = amountWheels;
			this.amountWindows = amountWindows;
			this.registrationNumber = registrationNumber;
		}
	}

	public class Båt : Fordon
	{
		public bool hasExternalEngine;
		public bool hasCabin;
		public int knots;

		public Båt(bool hasExternalEngine, bool hasCabin, int knots)
		{
			this.hasExternalEngine = hasExternalEngine;
			this.hasCabin = hasCabin;
			this.knots = knots;
		}
	}
}