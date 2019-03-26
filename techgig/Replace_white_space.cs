using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class Replace_white_space
    {
        static void Main(String[] args)
        {
            /*Replacing White Space Characters (100 Marks)
Given a sentence with multiple spaces between words and also spaces in front and back of sentence and you need to remove these extra spaces. 

Input Format
You will be taking a string as an input from stdin.

Constraints
1 <= |S| <= 10^5

Output Format
You need to print the sentence by removing spaces in front and back of sentence.

Sample TestCase 1
Input
     This is Taj     Mahal
Output
This is Taj Mahal*/
            string str = Console.ReadLine();
            int c = 0;
            for(int i=0;i<str.Length;i++)
            {
                if (Convert.ToInt32(str[i]) != 32 && c == 0)//for first alpabate
                {
                    if (i + 1 != str.Length)
                    {
                        if (Convert.ToInt32(str[i + 1]) == 32)
                        {
                            Console.Write(str[i] + " ");
                        }
                        else
                        {
                            Console.Write(str[i]);
                        }
                    }
                    c++;
                }
                else if (Convert.ToInt32(str[i]) != 32 && Convert.ToInt32(str[i - 1]) == 32)//first alp in the middle of the string
                {
                    if (Convert.ToInt32(str[i+1])==32)//this is for the word with one alp.
                    {
                        Console.Write(str[i]+" ");
                    }
                    else
                    {
                        Console.Write(str[i]);
                    }
                }              
                else if (i+1!=str.Length)//this is for checking if the word in the last in the string
                {
                    if (Convert.ToInt32(str[i]) != 32 && Convert.ToInt32(str[i + 1]) != 32)//to print the last alp of the word if it is last in the string
                    {
                        Console.Write(str[i]);
                    }
                    else if (Convert.ToInt32(str[i]) != 32 && Convert.ToInt32(str[i + 1]) == 32)//to print the middle alp of the words
                    {
                        Console.Write(str[i]);
                        Console.Write(" ");
                    }                                        
                }
                else if (i + 1 == str.Length&&Convert.ToInt32(str[i])!=32)
                {
                    Console.Write(str[i]);
                }
            }
        }
    }
}
