using System.Collections.Generic;
using System.Linq;
using System.Text;
using AABrownBag.Core;

namespace AABrownBag.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var stockPriceService = new GooglePricer();
            System.Console.WriteLine(stockPriceService.GetPrice());
            System.Console.ReadKey();
        }
    }
}
