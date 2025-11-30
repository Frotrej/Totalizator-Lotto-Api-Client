using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Totalizator_Lotto_Api_Client.Utils
{
	internal static class PrepareHttpClient
	{

		public static HttpClient GetHttpClient()
		{
			HttpClient myHttpClient = new();

			//apply base url
			var baseUrlAsUri = new Uri("https://developers.lotto.pl");
			myHttpClient.BaseAddress = baseUrlAsUri;

			//apply secret key from file
			readSecretKeyFromFile(myHttpClient);

			return myHttpClient;
		}

		private static void readSecretKeyFromFile(HttpClient myHttpClient)
		{
			try
			{
				string secretKey = File.ReadAllText(@"C:\Users\Kompjuter\Desktop\LottoApiKeyHere.txt");
				myHttpClient.DefaultRequestHeaders.Add("secret", secretKey);
			}
			catch (FileNotFoundException)
			{
				Console.WriteLine("Błąd podczas odczytu secret key: Plik nie został znaleziony.");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Błąd podczas odczytu secret key | Nieoczekiwany błąd: {ex}.");
			}
		}
	}
}
