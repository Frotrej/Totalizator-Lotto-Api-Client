using System.Net.Http;
using System.Text.Json;
using Totalizator_Lotto_Api_Client.ApiCalls;
using Totalizator_Lotto_Api_Client.Other;
using Totalizator_Lotto_Api_Client.Utils;
using Totalizator_Lotto_Api_Client.Utils.DataPresentation;

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
				string jsonResponse = await NextDraw.GetNextGameDraw(myHttpClient);

				DataPresentation showData = JsonSerializer.Deserialize<DataPresentation>(jsonResponse)!;
				showData.ShowNextDraw();
			}
		}
	}
}





