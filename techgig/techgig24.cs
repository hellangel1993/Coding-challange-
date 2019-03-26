using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class techgig24
    {
        /* For this challenge, you need to take number of elements as input on one line and array elements as an input on another line. You need to find the average of even numbers, then the average of odd numbers and add them (round the averages to the nearest integers). 

Input Format
In this challenge, you will take number of elements as input on one line and array elements which are space separated as input on another line. 

Constraints
1 < N < 10^5
1 < A[i] < 10^5

Output Format
You will print the value after addition of the two averages to the stdout. 

Sample TestCase 1
Input
6
11 22 33 44 55 66
Output
77*/
        static void Main(String[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            string str = Console.ReadLine();
            int[] vs = str.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int c = 0, d = 0;
            decimal e = 0, f = 0;
            for (int i = 0; i < a; i++)
            {
                if (vs[i]%2==0)
                {
                    e = e + vs[i];
                    c++;
                }
                else
                {
                    f = f + vs[i];
                    d++;
                }
            }
            if (c!=0)
            {
                e = e / c;
            }
            if (d!=0)
            {
                f = f / d;
            }
            e = e + f;
            string str1 = e.ToString();
            decimal[] g = str1.Split('.').Select(n => Convert.ToDecimal(n)).ToArray();
            //int p = 1;
            //if (g.Length==2)
            //{
            //    for (int i = 0; i < (g[1].ToString()).Length-1; i++)
            //    {
            //        p = p * 10;
            //    }
            //}
            //if (g.Length==2)
            //{
            //    if ((p*5)<g[1])
            //    {
            //        g[0] += 1;
            //    }
            //}
            //Console.WriteLine(g[0]);
            if (g.Length == 2)
            {
                int[] vs1 = (g[1].ToString()).Select(n => Convert.ToInt32(n)).ToArray();
                for (int i = vs1.Length - 1; i >= 0; i--)
                {
                    if (i != 0)
                    {
                        if (vs1[i] >= 53)
                        {
                            vs1[i - 1] += 1;
                        }
                    }
                    else if (i == 0)
                    {
                        if (vs1[i] >= 53)
                        {
                            g[0] += 1;
                        }
                    }

                }
            }
            Console.WriteLine(g[0]);
            Console.ReadLine();
            //Console.WriteLine((Math.Ceiling(e)+Math.(f)));
            //string str1 = e.ToString();
            //string str2 = f.ToString();
            //decimal[] g = str1.Split('.').Select(n => Convert.ToDecimal(n)).ToArray();
            //decimal[] h = str2.Split('.').Select(n => Convert.ToDecimal(n)).ToArray();        
            
            //int p = 1, q = 1;
            //if (g.Length == 2)
            //{
            //    for (int j = 0; j < (g[1].ToString()).Length - 1; j++)
            //    {
            //        p = p * 10;
            //    }
            //}
            //if (h.Length == 2)
            //{
            //    for (int k = 0; k < (h[1].ToString()).Length - 1; k++)
            //    {
            //        q = q * 10;
            //    }
            //}
            //if (g.Length == 2)
            //{
            //    if ((p * 5) < g[1])
            //    {
            //        g[0] += 1;
            //    }
            //}
            //if (h.Length == 2)
            //{
            //    if ((q * 5) < h[1])
            //    {
            //        h[0] += 1;
            //    }
            //}
            //Console.WriteLine((g[0] + h[0]));
        }
    }
}
