namespace Metoder_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Print("Galadriel!", 900, 5);
		}
		public static void Print(string name, int xp, int level)
		{
			Console.WriteLine("======MEDELTIDA VÄSTBERGA======\n" +
							 $"Välkommen {name}!\n" +
							 $"XP: {xp}\n" + 
							 $"Level: {level}");
		}
	}
}