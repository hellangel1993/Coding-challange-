using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class test4
    {
        static void Main(string[] args)
        {
            int x = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.Write("*");
                for (int j = 1; j < 4; j++)
                {
                    if (i==j)
                    {
                        Console.Write("*");
                    }
                    if (i==3)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");                   
                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
