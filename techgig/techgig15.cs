using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class techgig15
    {
        static void Main(String[] args)
        {
            string str = Console.ReadLine();
            int[] a = str.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            Console.WriteLine(fact(a[0], a[1]));
            Console.Read();
        }
        public static int fact(int b, int c)
        {
            int d = b;
            if (c != 0)
            {
                if (c != 1 && b != 0)
                {
                    d = d * fact(b, --c);
                }
            }
            else
            {
                d = 1;
            }
            
            return d;
        }
        
    }
}
