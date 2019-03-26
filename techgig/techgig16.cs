using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class techgig16
    {//to find the hcf or GCD of two number
        static void Main(String[] args)
        {
            string str = Console.ReadLine();
            int[] a = str.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int b=1;
            for (int i = 1; i < a[0]||i<a[1]; i++)
            {
                if (a[0]%i==0&&a[1]%i==0)
                {
                    b = i;
                }
            }
            Console.WriteLine(b);
        }
    }
}
