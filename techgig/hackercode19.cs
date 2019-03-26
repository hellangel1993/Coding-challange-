using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class hackercode19
    {/*PROBLEM STATEMENT
Points: 30
Arnab is a robber and he has managed to rob N different strings from Akash. Now he decides to sell these strings in the market to make some profit. But, of all the strings he has, he wants to find the size of the largest anagram group so that he can easily sell that one first and make maximum profit initially. Help him find the largest size of groups of anagrams.
An anagram of a string is another string that contains same characters, only the order of characters can be different. For example, “abcd” and “dabc” are anagram of each other. 
Input:
First line of input contains an integer N, number of total strings. Next N lines contains a single string S. 
Output:
Print the largest size of group of anagrams possible. 
Constraints: 


1≤
N







≤100000









1≤|S|≤50
SAMPLE INPUT
  

5
ab
ba
cab
bca
cba
SAMPLE OUTPUT
  

3

Explanation 
Groups of anagrams that can be formed are :
{ab,ba}
{cab, bca, cba} 
So the answer is 3 as largest size of group of anagram is 3. */
        static void Main(String[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 0;
            for (int i = 0; i < a; i++)
            {
                string str = Console.ReadLine();
                IList<char> vs = str.ToList();
                int count = str.Length;
                for (int j = 0; j < vs.Count; j++)
                {
                    if (j+1<vs.Count)
                    {
                        for (int k = j+1; k < vs.Count; )
                        {
                            if (vs[j] == vs[k])
                            {
                                vs.RemoveAt(k);
                            }
                            else
                            {
                                k++;
                            }
                        }
                    }
                }
                if (b<vs.Count)
                {
                    b = vs.Count;
                }
            }
            Console.WriteLine(b);
        }
    }
}
