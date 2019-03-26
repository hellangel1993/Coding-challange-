using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class test1
    {
        static void Main(String[] args)
        {
            string str1 = Console.ReadLine();
            decimal[] g = str1.Split('.').Select(n => Convert.ToDecimal(n)).ToArray();
           
            if (g.Length == 2)
            {
                int[] vs1 = (g[1].ToString()).Select(n => Convert.ToInt32(n)).ToArray();
                for (int i = vs1.Length - 1; i >= 0; i--)
                {
                    if (i != 0)
                    {
                        if (vs1[i] >= 53)
                        {
                            vs1[i - 1] += 1;
                        }
                    }
                    else if (i == 0)
                    {
                        if (vs1[i] >= 53)
                        {
                            g[0] += 1;
                        }
                    }
                    
                }
            }
            Console.WriteLine(g[0]);
        }
    }
}
