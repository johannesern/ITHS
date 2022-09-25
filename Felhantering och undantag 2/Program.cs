namespace Felhantering_och_undantag_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string _inkomst = "din inkomst";
			int inkomst = TryingMyBestToMakeThingsWork(_inkomst);
			string _timmar = "antal timmar";
			int timmar = TryingMyBestToMakeThingsWork(_timmar);
						
			try
			{
				Console.WriteLine("Din timlön blev: " + (inkomst / timmar) + " kr/h");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Är du galen!? Det går inte att dela med 0...");
			}
		}

		public static int TryingMyBestToMakeThingsWork(string x)
		{
			int input = 0;
			bool run = true;
			while (run)
			{
				bool ExcThrow = false;
				Console.Clear();
				try
				{
					Console.Write($"Ange {x}: ");
					input = int.Parse(Console.ReadLine());
				}
				catch (Exception ex)
				{
					Console.WriteLine("Felaktig inmatning, försök igen");
					Console.ReadKey();
					ExcThrow = true;
				}
				finally
				{
					if (ExcThrow)
					{
						run = true;
					}
					else
					{
						run = false;
					}
				}
			}
			return input;
		}
	}
}