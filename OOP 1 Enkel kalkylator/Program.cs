namespace OOP_Övning_1_Enkel_kalkylator
{
	using System.Threading;
	internal class Program
	{
		static void Main(string[] args)
		{
			Kalkylator kalkylator = new Kalkylator();
			bool run = true;
			while (run)
			{
				Console.Clear();
				Console.WriteLine("\n\t\tVälkommen till Kalkylatorn");
				Console.WriteLine("\t\tVad vill du göra:");
				Console.WriteLine("\t\t[1] Addition");
				Console.WriteLine("\t\t[2] Subtraktion");
				Console.WriteLine("\t\t[3] Multiplikation");
				Console.WriteLine("\t\t[4] Division");
				Console.Write("\t\t- ");
				string choice = Console.ReadLine();
				
				Console.WriteLine("\n\t\tSkriv in första talet:");
				Console.Write("\t\t- ");
				double x = double.Parse(Console.ReadLine());

				Console.WriteLine("\n\t\tSkriv in andra talet:");
				Console.Write("\t\t- ");
				double y = double.Parse(Console.ReadLine());

				switch (choice)
				{
					case "1":
						{
							double add = kalkylator.Addition(x, y);
							Console.WriteLine("\t\tSumman är " + add);
							Console.Write("\t\t- ");
							Console.ReadLine();
							break;
						}
					case "2":
						{
							double sub = kalkylator.Subtraction(x, y);
							Console.WriteLine("\t\tSumman är " + sub);
							Console.Write("\t\t- ");
							Console.ReadLine();
							break;
						}
					case "3":
						{
							double multiply = kalkylator.Multiply(x, y);
							Console.WriteLine("\t\tMultipliceringen blir " + multiply);
							Console.Write("\t\t- ");
							Console.ReadLine();
							break;
						}
					case "4":
						{
							double div = kalkylator.Division(x, y);
							Console.WriteLine("\t\tDivisionen blir " + div);
							Console.Write("\t\t- ");
							Console.ReadLine();
							break;
						}
					default:
						{
							Console.WriteLine("\n\t\tFel val försök igen");
							Thread.Sleep(1000);
							break;
						}
				}
			}
		}
	}

	public class Kalkylator
	{
		public double Addition(double x, double y)
		{
			return x + y;
		}
		public double Subtraction(double x, double y)
		{
			return (x - y) / (x - y);
		}
		public double Multiply(double x, double y)
		{
			return Multiply(x, y);
		}
		public double Division(double x, double y)
		{
			return Division(x, y);
		}
	}
}