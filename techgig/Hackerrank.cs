using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace techgig
{
    class Solution
    {

        // Complete the hourglassSum function below.
        static List<int> hourglassSum()
        {
            List<int> arr = new List<int>();
            arr.Add(4);
            arr.Add(2);
            arr.Add(5);
            arr.Add(1);
            arr.Add(6);
            //Array.Sort(arr.ToArray());
            arr.Sort();
            int n = arr.Count;
            int wSumA = 0, wSumB = 0, l = 0, r = n - 1;
            List<int> res = new List<int>();
            int count = 0;
            while (l <= r)
            {
                if (wSumB + arr[l] < wSumA)
                {
                    wSumB += arr[l++];
                }
                else
                {
                    wSumA += arr[r];
                    res.Add(arr[r--]);
                }

                count++;
            }
            res.Reverse();
            return res;
            //return result;
        }


        public static long storage(int n, int m, List<int> h, List<int> v)
        {
            Boolean[] hcut = new Boolean[n];
            Boolean[] vcut = new Boolean[m];
            foreach (int item in h)
            {
                hcut[item - 1] = true;

            }
            foreach (int item in v)
            {
                vcut[item - 1] = true;
            }
            int logestH = 0;
            for (int i = 0,j=0; i < n; i++)
            {
                if (!(hcut[i]))
                {
                    j = 0;
                }
                else
                {
                    j++;
                    logestH = Math.Max(logestH, j);
                }
            }
            int logestV = 0;
            for (int i = 0,j=0; i < m; i++)
            {
                if (!(vcut[i]))
                {
                    j = 0;
                }
                else
                {
                    j++;
                    logestV = Math.Max(logestV, j);
                }
            }

            return (long)((logestH + 1) * (logestV + 1));
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int[][] arr = new int[6][];

            //for (int i = 0; i < 6; i++)
            //{
            //    arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            //}

            List<int> result = hourglassSum();

            Console.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }

}