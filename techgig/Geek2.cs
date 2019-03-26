using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    /* Chess Championship (100 Marks)
Germany is organising a world level chess championship. Various players participated in the tournamentall over the world. Each player is assigned a different puzzle to solve related to chess only. In the final level, they are planning to give a single puzzle to solve to both of the contestants. Assuming that the king starts on some square of an infinite chessboard. In the puzzle of chess, the king can move to any neighbouring square horizontally, vertically, or diagonally. In this puzzle, the king takes one move extra after n number of moves. You have to find that in how many different squares can the king be after n moves? 
                                                             
Input Format
Your function will have one integer(n) depicting the number of moves taken by the king in the starting position

Output Format
Output will be the total number of different squares king can cover after n moves 

Sample Test Case
Sample Input
2
Sample Output
49
*/
    class Geek2
    {
        static void Main(String[] args)
        {
            int output;
            int ip1_size = 0;
            ip1_size = Convert.ToInt32(Console.ReadLine());
            int[] ip1 = new int[ip1_size];
            int ip1_item;
            for (int ip1_i = 0; ip1_i < ip1_size; ip1_i++)
            {
                ip1_item = Convert.ToInt32(Console.ReadLine());
                ip1[ip1_i] = ip1_item;
            }
            output = divideAndRule(ip1);
            Console.WriteLine(output);
        }

        static int divideAndRule(int[] input1)
        {            
            int count = 0;
            if ((input1.Length)%2==0)
            {
                count = -1;
            }
            else
            {
                int part1 = ((input1.Length) - 1) / 2;
                int part2 = part1 + 1;
                int a=0, b=0;
                for (int i = 0; i < part1; i++)
                {
                    a += input1[i];
                    b += input1[part2 + i];
                }
                if (a==b)
                {
                    count = 1;
                }
                else
                {
                    count = -1;
                }
            }
            return count;
        }

    }
}
