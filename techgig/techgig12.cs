using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class techgig12
    {
        //addtion of to matrix from the stringinput one by one in the row with the space in between.
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int[] a = str.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int[,] m1 = new int[a[0], a[1]];
            for (int i = 0; i < a[0]; i++)
            {
                string m1a = Console.ReadLine();
                int[] m1a1 = m1a.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
                for (int j = 0; j < a[1]; j++)
                {
                    m1[i, j] = m1a1[j];
                }
            }
            str = Console.ReadLine();
            int[] b = str.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int[,] m2 = new int[b[0], b[1]];
            for (int i = 0; i < a[0]; i++)
            {
                string m2a = Console.ReadLine();
                int[] m2a2 = m2a.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
                for (int j = 0; j < a[1]; j++)
                {
                    m2[i, j] = m2a2[j];
                }
            }
            if (a[0]==b[0]&&a[1]==b[1])
            {
                for (int i = 0; i < a[0]; i++)
                {
                    for (int j = 0; j < b[1]; j++)
                    {
                        int z = m1[i, j] + m2[i, j];
                        Console.Write(z + " ");
                    }
                    Console.WriteLine();
                }
            }
            
        }
    }
}
