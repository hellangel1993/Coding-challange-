using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class data_structure
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int c=0, d=0, e=0;
            for (int i = 0; i <=a; i++)
            {
                 int b= Convert.ToInt32(Console.ReadLine());
                if (b>=75)
                {
                    c++;
                }
                else if(b>40&&b<75)
                {
                    d++;
                }
                else
                {
                    e++;
                }
            }
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
        }
    }
}
