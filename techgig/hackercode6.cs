using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class hackercode6
    {
        /* PROBLEM STATEMENTPoints: 50Milly and Pranjul are playing a game in which Pranjul will give an index of a chocolate. Then, Milly has to tell him the box number in which that chocolate is in. There are N such boxes and Ci chocolates are there in ith the box. Description of index is given below :Suppose there are A1, A2 … AN chocolates in 1st, 2nd… Nth boxes respectively. So, indexing of chocolates in 1st box will be from 1 to A1, similarly in 2nd box indexing will be A1 + 1 to A2 … and indexing in Nth box will be from AN-1 + 1 to AN. Milly is blind folded so she can’t see the boxes. You are required to help her. InputFirst line will contain N (No. of boxes). Next line will contain N space separated integers denoting Ci, the number of chocolates in ith box.Next line will contain Q (No. of times Pranjul will ask her). Then each next Q lines will contain the asked index I.OutputFor every query, print in a new line : the box number in which that index of chocolate is in.Constraints1 ≤ N, Q ≤ 1051 ≤ Ci ≤ 101 ≤ ∑ Ci ≤ 1061 ≤ I ≤ ∑ CiSAMPLE INPUT  22 3224SAMPLE OUTPUT  12Explanation First Box will have the indexes : 1, 2 Second Box will have the indexes : 3, 4, 5*/
        static void Main(String[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int x = 0;
            int[] vs = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            for (int i = 0; i < a; i++)
            {
                x += vs[i];
                vs[i] = x;
            }
            int b = Convert.ToInt32(Console.ReadLine());//number of tries
            int[] vs1 = new int[b];
            for (int i = 0; i < b; i++)
            {
                int ind = Convert.ToInt32(Console.ReadLine());
                vs1[i] = Operation(vs, ind);

            }
            for (int i = 0; i < b; i++)
            {
                Console.WriteLine(vs1[i]);
            }

        }
        static int Operation(int[] vs,int a)
        {
            int b = 0;            
            for (int i = 0; i < vs.Length; i++)
            {
                if (a<=vs[i])
                {
                    b = i+1;
                    break;
                }
            }
            return b;
        }
    }
}
