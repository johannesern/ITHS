namespace Stringmanipulation_1_5
{
	internal class Program
	{
		static void Main(string[] args)
		{

		}

		public static void Övning1()
		{
			/*Använd följande kod:
			  string text = "Ylvas%Kaffelager%KB%erbjuder%fri%frakt.";
			  Bearbeta textsträngen så att output blir:
			  Ylvas Kaffelager KB erbjuder fri frakt.*/

			string text = "Ylvas%Kaffelager%KB%erbjuder%fri%frakt.";
			Console.WriteLine(text.Replace("%", " "));
		}
		public static void Övning2()
		{
			/*Använd följande kod:
		      string text = "?Nyhet: Mat-Mats störst i länet. Kantades av motgångar.";
			  Bearbeta textsträngen (observera frågetecknet) så att output blir:
			  Nyhet: Mat-Mats störst i länet. Kantades av motgångar.*/

			string text = "?Nyhet: Mat-Mats störst i länet. Kantades av motgångar.";
			Console.WriteLine(text.Trim('?'));
		}
		public static void Övning3()
		{
			/*Använd följande kod.
			  string text = "?Nyhet: Mat-Mats störst i länet.?Kantades av motgångar.?";
			  Bearbeta textsträngen (observera frågetecknen) så att output blir:
			  Nyhet: Mat-Mats störst i länet. Kantades av motgångar.*/

			string text = "?Nyhet: Mat-Mats störst i länet.?Kantades av motgångar.?";
			Console.WriteLine(text.Replace('?', ' ').Trim());
		}
		public static void Övning4()
		{
			/*Använd följande kod.
		      string text = "http://mat-mats.se/vi-soker-personal";
			  Bearbeta textsträngen så att output blir:
			  Mat-Mats
			  Vi söker personal*/
			string text = "http://mat-mats.se/vi-soker-personal";

			string[] strings = text.Substring(text.IndexOf('/')).Trim('/').Split('.');
			strings[0] = strings[0].Substring(0, 1).ToUpper() + strings[0].Substring(1);
			strings[0] = strings[0].Replace('m', 'M');

			int indexOfFrontSlash = strings[1].IndexOf('/') + 1;
			strings[1] = strings[1].Substring(indexOfFrontSlash);
			strings[1] = strings[1].Substring(0, 1).ToUpper() + strings[1].Substring(1).Replace('-', ' ');
			strings[1] = strings[1].Substring(0, 2) + strings[1].Substring(2, 8).Replace('o', 'ö') + strings[1].Substring(10);

			Console.WriteLine(strings[0] + "\n" + strings[1]);
		}
		public static void Övning5()
		{			
			/*Använd följande kod.
			  string text = "Pop, Rock, Jazz, Soul, Hip Hop, Metal, Heavy Metal";
			  Bearbeta textsträngen så att output blir:
			  Pop
			  Rock
			  Jazz
			  Soul
			  Hip Hop
			  Metal
			  Heavy Metal*/
			string text = "Pop, Rock, Jazz, Soul, Hip Hop, Metal, Heavy Metal";
			string[] arr = text.Split(',');
			foreach (string str in arr)
			{
				Console.WriteLine(str.Trim());
			}
		}
	}
}