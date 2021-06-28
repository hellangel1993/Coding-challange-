using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class hackerRank2Darry_DS
    {
        static int hourglassSum(int[][] arr)
        {
            int a = arr.Length;
            int b = arr[a - 1].Length;
            int result = 0;
            for (int j = 0; j < (b - 2); j++)
            {
                int temp = 0;
                for (int i = 0; i < (a - 3); i++)
                {
                    temp = arr[j][i] + arr[j][i + 1] + arr[j][i + 2] + arr[j + 1][i + 1] + arr[j + 2][i] + arr[j + 2][i + 1] + arr[j + 2][i + 2];
                    if (result != 0)
                    {
                        if (result < temp)
                        {
                            result = temp;
                        }
                    }
                    else
                    {
                        result = temp;
                    }
                }
            }

            for (int i = 0; i < 6; i++)
            {

            }

            return result;
        }
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = hourglassSum(arr);

            Console.WriteLine(result);

        }
    }
}
