using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class techgig28
    {
        static void Main(String[] args)
        {
            string str = Console.ReadLine();
            int a = 0, b = 0, c = 0, d = 0, e = 0;
            bool flag = true;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString()!=" "&&flag==true)
                {
                    a += int.Parse(str[i].ToString());
                    c = i;
                }
                else if (str[i].ToString()==" ")
                {
                    flag = false;
                    d = i;
                }
                else if (flag==false && (Convert.ToInt32(str[i])) != 32)
                {
                    b += int.Parse(str[i].ToString());
                    e = i;
                }
            }
            if (a>b)
            {
                for (int i = 0; i <= c; i++)
                {
                    Console.Write(str[i]);
                }
                Console.WriteLine();
            }
            else if (b>a)
            {
                for (int i = d+1; i <= e; i++)
                {
                    Console.Write(str[i]);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Equal");
            }
            
        }
    }
}
