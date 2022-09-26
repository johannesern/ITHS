namespace Felhantering_och_undantag_7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string startString = "Skriv in vart talföljden ska börja: ";
			string stopString = "Skriv in vart talföljden ska sluta: ";
			string stepString = "Skriv in steg: ";

			int startVal = PoorMansPolymorphism(startString);
			int stopVal = PoorMansPolymorphism(stopString);
			int stepVal;
			bool checkingStepValue = true;
			do
			{
				stepVal = PoorMansPolymorphism(stepString);
				if(stepVal < 0)
				{
					stepVal *= -1;
				}
				checkingStepValue = HelpingUserNotCrashingMyProgram(startVal, stopVal, stepVal);
				
			} while (checkingStepValue);

			DisplayingInConsole(startVal, stopVal, stepVal);
		}

		public static int PoorMansPolymorphism(string x)
		{
			int value;
			bool run;
			do
			{
				Console.Write($"{x}");
				bool isInt = int.TryParse(Console.ReadLine(), out value);
				if (isInt)
				{
					run = false;
				}
				else
				{
					run = true;
					Console.WriteLine("Skriv endast in heltal");
				}
			} while (run);
			return value;
		}

		public static bool HelpingUserNotCrashingMyProgram(int startVal, int stopVal, int stepVal)
		{
			bool stepIsBetweenStartAndStop;
			if (stopVal - startVal < 0)
			{
				stepIsBetweenStartAndStop = ((stopVal - startVal) * (-1)) > stepVal;
			}
			else
			{
				stepIsBetweenStartAndStop = (stopVal - startVal) > stepVal;
			}
			if (stepIsBetweenStartAndStop)
			{
				return false;
			}
			else
			{
				Console.WriteLine("Steget får inte vara större än stopp-talet, försök igen.");
				return true;
			}
		}

		public static void DisplayingInConsole(int startVal, int stopVal, int stepVal)
		{
			if(0 > stopVal - startVal)
			{
				for (int i = startVal; i >= (stopVal - startVal); i -= stepVal)
				{
					Console.WriteLine(i);
				}
			}
			else
			{
				for (int i = 0; i <= (stopVal - startVal); i += stepVal)
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}