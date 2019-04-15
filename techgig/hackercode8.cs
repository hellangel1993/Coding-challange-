﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    /* PROBLEM STATEMENT
    class hackercode8
    {
        static void Main(String[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int[] vs = new int[a];
            for (int i = 0; i < a; i++)
            {
                vs[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(Operation(vs[i])*2);
            }
        }
        static int Operation(int a)
        {
            int count = 0;
            for (int i = 2; i < a; i++)
            {
                if (a%i==0)
                {
                    if (GCDOperation(i,(a/i))&&a==i*(a/i))
                    {
                        count++;
                    }
                }
            }
            if (count==0)
            {
                return count = 1;
            }
            return count;
        }
        static bool GCDOperation(int a,int b)
        {
            bool flag = true;
            int j = b;
            if (a<b)
            {
                j = a;
            }

            for (int i = 2; i < j; i++)
            {
                if (a%i==0&&b%i==0)
                {
                    flag = false;
                }
            }
            return flag;
        }
        
    }
}