using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class hackercode3
    {
        /* PROBLEM STATEMENT
Points: 30
Little Fajlu and Laal Baadshah are extremely good, and passionate Age of Empires 2 players. They're crazy about the game, and the passion they display for the game, if displayed for their semester exams - will make them top the university, even. But well, that's them.
Laal Baadshah relies on rushing through the game, so he tries to create as many weird units as quick as possible, without realizing how much power and strength his total army is giving him. While, Little Fajlu is an extremely smart player - he plans his games in a very smart, and strategic manner... which makes it very difficult to defeat him. Really. Not kidding.
We want the problem solvers to learn Fajlu's strategy, too. So, here it goes.
The top three units he uses are: Samurai, Paladins, and Champions.
The cost of a Samurai is: 100 food, 0 gold.
The cost of a Paladin is: 125 food, 50 gold.
The cost of a Champion is: 50 food, 100 gold.
What Fajlu does is given the state of his current economy, and how much will each unit increase his total advantage over his opponent, he manages to get the maximum army strength he can manage to get.
What you need to do is to calculate this amount quickly, faster than Fajlu and let Laal Baadshah know how much strength will he need to overcome Fajlu?
Input format:
The first line contains a number, T, denoting the number of test cases. The next line contains SIX integers. 
1. The amount of food F Fajlu has, where 1<=F<= 40000
2. The amount of gold G Fajlu has, where 1<=G<= 40000
3. Power of a Samurai S, where 1<=S<= 1000
4. Power of a Paladin P , where 1<=P<= 1000
5. Power of a Champion C, where 1<=C<= 1000
6. Total power Power Laal Baadshah already has, where 1<=Power<= 3000 
1 <= T<= 100 
Output format:
You've to print how much more power would Laal Baadshah need to defeat Fajlu. If he already has more or equal power to defeat him, print -1.

PS: The image contains violent deaths. Adult supervision required. 
SAMPLE INPUT
  

1
389 130 16 13 18 24
output
42
*/

        static void Main(String[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            string str = Console.ReadLine();
            int[] b = str.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();            
            int f3 = 0;
            int f4 = 0;
            int f5 = 0;
            
            while (b[0]>=100)
            {
                f3++;
                b[0] -= 100;
            }
            while (b[0]>=125&&b[1]>=50)
            {
                f4++;
                b[0] -= 125;
                b[1] -= 50;
            }
            while (b[0]>=50&&b[1]>=100)
            {
                f5++;
                b[0] -= 50;
                b[1] -= 100;
            }

            int power = ((f3 * b[2]) + (f4 * b[3]) + (f5 * b[4])) - b[5];
            if (power<=0)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine(power);
            }

        }
    }
}
