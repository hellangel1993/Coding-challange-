using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    internal class microsoftqnlinetest2
    {

        static void Main(string[] args)
        {
            microsoftqnlinetest2 l=new microsoftqnlinetest2();

            //bool flag=l.solution(4, new int[] { 1, 2, 1,3 }, new int[] { 2, 4, 3, 4 });

            int a = l.sol1(new int[] { 10, 1, 3, 1, 2, 2, 1, 0, 4 });
        }

        public int sol1(int[] A)
        {
            int max = 0;
            for (int i = 0; i < A.Length-1; i++)
            {
                int reqSum = A[i] + A[i + 1];
                int reqSumCount = 1;
                for (int j = 0; j < A.Length-1;)
                {
                    if ((j < i && (j + 1) < i) ||(j>(i+1)))
                    {
                        if ((A[j]+A[j+1])==reqSum)
                        {
                            reqSumCount++;
                            j += 2;
                        }
                        else
                        {
                            j++;
                        }
                    }
                    else
                    {
                        j++;
                    }
                }
                if (max<reqSumCount)
                {
                    max = reqSumCount;
                }
            }
            return max;
        }


        public bool solution(int N, int[] A, int[] B)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            if (A.Length==0)
            {
                return false;
            }

            SortedList<int,List<int>> valuePairs = new SortedList<int, List<int>>();

            for (int i = 0; i < A.Length; i++)
            {
                if (valuePairs.ContainsKey(A[i]))
                {
                    valuePairs[A[i]].Add(B[i]);
                }
                else
                {
                    valuePairs.Add(A[i], new List<int>() { B[i] });
                }
                if (valuePairs.ContainsKey(B[i]))
                {
                    valuePairs[B[i]].Add(A[i]);
                }
                else
                {
                    valuePairs.Add(B[i], new List<int>() { A[i] });
                }
            }

            for (int i = 1; i < N; i++)
            {
                if (valuePairs.ContainsKey(i))
                {
                    List<int> list = valuePairs[i];
                    if (list.Contains(i+1))
                    {

                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
