﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    /* PROBLEM STATEMENT
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