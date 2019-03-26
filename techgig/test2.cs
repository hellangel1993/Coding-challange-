using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class test2
    {
        static void Main(String[] args)
        {
            int row = Convert.ToInt32(Console.ReadLine());
            int[] inp = new int[row];
            string s = Console.ReadLine();
            int odd = 0, even = 0, evenCnt = 0, oddCnt = 0;
            for (int i = 0; i < row; i++)
            {
                inp[i] = Convert.ToInt32(s.Split(' ')[i]);
            }
            for (int i = 0; i < row; i++)
            {
                if (inp[i] % 2 == 0)
                {
                    even += inp[i];
                    evenCnt++;
                }
                else
                {
                    odd += inp[i];
                    oddCnt++;
                }
            }
            decimal evenavg = 0.00m;
            decimal oddavg = 0.00m;
            if (evenCnt != 0)
                evenavg = (decimal)even / evenCnt;
            if (oddCnt != 0)
                oddavg = (decimal)odd / oddCnt;
            
            var a = evenavg + oddavg;
            var b = Math.Ceiling(a);
            Console.Write(b);
        }
    }
}
