using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class techgig19
    {
        //        You will be getting a binary number as an input and you need to convert it into a decimal number.

        //Input Format
        //You will be taking a binary number as an input. 

        //Constraints
        //1 < N< 10^9

        //Output Format
        //Print the decimal number to the stdout.

        //Sample TestCase 1
        //Input
        //110
        //Output
        //6 
        static void Main(String[] args)
        {
            string str = Console.ReadLine();
            int v1=0,j=0;            
            for (int i = (str.Length)-1; i >= 0; i--)
            {
                if (Convert.ToInt32(str[j++])==49)
                {
                    v1 = v1 + power(i);
                }
            }
            Console.WriteLine(v1);
        }
        public  static int power(int i)
        {
            int v1 = 1;
            for (int j =i ; j > 0; j--)
            {
                v1 = v1 * 2;
            }
            return v1;
        }

    }
}
