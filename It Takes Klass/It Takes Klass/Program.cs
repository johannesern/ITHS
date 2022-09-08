namespace It_Takes_Klass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebsiteGenerator websiteGenerator = new WebsiteGenerator();

            Console.WriteLine("Vad heter klassen:");
            string className = Console.ReadLine();

            Console.WriteLine("Vilka kurser ska klassen gå:");
            string courses = Console.ReadLine();

            Console.WriteLine("Hur många meddelande vill ni skriva till klassen:");
            int numberOfMessages = int.Parse(Console.ReadLine());
            List<string> classMessages = websiteGenerator.Messages(numberOfMessages);
            
            websiteGenerator.HTMLbuilder(className, courses, classMessages);

        }
    }
}