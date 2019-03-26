using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{/* PROBLEM STATEMENT
Points: 30
Given N words 


ai
of lowercase letters. Arrange these words such that word 


ai
of length 


li
comes before word 


aj
of length 


lj
if 
1) 





li<lj
. 
OR
2) 





li=lj
and the first different letter in 


ai
< corresponding letter in 


aj
. Letters are compared with respect to their ASCII Value.
For example: 


ai
= "arm", 


aj
= "ant", so "ant" comes before "arm" because second letter in 


aj
n < second letter in 


ai
r. 
Input: 
In the first line: Given an integer N. 
In the second line: N strings 


ai
follow. 
Output: 
Print the words in the order illustrated in the question. 
Constraints: 







1≤N≤100
. 







1≤li≤10
.
SAMPLE INPUT
  

5
omar
apple
banana
ant
cat
SAMPLE OUTPUT
  

ant
cat
omar
apple
banana

Time Limit: 1.0 sec(s) for each input file. 
Memory Limit: 256 MB 
Source Limit: 1024 KB 
Marking Scheme: Marks are awarded if any testcase passes.*/
    class hackercode13
    {
        static void Main(String[] args)//run time exception is coming in the some of the test case
        {
            int a = Convert.ToInt32(Console.ReadLine());
            string[] vs = new string[a];
            for (int i = 0; i < a; i++)
            {
                vs[i] = Console.ReadLine();
            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if (Operation(vs[i],vs[j]))
                    {
                        string temp;
                        temp = vs[j];
                        vs[j] = vs[i];
                        vs[i] = temp;
                    }
                }
            }
            for (int i = a-1; i >= 0; i--)
            {
                Console.WriteLine(vs[i]);
            }
        }
        static bool Operation(string a,string b)
        {
            bool flag = false;
            if (a.Length<b.Length)
            {
                return flag = false;
            }
            else
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (Convert.ToInt32(a[i])<Convert.ToInt32(b[i]))
                    {
                        return flag = false;
                    }
                    else if (Convert.ToInt32(a[i]) == Convert.ToInt32(b[i]))
                    {
                        continue;
                    }
                    else
                    {
                        flag = true;
                        break;
                    }
                }
            }
            return flag;
        }
    }
}
