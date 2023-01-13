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
            //l.StrStr("mississippi", "issip");
            //l.Multiply("123", "456");
            //l.AddBinary("11", "1");
            //l.solve("       fwbpudnbrozzifml osdt ulc jsx kxorifrhubk ouhsuhf sswz qfho dqmy sn myq igjgip iwfcqq                 ");
            //l.GetRow(30);
            //l.Merge(new int[][] {  new int[] { 1, 4 }, new int[] { 0, 1 }, new int[] { 0, 2 }, new int[] { 0, 0 } });
            //l.Merge(new int[][] { new int[] { 1, 4 }, new int[] { 0, 5 } });
            //l.MinAddToMakeValid("())");
            //l.RemoveDuplicates(new int[] { 1,2,3});
            l.MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });
        }

        #region Leetcode 11
        public int MaxArea(int[] height)
        {
            int result = 0;
            int l = 0, r = height.Length - 1;

            while (l < r)
            {
                int temp = ((r - l) * ((height[l] <= height[r]) ? (height[l]) : (height[r])));
                if (result < temp)
                {
                    result = temp;
                }

                if (height[l] < height[r])
                {
                    l++;
                }
                else
                {
                    r++;
                }
            }

            return result;
        }
        #endregion

        #region Leetcode 26
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            if (nums.Length == 1)
            {
                return 1;
            }
            if (nums.Length == 2)
            {
                if (nums[0] != nums[1])
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }

            int fixPoint = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[fixPoint] != nums[i])
                {
                    if (i != fixPoint + 1)
                    {
                        int temp = nums[i];
                        nums[i] = nums[fixPoint + 1];
                        nums[fixPoint + 1] = temp;
                        fixPoint++;
                    }
                    else if (nums[fixPoint] < nums[i])
                    {
                        fixPoint++;
                    }
                }
            }

            return fixPoint + 1;


        }
        #endregion

        #region Leetcode 921

        public class Collect
        {
            List<char> vs;

            public Collect()
            {
                vs = new List<char>();
            }

            public void Add(char a)
            {
                if (a == ')'&&vs.Count>0 && vs[vs.Count - 1] == '(')
                {
                    vs.RemoveAt(vs.Count - 1);
                }
                else
                {
                    vs.Add(a);
                }
            }

            public int Result()
            {
                return vs.Count;
            }
        }
        public int MinAddToMakeValid(string s)
        {
            if (s.Length == 1)
            {
                return 1;
            }
            else
            {
                Collect res = new Collect();
                for (int i = 0; i < s.Length; i++)
                {
                    res.Add(s[i]);
                }
                return res.Result();
            }
        }
        #endregion

        #region leetcode 56

        public int[][] Merge(int[][] intervals)
        {
            if (intervals.Length == 1)
            {
                return intervals;
            }

            Array.Sort(intervals, (arr1, arr2) => ((arr1[0]).CompareTo(arr2[0])));

            List<int[]> res = new List<int[]>();

            int start = intervals[0][0];
            int end = intervals[0][1];
            for (int i = 1; i < intervals.Length; i++)
            {
                int tempStart = intervals[i][0];
                int tempEnd = intervals[i][1];

                if (end >= tempStart && end <= tempEnd && start <= tempStart)//1,3 2,6->1,6 ||1,3 3,6->1,6 ||1,6 2,6->1,6
                {
                    end = tempEnd;
                }
                else if (end < tempStart)
                {
                    res.Add(new int[] { start, end });
                    start = tempStart;
                    end = tempEnd;
                }

                if (i == (intervals.Length - 1))
                {
                    res.Add(new int[] { start, end });
                }
            }


            return res.ToArray();
        }

        #endregion

        #region Leetcode 119
        public IList<long> GetRow(int rowIndex)
        {
            List<long> nums = new List<long>(rowIndex);
            nums.Add(1);
            if (rowIndex == 0)
            {
                return nums;
            }
            if (rowIndex == 1)
            {
                nums.Add(1);
                return nums;
            }

            long lastValue = 1;
            for (int i = 0; i < rowIndex; i++)
            {
                long temp1 = (rowIndex - i);
                long temp2 = (lastValue * temp1);
                int temp = (int)(temp2 / (i + 1));
                nums.Add(temp);
                lastValue = temp;
            }

            return nums;
        }
        #endregion


        public string solve(string A)
        {

            string[] vs = A.Trim().Split(' ');

            string res = "";

            for (int i = vs.Length - 1; i >= 0; i--)
            {
                if (vs[i] != "")
                {
                    res += vs[i];
                    if (i != 0)
                    {
                        res += " ";
                    }
                }
            }

            return res;
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

        public string Multiply(string num1, string num2)
        {
            int[] res = new int[(num1.Length + num2.Length)];

            string top = "", bottom = "";
            for (int i = num1.Length - 1; i >= 0; i--)
                top += num1[i];
            for (int i = num2.Length - 1; i >= 0; i--)
                bottom += num2[i];
            for (int i = 0; i < top.Length; i++)
            {
                int a = ((int)top[i] - 48);
                for (int j = 0; j < bottom.Length; j++)
                {
                    int b = ((int)bottom[j] - 48);
                    int c = (a * b)+res[(i+j)];
                    res[(i + j)] = c % 10;
                    res[(i + j) + 1] += c / 10;
                }
            }

            string num = "";
            bool flag = true;
            for (int i = res.Length - 1; i >= 0; i--)
            {
                if (flag)
                {
                    if (res[i] == 0)
                    {

                    }
                    else
                    {
                        flag = false;
                        num += res[i].ToString();
                    }
                }
                else
                {
                    num += res[i].ToString();
                }
            }
            return num;
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

        public string AddBinary(string a, string b)
        {
            string res = "";
            int length = 1;

            bool carry = false;
            int aLength = a.Length;
            int bLength = b.Length;
            string temp = "";

            while (aLength >= 0 || bLength >= 0)
            {
                if (aLength > 0 && bLength > 0)
                {
                    if (a[aLength - 1] == '1' && b[bLength - 1] == '1')
                    {
                        if (carry)
                        {
                            res += "1";
                            carry = true;
                        }
                        else
                        {
                            res += "0";
                        }
                        carry = true;
                    }
                    else if (a[aLength - 1] == '0' && b[bLength - 1] == '0')
                    {
                        if (carry)
                        {
                            res += "1";
                            carry = false;
                        }
                        else
                        {
                            res += "0";
                        }
                    }
                    else
                    {
                        if (carry)
                        {
                            res += "0";
                            carry = true;
                        }
                        else
                        {
                            res += "1";
                            carry = false;
                        }
                    }
                }
                else
                {
                    if (aLength > 0)
                    {
                        if (a[aLength - 1] == '1' && carry)
                        {
                            res += "0";
                            carry = true;
                        }
                        else if (a[aLength - 1] == '0' && carry)
                        {
                            res += "1";
                            carry = false;
                        }
                        else if (a[aLength - 1] == '1' && !carry)
                        {
                            res += "1";
                            carry = false;
                        }
                        else if (a[aLength - 1] == '0' && !carry)
                        {
                            res += "0";
                            carry = false;
                        }
                    }
                    else if(bLength > 0)
                    {
                        if (b[bLength - 1] == '1' && carry)
                        {
                            res += "0";
                            carry = true;
                        }
                        else if (b[bLength - 1] == '0' && carry)
                        {
                            res += "1";
                            carry = false;
                        }
                        else if (b[bLength - 1] == '1' && !carry)
                        {
                            res += "1";
                            carry = false;
                        }
                        else if (b[bLength - 1] == '0' && !carry)
                        {
                            res += "0";
                            carry = false;
                        }
                    }
                }

                aLength--;
                bLength--;
            }

            if (carry)
            {
                res += "1";
            }

            for (int i = res.Length - 1; i >= 0; i--)
            {
                temp += res[i].ToString();
            }

            return temp;
        }
    }
}
