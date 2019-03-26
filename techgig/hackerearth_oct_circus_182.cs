using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Total cost
Max. Marks: 100

A family consists of 

x
members. You are given the task to book flight tickets for these 

x
members.
You are given the following information about the airline in which you have to book the tickets:

P
: It denotes the cost of one ticket of the flight.

S
: It denotes the number of total available seats in the flight.

T
: If the numbers of available seats are less than or equal to 

T
, then the cost of the flight ticket increases to 

H
.

H
: It denotes the new hiked cost.
Determine the total cost to book the tickets for all the family members.
Note: The tickets are booked one by one for all the family members.
Input format
First line: Five space-separated integers 
P,S,T,H, and 
x
respectively
Output format
Print the total cost to book the tickets for all the members of the family.
Constraints
1≤P≤H≤105
1≤S≤300
1≤T≤S
1≤x≤S
SAMPLE INPUT
6000 10 5 6500 7
SAMPLE OUTPUT
43000
Explanation 
Monk books 5 tickets for price 6000 each and rest 2 for price 6500 each.
Total expenditure = 6000*5+6500*2 = 43000
 */
namespace techgig
{
    class hackerearth_oct_circus_182
    {
        static void Main(String[] args)
        {
            int[] a = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int cp = 0;
            for (int i = 1; i <= a[4]; i++)
            {
                if (i>=a[2])
                {
                    if (a[1]<=a[2]&&i>a[2])
                    {
                        cp += a[3];
                        a[1]--;
                    }
                    else
                    {
                        cp += a[0];
                        a[1]--;
                    }
                }
                else
                {
                    cp += a[0];
                    a[1]--;                    
                }
            }
            Console.WriteLine(cp);
        }
    }
}
