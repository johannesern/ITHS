namespace Hemsida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] techniques = { "   C#", "daTAbaser", "WebbuTVeCkling ", "clean Code   " };                 // Från en ev fil
            string[] messagesToClass = { "Glöm inte att övning ger färdighet!", "Öppna boken på sida 257." };   // Kanske har vi fått dessa värden ifrån en API
            string className = ".NET Distans 2022";
            string colour = "red";
			
            //WebsiteGenerator websiteGenerator = new WebsiteGenerator(className, messagesToClass, techniques);
			StyledWebsiteGenerator styledWebsiteGenerator = new StyledWebsiteGenerator(className, messagesToClass, techniques, colour);

            bool run = true;
            while (run)
            {
				Console.WriteLine("Vad vill du göra?\n" +
							  "[1] Visa websidan i consolen\n" +
							  "[2] Spara websidan till en fil\n" +
							  "[3] Utföra både [1] och [2]\n");
				string input = Console.ReadLine();
				switch (input)
				{
					case "1":
						{
							//websiteGenerator.PrintWebsite();
							styledWebsiteGenerator.PrintWebsite();
							run = false;
							break;
						}
					case "2":
						{
							styledWebsiteGenerator.SaveWebsiteToFile();
							Console.Clear();
							run = false;
							break;
						}
					case "3":
						{
							styledWebsiteGenerator.PrintWebsite();
							styledWebsiteGenerator.SaveWebsiteToFile();
							run = false;
							break;
						}
					default:
						{
							Console.WriteLine("Gör ett val");
							break;
						}
				}
			}
        }
    }
}