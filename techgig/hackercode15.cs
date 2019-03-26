using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{/* PROBLEM STATEMENT
Points: 50
The secret services of Armin, an otherwise peace-loving country, have decided to perform a surgical strike in the war-torn city of Tashka. Tashka is under enemy control and the objective of the strike is to gain control over the city.
The mission is subdivided into the following steps:
1) Divide in groups and infiltrate all enemy bases in Tashka as unarmed civilians, and find the status of enemy's defense strength at that base.
( You can assume that the number of groups are sufficiently large to cover each base separately )
2) Pick up the required amount of ammunition from our secret ammunition store in the city.
3) Return to the bases and destroy the enemy defense.
4) Rush to the Town Hall for the Helicopter pick up out of the town.
There are a total of N buildings in Tashka, numbered from 1 to N . The agents will be dropped at building denoted by S, post which they will divide into groups and each enemy base will have a group moving towards it. The ammunition store is denoted by A and town hall is denoted by H . All the buildings except these three are enemy bases and are to be infiltrated. There are a total of M bidirectional roads in the city, each road connects two cities. There can be multiple roads between a pair of cities and each road has a time taken to cross associated with its terrain.
Monk is made in charge of the pickup. He can not land the Helicopter before all the groups have arrived at the Town Hall. Find the Minimum units of Time, post dropping the agents, that the Helicopter should be landed such that all groups are able to reach the Town Hall.
Input:
First line contains an integer T. T test cases follow.
First line of each test cases contains two space-separated integers N, M.
Each of the next M lines contains three space-separated integers X, Y, C, denoting that there is a bidirectional road between X and Y that needs C units of time to cross.
The next line contains three space-separated integers S, A and H (not necessarily distinct) .
Output:
Print the answer to each test case in a new line.
Constraints:
1 ≤ T ≤ 10
4 ≤ N ≤ 100
1 ≤ M ≤ 10000
1 ≤ X, Y, S, A, H ≤ N
1 ≤ C ≤ 100
Note:
Time taken to note status of enemy defense, load ammunition or attack enemy enemy base can be considered negligible compared to time taken to travel.
SAMPLE INPUT
  

1
4 4
1 4 1
1 2 1
2 3 1
2 4 1
1 2 3
SAMPLE OUTPUT
  

5

Explanation 
Agents start at 1, rush to enemy base at 4 (Time taken = 1 units). Go to ammunition store at 2, and return back to attack enemy base (Time taken=2 units) , destroy the base and head off to pickup point (Time taken =2 units).
Hence, 1+2+2= 5units.
Time Limit: 2.0 sec(s) for each input file. 
Memory Limit: 256 MB 
Source Limit: 1024 KB 
Marking Scheme: Marks are awarded if any testcase passes.*/
    class hackercode15
    {
        static void Main(String[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int[] tu = new int[a];
            for (int i = 0; i < a; i++)
            {
                int[] a1 = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
                path[] paths = new path[a1[1]];
                for (int j = 0; j < a1[1]; j++)
                {
                    string[] vs = Console.ReadLine().Split(' ');
                    paths[j].x = Convert.ToInt32(vs[0]);
                    paths[j].y = Convert.ToInt32(vs[1]);
                    paths[j].c = Convert.ToInt32(vs[2]);
                }
                int[] a2 = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
                tu[i] = Operation(paths, a1[0], a1[1], a2[0], a2[1], a2[2]);
            }
            for (int i = 0; i < tu.Length; i++)
            {
                Console.WriteLine(tu[i]);
            }
        }
        static int Operation(path[] paths, int n, int m, int s, int a, int h)//n for number of building,m is number of paths,s for start,a for amunation point,h for point of helicoptor
        {
            int tu = 0;
            int count = 0;
            if (s==a&&a==h)
            {
                count = n - 1;
            }
            else
            {
                if (s==h)
                {
                    count = n - 2;
                }
                else if (s==a)
                {
                    count = n - 2;
                }
                else if (s==h)
                {
                    count = n - 2;
                }
                else
                {
                    count = n - 3;
                }
            }
            tu += objective1(count, s, a, h, paths,n);
            tu += objective2(a, paths, n, s, h,count);
            //tu += objective3(paths,s,a,h,n,count);
            tu += objective4(paths,s,a,h,n,count);
            return tu;
        }
        static int objective1(int Ebase,int s,int a,int h,path[] paths,int b)//from entry point to the enamy base,b for building
        {
            int tu = 0;
            for (int i = 1; i <= b; i++)
            {
                if (i!=s&&i!=a&&i!=h)
                {
                    tu = Movements(s, i, paths);
                }
                else
                {
                    continue;
                }
            }
            return tu;
        }
        static int objective2(int a,path[] paths,int b,int s,int h,int Ebase)//a for ammunation, b for number of building,ebase for number of enamey base
        {
            int tu=0;
            for (int i = 1; i <= b; i++)
            {
                if (i!=s&&i!=a&&i!=h)
                {
                    tu = Movements(i, a, paths);
                }
                else
                {
                    continue;
                }
            }
            return tu=tu*2;
        }
        //static int objective3(path[] paths,int s,int a,int h,int b,int Ebase)//a for ammunation, b for number of building,ebase for number of enamey base
        //{
        //    int tu = 0;
        //    for (int i = 1; i <= b; i++)
        //    {
        //        if (i!=s&&i!=a&&i!=h)
        //        {
        //            tu = Movements(a, i, paths);
        //        }
        //        else
        //        {
        //            continue;
        //        }
        //    }
        //    return tu=tu-Ebase;
        //}
        static int objective4(path[] paths,int s,int a,int h,int b,int Ebase)//for exit
        {
            int tu = 0;
            for (int i = 1; i <= b; i++)
            {
                if (i != s && i != a && i != h)
                {
                    tu = Movements(i, h, paths);
                }
                else
                {
                    continue;
                }
            }
            return tu = tu ;
        }
        static int Movements(int current,int goal,path[] paths)
        {
            int tu = 0;
            for (int i = 0; i <= paths.Length; i++)
            {
                if (current==paths[i].x)
                {
                    if (goal==paths[i].y)
                    {
                        return tu = paths[i].c;
                    }
                    else
                    {
                        tu = Movements(paths[i].y, goal, paths);
                    }
                }
                else if (current==paths[i].y)
                {
                    if (goal==paths[i].x)
                    {
                        return tu = paths[i].c;
                    }
                    else
                    {
                        tu = Movements(paths[i].x, goal, paths);
                    }
                }
            }
            return tu;
        }
        public struct path
        {
            public int x;
            public int y;
            public int c;
        }
    }
}
   
