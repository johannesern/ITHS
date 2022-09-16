namespace Metoder_5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] myArray = new string[] { "Jag", "gillar", "att", "köra", "motorcykel!" };
			string whatDoYouLike = ConcatThisArray(myArray);
			Console.WriteLine(whatDoYouLike);
		}

		public static string ConcatThisArray(string[] myArray)
		{
			string concatedString = "";
			foreach(string str in myArray)
			{
				concatedString += str + " ";
				concatedString.Trim();
			}
			return concatedString;
		}
	}
}