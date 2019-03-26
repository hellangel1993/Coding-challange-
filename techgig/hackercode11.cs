using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class hackercode11
    {
        /* PROBLEM STATEMENT
Points: 30
Marut loves good strings. According to him, good strings are those which contain either all alphabets of uppercase or lowercase. While he is preparing for his exams, he finds many bad strings in his book and wants to convert them to good strings. But he wants to do this in minimum number of operations.
In one operation, he can pick only one character of any case and convert it to any other case.
As his exams are going on, he wants your help.
Input:
The first line contains an integer T, denoting the number of test cases.
Each test case consists of only one line with a string S which contains uppercase and lowercase alphabets..
Output:
Print the minimum number of operations, in which Marut can obtain a good string.
Print the answer for each test case in new line.
Constraints:
1 ≤ T ≤ 10
If T is not in this range, print "Invalid Test" (without the quotes)
1 ≤ Length of S ≤ 100
S can contain numbers, special characters but no spaces.
If the length of string is not in the above range or it does not contain any alphabets, print "Invalid Input" (without the quotes) 
For Example, if the input is:
0
TestString 
Print "Invalid Test" (without the quotes)
SAMPLE INPUT
  

3
abcEfg
!@6#2
123A
SAMPLE OUTPUT
  

1
Invalid Input
0

Time Limit: 1.0 sec(s) for each input file. 
Memory Limit: 256 MB 
Source Limit: 1024 KB 
Marking Scheme: Marks are awarded if any testcase passes.*/
        static void Main(String[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());            
            int[] c = new int[a];
            if (a>=1&&a<=10)
            {
                for (int i = 0; i < a; i++)
                {
                    string str = Console.ReadLine();
                    c[i] = operation(str);
                }
                for (int i = 0; i < a; i++)
                {
                    if (c[i] == -1)
                    {
                        Console.WriteLine("Invalid Inpput");
                    }
                    else if (c[i] == 0)
                    {
                        Console.WriteLine(c[i]);
                    }
                    else
                    {
                        Console.WriteLine(c[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid Tes");
            }
        }
        static int operation(string str)
        {
            int u = 0, l = 0 ,d=0;
            for (int i = 0; i < str.Length; i++)
            {
                int ob = Convert.ToInt32(str[i]);
                if (ob > 64 && ob < 91)
                {
                    u += 1;
                }
                else if (ob > 47 && ob < 58)
                {
                    continue;
                }
                else if (ob > 96 && ob < 123)
                {
                    l += 1;
                }
                else
                {
                    return d = -1;                    
                }
            }
            if (u>l)
            {
                d = l;
            }
            else if (l>u)
            {
                d = u;
            }            
            return d;
        }
    }
}
