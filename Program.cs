namespace Totalizator_Lotto_Api_Client
{
    internal class Program
    {
        static void Main(string[] args)
        {

			//https://developers.lotto.pl/api/open/v1/lotteries/info/game-jackpot
			//ZFH07XmjGMFVOP37+Gf643PLK2p7JO1QDDcchRTXmIk=

			var httpClient = new HttpClient();
            
            httpClient.DefaultRequestHeaders.Add("secret", "ZFH07XmjGMFVOP37+Gf643PLK2p7JO1QDDcchRTXmIk=");
			httpClient.
            
            httpClient.GetStringAsync("https://developers.lotto.pl/api/open/v1/lotteries/info/game-jackpot?gameType=Lotto").Wait();
            

		}
    }
}
