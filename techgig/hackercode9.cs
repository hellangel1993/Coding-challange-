﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    /* PROBLEM STATEMENTPoints: 30View Russian TranslationLimak is a little polar bear. Today he found something delicious in the snow. It's a square bar of chocolate with N x N pieces. Some pieces are special because there are cherries on them. You might be surprised by cherries on a chocolate but you've never been on the Arctic Circle, have you?Limak is going to use his claws and break a chocolate into two parts. He can make a cut between two rows or between two columns. It means that he can't break any piece!Limak will eat one part right now, saving the second part for tomorrow. Cherries are very important to him so he wants to have equal number of cherries today and tomorrow. Though parts don't have to have equal numbers of pieces of chocolate.Given description of a chocolate, could you check if Limak can make a cut dividing a chocolate into two parts with equal number of cherries?Note: It's guaranteed that a chocolate contains at least one cherry.Input format:The first line contains one integer number T, denoting number of test cases. Then T test cases follow, each describing one bar of chocolate.For each test case the first line contains one integer number N, denoting size of a chocolate. Each of the next N lines contains a string of size N. Each character in a string is either # (denoting cherry) or . (empty piece). In each test case at least one character is #.Output format:For each test case output an answer in the single line. If Limak can break a chocolate according to rules above print YES. Otherwise, print NO.Constraints:1 <= T <= 102 <= N <= 1000 SAMPLE INPUT  23#####.###4####.##..#..#...SAMPLE OUTPUT  NOYESExplanation In the first test case there are 8 cherries. There is no cut dividing a chocolate into two parts with 4 cherries each.In the second test case we have 8 cherries again. Limak can break a chocolate between the first and the second row. Each part has 4 cherries then.*/
    class hackercode9
    {
        static void Main(String[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            bool[] b1 = new bool[a];
            for (int i = 0; i < a; i++)
            {
                int b = Convert.ToInt32(Console.ReadLine());
                string[] vs = new string[b];
                int count = 0;
                for (int j = 0; j < b; j++)
                {
                    vs[j] = Console.ReadLine();                    
                    for (int k = 0; k < b; k++)
                    {
                        if (vs[j][k].ToString()=="#")
                        {
                            count++;
                        }
                    }
                    
                }
                b1[i] = Operation(vs, count);
            }
            for (int i = 0; i < a; i++)
            {
                if (b1[i])
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
        static bool Operation(string[] vs,int count)
        {
            bool flag = false;
            if (count%2==0)
            {
                //for rows
                int[] a = new int[vs.Length];                
                for (int i = 0; i < vs.Length; i++)
                {
                    for (int j = 0; j < vs.Length; j++)
                    {
                        if (vs[i][j].ToString()=="#")
                        {
                            a[i] += 1;
                        }
                    }
                }
                int x = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    x += a[i];
                    if ((count/2)==(count-x))
                    {
                        x = 0;
                        return flag = true;

                    }
                }
                //for columns                
                int[] a1 = new int[vs.Length];
                for (int i = 0; i < vs.Length; i++)
                {
                    for (int j = 0; j < vs.Length; j++)
                    {
                        if (vs[j][i].ToString()=="#")
                        {
                            a1[i] += 1;
                        }
                    }
                }
                for (int i = 0; i < a.Length; i++)
                {
                    x += a1[i];
                    if ((count/2)==(count-x))
                    {
                        x = 0;
                        return flag = true;
                    }
                }
            }
            return flag;
        }
    }
}
