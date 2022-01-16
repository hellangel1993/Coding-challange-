using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    internal class Microsoft_online_test
    {
        static void Main(string[] args)
        {
            Microsoft_online_test l=new Microsoft_online_test();

            //l.solution(new int[] { 1,2,3 });
            //int a=l.solution("babaa");
            l.StrStr("mississippi", "issip");
        }

        public int StrStr(string haystack, string needle)
        {
            if (needle == "")
            {
                return 0;
            }
            if (haystack.Length < needle.Length)
            {
                return -1;
            }
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0])
                {
                    if (needle.Length == 1)
                    {
                        return i;
                    }
                    else
                    {
                        int temp = i;
                        bool flag = false;
                        i++;
                        for (int j = 1; j < needle.Length; j++, i++)
                        {
                            if (haystack[i] == needle[j])
                            {
                                flag = true;
                            }
                            else
                            {
                                flag = false;
                                break;
                            }
                        }
                        if (flag)
                        {
                            return temp;
                        }
                    }
                }
            }

            return -1;
        }

        public int solution(string S)
        {
            List<int> list=new List<int>();
            int high = 0;
            for (int i = 0; i < S.Length; i++)
            {
                int count = seq(S, i + 1, S[i]);
                list.Add(count);
                i += count;
                if (high<count)
                {
                    high = count;
                }
            }

            int res = 0;
            foreach (int i in list)
            {
                res += high - i;
            }
            return res;
        }

        public int seq(string s,int pos, char x)
        {
            int count = 0;
            for (int i = pos; i < s.Length; i++)
            {
                if (s[pos] == x)
                {
                    count++;
                }
                else
                {
                    return count;
                }
            }
            return count;
        }

        public int Find(string S, int N, String T, int M, int[,] vs)
        {
            if (N==0||M==0)
            {
                return 0;
            }

            if (vs[N,M]!=0)
            {
                return vs[N, M];
            }

            if (S[N-1]==T[M-1])
            {
                return vs[N, M] = 1 + Find(S, N - 1, T, M - 1, vs);
            }

            return vs[N, M] = Math.Max(Find(S, N - 1, T, M, vs), Find(S, N, T, M - 1, vs));
        }

        public int solution1(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            int res = 1;

            //Array.Sort(A);

            bool[] vs = new bool[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i]>0)
                {
                    vs[A[i]-1] = true;
                }
            }

            for (int i = 0; i < vs.Length; i++)
            {
                if (vs[i]==false)
                {
                    return res = i + 1;
                }
            }

            return res=A[A.Length-1]+1;
        }
    }
}
