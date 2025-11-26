using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Totalizator_Lotto_Api_Client.ApiCalls
{
	public static class HttpPerformACall
	{
		public static async Task<string> GetJsonAsync(HttpClient client, string endpoint)
		{
			try
			{
				HttpResponseMessage response = await client.GetAsync(endpoint);
				response.EnsureSuccessStatusCode();
				return await response.Content.ReadAsStringAsync();
			}
			catch (HttpRequestException ex)
			{
				Console.WriteLine($"B³¹d zapytania: {ex.Message}");
				return string.Empty;
			}
		}
	}
}
