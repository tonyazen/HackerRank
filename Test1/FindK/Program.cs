using System;
using System.Linq;

namespace FindK
{
    class Program
    {   
        static void Main(string[] args)
        {
            var count = args.Count();
            int n = Convert.ToInt32(args[0]);
            int[] arr = new int[n];
            for (var x = 0; x < n; x++)
            {
                arr[x] = Convert.ToInt32(args[x + 1]);
            }

            var k = Convert.ToInt32(args[count - 1]);

            var exists = findNumber(arr, k);

            Console.WriteLine(exists);
        }
        static string findNumber(int[] arr, int k)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] == k)
                    return "YES";
            }
            return "NO";
        }
    }
}
