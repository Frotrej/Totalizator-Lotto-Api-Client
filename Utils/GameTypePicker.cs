namespace Totalizator_Lotto_Api_Client.Utils
{
	internal static class GameTypePicker
	{
		static string[] gameTypes = new string[]
			{
				"Lotto",
				"LottoPlus",
				"EuroJackpot",
				"MultiMulti",
				"MiniLotto",
				"Kaskada",
				"Keno",
				"EkstraPensja",
				"EkstraPremia",
				"Szybkie600"
			};

		public static string Start(string incompleteEndpoint)
		{
			ShowGameTypesToUser();

			Console.WriteLine("Wybierz grę, dla której chcesz poznać datę następnego losowania:");

			string chosenGameType = ReadUserInput();

			return incompleteEndpoint + chosenGameType;

		}

		private static void ShowGameTypesToUser()
		{
			string output = "";
			for (int i = 0; i < gameTypes.Length; i++)
			{
				output += $"{i + 1}. {gameTypes[i]}\n";
			}
			Console.WriteLine(output);
		}

		private static string ReadUserInput()
		{
			string userInput = Console.ReadLine();

			while (!ValidateUserInput(userInput))
			{
				Console.WriteLine("Niepoprawny wybór. Spróbuj ponownie:");

				userInput = Console.ReadLine();
			} 

			return userInput;
		}

		private static bool ValidateUserInput(string userInput)
		{
			for (int i = 0; i < gameTypes.Length; i++)
			{
				if (userInput == gameTypes[i])
				{
					return true;
				}
			}
			return false;
		}
	}
}
