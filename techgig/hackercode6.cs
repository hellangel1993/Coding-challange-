﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class hackercode6
    {
        /* PROBLEM STATEMENT
        static void Main(String[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int x = 0;
            int[] vs = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            for (int i = 0; i < a; i++)
            {
                x += vs[i];
                vs[i] = x;
            }
            int b = Convert.ToInt32(Console.ReadLine());//number of tries
            int[] vs1 = new int[b];
            for (int i = 0; i < b; i++)
            {
                int ind = Convert.ToInt32(Console.ReadLine());
                vs1[i] = Operation(vs, ind);

            }
            for (int i = 0; i < b; i++)
            {
                Console.WriteLine(vs1[i]);
            }

        }
        static int Operation(int[] vs,int a)
        {
            int b = 0;            
            for (int i = 0; i < vs.Length; i++)
            {
                if (a<=vs[i])
                {
                    b = i+1;
                    break;
                }
            }
            return b;
        }
    }
}