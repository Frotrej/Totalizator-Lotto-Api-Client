using System.Net.Http;
using Totalizator_Lotto_Api_Client.ApiCalls;
using Totalizator_Lotto_Api_Client.Other;
using Totalizator_Lotto_Api_Client.Utils;

namespace Totalizator_Lotto_Api_Client
{
	internal class Program : TestJsonApiGet
	{
		static async Task Main(string[] args)
		{
			HttpClient myHttpClient = PrepareHttpClient.GetHttpClient();


			//jeżeli nagłówki są poprawnie ustawione (jest secret key)
			if ( myHttpClient.DefaultRequestHeaders.Any())
			{
				string jsonResponse = await NextLottoDraw.GetNextLottoDraw(myHttpClient);

				Console.WriteLine(jsonResponse);
			}
		}
	}
}


// api/open/v1/lotteries/info/game-jackpot




