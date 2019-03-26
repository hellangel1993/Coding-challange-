using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class techgig25
    {
        static void Main(String[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            string str = Console.ReadLine();
            int[] vs = str.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if (vs[j] > vs[i])
                    {
                        int temp;
                        temp = vs[j];
                        vs[j] = vs[i];
                        vs[i] = temp;
                    }
                }
            }
            bool b = true;            
            for (int i = 0; i < a; i++)
            {
                if (i+1!=a)
                {
                    if (vs[i]!=vs[i+1])
                    {
                        if ((vs[i] + 1) != vs[i + 1])
                        {
                            b = false;
                            break;
                        }
                    }
                }
            }
            if (a>1)
            {
                Console.WriteLine(b);
            }
            else
            {
                b = false;
                Console.WriteLine(b);
            }
            Console.ReadLine();
        }
    }
}
