using System;

namespace Totalizator_Lotto_Api_Client
{
	internal class TestJsonApiGet
	{
		public static async Task GetAsync()
		{
			HttpClient httpClient = new() { BaseAddress = new Uri("https://jsonplaceholder.typicode.com"), };

			HttpResponseMessage response = await httpClient.GetAsync("todos");

			response.EnsureSuccessStatusCode();

			var jsonResponse = await response.Content.ReadAsStringAsync();

			Console.WriteLine(jsonResponse);

			Console.WriteLine(httpClient.BaseAddress.ToString());
		}
	}
}