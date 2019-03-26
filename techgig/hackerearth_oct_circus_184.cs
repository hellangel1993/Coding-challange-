using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Reversing elements
Max. Marks: 100

You are given an array

A
of size 

N
 and 

Q
queries. For each query, you are given two indices of the array 

L
 and 

R
. The subarray generated from 

L
to 

R
is reversed. Your task is to determine the maximum sum of the subarrays.
Note: After each query is solved, the array comes to its initial states.
Input format
First line: Two space-separated integers 

N
 and 

Q
Next line: 

N
space-separated integers denoting the array elements.
Next 

Q
lines: Two space-separated integers in every line denoting the values of 


Li
and 


Ri
Output format
For each query, print the required answer in a new line.
Constraints









1≤N,Q≤105







1≤L≤R≤N











−106≤Ai≤106
SAMPLE INPUT
  

5 2
3 -1 4 2 -1
3 4
1 2
SAMPLE OUTPUT
  

8
9

Explanation 
Given array is {3,-1,4,2,-1}.
For first query L=3 and R=4. Now the array becomes {3,-1,2,4,-1}.
Maximum sub-array sum is 8 and the sub-array is {3,-1,2,4}.
For second query L=1 and R=2. Now the array becomes {-1,3,4,2,-1}.
Maximum sub-array sum is 9 and the sub-array is {3,4,2}.*/
namespace techgig
{
    class hackerearth_oct_circus_184
    {
        static void Main(String[] args)
        {
            int[] a = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();

        }
    }
}
