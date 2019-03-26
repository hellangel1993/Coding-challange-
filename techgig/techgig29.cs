using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class techgig29
    {
        static void Main(String[] args)
        {
            string str = Console.ReadLine();
            int[] vs = str.Split(' ').Select(n => Convert.ToInt32(n.ToString())).ToArray();
            int[,] a = new int[vs[0], vs[1]];
            for (int i = 0; i < vs[0]; i++)
            {
                string str1=Console.ReadLine();
                int[] vs1 = str1.Split(' ').Select(n => Convert.ToInt32(n.ToString())).ToArray();
                for (int j = 0; j < vs[1]; j++)
                {
                    a[i, j] = vs1[j];
                }
            }
            int b = 0, c = 0;
            for (int i = 0; i < vs[0]; i++)
            {
                b += (a[i, i]);
            }
            for (int i = 0; i < vs[0]; i++)
            {
                c += a[i, (vs[0] - 1) - i];
            }
            if (b>c)
            {
                Console.WriteLine("Diagonal 1");
            }
            else if (c>b)
            {
                Console.WriteLine("Diagonal 2");
            }
            else if (b==c)                      
            {
                Console.WriteLine("Equal");
            }
        }
    }
}
