using System;
using System.Collections.Generic;

namespace OddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var startNumber = args[0];
            var endNumber = args[1];
            var odds = new List<int>();
            for (var i = Convert.ToInt32(args[0]); i < Convert.ToInt32((args[1] + 1)); i++)
            {
                if (i % 2 > 0)
                {
                    odds.Add(i);
                }
            }

            int[] oddNumbers = odds.ToArray();
        }
    }
}
