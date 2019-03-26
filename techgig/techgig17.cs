using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class techgig17
    {
        static void Main(String[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            string str = Console.ReadLine();
            int[] vs = new int[a];
            vs= str.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int b = Convert.ToInt32(Console.ReadLine());
            bool flag = false;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if ((vs[i]+vs[j])==b)
                    {
                        flag = true;
                        break;
                    }
                }
            }
            if (flag==false)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }

            Console.ReadLine();
        }
    }
}
