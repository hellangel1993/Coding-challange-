using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class techgig26
    {
        //find the biggest number in the integer
        static void Main(String[] args)
        {
            string str = Console.ReadLine();
            char a='0';
            for (int i = 0; i < str.Length; i++)
            {
                if (a<str[i])
                {
                    a = str[i];
                }
            }
            Console.WriteLine(a);
        }
    }
}
