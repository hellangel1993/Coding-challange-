using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class Amazon_Online_Assessment__OA____Optimizing_Box_Weights
    {
        /*Given a multiset (set that allows for multiple instances of same value), partition it into two multisets A and B such that the sum of A is greater than that of B. Return A. If more than one such As exists, return the one with minimal size.

Examples
Example 1:
Input:
nums = [4, 5, 2, 3, 1, 2]

Output:
[4, 5]

Explanation:
We can divide the numbers into two subsets A = [4, 5] and B = [1, 2, 2, 3]. The sum of A is 9 which is greater than the sum of B which is 8. There are other ways to divide but A = [4, 5] is of minimal size of 2.

Try it yourself*/
        static int[] optimizing_box_weights(int[] arr)
        {
            List<int> res = new List<int>();
            if (false)
            {                
                int sumarr = arr.Sum();//o(n)
                int sunRes = 0;
                Array.Sort(arr);
                for (int i = arr.Length - 1; i > 0; i--)
                {
                    sumarr -= arr[i];
                    sunRes += arr[i];
                    res.Add(arr[i]);
                    if (sunRes > sumarr)
                    {
                        break;
                    }

                }
            }
            else
            {
                
            }

            return res.ToArray();
        }

        static void Main(string[] args)
        {
            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));

            int[] result = optimizing_box_weights(c);

        }
    }
}
