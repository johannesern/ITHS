namespace OOP_Övning_2_Restaurang_Liljeholmskajen
{
	internal class Program
	{
		static void Main(string[] args)
		{
			RestaurangLiljeholmskajen menu = new RestaurangLiljeholmskajen();
			menu.PrintMenu();
		}
	}

	public class RestaurangLiljeholmskajen
	{
		public string[] dishes = new string[3];
		
		public RestaurangLiljeholmskajen()
		{
			this.dishes[0] = "Köttbullar brunsås och potatis";
			this.dishes[1] = "Örtmarinerad kyckling med klyftpotatis och tzatsiki";
			this.dishes[2] = "Vegetarisk lasagne";

		}

		public void PrintMenu()
		{
			Console.WriteLine("\t========Restaurang Liljeholmskajen========");
			Console.WriteLine("\t =======\tDagens Meny       =======");
			Console.WriteLine("\n\t\t\tDagens Alt 1");
			Console.WriteLine($"\t\t{this.dishes[0]}\n\n" +
							   "\t\t\tDagens alt 2\n" +
							  $"     {this.dishes[1]}\n\n" +
							  $"\t\t     Dagens Vegetariska\n" +
							  $"\t\t     {this.dishes[2]}");


			Console.ReadLine();
		}
	} 
}