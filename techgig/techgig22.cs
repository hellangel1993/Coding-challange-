using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class techgig22
    {
        //        War between odd and even(100 Marks)
        //For this challenge, you need to take number of elements as input on one line and array elements as an input on another line.You need to find the numbers that are present at odd index, add them. find the numbers that are present at even index, add them and then subtract the smallest of the two values from the lager one.
        //Note: 
        //Array indexes always starts from 0. 

        //Input Format
        //In this challenge, you will take number of elements as input on one line and array elements which are space separated as input on another line. 

        //Constraints
        //1 <  N< 10^5
        //1 < A[i] < 10^5

        //Output Format
        //You will print the value after subtraction to the stdout.

        //Sample TestCase 1
        //Input
        //6
        //11 22 33 44 55 66
        //Output
        //33
        static void Main(String[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            string str = Console.ReadLine();
            int[] b = str.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int v1 = 0, v2 = 0;
            for (int i = 0; i < a; i++)
            {
                if (i%2==0)
                {
                    v1 += b[i];
                }
                else
                {
                    v2 += b[i];
                }
            }
            if (v1>v2)
            {
                v1 = v1 - v2;
            }
            else
            {
                v1 = v2 - v1;
            }
            Console.WriteLine(v1);
        }

    }
}
