using System;
using System.Threading.Tasks;

namespace Stockify
{
    public class StockPriceService
    {
        public async Task<double> GetFuturePrice(string stockName, int secondsInFuture)
        {
            await Task.Delay(TimeSpan.FromSeconds(secondsInFuture));
            var rnd = new Random();
            return rnd.NextDouble();
        }
    }
}