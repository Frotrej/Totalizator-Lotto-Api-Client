using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Totalizator_Lotto_Api_Client.Utils.DataPresentation
{
	internal class DataPresentation
	{
		public string? gameType { get; set; }
		public Decimal? closestPrizeValue { get; set; }
		public DateTimeOffset ? nextDrawDate { get; set; }
		

		public void ShowNextDraw()
		{
			Console.WriteLine($"{gameType} - Data kolejnej gry: {nextDrawDate} | Kumulacja: {closestPrizeValue}zł");
		}
	}
}
