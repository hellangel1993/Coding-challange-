﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    /* PROBLEM STATEMENT
Points: 30
Prateek wants to give a party to his N friends on his birthday, where each friend is numbered from 1 to N. His friends are asking for a gift to come to the party, instead of giving him one. The cost of the gifts are given in the array Value where ith friend asks for a gift which has a cost Costi. 
But, Prateek has only X amount of money to spend on gifts and he wants to invite his friends which are in continuous range such that sum of the cost of the gifts of those friends will be exactly equal to X. 
If he can invite his friends, who can satisfy the above condition then, print YES otherwise print NO. 
Input:
The first line contains a single integer T, denoting the number of test cases. In each test case, the following input will be present: - The next line contains two space-separated integers N and X, where N represents the number of friends and X represents amount of money which Prateek can spend on gifts. 
- Next N line contains N integers, where ith line contains ith integer, which represents the Costi .
Ouput
Output exactly T lines, each containing the answer to the corresponding test case . 
Constraints:
1 <= T <= 10
1 <= N , Costi <= 106
1 <= X <= 1012 
SAMPLE INPUT
  

1
5 12
1
3
4
5
2
SAMPLE OUTPUT
  

YES

Explanation 
In the sample input, T is equal to 1. So, accordingly, in next line, values of N and X are given which are 5 and 12 respectively. In the next 5 lines, you have costi asked by ith friend. As friends numbered from 2 to 4 (inclusively) have gifts value which are {3, 4, 5}, and their sum equals to 12 - that is, the given value of X. So, the answer is YES.*/
    class hackercode10
    {
        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            bool[] flag = new bool[t];
            for (int i = 0; i < t; i++)
            {
                int[] a = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
                int[] b = new int[a[0]];
                for (int j = 0; j < a[0]; j++)
                {
                    b[j] = Convert.ToInt32(Console.ReadLine());
                }
                flag[i] = Operation(b, a[1]);
            }
            for (int i = 0; i < t; i++)
            {
                if (flag[i])
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
        static bool Operation(int[] a,int price)
        {
            bool flag = false;
            for (int i = 0; i < a.Length; i++)
            {
                int b = 0;
                for (int j = i; j < a.Length; j++)
                {
                    b += a[j];
                    if (b==price)
                    {
                        return flag = true;
                    }
                    else if (b<price)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return flag;
        }
    }
}
