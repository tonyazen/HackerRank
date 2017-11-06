using System;
using System.Linq;

namespace LeftRotation
{
    class Program
    {
        static int[] leftRotation(int[] a, int d)
        {
            var arrayCount = a.Count();
            var newOrder = new int[arrayCount];
            for (var i = 0; i < arrayCount; i++)
            {
                var newLocation = i - d;
                if (newLocation < 0)
                {
                    newLocation = arrayCount + newLocation;
                }
                newOrder[newLocation] = a[i];
            }
            return newOrder;
        }

        static void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int d = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            int[] result = leftRotation(a, d);
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
