using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    internal class Leetcode_18
    {
        static void Main(string[] args)
        {
            Leetcode_18 l = new Leetcode_18();
            //l.FourSum(new int[] { -3,-1,0,2,4,5 }, 0);
            //l.TwoSum(new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 }, 11);
            //l.FindMedianSortedArrays(new int[] {1,3},new int[] {2});
            //l.Search(new int[] { 1, 3 }, 3);
            //l.MyPow( 2.00000,- 21);
            //l.solve(new List<int> { -1,0,0,0,3 });
            //l.prefix(new List<string> { "zebra", "dog", "duck", "dove" });
            //l.LargestRectangleArea(new int[] { 2, 1, 5, 6, 2, 3 });
            //l.MaximalRectangle(new char[][] { new char[] { '1', '0', '1', '0', '0' }, new char[] { '1', '0', '1', '1', '1' }, new char[] { '1', '1', '1', '1', '1' }, new char[] { '1', '0', '0', '1', '0' } });
            //l.NumDistinct("rabbbit", "rabbit");
            //l.WordBreak("catsanddog", new List<string> { "cat", "cats", "and", "sand", "dog" });
            //l.IsMatch("aa", "a*");
            l.RemoveNthFromEnd(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, null))))), 2);
        }

        //public List<int> solve(List<int> A)
        //{
        //    List<int> xxx = new List<int>();
        //    int a = A.Count;
        //    for (int i = 0; i < a; i++)
        //    {
        //        int count = 0;
        //        for (int j = 0; j < a; j++)
        //        {
        //            if (A[i] == A[j])
        //            { count++; }
        //        }
        //        xxx.Add(count);
        //    }
        //    return xxx;
        //}

        #region Leetcode 19
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode temp = new ListNode(0, head);
            ListNode slow = temp;
            ListNode fast = head;
            while (n > 0 && fast != null)
            {
                fast = fast.next;
                n--;
            }

            while (fast != null)
            {
                fast = fast.next;
                slow = slow.next;
            }
            slow.next = fast;
            return temp.next;
        }
        #endregion

        #region Leetcode 10
        public bool IsMatch(string s, string p)
        {
            cache = new int[s.Length, p.Length];
            bool flag = travel(0, 0, s, p);
            return flag;
        }
        int[,] cache;
        public bool travel(int sIndex, int pIndex, string s, string p)
        {
            int sLength=s.Length;
            int pLength=p.Length;

            
            if (sIndex>=sLength &&pIndex>=pLength)
            {
                return true;
            }
            if (pIndex>=pLength)
            {
                return false;
            }
            if (sIndex<sLength&&pIndex<pLength&&cache[sIndex, pIndex] != 0)
            {
                return (cache[sIndex, pIndex] == 1) ? true : false;
            }

            bool check = ((sIndex < sLength) && (s[sIndex] == p[pIndex] || p[pIndex] == '.'));
            if (pIndex+1<pLength&&p[pIndex+1]=='*')
            {
                cache[sIndex, pIndex] = ((travel(sIndex, pIndex + 2, s, p) || (check && travel(sIndex + 1, pIndex, s, p))) == true) ? 1 : 2;
                return (cache[sIndex, pIndex] == 1) ? true : false;
                //return (travel(sIndex, pIndex + 2, s, p) || (check && travel(sIndex + 1, pIndex, s, p)));
            }
            if (check)
            {
                cache[sIndex - 1, pIndex - 1] = travel(sIndex + 1, pIndex + 1, s, p) == true ? 1 : 2;
                return (cache[sIndex - 1, pIndex - 1] == 1) ? true : false;
                //return travel(sIndex + 1, pIndex + 1, s, p);
            }
            cache[sIndex-1, pIndex-1] = 2;
            return false;
        }
        #endregion

        #region Leet code 139
        public bool WordBreak(string s, IList<string> wordDict)
        {
            int n = s.Length;
            bool[] dp=new bool[n+1];

            int max = 0;
            foreach (string item in wordDict)
            {
                if (max<item.Length)
                {
                    max = item.Length;
                }
            }

            Dictionary< Tuple<int, int>,string> list = new Dictionary<Tuple<int, int>, string>();
            dp[0] = true;
            for (int i = 0; i <= n; i++)
            {
                for (int j = i-1; j >=0; j--)
                {
                    if (i-j>max)
                    {
                        continue;
                    }

                    string temp=s.Substring(j,i-j);
                    if (dp[j]&& wordDict.Contains(s.Substring(j,(i-j))))
                    {
                        dp[i] = true;
                        list.Add(new Tuple<int, int>(j, i), temp);
                        //break;
                    }
                }
            }

            List<string> res = new List<string>();

            int first = 0;
            
            foreach (var item in list)
            {
                string temp = "";


            }
            return dp[n];
        }

        //private string GetString(Dictionary<Tuple<int, int>, string> list,int index)
        //{
        //    if (list.ContainsKey()
        //    {

        //    }
        //}
        
        #endregion

        #region leetcode 115
        public int NumDistinct(string s, string t)
        {
            int sSize = s.Length;
            int tSize = t.Length;
            int count = Combination(s, 0, t, 0);
            return count;
        }

        public int Combination(string s, int sIndex, string t, int tIndex)
        {
            int count = 0;
            if (tIndex==t.Length)
            {
                return 1;
            }
            if(sIndex==s.Length)
            {
                return 0;
            }

            char c = s[sIndex];
            char d = t[tIndex];

            if (s[sIndex] == t[tIndex])
            {
                count += Combination(s, (sIndex + 1), t, tIndex);
                _ = Combination(s, (sIndex + 1), t, (tIndex + 1));
            }
            else
            {
                count+=Combination(s, (sIndex + 1), t, tIndex);
            }

            return count;
        }
        #endregion

        #region Leetcode 85
        public int MaximalRectangle(char[][] matrix)
        {
            int n = matrix.Length;

            if (n==0)
            {
                return 0;
            }
            int maxArea = 0;
            int size = matrix[0].Length;
            int[] vs = new int[size];
            for (int k = 0; k < n; k++)
            {
                char[] tempMatrix = matrix[k];
                
                for (int j = 0; j < size; j++)
                {
                    if (tempMatrix[j]=='1')
                    {
                        vs[j] += 1;
                    }
                    else
                    {
                        vs[j] = 0;
                    }
                }


                Stack<int> stack = new Stack<int>();
                int[] left = new int[size];
                for (int i = 0; i < size; i++)
                {
                    if (stack.Count == 0)
                    {
                        left[i] = 0;
                        stack.Push(i);
                    }
                    else
                    {
                        while (stack.Count != 0 && vs[stack.Peek()] >= vs[i])
                        {
                            stack.Pop();
                        }
                        left[i] = (stack.Count == 0) ? 0 : stack.Peek() + 1;
                        stack.Push(i);
                    }
                }

                stack.Clear();

                int[] right = new int[size];
                for (int i = size - 1; i >= 0; i--)
                {
                    if (stack.Count == 0)
                    {
                        right[i] = size - 1;
                        stack.Push(i);
                    }
                    else
                    {
                        while (stack.Count != 0 && vs[stack.Peek()] >= vs[i])
                        {
                            stack.Pop();
                        }
                        right[i] = (stack.Count == 0) ? size - 1 : stack.Peek() - 1;
                        stack.Push(i);
                    }
                }

                for (int j = 0; j < size; j++)
                {
                    int temp = vs[j] * (right[j] - left[j] + 1);
                    maxArea = (maxArea < temp) ? temp : maxArea;
                }
            }

            return maxArea;
        }
        #endregion

        #region leetcode 84
        public int LargestRectangleArea(int[] heights)
        {
            int n = heights.Length;
            Stack<int> stack = new Stack<int>();
            int[] left = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (stack.Count == 0)
                {
                    left[i] = 0;
                    stack.Push(i);
                }
                else
                {
                    while (stack.Count != 0 && heights[stack.Peek()] >= heights[i])
                    {
                        stack.Pop();
                    }
                    left[i] = (stack.Count == 0) ? 0 : stack.Peek() + 1;
                    stack.Push(i);
                }
            }

            stack.Clear();

            int[] right=new int[n];
            for (int i = n-1; i >=0; i--)
            {
                if (stack.Count==0)
                {
                    right[i] = n-1;
                    stack.Push(i);
                }
                else
                {
                    while (stack.Count!=0&& heights[stack.Peek()]>=heights[i])
                    {
                        stack.Pop();
                    }
                    right[i]= (stack.Count == 0) ? n-1 : stack.Peek() - 1;
                    stack.Push(i);
                }
            }

            int res = 0;
            for (int i = 0; i < n; i++)
            {
                int temp = heights[i] * (right[i] - left[i] + 1);
                if (temp > res)
                    res = temp;
            }


            return res;
        }
        #endregion

        #region Interview bit Shortest Unique Prefix

        public List<string> prefix(List<string> A)
        {
            int n=A.Count;
            List<string> res=new List<string>();

            Node root=new Node();
            foreach (string s in A)
            {
                Add(root, s, 0);
            }

            foreach (string s in A)
            {
                int temp = Find(root, s, 0);
                string str = "";
                for (int i = 0; i < temp+1; i++)
                {
                    str += s[i];
                }

                res.Add(str);
            }

            return res;
        }

        public void Add(Node root, string s, int index)
        {
            if (index == s.Length)
            {
                return;
            }

            if (!(root.ar.ContainsKey(s[index])))
            {
                root.ar.Add(s[index], new Node());
            }

            root.ar[s[index]].freq++;
            Add(root.ar[s[index]], s, ++index);
        }

        public int Find(Node root, string s, int index)
        {
            if (root.ar[s[index]].freq == 1)
            {
                return index;
            }

            if (root.ar.ContainsKey(s[index]))
            {
                return Find(root.ar[s[index]], s, ++index);
            }

            return -1;
        }
        public class Node
        {
            public int freq = 0;
            public Dictionary<char,Node> ar = new Dictionary<char, Node>();
        }
        #endregion

        #region Longest distance between two node
        public int solve(List<int> A)
        {
            Dictionary<int, List<int>> B = new Dictionary<int, List<int>>();

            for (int i = 0; i < A.Count; i++)
            {
                if (A[i]==-1)
                {
                    continue;
                }
                if (B.ContainsKey(A[i]))
                {
                    B[A[i]].Add(i);
                }
                else
                {
                    B.Add(A[i], new List<int> { i});
                }
            }

            return B.Count;
        }
        
        int point1=0, point2=0;

        public int Diamter(Dictionary<int,List<int>> keyValuePairs,int parent)
        {
            for (int i = 0; i < keyValuePairs[parent].Count; i++)
            {

            }
            return 0;
        }
        #endregion


        #region Leetcode 50
        public double MyPow(double x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n == 1)
            {
                return x;
            }
            double _x = 0;
            bool carry = false;
            if (n < 0)
            {
                _x = 1 / x;
                if (n==int.MinValue)
                {
                    carry = true;
                    n += 1;
                }
                n = n * (-1);
            }
            else
            {
                _x = x;
            }
            double res = 1;
            for (int i = 0; i < n / 2; i++)
            {
                res =res* _x;
            }
            res *= res;
            if (n % 2 != 0)
            {
                res *= _x;
            }
            if (carry)
            {
                res *= _x;
            }

            return res;
        }
        #endregion

        #region Leetcode 33
        public int Search(int[] nums, int target)
        {
            if (nums.Length == 1)
            {
                if (nums[0] == target)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                int left = 0;
                int right = nums.Length - 1;
                while (left < right)
                {
                    int point = (int)(left + right) / 2;
                    if (target == nums[point])
                    {
                        return point;
                    }
                    if (nums[point] > nums[right])
                    {
                        left = point + 1;
                    }
                    else
                    {
                        right = point;
                    }
                }
                int start = left;
                left = 0;
                right = nums.Length - 1;
                if (nums[start]<=target &&nums[right]>=target)
                {
                    left = start;
                }
                else
                {
                    right=start;
                }
                while (left<right)
                {
                    int point = (int)(left + right) / 2;
                    if (target == nums[point])
                    {
                        return point;
                    }
                    if (nums[point] < target)
                    {
                        left=point+1;
                    }
                    else if(nums[point]<=target)
                    {
                        right=point-11;
                    }
                }
                return -1;
            }
            }
        #endregion

        #region leetcode 4
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            List<int> vs = new List<int>();
            int m = 0, n = 0;
            int length = (nums1.Length + nums2.Length) - 1;
            if (length % 2 == 0)//even
            {
                m = length / 2;
                return loop(nums1, nums2, m, -1);
            }
            else
            {
                m = length / 2;
                return loop(nums1, nums2, m, (m + 1));
            }
        }


        public double loop(int[] nums1, int[] nums2, int mid1, int mid2)
        {
            double res1 = 0;
            double res2 = 0;

            int n = 0;
            int i = 0, j = 0;
            while (n <= mid2 || n <= mid1)
            {
                if (n == mid1)
                {
                    if (i<nums1.Length&&j<nums2.Length&&nums1[i] < nums2[j])
                    {
                        res1 = (double)nums1[i];
                        i++;
                    }
                    else if(i < nums1.Length && j < nums2.Length && nums2[j] <= nums1[i])
                    {
                        res1 = (double)nums2[j];
                        j++;
                    }
                    else
                    {
                        if (i<nums1.Length&&j>=nums2.Length)
                        {
                            res1 = (double)nums1[i];
                            i++;
                        }
                        else
                        {
                            res1 = (double)nums2[j];
                            j++;
                        }
                    }
                    
                }
                else if (n == mid2)
                {
                    if (i < nums1.Length && j < nums2.Length && nums1[i] < nums2[j])
                    {
                        res2 = (double)nums1[i];
                        i++;
                    }
                    else if (i < nums1.Length && j < nums2.Length && nums2[j] <= nums1[i])
                    {
                        res2 = (double)nums2[j];
                        j++;
                    }
                    else
                    {
                        if (i < nums1.Length && j >= nums2.Length)
                        {
                            res2 = (double)nums1[i];
                            i++;
                        }
                        else
                        {
                            res2 = (double)nums2[j];
                            j++;
                        }
                    }
                }
                else
                {
                    if (i < nums1.Length && j < nums2.Length && nums1[i] < nums2[j])
                    {
                        i++;
                    }
                    else if (i < nums1.Length && j < nums2.Length && nums2[j] <= nums1[i])
                    {
                        j++;
                    }
                    else
                    {
                        if (i < nums1.Length && j >= nums2.Length)
                        {
                            i++;
                        }
                        else
                        {
                            j++;
                        }
                    }
                }
                n++;
            }

            return ((res1 + res2) / 2);
        }
        #endregion


        #region Leetcode 36
        public bool IsValidSudoku(char[][] board)
        {
            Dictionary<int, HashSet<char>> row = new Dictionary<int, HashSet<char>>();
            Dictionary<int, HashSet<char>> col = new Dictionary<int, HashSet<char>>();
            Dictionary<string, HashSet<char>> box = new Dictionary<string, HashSet<char>>();

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if(board[i][j] != '.')
                    {
                        char c = board[i][j];
                        //for row
                        if (row.ContainsKey(i))
                        {
                            if (!row[i].Contains(c))
                            {
                                row[i].Add(c);
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            row.Add(i, new HashSet<char>());
                            row[i].Add(c);
                        }
                        //for column
                        if (col.ContainsKey(j))
                        {
                            if (!col[j].Contains(c))
                            {
                                col[j].Add(c);
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            col.Add(j, new HashSet<char>());
                            col[j].Add(c);
                        }
                        //box
                        string _r = (i / 3).ToString();
                        string _c = (j / 3).ToString();
                        if(box.ContainsKey(_r+_c))
                        {
                            if (!box[_r+_c].Contains(c))
                            {
                                box[_r + _c].Add(c);
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            box.Add(_r+_c, new HashSet<char>());
                            box[_r+_c].Add(c);
                        }
                    }
                }
            }
            return true;
        }
        #endregion

        #region leetcode 1
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> vs = new Dictionary<int, int>();

            Dictionary<int,HashSet<int>> hs = new Dictionary<int, HashSet<int>>();

            if (hs.ContainsKey(0))
            {
                Console.WriteLine();
            }
            int a = hs[0].Count;

            for (int i = 0; i < nums.Length; i++)
            {
                int temp = (target - nums[i]);
                if (vs.ContainsKey(nums[i]))
                {
                    return new int[] { vs[nums[i]], i };
                }
                else
                {
                    if (!vs.ContainsKey(temp))
                    {
                        vs.Add(temp, i);
                    }
                }
            }

            return new int[] { };
        }
        #endregion

        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            IList<IList<int>> res = new List<IList<int>>();
            Dictionary<int, HashSet<Tuple<int, int>>> vs = new Dictionary<int, HashSet<Tuple<int, int>>>();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (vs.ContainsKey(nums[i] + nums[j]))
                    {
                        vs[(nums[i] + nums[j])].Add(new Tuple<int, int>(i,j));
                    }
                    else
                    {
                        vs.Add((nums[i] + nums[j]), new HashSet<Tuple<int, int>>() { new Tuple<int, int>(i, j) });
                    }
                }
            }


            foreach (KeyValuePair<int, HashSet<Tuple<int, int>>> item in vs)
            {
                int find = (target - item.Key);
                if (vs.ContainsKey((target - item.Key)))
                {
                    HashSet<Tuple<int, int>> temp1 = vs[item.Key];
                    HashSet<Tuple<int, int>> temp2 = vs[find];
                    foreach (Tuple<int, int> tuple1 in temp1)
                    {
                        foreach (Tuple<int, int> tuple2 in temp2)
                        {
                            if (tuple1.Item1 != tuple2.Item1 && tuple1.Item1 != tuple2.Item2 && tuple1.Item2 != tuple2.Item1 && tuple1.Item2 != tuple2.Item2)
                            {
                                List<int> vs1 = new List<int>();
                                vs1.Add(nums[tuple1.Item1]);
                                vs1.Add(nums[tuple2.Item1]);
                                vs1.Add(nums[tuple1.Item2]);
                                vs1.Add(nums[tuple2.Item2]);
                                vs1.Sort();
                                bool flag = false;
                                foreach (var item2 in res)
                                {
                                    if (item2[0] == vs1[0] && item2[1] == vs1[1] && item2[2] == vs1[2] && item2[3] == vs1[3])
                                    {
                                        flag = true;
                                        break;
                                    }
                                }
                                if (!flag)
                                    res.Add(vs1);
                            }
                        }
                    }

                }
            }
            return res;
        }
    }
}


