using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class leetcode
    {
        static void Main(string[] args)
        {
            //leetcode leetcode= new leetcode();
            //int[][] vs = new int[][] { new int[] { 1, 2 }, new int[] { 5, 1 }, new int[] { 1, 3 }, new int[] { 1, 4 } };
            //Console.WriteLine(leetcode.FindCenter(vs).ToString());

            //question 797
            leetcode leetcode = new leetcode();
            //int[][] vs = new int[][] { new int[] { 4, 3, 1 }, new int[] {, 3, 2, 4 }, new int[] { 3 }, new int[] { 4 }, new int[] { } };

            //int a = leetcode.MinInsertions("zjveiiwvc");
            string s = leetcode.ShiftingLetters("abc", new int[][] { new int[] { 0, 1, 0 }, new int[] { 1, 2, 1 }, new int[] { 0, 2, 1 } });

        }

        #region leetcode2381

        public string ShiftingLetters(string s, int[][] shifts)
        {
            int n = s.Length;
            int[] vs = new int[n+1];
            for(int i = 0; i < shifts.Length; i++)
            {
                if(shifts[i][2] == 0)
                {
                    vs[shifts[i][0]] -= 1;
                    vs[shifts[i][1]+1] += 1;
                }
                else if(shifts[i][2] == 1)
                {
                    vs[shifts[i][0]] += 1;
                    vs[shifts[i][1]+1] -= 1;
                }
            }
            for (int i = 1; i < vs.Length; i++)
            {
                vs[i] += vs[i - 1];
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                char temp = ((char)((((s[i] - 'a' + vs[i])%26)+26)%26+'a'));
                //int sum = s[i] + vs[i];
                //if ('a' > s[i] + vs[i])
                //{
                //    temp = (char)('z' +1+ vs[i]);
                //}
                //else if('a'<=sum && 'z' > sum)
                //{
                //    temp = (char)(s[i] + vs[i]);
                //}


                
                sb.Append(temp);
            }

            return sb.ToString();
        }
        
        #endregion

        #region leetcode1312
        public int MinInsertions(string s)
        {
            string rev = "";

            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev += s[i].ToString();
            }

            string temp = s;
            int maxLength = s.Length * 2;
            for (int i = 0; i < s.Length; i++)
            {
                int count = 0;
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (rev[i] == rev[j])
                    {
                        count++;
                    }
                }
                if (count > 0)
                {
                    maxLength -= 2;
                }
                else if (count == 0)
                {
                    maxLength -= 1;
                    break;
                }
            }

            return (maxLength - s.Length);
        }
        #endregion

        //#region 797 
        //public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        //{
        //    int s = 0;
        //    int f = graph.Length;
        //    for (int i = 0; i < graph[0].Length; i++)
        //    {
        //        List<IList<int>> res = new List<IList<int>>();
        //        List<int> res2=
        //            //Path(graph, graph[0][i], f);
        //    }
        //}

        //private List<IList<int>> Path(int[][] graph, int station, int f,List<int> path)
        //{
        //    if (station == f)
        //    {
        //        path.a
        //    }
        //}
        //#endregion



        //public int FindCenter(int[][] edges)
        //{

        //    for (int i = 0; i < edges.Length; i++)
        //    {
        //        if (i == 0)
        //        {
        //            C1 = edges[i][0];
        //            C2 = edges[i][1];
        //        }
        //        else
        //        {
        //            if (edges[i][0] == C1)
        //            {
        //                C1 = edges[i][0];
        //            }
        //            else if (edges[i][0] == C2)
        //            {
        //                C2 = edges[i][0];
        //            }
        //            else if (edges[i][1] == C1)
        //            {
        //                C1 = edges[i][1];
        //            }
        //            else if (edges[i][1] == C2)
        //            {
        //                C1 = edges[i][1];
        //            }
        //        }
        //    }
        //    if (countC1 == (edges.Length))
        //    {
        //        return C1;
        //    }
        //    else if (countC2 == (edges.Length))
        //    {
        //        return C2;
        //    }
        //    return -1;
        //}

        //int _c1;
        //int countC1 = 0;
        //public int C1
        //{
        //    get
        //    {
        //        return _c1;
        //    }
        //    set
        //    {
        //        _c1 = value;
        //        countC1++;
        //    }
        //}
        //int _c2;
        //int countC2 = 0;
        //public int C2
        //{
        //    get
        //    {
        //        return _c2;
        //    }
        //    set
        //    {
        //        _c2 = value;
        //        countC2++;
        //    }
        //}
    }
}
