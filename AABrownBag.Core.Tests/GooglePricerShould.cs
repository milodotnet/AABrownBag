using NUnit.Framework;

namespace AABrownBag.Core.Tests
{
    public class GooglePricerShould
    {
        [Test]
        public void ReturnFormattedPriceStartingWithPricePrefix()
        {
            var pricer = new GooglePricer();
            const string pricePrefix = "Price for Google is";
            var formattedPrice = pricer.GetPrice();

            Assert.IsTrue(formattedPrice.StartsWith(pricePrefix));
         }
    }
}
