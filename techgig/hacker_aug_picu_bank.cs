using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class hacker_aug_picu_bank
    {
        /* Picu Bank
Max. Marks: 100

You have D dollars with you. You want to put it into a Bank, namely Picu Bank. This bank has a peculiar behavior for interest. Regardless of the Bank deposit amount, every month it adds A dollars to your bank account and this continues till  M
months. Exaxtly on M+1
months, it adds B
dollars (B<A) to your bank account. This scanario repeats again in same manner.( i.e on the (M+2)th month A
dollars are added, and so on.. ). Your task is to find out how many months does it take for the dollar amount to reach at least X
, in the bank account .    
Input:
Input starts with an integer T(1≤T≤100000)
, denoting the number of test cases.  Each case starts with 5 integers D,A,M,B
 , and X
as described in problem statement.
Constraints:
1≤D,M,X≤109
1≤B<A≤109
Output:
For each case of input minimum number of months needed to reach dollar value of at least X in a single line.
Note that the Expected Output feature of Custom Invocation is not supported for this contest. 
SAMPLE INPUT
2
2 5 4 3 51
2 5 4 3 46
SAMPLE OUTPUT
11
10
Explanation 
Time Limit: 
1.0 sec(s) for each input file. 
Memory Limit: 
256 MB 
Source Limit: 
1024 KB 
Marking Scheme: 
Marks are awarded if any testcase passes.*/
        static void Main(String[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int[] b = new int[a];
            for (int i = 0; i < a; i++)
            {
                int[] vs = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
                b[i] = Operation(vs[0], vs[1], vs[2], vs[3], vs[4]);
            }
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(b[i]);
            }
        }
        static int Operation(int D,int A,int M,int B,int X)
        {
            int month = M;
            int i = 0;
            D += (M + 1) * A;
            while (D<X)
            {
                if (i % 2 == 0)
                {
                    D += B;
                    i++;
                }
                else
                {
                    D += A;
                    i++;
                }
                month++;
            }
            return month;
        }
    }
}
