﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    /*We all know the town Radiator Springs, connected to California by direct road (Route no. 66). After a commendable performance by Lighting McQueen at the Piston Cup, the town of Radiator Springs became famous. In order to improve the traffic capacity of the road, the town's judge and doctor, Doc Hudson ordered to place on traffic sign, thus limiting the maximum speed. The traffic sign in the town of Radiator Springs seems to be a bit odd. The reason being, they only limit the speed where the traffic signals are placed and just after passing the sign the cars are allowed to drive at any speed.
It is given that the cars of Radiator Springs has an average accerleration/deceleration of x km/h2, and has a maximum speed of y km/h. The road has the length of L km, and the speed sign, limiting the speed to w km/h, is placed d km (1 <= d <= L) away from the Radiator Springs. You have to find the minimum time that an average Radiator Spring car will need to get from the California, if the car drives at the optimal speed.
Note : The car has a zero speed at the beginning of the journey.
Input format
The first line of the input file contains two integer numbers x and y (1 <= x, y <= 10000). The second line contains three integer numbers L, d and w (2 <= L <= 10000; 1 <= d < L; 1 <= w <= 10000).
Output format
Print the answer with nine digits after the decimal point.
Partial Scoring
This problem has 20 test input files,each of them having score of 5. It means even if 10 input are passed, you will get score as 50 and solution will be marked as accepted. But If the total time limit or memory limit exceeds, then the submission is marked unaccepted even if few testcases might have passed.
SAMPLE INPUT
  

1 1
2 1 3
SAMPLE OUTPUT
  

2.500000000*/
    class hackercode25
    {
        static void Main(String[] args)
        {
            int[] s = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int[] ldw = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();

        }
    }
}
