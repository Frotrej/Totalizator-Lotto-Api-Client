using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Totalizator_Lotto_Api_Client.Utils;

namespace Totalizator_Lotto_Api_Client.ApiCalls
{
	internal static class NextDraw
	{
		public static async Task<string> GetNextGameDraw(HttpClient myHttpClient)
		{
			string endpoint = GameTypePicker.Start("api/open/v1/lotteries/info/next-draw?gameType=");

			return await HttpPerformACall.GetJsonAsync(myHttpClient, endpoint);
		}
	}
}
