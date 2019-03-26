using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    /* PROBLEM STATEMENT
Points: 30
Xenny had a list of N strings of equal length. He wanted to sort them by the first M characters only. That means, while sorting the list of strings, he only wanted to consider the first M characters of each string.
Help Xenny to find out the Kth string in the list after he sorts them.
Note: Xenny wanted to perform stable sorting.
Stable sorting algorithms maintain the relative order of records with equal keys (i.e. values). That is, a sorting algorithm is stable if whenever there are two records R and S with the same key and with R appearing before S in the original list, R will appear before S in the sorted list.
Input
First line contains a single integer - T, which represents the number of testcases.
T testcases follow.
Each testcase is of the following format:
First line contains 3 space-separated integers - N, K and M.
N is the total number of strings Xenny has.
K is the index of the string in the list after sorting, which Xenny has to find.
M is the number of characters based on which sorting will be done by Xenny.
Then next N lines contain N strings ( each line will contain one string ) .
Output
For each testcase, print the Kth string in the sorted list in a new line.
Constraints
1 ≤ T ≤ 50
1 ≤ N ≤ 103
1 ≤ Max Length of each String ≤ 103
1 ≤ M ≤ Max Length
M ≤ Max Length of each String ≤ 103
SAMPLE INPUT
  

1
3 1 3
abcdef
abcaaa
aabaaa
SAMPLE OUTPUT
  

aabaaa

Explanation 
After performing sorting by the first 3 characters, the order is:
1. aabaaa
2. abcdef
3. abcaaa
Time Limit: 1.0 sec(s) for each input file. 
Memory Limit: 256 MB 
Source Limit: 1024 KB */
    class hackercode18
    {
        static void Main(String[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            string[] str1 = new string[a];
            for (int i = 0; i < a; i++)
            {
                int[] vs = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
                string[] str = new string[vs[0]];
                for (int j = 0; j < vs[0]; j++)
                {
                    str[j] = Console.ReadLine();
                }
                str1[i]=Operation(str, vs[1], vs[2]);
            }
            for (int i = 0; i < str1.Length; i++)
            {
                Console.WriteLine(str1[i]);
            }
        }
        static string Operation(string[] vs,int k,int m)
        {
            string c = "";
            for (int i = 0; i < vs.Length; i++)
            {
                for (int j = 0; j < vs.Length; j++)
                {
                    if (vs[i][m-1]<vs[j][m-1])
                    {
                        string temp = vs[i];
                        vs[i] = vs[j];
                        vs[j] = temp;
                    }
                }
            }
            return c=vs[k-1];
        }
        
        
    }
}
