using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class microsoft_code_car_race
    {
        /* microsoft coding challenger: Car Race (100 Marks)
Paul is very good car racer and loves to race with opponents. This time he chooses some different type of race in which K racers compete between start point S and end point D. Rule of the race is that racers run their cars on different paths such that no other opponent can use the same track if it is used by other.

Pauls seeks your help to decide if the area chosen by him is feasible for the race or not.

Input Format
First line contains t as input denoting total number of the test cases. Each test case contains some data as input. The first line of each test case is N and M, total number of checkpoints and number of connecting paths between these checkpoints. Next M lines contains 2 integers u and v which means there is a directed edge from node u to v. Next line of the test case contains three numbers S, D and K.

Constraints
1 <= t <= 10
1 <= N <= 1000
1 <= M <= 100000
1 <= K <= 500
1 <= u, v, S, D <= N  

Output Format
Print YES if map is feasible to race, NO otherwise.

Sample TestCase 1
Input
2
4 5
1 2
1 3
2 3
2 4
3 4
1 4 2
4 3
1 2
2 3
3 4
1 4 2
Output
YES
NO
Explanation
In first test possible paths are: 1-2-4 and 1-3-4, hence 2 racers can race.

In second there is only one possible path 1-2-3-4, hence only 1 racer can race, therefore it is not feasible.*/
        static void Main(String[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            bool[] flag = new bool[a];
            for (int i = 0; i < a; i++)
            {
                int[] n = Console.ReadLine().Split(' ').Select(n1 => Convert.ToInt32(n1)).ToArray();
                int[][] m = new int[n[1]][];
                for (int j = 0; j < n[1]; j++)
                {
                    m[j] = Console.ReadLine().Split(' ').Select(n1 => Convert.ToInt32(n1)).ToArray();
                }
                int[] sdk = Console.ReadLine().Split(' ').Select(n1 => Convert.ToInt32(n1)).ToArray();
                flag[i] = Operation(n[0],m, sdk[0], sdk[1], sdk[2]);
            }
            for (int i = 0; i < flag.Length; i++)
            {
                if (flag[i])
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
        static bool Operation(int cp,int[][] m,int s,int d,int k)
        {
            bool flag = false;
            IList<int[]> ts = m.ToList();
            int[] a = new int[m.Length];
            int st = 0,fl=0;
            int count = 0;
            for (int i = 0; i < m.Length; i++)
            {
                if (m[i][0]==s)
                {
                    st++;
                }
                if (m[i][1]==d)
                {
                    fl++;
                }
            }            
            if (st<k&&fl<k)
            {
                return flag = false;
            }
            int l = k;
            while (k>0&&st>=0)
            {
                int point = s;
                for (int i = 0; i < ts.Count; i++)
                {
                    if (ts[i][0]==s)
                    {
                        point = ts[i][1];
                        if (Operation2(point,ts,d))
                        {
                            l--;
                            k--;
                            st--;
                            count++;
                            ts.RemoveAt(i);
                            break;
                        }
                    }
                    
                }
            }
            if (k==0)
            {
                flag = true;
            }
            return flag;
        }
        static bool Operation2(int a,IList<int[]> vs,int d)
        {
            bool flag = false;                        
            for (int i = 0; i < vs.Count; i++)
            {
                if (vs[i][0]==a)
                {
                    a = vs[i][1];                    
                    if (a==d)
                    {
                        flag=true;
                    }
                }
            }//use x for the 
            return flag;
        }
    }
}
