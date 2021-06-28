using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{/*he box is divided by m x n dividers into (m + 1) x (n + 1) cells. Assuming the depth of the box is 1, each cell has a volume of 1.

Now we want to remove a number of dividers. Find the largest space after removing the dividers.

Example 1:
Input:
n = 5 Number of dividers in the horizontal direction

m = 5 Number of dividers in the vertical direction

h = [2, 3] Horizontal dividers to remove

v = [3] Vertical dividers to remove

Output: 6
Explanation:
We want to remove the 2nd and 3rd horizontal divider and the 3rd vertical divider. The largest space after removing the dividers has a volume of (4 - 1) * (4 - 2) * 1 = 6.*/
    class Amazon_Online_Assessment__OA__2021___Storage_Optimization
    {
        public static int storage_optimization(int n, int m, int[] h, int[] v)
        {
            int maxH = 1;
            int fh = 1;
            int maxV = 1;
            int fv = 1;

            for (int i = 0; i < (h.Length-1); i++)
            {
                if (h[i]+1==h[i+1])
                {
                    maxH++;
                    if (fh<maxH)
                    {
                        fh = maxH;
                    }
                }
                else
                {
                    maxH = 1;
                }
            }
            for (int i = 0; i < (v.Length-1); i++)
            {
                if (v[i]+1==v[i+1])
                {
                    maxV++;
                    if (fv<maxV)
                    {
                        fv = maxV;
                    }
                }
                else
                {
                    maxV = 1;
                }
            }

            return (fh * fv);
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
            int[] v = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
            int res = storage_optimization(n, m, h, v); 
         }
    }
}
