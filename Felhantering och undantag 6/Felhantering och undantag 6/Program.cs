namespace Felhantering_och_undantag_6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ProgramStart();
		}

		public static void ProgramStart()
		{
			int inkomst;
			int timmar;
			bool inmatning = false;
			do
			{
				Console.Write("Ange din inkomst: ");
				inmatning = int.TryParse(Console.ReadLine(), out inkomst);
				if (!inmatning)
				{
					Console.WriteLine("Endast heltal och inget annat och försök inte dela med noll.");
					inmatning = false;
				}
				else
				{
					inmatning = true;
				}
			} while (!inmatning);

			do
			{
				Console.Write("Ange antal timmar: ");
				inmatning = int.TryParse(Console.ReadLine(), out timmar);
				if (!inmatning)
				{
					Console.WriteLine("Endast heltal och inget annat och försök inte dela med noll.");
					inmatning = false;
				}
				else
				{
					inmatning = true;
				}
			} while (!inmatning);

			bool Excthrow = false;
			try
			{
				Console.WriteLine("Din timlön blev: " + (inkomst / timmar) + " kr/h");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Försök inte att dela med noll eller några andra dumheter.\nGör om och gör rätt...");
				Excthrow = true;
			}
			finally
			{
				if (Excthrow)
				{
					ProgramStart();
				}
			}
		}
	}
}