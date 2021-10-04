using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class Pramp
    {
        public static int[] SortKMessedArray(int[] arr, int k)
        {
            // your code goes here
            int x, j;
            for (int i = 1; i < arr.Length ; i++)
            {
                x = arr[i];
                j = i - 1;
                while (j >= 0 && arr[j] > x)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = x;
            }

            return arr;
        }

        static void Main(string[] args)
        {
            int[] res = SortKMessedArray(new int[] { 1, 4, 5, 2, 3, 7, 8, 6, 10, 9 }, 2);
            foreach (int a in res)
            {
                Console.WriteLine(a);
            }
        }
    }
}
