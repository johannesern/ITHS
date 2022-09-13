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

            WebsiteGenerator websiteGenerator = new WebsiteGenerator(className, messagesToClass, techniques);
            //websiteGenerator.PrintWebsite();

            StyledWebsiteGenerator styledWebsiteGenerator = new StyledWebsiteGenerator(className, messagesToClass, techniques, colour);
            styledWebsiteGenerator.PrintWebsite();
            Console.ReadLine();
        }
    }
}