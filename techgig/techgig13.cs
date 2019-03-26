using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class techgig13
    {
        /* new question:  For this challenge, you need to take a matrix as an input from the stdin , transpose it and print the resultant matrix to the stdout. 

Input Format
A matrix is to be taken as input from stdin. On first line you need to tell that how many rows and columns your matrix need to have and these values should be separated by space. Below lines will represent the elements of the matrix where each line will represent the row of the matrix.

Constraints
1 < (n,m) < 100

Output Format
Print the resultant matrix to the stdout where each line should represent each row and values in the row should be separated by a space. */

        static void Main(String[] args)
        {
            //string str = Console.ReadLine();
            //int[] a = str.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            //int[,] m1 = new int[a[0], a[1]];
            //for (int e = 0; e < a[0]; e++)
            //{
            //    str = Console.ReadLine();
            //    int[] m1a = str.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            //    for (int r = 0; r < a[1]; r++)
            //    {
            //        m1[e, r] = m1a[r];
            //    }
            //}

            //for (int q = 0; q < a[1]; q++)
            //{
            //    for (int w = 0; w < a[0]; w++)
            //    {
            //        Console.Write(m1[w,q]+ " ");
            //    }
            //    Console.WriteLine();
            //}
            string str1 = Console.ReadLine();
            int[] a1 = str1.Split(' ').Select(n => int.Parse(n)).ToArray();
            string[,] m1 = new string[a1[0], a1[1]];
            for (int i = 0; i < a1[0]; i++)
            {
                string str2 = Console.ReadLine();
                string[] m1a = str2.Split(' ').Select(n => n).ToArray();
                for (int j = 0; j < a1[1]; j++)
                {
                    m1[i, j] = m1a[j];
                }
            }
            for (int i = 0; i < a1[1]; i++)
            {
                for (int j = 0; j < a1[0]; j++)
                {
                    Console.Write(m1[j, i] + " ");
                }
                Console.WriteLine();
            }

            //string a     = Console.ReadLine();
            //    string[] matrixSize = a.Split();

            //    string[,] m1 = new string[Convert.ToInt32(matrixSize[1]), Convert.ToInt32(matrixSize[0])];

            //    for (int i = 0; i <= m1.GetUpperBound(1); i++)
            //    {
            //        string a1 = Console.ReadLine();
            //        string[] m1a = a1.Split();

            //        for (int j = 0; j <= m1.GetUpperBound(0); j++)
            //        {
            //            m1[j, i] = m1a[j];
            //        }
            //    }
            //    int k = 0;
            //    for (int i = 0; i <= m1.GetUpperBound(0); i++)
            //    {

            //        for (int j = 0; j <= m1.GetUpperBound(1); j++)
            //        {
            //            if (k != i)
            //            {
            //                Console.WriteLine();
            //                k = k + 1;
            //            }

            //            if (j == m1.GetUpperBound(1))
            //                Console.Write(m1[i, j]);
            //            else
            //                Console.Write(m1[i, j] + " ");
            //        }
            //    }

        }
    }

}
