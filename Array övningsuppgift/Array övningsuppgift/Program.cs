namespace Array_övningsuppgift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            string[] cars = { "Ford", "Cadillac", "Audi" };
            Array.Sort(cars);
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine();

            //2.
            int[] numbers = { 12, 50, 72 };
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine(sum);
            Console.WriteLine();

            //3.
            string[] strings = { "Sagan om Ringen", "Die Hard", "Nyckeln till Frihet", "Star Wars", "Harry Potter" };
            Array.Sort(strings);
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            //4.
            string[,] array = { { "199", "Harry Potter" }, { "99", "En gammal pocket" }, { "399", "Sagan om Ringen" }, };
            for (int i = 0; i < array.Length / 2; i++)
            {
                Console.WriteLine(array[i, 0]);
                Console.WriteLine(array[i, 1]);
            }
        }
    }
}