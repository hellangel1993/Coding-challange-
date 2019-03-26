using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class techgig11
    {
        //Checking the string and counting total number of upper and lower character in the string 
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int c = 0, d = 0;
            for (int i = 0; i < str.Length; i++)
            {
                int ascii = (int)Convert.ToChar(str[i]);
                if (ascii==32)
                {

                }
                else if (ascii>64&&ascii<91)
                {
                    c++;
                }
                else if (ascii>96&&ascii<123)
                {
                    d++;
                }
                
            }
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.ReadLine();
        }
        

    }
}
