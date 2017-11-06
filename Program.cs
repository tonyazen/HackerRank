using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Testing applicaiton.");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int t = 0; t < n; t++)
            {
                String str = Console.ReadLine();
                String[] strArr = str.Split();
                int a = Convert.ToInt32(strArr[0]);
                int b = Convert.ToInt32(strArr[1]);
                Console.WriteLine(a + b);
            }
        }

    }
}
