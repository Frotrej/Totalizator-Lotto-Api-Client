using System.Net.Http;

namespace Totalizator_Lotto_Api_Client
{
	internal class Program : TestJsonApiGet
	{
		static async Task Main(string[] args)
		{
			string endpoint = "api/open/v1/lotteries/info/next-draw?gameType=Lotto";
			string? jsonResponse = string.Empty;

			HttpClient myHttpClient = PrepareHttpClient.GetHttpClient();

			//zapytanie do API o najlbizsze losowanie Lotto
			if ( myHttpClient.DefaultRequestHeaders.Any())
			{
				jsonResponse = await HttpRequestHelper.GetJsonAsync(myHttpClient, endpoint);

				Console.WriteLine(jsonResponse);
			}
		}
	}
}


// api/open/v1/lotteries/info/game-jackpot




