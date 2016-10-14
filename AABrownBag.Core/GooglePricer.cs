using Stockify;

namespace AABrownBag.Core
{
    public class GooglePricer
    {
        public string GetPrice()
        {
            //authorization stuff
            //crazy config stuff
            //lots of logging and error handling etc
            var stockPriceService = new StockPriceService();
            var priceInOneSecondeFromNow = stockPriceService.GetFuturePrice("Google", 1).Result;
            var formattedPrice = string.Format("Price for Google is {0}", priceInOneSecondeFromNow);
            return formattedPrice;           
        }
    }
}