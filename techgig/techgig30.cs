using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class techgig30
    {
        static void Main(String[] args)
        {
            string str = Console.ReadLine();
            int[] a = str.Split(' ').Select(n => Convert.ToInt32(n.ToString())).ToArray();
            int[] b = new int[a[0]];
            for (int i = 0; i < a[0]; i++)
            {
                string str1 = Console.ReadLine();
                int[] c = str1.Split(' ').Select(n => Convert.ToInt32(n.ToString())).ToArray();
                for (int j = 0; j < a[1]; j++)
                {
                    b[i]+=c[j];
                }
            }
            int d = 0;
            for (int i = 0; i < a[0]; i++)
            {
                for (int j = 0; j < a[0]; j++)
                {
                    if (b[d]<b[j])
                    {
                        if (b[i] < b[j])
                        {
                            d = j;
                        }
                        else
                        {
                            d = i;
                        }
                    }
                }
            }
            Console.WriteLine("Row " + (d+1));
        }
    }
}
