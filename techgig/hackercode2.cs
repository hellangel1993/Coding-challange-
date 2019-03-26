using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class hackercode2
    {
        static void Main(String[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            string[] vs = new string[a];
            for (int i = 0; i < a; i++)
            {
                vs[i] = Console.ReadLine();
            }
            int[][] price = new int[a][];
            for (int i = 0; i < a; i++)
            {
                string str = Console.ReadLine();
                price[i] = str.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            }
            int b = Convert.ToInt32(Console.ReadLine());
            string[] vs1 = new string[b];
            for (int i = 0; i < b; i++)
            {
                vs1[i] = Console.ReadLine();
            }

            //algo starts
            int c = 0;
            int d = 0;
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if (vs1[i]==vs[j])
                    {
                        c += Operation(price, d, j);
                        d = j;
                        break;
                    }
                }
            }
            Console.WriteLine(c);
        }
        static int Operation(int[][] cost,int i,int j)
        {
            int c = 0;
            c += cost[i][j];
            return c;
        }
    }
}
