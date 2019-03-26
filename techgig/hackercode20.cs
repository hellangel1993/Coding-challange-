using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class hackercode20
    {
        /*PROBLEM STATEMENT
Points: 30
Rash is known about his love for racing sports. He is an avid Formula 1 fan. He went to watch this year's Indian Grand Prix at New Delhi. He noticed that one segment of the circuit was a long straight road. It was impossible for a car to overtake other cars on this segment. Therefore, a car had to lower down its speed if there was a slower car in front of it. While watching the race, Rash started to wonder how many cars were moving at their maximum speed. Formally, you're given the maximum speed of N cars in the order they entered the long straight segment of the circuit. Each car will prefers to move at its maximum speed. If that's not possible because of the front car being slow, it might have to lower its speed. It still moves at the fastest possible speed while avoiding any collisions. For the purpose of this problem, you can assume that the straight segment is infinitely long. Count the number of cars which were moving at their maximum speed on the straight segment.
Input
The first line of the input contains a single integer T denoting the number of test cases to follow. Description of each test case contains 2 lines. The first of these lines contain a single integer N, the number of cars. The second line contains N space separated integers, denoting the maximum speed of the cars in the order they entered the long straight segment.
Output
For each test case, output a single line containing the number of cars which were moving at their maximum speed on the segment.
Constraints
1≤T≤100
1≤N≤105
1≤speed≤109
SAMPLE INPUT
3
1
10
3
8 3 6
5
4 5 1 2 3
outpit 
1
2
2
*/
        static void Main(String[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int[] vs1 = new int[a];
            for (int i = 0; i < a; i++)
            {
                int b = Convert.ToInt32(Console.ReadLine());
                IList<int> vs = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToList();
                for (int j = 0; j < vs.Count; j++)
                {
                    if (j+1<vs.Count)
                    {
                        for (int k = j+1; k < vs.Count; )
                        {
                            if (vs[j]<vs[k])
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
                vs1[i] = vs.Count;
            }
            for (int i = 0; i < vs1.Length; i++)
            {
                Console.WriteLine(vs1[i]);
            }
        }
    }
}
