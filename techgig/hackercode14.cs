using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class hackercode14
    {
        /* PROBLEM STATEMENT
Points: 30
A big international retailer is setting up shop in India and plans to open stores in N towns (3 ≤ N ≤ 1000), denoted by 1, 2, . . . , N. There are direct routes connecting M pairs among these towns. The company decides to build warehouses to ensure that for any town X, there will be a warehouse located either in X or in an immediately neighboring town of X.
Write a program to find the minimum number of warehouses the company has to build.
[Input]:
Input will be given in the following format 
N M
S1 E1 (Start Pt and End Pt of a direct route)
S2 E2
S3 E3
....
SM EM
Each route is bidirectional
No combination of towns will be repeated. 
[Output]:
Output should be in a file in the following format
Wx - Minimum # of warehouses
*Problem provided by JDA
SAMPLE INPUT
  

10 7
1 2
2 4
2 5
3 6
8 6
9 7
10 7
SAMPLE OUTPUT
  

3

Time Limit: 5.0 sec(s) for each input file. 
Memory Limit: 256 MB 
Source Limit: 1024 KB 
Marking Scheme: Marks are awarded if any testcase passes.*/
        static void Main(String[] args)
        {
            int[] a = Console.ReadLine().Split(' ').Select(n=>Convert.ToInt32(n)).ToArray();
            int count = 0;
            int[] vs = new int[a[1] * 2];
            route[] routes = new route[a[0]];
            for (int i = 0; i < (a[1]*2); i+=2)
            {
                int[] xx = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
                vs[i] = xx[0];
                vs[i + 1] = xx[1];
            }
            for (int i = 0; i < vs.Length; i++)
            {
                for (int j = 0; j < a[0]; j++)
                {
                    if (vs[i]==j+1)
                    {
                        routes[j].a = vs[i];
                        routes[j].b += 1;
                    }
                }
            }
            int c = 0;
            for (int i = 0; i < routes.Length; i++)
            {
                if (routes[i].b>1)
                {
                    c++;
                }
            }
            Console.WriteLine(c);
            
        }       
    }
    public struct route
    {
        public int a;
        public int b;
    }
}
