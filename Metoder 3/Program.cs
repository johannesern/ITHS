namespace Metoder_3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Skriv in första talet: ");
			int x = int.Parse(Console.ReadLine());
			Console.WriteLine("Skriv in andra talet: ");
			int y = int.Parse(Console.ReadLine());
			Multiply(x, y);
		}

		public static void Multiply(int x, int y)
		{
			int sum = x * y;
			Console.WriteLine($"Multipliceringen av {x} och {y} = {sum}");
		}
	}
}