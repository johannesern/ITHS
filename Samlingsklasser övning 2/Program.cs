namespace Samlingsklasser_övning_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("\n\t\tMedelvärdet av listan är nu: 0");
			List<int> list = new List<int>();
			bool run = true;
			while (run)
			{
				Console.WriteLine("\n\t\tSkriv in ett tal: ");
				Console.Write("\t\t-");
				int temp =int.Parse(Console.ReadLine());
				if(temp == 0)
				{
					run = false;
				}
				else
				{
					list.Add(temp);
				}
				Console.Clear();
				Console.WriteLine("\n\t\tMedelvärdet av lista är nu: " + list.Average());
			}
		}
	}
}