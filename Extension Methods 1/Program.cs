using System.Security.Cryptography.X509Certificates;
using Utilities;

namespace Extension_Methods_1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string test = "";
			Console.WriteLine(test.HasValue());
		}
	}
}

namespace Utilities
{
	public static class MyUtilities
	{
		public static bool HasValue(this string input)
		{
			if (String.IsNullOrWhiteSpace(input))
			{
				return false;
			}
			else
			{
				return true;
			}
		}
	}
}