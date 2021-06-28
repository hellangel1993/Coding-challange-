using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{/*There is a string, , of lowercase English letters that is repeated infinitely many times. Given an integer, , find and print the number of letter a's in the first  letters of the infinite string.

Example


The substring we consider is , the first  characters of the infinite string. There are  occurrences of a in the substring.

Function Description

Complete the repeatedString function in the editor below.

repeatedString has the following parameter(s):

s: a string to repeat
n: the number of characters to consider
Returns

int: the frequency of a in the substring
Input Format

The first line contains a single string, .
The second line contains an integer, .

Constraints

For  of the test cases, .
Sample Input

Sample Input 0

aba
10
Sample Output 0

7
Explanation 0
The first n=10  letters of the infinite string are abaabaabaa. Because there are 7 a's, we return 7.

Sample Input 1

a
1000000000000
Sample Output 1

1000000000000
Explanation 1
Because all of the first n=1000000000000  letters of the infinite string are a, we return 1000000000000 .
  */
    class hackerRankRepeated_String
    {
        static long repeatedString(string s, long n)
        {
            int timeA = 0;
            int extraA = 0;
            long repeatTime = n % (long)s.Length;
            long loopTime = n / (long)s.Length;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a')
                {
                    timeA++;
                    if (i<repeatTime)
                    {
                        extraA++;
                    }
                }
            }
            long result = (loopTime * timeA) + (extraA);
            return result;

        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = repeatedString(s, n);

            Console.WriteLine(result);
        }
    }
}
