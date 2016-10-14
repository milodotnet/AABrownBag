using NUnit.Framework;

namespace Stockify.Tests
{
    public class StockPriceServiceShould
    {
        [Test]
        public void ReturnsANonZeroPrice()
        {
            var stockPriceService = new StockPriceService();
           
            var actualPrice = stockPriceService.GetFuturePrice("google", 1).Result;

            Assert.NotZero(actualPrice);
        } 
    }
}