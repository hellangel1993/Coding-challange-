using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class hackercode5
    {
        /*PROBLEM STATEMENT
Points: 30
Watson was observing in calendar dates of form DD:MM:YYYY. He considers a date to be lucky if 
DD + 1 = MM and
MM + 1 = YYYY % 100, where a % b denotes the remainder when a is divided by b.
For example, date 02:03:2004 is lucky because 02 + 1 = 03 and 03 + 1 = 2004 % 100. 
Now comes Sherlock and Watson gives him two dates, say D1 and D2, and asks him how many lucky dates lie between D1 and D2(both inclusive).
Input
First line contains T, the number of test cases. Each test case consists of two valid dates D1 and D2(in form DD:MM:YYYY) separated by a space. D2 occurs on or after D1.
Output
For each test case, print the required answer in one line.
Constraints
1 ≤ T ≤ 104 
1 ≤ Year of each date ≤ 9999
20% testdata: Years D1 and D2 don't differ by more than 10
20% testdata: Years D1 and D2 don't differ by more than 100 
60% testdata: General constraints.
SAMPLE INPUT
  

2
01:01:0001 01:02:0003
05:02:2015 05:02:2017
SAMPLE OUTPUT
  

1
0

Explanation 
testcase1: Date 01:02:0003 is the lucky date in range.
testcase2: No lucky date in range. */
        static void Main(String[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            //string[] str = new string[a];
            int  m=0;
            int[] count = new int[a];
            for (int i = 0; i < a; i++)
            {
                string[] str1 = Console.ReadLine().Split(' ').ToArray();
                int[][] int1 = new int[2][];
                for (int j = 0; j < 2; j++)
                {
                    int1[j] = str1[j].Split(':').Select(n => Convert.ToInt32(n)).ToArray();
                }
                int year = int1[0][2], mm = int1[0][1], dd = int1[0][0];
                while (year <= int1[1][2])
                {
                    while (mm<=11)
                    {
                        if (year==int1[1][2])
                        {
                            if (mm!=int1[1][1])
                            {
                                int d = 0;                    
                                count[i] += MonthOperation(d,mm, year);
                            }
                            else
                            {
                                int ed = int1[1][0];
                                count[i] += MonthOperation(1,ed, mm, year);
                            }
                        }
                        else if (year<int1[1][2])
                        {
                            int sd = 0;
                            if (m == 0)
                            {
                                sd = dd;
                            }                            
                            count[i] += MonthOperation(sd,mm, year);
                        }
                        mm++;
                        
                    }
                    if (mm==12)
                    {
                        mm = 0;
                    }
                    year++;
                }
            }
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(count[i]);
            }
            
            
        }
        static int MonthOperation(int sd,int m,int y)
        {
            int count = 0;
            if (m==0||m==2||m==4||m==6||m==7||m==9||m==11)
            {
                count += DayOperation(sd,31, m, y);
            }
            else
            {
                count += DayOperation(sd,30, m, y);
            }            
            return count;
        }
        static int MonthOperation(int a,int ed,int m,int y)
        {
            int count = 0;
            if (m == 0 || m == 2 || m == 4 || m == 6 || m == 7 || m == 9 || m == 11)
            {
                count += DayOperation(1, ed, m, y);
            }
            else
            {
                count += DayOperation(1, ed, m, y);
            }
            return count;
        }
        static int DayOperation(int sd,int ed,int m,int y)
        {
            int a = sd;
            int count = 0;
            while (a<=ed)
            {
                if (m==a+1&&m==y%100)
                {
                    count++;
                }
                a++;
            }
            return count;
        }
    }
}
