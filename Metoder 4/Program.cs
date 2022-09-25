namespace Metoder_4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Skriv in din bruttolön:");
			int salary = int.Parse(Console.ReadLine());
			decimal newSalary = SalaryIncrement5percent(salary);
			Console.WriteLine($"Er nya lön efter ökningen är: {newSalary}:-");
		}

		public static decimal SalaryIncrement5percent(int salary)
		{
			decimal fivePercent = 1.05m;
			decimal newSalary = salary * fivePercent;
			return newSalary;
		}
	}
}