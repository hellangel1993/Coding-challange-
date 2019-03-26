using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{/* Hotel Room (100 Marks)
There are ‘n’ number of persons who want the same room in a hotel. Each person wants to stay in the hotel as per his own convenient time but only one person can stay at a time. Please note that the room is available only during 5:00 AM to 11:00 PM.   
The Hotel Manager takes 500 rupees from each person who is staying in that room. The duration of the person’s stay is irrelevant, just remember that you need to maximize the profit of the Hotel Manager.
Let us say that n =4 i.e. four persons want the same room. Let us say that 1st person wants the room during 6:00 AM to 8:00 AM and the 2nd person wants the room during 7:00 AM to 8:00 AM, 3rd person wants the room during 8:00 AM to 12:00 Noon and the 4th person wants the room during 11:00 AM to 1:00 PM.




By observing the above image, you can easily see that the Manager can only allow maximum of two persons to stay (1st and 3rd or 1st and 4th or 2nd and 3rd or 2nd and 4th). The maximum profit he can get is 500+500 = 1000 rupees. So, you need to implement an algorithm which can calculate the maximum profit for the Manager. Let’s assume that the persons want the room only during 5:00 AM to 11:00 PM and each person wants the room in multiple of hours.



Input Format
First line contains n, the size of array followed by an N line containing strings describing {<job starting time >#< job ending time >}


Constraints
Array size <= 10000

Output Format
Output should be maximum profit value (Integer). 


Sample TestCase 1
Input
8
6AM#8AM
11AM#1PM
7AM#3PM
7AM#10AM
10AM#12PM
2PM#4PM
1PM#4PM
8AM#9AM
Output
2000
Time Limit(X): 
1.00 sec(s) for each input. 
Memory Limit: 
512 MB 
Source Limit: 
100 KB */
    class techgignetflex
    {       
        static void Main(String[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            check[] checks = new check[a];
            for (int i = 0; i < a; i++)
            {
                string[] vs = Console.ReadLine().Split('#');
                int[] xxx = new int[2];
                for (int j = 0; j < 2; j++)
                {
                    if (Convert.ToInt32(vs[j][vs.Length-1])==65)
                    {
                        xxx[j] = Operation1(vs[j], 0);
                    }
                    else
                    {
                        xxx[j] = Operation1(vs[j], 12);
                    }
                }
                if (xxx[1]>xxx[0])
                {
                    checks[i].duration = xxx[1] - xxx[0];
                }
                else
                {
                    checks[i].duration = xxx[0] - xxx[1];
                }
                checks[i].intime = xxx[0];
                checks[i].outtime = xxx[1];
            }
            for (int i = 0; i < checks.Length; i++)
            {
                //for (int j = 0; j < checks; j++)
                //{

                //}
            }
        }
        static int Operation1(string intime,int a)
        {
            int time = 0;
            string str = "";
            if (intime.Length==4)
            {
                for (int i = 0; i < 2; i++)
                {
                    str+=intime[i];
                }
                return time = a + Convert.ToInt32(str);
            }
            else
            {
                return time = a + Convert.ToInt32(intime[0].ToString());
            }
        }
    }
    public struct check
    {
        public int intime;
        public int outtime;
        public int duration;
    }
}
