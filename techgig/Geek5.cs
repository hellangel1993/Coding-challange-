using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class Geek5
    {
        /* Toepliz Matrix (100 Marks)
You will be given a two-dimensional array and a number and you are asked to find whether the given matrix is Toepliz or not. 


Input Format:
You will be given a function which will take two-dimensional matrix as argument.

Output Format:
Return 1 from the function if the matrix is Toepliz, else return -1.


Constraints:
3 < n,m < 10,00,000
where n is the number of rows while m will be the number of columns.


Sample Test Case: 
Sample Input :
4 
5
6 7 8 9 2
4 6 7 8 9
1 4 6 7 8
0 1 4 6 7 

Sample Output : 
1 

Explanation: 
A matrix is "Toepliz" if each descending diagonal from left to right is constant. */
        static void Main(String[] args)
        {
            int output;
            int ip1_rows = 0;
            int ip1_cols = 0;
            ip1_rows = Convert.ToInt32(Console.ReadLine());
            ip1_cols = Convert.ToInt32(Console.ReadLine());
            int[][] ip1 = new int[ip1_rows][];
            for (int ip1_i = 0; ip1_i < ip1_rows; ip1_i++)
            {
                string[] ip1_temp = Console.ReadLine().Split(' ');
                ip1[ip1_i] = Array.ConvertAll(ip1_temp, Int32.Parse);

            }
            output = toeplizMatrix(ip1);
            //test(ip1);
            Console.WriteLine(output);
        }
        static bool test(int[][] input1)
        {
            int z = input1[0].Length;
            bool flag = false;
            for (int i = 0; i < input1.Length; i++)
            {
                if (z==input1[i].Length)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        static int toeplizMatrix(int[][] input1)
        {
            int output = 0;
            int a = input1.Length;
            int b = input1[0].Length;
            int z = a;
            if (test(input1)==false)
            {
                return output = -1;
            }
            if (a==1||b==1)
            {
                return output = -1;
            }
            if (a>b)
            {
                z = b;
            }
            else
            {
                z = a;
            }
            for (int i = 0; i < z; i++)//forcommon diagonal[0,0][1,1]......
            {
                int temp = input1[0][0];
                if (temp == input1[i][i])
                {
                    if (output != -1)
                    {
                        output = 1;
                    }
                }
                else
                {
                    output = -1;
                }
            }
            if (output!=-1)
            {
                for (int i = 1; i < a; i++)//for lower triangle
                {
                    int l = 0;
                    for (int j = i; j < a; j++)
                    {
                        int temp = input1[i][0];
                        if (temp == input1[j][l])
                        {
                            if (output == 0 || output == 1)
                            {
                                output = 1;
                            }
                        }
                        else
                        {

                            output = -1;
                            break;
                        }
                        l++;
                    }                    
                }
                if (output!=-1)
                {
                    for (int i = 1; i < b; i++)//for upper trinagle
                    {
                        int k = 0;
                        for (int j = i; j < b; j++)
                        {
                            int temp = input1[0][i];
                            if (temp==input1[k][j])
                            {
                                if (output!=-1)
                                {
                                    output = 1;
                                }
                            }
                            else
                            {
                                output = -1;
                            }
                            k++;
                        }
                    }
                }
            }            
            return output;
        }
        
    }
}
