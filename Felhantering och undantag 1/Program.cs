namespace Felhantering_och_undantag_1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.Write("Ange din inkomst: ");
				int inkomst = int.Parse(Console.ReadLine());
				Console.Write("Ange antal timmar: ");
				int timmar = int.Parse(Console.ReadLine());

				Console.WriteLine("Din timlön blev: " + (inkomst / timmar) + " kr/h");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}
	}
}