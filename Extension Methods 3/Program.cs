
using Utilities;

namespace Extension_Methods_3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string test = "Jag älskar att köra motorcykel!";
			foreach (string s in test.ToLineArray())
			{
				Console.WriteLine(s);
			}
		}
	}
}

namespace Utilities
{
	public static class MyUtilities
	{
		public static List<string> ToLineArray(this string input)
		{
			List<string> lines = new List<string>();
			string[] strings = input.Split(' ');
			foreach(string s in strings)
			{
				lines.Add(s);
			}
			return lines;
		}
	}
}