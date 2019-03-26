using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class testforchecking
    {
        static void Main(String[] args)
        {
            int[,] a = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    a[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 3; i>=0; i--)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j==3-i)
                    {
                        Console.WriteLine(a[i, j]);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
