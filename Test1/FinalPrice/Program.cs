using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] items = new int[] { 5, 1, 3, 4, 6, 2 };
            int[] items2 = new int[] { 1, 3, 3, 2, 5 };
            FinalPrices(items2);
        }

        static void FinalPrices(int[] prices)
        {
            var notDiscountedString = string.Empty;
            var finalPrices = new List<int>();

            for (var p = 0; p < prices.Length; p++)
            {
                var discounted = false;
                for (var i = p + 1; i < prices.Length; i++)
                {
                    if (discounted) continue;
                    if (prices[i] > prices[p]) continue;
                    prices[p] = prices[p] - prices[i];
                    discounted = true;
                }
                finalPrices.Add(prices[p]);
                if (!discounted)
                    notDiscountedString += $"{p} ";
            }

            Console.WriteLine(finalPrices.Sum());
            Console.WriteLine(notDiscountedString);
        }
    }
}
