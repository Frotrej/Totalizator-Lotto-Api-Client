namespace Totalizator_Lotto_Api_Client
{
	internal class Program : TestJsonApiGet
	{
		static void Main(string[] args)
		{
			TestJsonApiGet.GetAsync().Wait();
		}
	}
}






