using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class hackercode4
    {
        /* PROBLEM STATEMENT
Points: 50
Implement the recursive function given by the following rules and print the last 3 digits:
F(x, y) = {
y + 1 when x = 0,
F(x - 1, 1) when x > 0 and y = 0,
F(x - 1, F(x, y - 1)) when x > 0 and y > 0
} 
Input Format
A single line containing two integers X,Y
1 <= X,Y <= 100000 
Output Format
The last three digits 
Input Constraints
X and Y are non-negative integers. Problem Setter: Practo Tech Team 
SAMPLE INPUT
  

1 100
SAMPLE OUTPUT
  

102

Explanation 
Note: x and y are non-negative integers*/
        static void Main(String[] args)
        {
            int[] vs = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int x = vs[0];
            int y = vs[1];
            int c = 0;
            if (1<=x&&x<=100000&&y>=1&&y<=100000)
            {
                if (x>y)
                {
                    c = x - y;
                    x = c;
                }
                else if (y>x)
                {
                    c = y - x;
                    y -=c;
                }
                c += Operation(x, y);
            }
            string str = c.ToString();
            for (int i = str.Length-3; i <= vs.Length; i++)
            {
                Console.Write(str[i]);
            }
        }
        static int Operation(int x,int y)
        {
            int c = 0;
            if (x==0)
            {
                c = y + 1;
            }
            else if (x> 0&&y==0)
            {
                c=Operation(x - 1, 1);
            }
            else if (x>0&&y>0)
            {
                c = Operation(x - 1, Operation(x, y - 1));
            }
            return c;
        }
    }
}
