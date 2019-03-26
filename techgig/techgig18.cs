using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class techgig18
    {
        static void Main(String[] args)
        {
//            For this challenge, Given an unsorted array arr[0..n - 1] of size n, find the minimum length subarray arr[s..e] such that sorting this subarray makes the whole array sorted. 

//Input Format
//On the first line, you need to take an integer input which will be the length of the array. Another line will have space separated integer values. 

//Constraints
//1 < n < 10 ^ 5
//1 < A[i] < 10 ^ 5

//Output Format
//Space separated integer values present in the subarray. 

//Sample TestCase 1
//Input
//13
//1 2 4 7 10 11 7 12 3 7 16 18 19
//Output
//4 7 10 11 7 12 3 7
            int a = Convert.ToInt32(Console.ReadLine());
            string str = Console.ReadLine();
            int[] b = str.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int[] c = str.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if (b[j]>b[i])
                    {
                        int temp;
                        temp = b[j];
                        b[j] = b[i];
                        b[i] = temp;
                    }
                }
            }            
            int v1=-1, v2=0;
            for (int k = 0; k < a; k++)
            {
                if (b[k]!=c[k])
                {
                    if (v1==-1)
                    {
                        v1 = k;
                    }
                    v2 = k;
                }
            }
            for (int m = v1; m <= v2 ; m++)
            {
                Console.Write(c[m] + " ");
            }
            Console.ReadLine();
        }
    }
}
