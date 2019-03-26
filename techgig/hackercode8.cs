using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    /* PROBLEM STATEMENTPoints: 50Alice is very good in mathematics. So, his teacher gave him a number N and wants from him to count total number of pairs, such that gcd(x,y)=1and x∗y=N, where (x,y)forms a pair.Alice is very busy in his exams and he wants your help .So solve this problem for Alice. Input:Input starts with a number T and then follows T lines contains a single number, N. Output:Find the total number of pairs, and print the required answer in a new line.Constraints:1≤T≤1051≤N≤107SAMPLE INPUT  226SAMPLE OUTPUT  24Explanation For 1st test case, pairs are (1,2) and (2,1)For 2nd test case, pairs are (1,6) , (6,1) , (2,3) and (3,2).Time Limit: 1.0 sec(s) for each input file. Memory Limit: 256 MB Source Limit: 1024 KB Marking Scheme: Marks are awarded if any testcase passes.*/
    class hackercode8
    {
        static void Main(String[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int[] vs = new int[a];
            for (int i = 0; i < a; i++)
            {
                vs[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(Operation(vs[i])*2);
            }
        }
        static int Operation(int a)
        {
            int count = 0;
            for (int i = 2; i < a; i++)
            {
                if (a%i==0)
                {
                    if (GCDOperation(i,(a/i))&&a==i*(a/i))
                    {
                        count++;
                    }
                }
            }
            if (count==0)
            {
                return count = 1;
            }
            return count;
        }
        static bool GCDOperation(int a,int b)
        {
            bool flag = true;
            int j = b;
            if (a<b)
            {
                j = a;
            }

            for (int i = 2; i < j; i++)
            {
                if (a%i==0&&b%i==0)
                {
                    flag = false;
                }
            }
            return flag;
        }
        
    }
}
