using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    /*PROBLEM STATEMENT
Points: 10
Janardhan bhaiya has intense crush on N girls :p but he is bored as he develops feelings for new girl on each day. So he wants to find perfect girl before searching perfect girl he wants to know the common characteristics between all of his N crushes. 
You are given N rows first element of ith row ( ai ) represents number of characteristics ith crush possess. Next ai integers represents the characteristics id.
You have to print the characteristics id which are present in all of the crushes in ascending order.
Note: characteristics id in row may or may not be distinct.
Input:
First line of input is N.
Next each N lines will contain first integer ai and followed by ai space separated integers each representing characteristics id. 
Output:
Print the common characteristics id in all of the rows in ascending order if non of the id's are common then print -1. 
Constraints:
1 <= N <= 103
1 <= characterstic id <= 103
1 <= sum of all ai <= 106
SAMPLE INPUT
  

3
5 2 2 4 2 1
5 1 2 3 2 1
5 3 2 3 2 1
output 
1 2*/
    class hackercode23
    {
        static void Main(String[] args)
        {
        //    int a = Convert.ToInt32(Console.ReadLine());
        //    IList<int>[][] vs = new IList<int>[a][];
        //    for (int i = 0; i < a; i++)
        //    {
        //        string str = Console.ReadLine();
        //        for (int j = 1; j < str.Length; j++)
        //        {
        //            if (Opertion1(vs,Convert.ToInt32(str[j].ToString(),i)))
        //            {

        //            }
        //        }
        //    }

        //}
        //static IList<int>[] Operation(int[][] vs)
        //{
        //    IList<int>[] vs1 = new IList<int>[1];
        //    for
        //    return vs1;
        //}
        //static bool Opertion1(IList<int>[][] vs,int a,int index)
        //{
        //    Boolean flag = false;
        //    for (int i = 0; i < vs[index].Length; i++)
        //    {
        //        int b = Convert.ToInt32(vs[index][i]);
        //        if (b==a)
        //        {

        //        }
        //    }
        //    return flag;
        }
    }
}
