using Utilities;

namespace Extension_Methods_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string test = "Visual Studio is an awesome IDE!";
			Console.WriteLine(test.WordCount().ToString());
		}
	}
}

namespace Utilities
{
	public static class MyUtilities
	{
		public static int WordCount(this string input)
		{
			string[] strings = input.Split(' ');
			return strings.Length;
		}
	}
}