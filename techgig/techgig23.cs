using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class techgig23
    {
        //        Maximum Vs Minimum(100 Marks)
        //For this challenge, you need to take number of elements as input on one line and array elements as an input on another line.You need to find the minimum number and maximum number from the array and multiply them. 

        //Input Format
        //In this challenge, you will take number of elements as input on one line and array elements which are space separated as input on another line. 

        //Constraints
        //1 < N< 10^5
        //1 < A[i] < 10^5

        //Output Format
        //You will print the value after multiplication to the stdout.

        //Sample TestCase 1
        //Input
        //6
        //11 22 33 44 55 66
        //Output
        //726
        static void Main(String[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            string str = Console.ReadLine();
            int[] b = str.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();            
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
            Console.WriteLine((b[0] * b[a - 1]));

        }
    }
}
