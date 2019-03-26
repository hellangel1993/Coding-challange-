using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{/*English Alphabets (100 Marks)
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
    class Geek1
    {
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
           // Console.WriteLine(ip1.Length);
            //for (int i = 0; i < ip1_rows; i++)
            //{
            //    for (int j = 0; j < ip1_rows; j++)
            //    {
            //        Console.Write(ip1[i][j]);
            //    }
            //}
            output = word_count(ip1, ip2);
            Console.WriteLine(output);
        }

        static public int word_count(string[][] vs, string str)
        {
            int count = 0;
            //for horizontal search
            for (int i = 0; i < vs.Length; i++)
            {
                int a1 = 0;
                for (int j = 0; j < vs.Length; j++)
                {
                    int a = 0;
                    if (vs[i][j]==str[a++].ToString()&&a<str.Length)
                    {
                        a1 = 1;
                        for (int k = j+1; k < vs.Length; k++)
                        {
                            if (vs[i][k]==str[a].ToString()&& a < str.Length)
                            {
                                a1++;
                                a++;
                                if (a1 == str.Length)
                                {
                                    count++;
                                    a = 0;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                    }                    
                }
                //if (a1 == str.Length )
                //{
                //    count++;
                //}
            }
            //for vertical
            for (int i = 0; i < vs.Length; i++)
            {
                int b1 = 0;
                for (int j = 0; j < vs.Length; j++)
                {
                    int b = 0;
                    if (vs[j][i]==str[b++].ToString()&&b<str.Length)
                    {
                        b1 = 1;
                        for (int k = i+1; k < vs.Length; k++)
                        {
                            if (vs[j][k]==str[b].ToString()&&b<str.Length)
                            {
                                b1++;
                                b++;
                                if (b1==str.Length)
                                {
                                    count++;
                                    b = 0;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
                //if (b1==str.Length)
                //{
                //    count++;
                //}
            }
            if ((vs.Length)%2==0)//start of diagonal
            {
               
                for (int i = 0; i < vs.Length; i++)
                {
                    int b = 0, b1 = 1;
                    //from left to right from top to bottom
                    if (vs[i][i] == str[b++].ToString() && b < str.Length)
                    {
                        for (int j = i + 1; j < vs.Length; j++)
                        {
                            if (vs[j][j] == str[b].ToString())
                            {
                                b1++;
                                b++;
                                if (b1 == str.Length)
                                {
                                    count++;
                                    b = 0;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
                //for left to right from botton to up.                    
                //int f = vs.Length - 1;
                int k = 0;
                for (int i = vs.Length-1; i >=0 ; i--)
                {
                    int c = 0, c1 = 1;
                    while (k<vs.Length)
                    {
                        if (vs[i][k]==str[c].ToString()&&c<str.Length)
                        {
                            c++;
                            int z = k;
                            for (int j = i+1; j >=0 ; j--)
                            {
                                while (j<vs.Length)
                                {
                                    if (vs[j][k]==str[c].ToString())
                                    {
                                        c++;
                                        c1++;
                                        if (c1==str.Length)
                                        {
                                            count++;
                                            c = 0;
                                        }
                                    }
                                    else
                                    {
                                        break;
                                    }
                                    j++;
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                        k++;
                    }
                }
                /*for (int i = vs.Length - 1; i >=0 ; i--)
                {
                    
                    for (int j = 0; j < vs.Length; j++)
                    {
                        
                        if (j == (vs.Length - 1) - i)
                        {
                            if (vs[i][j]==str[c].ToString()&&c<str.Length)
                            {
                                c1++;
                                if (c<=str.Length-1)
                                {
                                    c++;
                                }
                                else
                                {
                                    c = 0;
                                }
                            }
                            else
                            {
                                c = 0;
                            }
                        }
                    }
                    if (c1==str.Length)
                    {
                        count++;
                        c1 = 0;
                    }
                }*/
                //for right to left up to down
                /*int d = 0, d1 = 0;
                for (int i = 0; i < vs.Length; i++)
                {
                    for (int j = vs.Length-1; j >=0; j--)
                    {
                        if (j==(vs.Length-1)-i)
                        {
                            if (vs[i][j]==str[d].ToString())
                            {
                                d1++;
                                if (d<str.Length-1)
                                {
                                    d++;
                                }
                                else
                                {
                                    d = 0;
                                }
                            }
                            else
                            {
                                d = 0;
                            }
                        }
                    }
                    if (d1==str.Length)
                    {
                        count++;
                        d1 = 0;
                    }
                }
                //for right to left bottom to up
                for (int i = f; i >=0; i--)
                {
                    int e = 0, e1 = 1;
                    if (vs[i][i]==str[e++].ToString()&&e<str.Length)
                    {
                        for (int j = i-1; j >=0; j--)
                        {
                            if (vs[j][j]==str[e].ToString())
                            {
                                e1++;
                                e++;
                                if (e1==str.Length)
                                {
                                    count++;
                                    e = 0;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }*/
            }
            return count;
        }
    }
}
