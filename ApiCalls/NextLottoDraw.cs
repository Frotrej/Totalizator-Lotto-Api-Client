using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Totalizator_Lotto_Api_Client.ApiCalls
{
	public static class NextLottoDraw
	{
		public static async Task<string> GetNextLottoDraw(HttpClient myHttpClient)
		{
			string endpoint = "api/open/v1/lotteries/info/next-draw?gameType=Lotto";

			return await HttpPerformACall.GetJsonAsync(myHttpClient, endpoint);
		}

		public static string ChooseGameType(string gameType)
		{
			return gameType switch
			{
				//wypisać typy gier tutaj jako case'y'
			};
		}
	}
}
