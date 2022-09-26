namespace OOP_Arv_övning_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Industrilokal industrilokal = new Industrilokal(11, 5, 25000);
			industrilokal.antalKvadratmeter = 1200.5f;
			industrilokal.address = "Industrivägen 1";
			Console.WriteLine($"De nya industrilokalen är {industrilokal.höjd} meter hög.\n" +
							  $"Den har {industrilokal.antalRum} rum.\n" + 
							  $"Månadskostnad: {industrilokal.månadsHyra}:-\n" + 
							  $"Yta: {industrilokal.antalKvadratmeter} kvm\n" + 
							  $"Lokalen ligger på {industrilokal.address} i någon stad.");
		}
	}

	public class Fastighet
	{
		public double antalKvadratmeter;
		public string address;
	}

	public class Industrilokal : Fastighet
	{
		public int höjd;
		public int antalRum;
		public int månadsHyra;

		public Industrilokal(int höjd, int antalRum, int månadsHyra)
		{
			this.höjd = höjd;
			this.antalRum = antalRum;
			this.månadsHyra = månadsHyra;
		}
	}
}