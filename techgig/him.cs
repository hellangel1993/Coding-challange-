
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    

    internal class him
    {
        static void Main(string[] args)
        {
            string muns = Console.ReadLine();

            if (muns == null)
            {
                
            }

            if (muns.Length == 0)
            {
                Console.WriteLine();    
            }
            else
            {
                string res = "";
                if ((muns.Length % 2) == 0)
                {
                    for (int i = 0; i < muns.Length; )
                    {
                       res+=muns[i+1].ToString()+muns[i].ToString();
                        i += 2;
                    }
                }
                else
                {
                    for (int i = 0; i < muns.Length-1;)
                    {
                        res += muns[i + 1].ToString() + muns[i].ToString();
                        i += 2;
                    }
                    res += muns[muns.Length - 1];
                }

                Console.WriteLine(res);
            }
        }

    }
}
