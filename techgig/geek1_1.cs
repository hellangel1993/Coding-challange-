using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class geek1_1
    {
        /*English Alphabets (100 Marks)
Given a square matrix of alphabets which contain English letters in arbitrary manner. While searching a word in it, you can go left to right horizontally, vertically downwards or diagonally towards left (both upwards and downwards).
 
You have to find the number of matches of a given word in the matrix.

For example, In the given square matrix {A#A#K,A#S#K,A#K#K},
                                                            
                                                                                                                                             
The word "ASK"  is matched four times in the input matrix. So the output will be 4.

Input Format
You will be given a function which contains two dimensional string array and a string(Word to be searched) as arguments.

Output Format
You need to return the Number of occurrences of the word in the matrix {an integer}.


Sample Test Case1
Sample Input
2
2
A S
S T
AS

Sample Output
2

Sample Test Case 2
Sample Input
5
5
E D E E E
D I S K E
E S E E E
E C E E E
E E E E E
DISK

Sample Output
1

Explanation: 
In this example, "DISK"  is matched only one time in the input matrix. So the output will be 1.*/
        static void Main(String[] args)
        {
            int output;
            int ip1_rows = 0;
            //int ip1_cols = 0;
            ip1_rows = Convert.ToInt32(Console.ReadLine());
            //ip1_cols = Convert.ToInt32(Console.ReadLine());
            string[][] ip1 = new string[ip1_rows][];
            for (int ip1_i = 0; ip1_i < ip1_rows; ip1_i++)
            {
                ip1[ip1_i] = Console.ReadLine().Split(' ');

            }
            string ip2;
            ip2 = Console.ReadLine();
            
            output = word_count(ip1, ip2);
            Console.WriteLine(output);
        }
        static public int word_count(string[][] vs, string str)
        {
            int count = 0;
            //for horizotal
            //for (int i = 0; i < vs.Length; i++)
            //    {
            //        int a = 0;
            //        for (int j = 0; j < vs.Length; j++)
            //        {
            //            if (Operations(i, j, vs, str, a) == true)
            //            {
            //                if (a == str.Length - 1)
            //                {
            //                    count++;
            //                    a = 0;
            //                }
            //                else
            //                {
            //                    a++;
            //                }
            //            }
            //            else
            //            {
            //                a = 0;
            //            }
            //        }
            //    }

            //for vertical
            //for (int i = 0; i < vs.Length; i++)
            //{
            //    int a = 0;
            //    for (int j = 0; j < vs.Length; j++)
            //    {
            //        if (Operations(j,i,vs,str,a)==true)
            //        {
            //            if (a==str.Length-1)
            //            {
            //                count++;
            //                a = 0;
            //            }
            //            else
            //            {
            //                a++;
            //            }
            //        }
            //        else
            //        {
            //            a = 0;
            //        }
            //    }
            //}

            //for diagonal

            
                int b = 0;
                for (int i = vs.Length-1; i >= 0; i++)
                {
                    if (Operations(i,i,vs,str,b))
                    {
                        if (b==str.Length-1)
                        {
                            count++;
                            b = 0;
                        }
                        else
                        {
                            b++;
                        }
                    }
                    else
                    {
                        b = 0;
                    }
                }
                int c = 0;
                for (int i = vs.Length-1,j=0; i >=0 ; i--,j++)
                {
                    if (Operations(j,i,vs,str,c))
                    {
                        if (c==str.Length-1)
                        {
                            count++;
                            c = 0;
                        }
                        else
                        {
                            c++;
                        }
                    }
                    else
                    {
                        c = 0;
                    }
                }
            
            return count;
        }
        static public bool Operations(int row,int col,string[][] vs,string str,int point)
        {
            bool flag=false;
            if (vs[row][col]==str[point].ToString())
            {
                flag = true;
            }           
            return flag;
        }
    }
}
