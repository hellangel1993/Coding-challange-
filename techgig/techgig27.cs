using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class techgig27
    {
        /* For this challenge, you will take an integer input from stdin, store it in a variable, find the digits in that number, identify digits that are odd and add them, identify which digits are even and add them. Subtract the smaller with the larger one. 

Input Format
A single integer value to be taken as input from stdin and stored it in a variable of your choice. 

Constraints
1 < N < 10^9

Output Format
Print the single number after subtraction. 

Sample TestCase 1
Input
34567
Output
5*/
        static void Main(String[] args)
        {
            //char chai;
            //chai = (char)65;
            //Console.WriteLine(chai);
            string str = Console.ReadLine();
            int e = 0, o = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]%2==0)
                {
                    e += int.Parse(str[i].ToString());
                }
                else
                {
                    o += int.Parse(str[i].ToString());
                }
            }
            if (e>o)
            {
                Console.WriteLine((e - o));
            }
            else
            {
                Console.WriteLine((o - e));
            }
        }
    }
}
