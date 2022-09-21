using Utilities;

namespace Extension_Methods_4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int x = 5;
			Console.WriteLine(x.IsEven());
		}
	}
}

namespace Utilities
{
	public static class MyUtilities
	{
		public static bool IsEven(this int input)
		{
			if(input % 2 == 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}