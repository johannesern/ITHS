using Utilities;

namespace Extension_Methods_5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string test = "5";
			Console.WriteLine(test.IsNumeric());
		}
	}
}

namespace Utilities
{
	public static class MyUtilities
	{
		public static bool IsNumeric(this string input)
		{
			bool isItNumeric = int.TryParse(input, out int value);
			return isItNumeric;
		}
	}
}