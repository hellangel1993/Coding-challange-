using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    internal class Scaler
    {
        
        static void Main(string[] args)
        {
            Scaler Scaler = new Scaler();
            //Scaler.solve(new List<int> { 343, 291, 963, 165, 152 });
            //Scaler.solve(5, new List<List<int>> { new List<int> { 1, 2, 10 }, new List<int> { 2, 3, 20 }, new List<int> { 2, 5, 25 } });
            //Scaler.trap(new List<int> { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 });
            //Scaler.plusOne(new List<int> { 1, 2, 3 });
            //Scaler.cal(4, 0, "cool");
            //Scaler.grayCode(2);
            //Scaler.pow(-1, 1, 20);
            //Scaler.paint(4, 10, new List<int> { 884, 228, 442, 889 });
            //Scaler.lengthOfLongestSubstring("dadbc");
            //Scaler.caldecimal(101);
            //Scaler.mergeTwoLists(new ListNode(1, new ListNode(3, new ListNode(5, null))), new ListNode(2, new ListNode(4, new ListNode(6, null))));
            //Scaler.solve("{([])}");
            //Scaler.evalRPN(new List<string> { "-2", "-1", "2", "+", "-1", "-", "-", "2", "-2", "1", "-", "+", "-", "-2", "-2", "-", "-1", "2", "-2", "-", "-2", "-1", "+", "1", "1", "-", "-1", "+", "1", "*", "*", "2", "+", "*", "-", "-2", "1", "-2", "*", "+", "-2", "*", "1", "*", "-", "*", "*" });
            //Scaler.evalRPN(new List<string> { "4", "13", "5", "/", "+" });
            //Scaler.solve4(new List<int> { 66, 96, 43, 28, 14, 1, 41, 76, 70, 81, 22, 11, 42, 78, 4, 88, 70, 43, 90, 6, 12 });
            //Scaler.infixtopostfix("a+b*(c^d-e)^(f+g*h)-i");
            //Scaler.Deletemid(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, null))))));
            //Scaler.sumofarray("100 37 77 70 9 45 78 80 29 60 12 28 74 36 2 30 13 55 94 40 79 95 63 21 89 81 86 96 78 96 7 75 85 36 97 46 82 75 26 11 87 90 92 62 27 46 44 92 2 90 84 81 37 48 55 79 81 93 75 60 41 34 35 78 71 32 24 53 59 50 16 47 93 60 61 72 7 57 16 9 99 1 42 88 1 97 67 82 43 42 42 84 29 29 63 0 61 87 5 73 90 ");
            //BST retr= Scaler.checkBST(new TreeNode(5,new TreeNode(3,new TreeNode(1,null,null),new TreeNode(4,null,null)),new TreeNode(8,new TreeNode(7,null,null),new TreeNode(9,null,null))));
            //int retr = Scaler.checkBST(new TreeNode(20, new TreeNode(14, new TreeNode(11, null, null), null), new TreeNode(12, null, null)));
            //int sol = Scaler.uniquePathsWithObstacles(new List<List<int>> { new List<int> { 0, 0, 0 }, new List<int> { 0, 1, 0 }, new List<int> { 0, 0, 0 } });
            int sol = Scaler.MinimumTotal(new List<List<int>> { new List<int> { 9 }, new List<int> { 3, 8 }, new List<int> { 0, 2, 4 }, new List<int> { 8, 3, 9, 0 }, new List<int> { 5, 2, 2, 7, 3 }, new List<int> { 7, 9, 0, 2, 3, 9 }, new List<int> { 9, 7, 0, 3, 9, 8, 6 }, new List<int> { 5, 7, 6, 2, 7, 0, 3, 9 } });
        }

        #region day 94 ass2
        public int MinimumTotal(List<List<int>> A)
        {
            return Sum(A, 0, 0);
        }
        //Dictionary<string, int> cache = new Dictionary<string, int>();
        public int Sum(List<List<int>> A, int i, int j)
        {
            if (cache.ContainsKey(i + "@" + j))
            {
                return cache[i + "@" + j];
            }
            else
            {
                if (i >= A.Count || j >= A[i].Count)
                {
                    return 1001;
                }
                if (i == A.Count - 1)
                {
                    return A[i][j];
                }

                int f = Sum(A, i + 1, j);
                int s = Sum(A, i + 1, j + 1);
                if (f <= s)
                {
                    cache.Add(i + "@" + j, f);
                }
                else
                {
                    cache.Add(i + "@" + j, s);
                }

                return cache[i + "@" + j] + A[i][j];
            }
        }
        #endregion

        #region day 94 ass1
        public int uniquePathsWithObstacles(List<List<int>> A)
        {
            return Travel(A, 0, 0);
        }

        Dictionary<string, int> cache = new Dictionary<string, int>();
        public int Travel(List<List<int>> A, int i, int j)
        {
            if (cache.ContainsKey(i + "@" + j))
            {
                return cache[i + "@" + j];
            }
            else
            {
                if (i >= A.Count || j >= A[0].Count)
                {
                    return 0;
                }
                if (i == A.Count - 1 && j == A[0].Count - 1)
                {
                    return 1;
                }
                if (A[i][j] == 1)
                {
                    return 0;
                }

                int right=Travel(A, i, j+1);
                int down = Travel(A, i + 1, j);

                cache.Add(i + "@" + j, right+down);

                return right+down;
            }
        }
        #endregion

        #region day 82 ass2
        public class BST
        {
            public int sz;
            public int min;
            public int max;
            public int ans;
            public bool isBst=false;
        }

        public static int isValidBST(TreeNode A)
        {
            if (isValid(A, Int32.MinValue, Int32.MaxValue))
                return 1;
            return 0;
        }
        public static bool isValid(TreeNode A, int l, int r)
        {
            if (A == null)
                return true;
            if (A.val > l && A.val < r)
            {
                bool left = isValid(A.left, l, A.val);
                bool right = isValid(A.right, A.val, r);
                return (left && right);
            }
            else
                return false;
        }
        public static int count(TreeNode A)
        {
            if (A == null)
                return 0;
            return 1 + count(A.left) + count(A.right);

        }

        public static int checkBST(TreeNode A)
        {
            if (isValidBST(A) == 1) return count(A);
            else return Math.Max(checkBST(A.left), checkBST(A.right));
        }
        #endregion

        #region Day 14 ass3
        public int sumofarray(string input)
        {
            string[] vs1=input.Split(' ');
            int count =int.Parse(vs1[0]);
            int res = 0;
            for (int i = 1; i <= count; i++)
            {
                res += int.Parse(vs1[i]);
            }
            return res;
        }
        #endregion

        #region Day 73 ass1
        public ListNode Deletemid(ListNode A)
        {
            if (A.next == null)
            {
                return null;
            }
            else
            {
                ListNode head = A;
                ListNode f = A;
                ListNode s = A;
                ListNode p = A;
                while (f!=null&&f.next!=null)
                {
                    p = s;
                    s = s.next;
                    f = f.next.next;
                }
                p.next = s.next;
                return head;
            }
        }
            #endregion

            #region Day 76 HW2
            public string infixtopostfix(string A)
        {
            return infixToPostfix(A);
        }
        public int prec(char c)
        {
            if (c == '^')
                return 3;
            else if (c == '*' || c == '/')
                return 2;
            else if (c == '+' || c == '-')
                return 1;
            else
                return -1;
        }
        // Function to convert infix expression
        //to postfix expression
        public string infixToPostfix(string s)
        {
            Stack<char> st = new Stack<char>();
            st.Push('N');
            List<char> ns = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                char C = s[i];
                // If the scanned character is an operand, add it to output string.
                if ((C >= 'a' && C <= 'z') || (C >= 'A' && C <= 'Z'))
                    ns.Add(C);
                // If the scanned character is an '(', push it to the stack.
                else if (C == '(')
                    st.Push('(');
                // If the scanned character is an ')', pop and to output string from the stack
                // until an '(' is encountered.
                else if (C == ')')
                {
                    while (st.Peek() != 'N' && st.Peek() != '(')
                    {
                        char c = st.Peek();
                        st.Pop();
                        ns.Add(c);
                    }
                    if (st.Peek() == '(')
                    {
                        char c = st.Peek();
                        st.Pop();
                    }
                }
                //If an operator is scanned
                else
                {
                    while (st.Peek() != 'N' && prec(C) <= prec(st.Peek()))
                    {
                        char c = st.Peek();
                        st.Pop();
                        ns.Add(c);
                    }
                    st.Push(C);
                }
            }
            //Pop all the remaining elements from the stack
            while (st.Peek() != 'N')
            {
                char c = st.Peek();
                st.Pop();
                ns.Add(c);
            }
            StringBuilder result = new StringBuilder();
            foreach (char c in ns)
            {
                result.Append(c);
            }
            return result.ToString();
        }
        #endregion

        #region Day 76 ass4
        public List<int> solve4(List<int> A)
        {
            

            Stack<int> input = new Stack<int>(A);

            Stack<int> res = new Stack<int>();
            //res.Push(input.Pop());
            int check = input.Pop();
            while (res.Count!=A.Count)
            {
                if (res.Count == 0)
                {
                    res.Push(check);
                    check=input.Pop();
                }
                else if(res.Peek() > check)
                {
                    input.Push(res.Pop());
                }
                else if (res.Peek() <= check)
                {
                    res.Push(check);
                    if (input.Count!=0)
                    {
                        check = input.Pop();
                    }
                }
            }
            List<int> result = res.Reverse().ToList();
            return res.Reverse().ToList();
        }
        #endregion

        #region Day 76 ass3
        public int evalRPN(List<string> A)
        {
            Stack<int> res = new Stack<int>();
            int first = -9999, second = -9999;
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] == "+" || A[i] == "-" || A[i] == "*" || A[i] == "/")
                {
                    second=res.Pop();
                    first=res.Pop();
                    switch (A[i])
                    {
                        case "+":
                            res.Push(first+second);
                            break;
                        case "-":
                            res.Push(first - second);
                            break;
                        case "*":
                            res.Push(first * second);
                            break;
                        case "/":
                            res.Push(first / second);
                            break;
                    }
                }
                else
                {
                    res.Push(int.Parse(A[i]));
                }
            }

            return res.Pop();
        }
        #endregion

        #region Day 76 ass2
        public string solveB(string A)
        {
            Stack<char> res = new Stack<char>();
            for (int i = 0; i < A.Length; i++)
            {
                if (res.Count != 0)
                {
                    if (res.Peek() == A[i])
                    {
                        res.Pop();
                    }
                    else
                    {
                        res.Push(A[i]);
                    }
                }
                else
                {
                    res.Push(A[i]);
                }
            }
            string output = "";
            if (res.Count != 0)
            {
                while(res.Count > 0)
                {
                    output+=res.Pop();
                }
            }
            return output;
        }
        #endregion
        #region Day 76 ass1
        public int solve(string A)
        {
            Stack<char> res = new Stack<char>();
            for (int i = 0; i < A.Length; i++)
            {
                if (res.Count != 0)
                {
                    if (A[i] == ']' && res.Peek() == '[')
                    {
                        res.Pop();
                    }
                    else if (A[i] == '}' && res.Peek() == '{')
                    {
                        res.Pop();
                    }
                    else if (A[i] == ')' && res.Peek() == '(')
                    {
                        res.Pop();
                    }
                    else
                    {
                        res.Push(A[i]);
                    }
                }
                else
                {
                    res.Push(A[i]);
                }
            }
            if (res.Count>0)
            {
                return 0;
            }
            return 1;
        }
        #endregion

        #region Day 75 ass1
        public ListNode mergeTwoLists(ListNode A, ListNode B)
        {
            ListNode res = new ListNode(0);
            ListNode temp = res;
            while (A != null && B != null)
            {
                if (A.val <= B.val)
                {
                    temp.next = A;
                    A = A.next;
                }
                else
                {
                    temp.next = B;
                    B = B.next;
                }
                temp=temp.next;
            }
            if (A!=null)
            {
                temp.next = A;
            }
            else { temp.next = B; }

            return res.next;
        }
        #endregion

        #region Day 12 ass1
        public void caldecimal(long n)
        {
            long res = 0;
            int bit = 0;
            while (n != 0)
            {
                long dig = n % 10;
                n = n / 10;
                res = res + (Scaler.pow(bit) * dig);
                bit++;
            }
            Console.WriteLine(res);

        }

        public static long pow(int power)
        {
            long res = 1;
            for (int i = 0; i < power; i++)
            {
                res *= 2;
            }
            return res;
        }
        #endregion

        #region Day 69 ass3
        public int lengthOfLongestSubstring(string A)
        {
            HashSet<char> vs = new HashSet<char>();
            int res = 0;
            int fast = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (vs.Contains(A[i]))
                {
                    res = Math.Max(res, fast);
                    fast = 0;
                }
                else
                {
                    fast++;
                    vs.Add(A[i]);
                }
            }

            return Math.Max(res, fast);
        }
        #endregion

        #region day 66 ass1
        //public int paint(int A, int B, List<int> C)
        //{
        //    int maxSum = 0;
        //    int minTime = C[0];
        //    for (int i = 0; i < C.Count; i++)
        //    {
        //        maxSum += C[i];
        //        if (minTime < C[i])
        //        {
        //            minTime = C[i];
        //        }
        //    }
        //    return test(minTime * B, maxSum * B, C, A, B);
        //}

        //public int test(int low, int high, List<int> C, int A, int B)
        //{
        //    int mod = 10000003;
        //    int ans = 0;
        //    int mid = 0;
        //    while (low <= high)
        //    {
        //        mid = (low + high) / 2;
        //        if (check(mid, C, A, B))
        //        {
        //            high = mid - 1;
        //            ans = mid;
        //        }
        //        else
        //        {
        //            low = mid + 1;
        //            //ans=mid;
        //        }
        //    }
        //    return ans % mod;
        //}

        //public bool check(int work, List<int> C, int A, int B)
        //{
        //    if (work == 0)
        //    {
        //        return false;
        //    }
        //    int job = 0;
        //    for (int i = 0; i < C.Count; i++)
        //    {
        //        job = job + C[i];
        //        if ((job * B) > work)
        //        {
        //            job = C[i];
        //            if ((job * B) > work)
        //            {
        //                return false;
        //            }
        //            A--;
        //        }
        //    }
        //    A--;
        //    if (A < 0)
        //    {
        //        return false;
        //    }
        //    return true;
        //}
        public int mod = 10000003;
        public bool check(long A, long B, List<int> C, long mid)
        {
            long cnt = 1;
            long n = C.Count;
            long tmp = 0;
            for (int i = 0; i < n; ++i)
            {
                if (tmp + C[i] * B > mid)
                {
                    tmp = C[i] * B;
                    cnt++;
                }
                else tmp += C[i] * B;
            }
            if (cnt <= A)
                return true;
            else return false;
        }

        public int paint(int A, int B, List<int> C)
        {
            int n = C.Count;
            long low = 0;
            long high = 0;
            for (int i = 0; i < n; ++i)
            {
                high += C[i];
                low = Math.Max(low, (long)C[i]);
            }
            low = low * B;
            high = high * B;
            long ans = high;
            while (low <= high)
            {
                long mid = low + (high - low) / 2;
                if (check(A, B, C, mid))
                {
                    ans = Math.Min(ans, mid);
                    high = mid - 1;
                }
                else
                    low = mid + 1;
            }
            return (int)(ans % mod);
        }

        #endregion
        #region day 43 ass1
        public int pow(int A, int B, int C)
        {
            if (A == 0)
                return 0;
            if (A < 0)
            {
                A *= -1;
            }
            int n= Move(A, B) % C;
            return n;
        }

        int Move(int A, int B)
        {
            if (B == 1)
                return A;
            return Move(A, B - 1) * A;
        }
        #endregion

        #region Day 60 ass2
        //public List<int> grayCode(int A)
        //{
        //    if (A == 1)
        //    {
        //        List<int> b = new List<int>();
        //        b.Add(0);
        //        b.Add(1);
        //        return b;
        //    }
        //    List<int> seq = grayCode(A - 1);
        //    List<int> ans = new List<int>();

        //    int x = seq.Count;
        //    for (int i = 0; i < x; i++)
        //    {
        //        ans.Add(seq[i]);
        //    }

        //    for (int i = x - 1; i >= 0; i--)
        //    {
        //        int test = 1 << A - 2;
        //        ans.Add(seq[i] + 1 << A-2);
        //    }

        //    return ans;
        //}
        public List<int> grayCode(int A)
        {
            int n = A;
            List<int> result = new List<int>();
            result.Add(0);
            for (int i = 0; i < n; i++)
            {
                int curSize = result.Count;
                // push back all element in result in reverse order
                for (int j = curSize - 1; j >= 0; j--)
                {
                    result.Add(result[j] + (1 << i));
                }
            }
            return result;
        }
        #endregion


        #region Day 42 ass4
        public void cal(int n, int i, string str)
        {
            i++;
            if (i > n)
            {
                return;
            }
            if (i <= n)
            {
                cal(n, i, str);
                Console.Write(str[i - 1]);
                return;
            }
        }
        #endregion

        #region Day 50 HW-1
        public List<int> plusOne(List<int> A)
        {
            int size = A.Count;
            int carry = 1;
            int num = 0;

            for (int i = size - 1; i >= 0; i--)
            {
                num = A[i];
                num += carry;
                carry = 0;
                if (num == 10)
                {
                    num = 0;
                    carry = 1;
                }
                A[i] = num;
            }

            List<int> res = new List<int>();
            if (carry == 1)
                res.Add(1);
            for (int i = 0; i < size; i++)
            {
                if (A[i] == 0 && res.Count() == 0)
                    continue;
                res.Add(A[i]);
            }
            return res;
        }
        #endregion

        #region day 50-1
        public int trap(List<int> A)
        {
            #region approch 1
#if false
            int[] L = new int[A.Count];
            int[] R = new int[A.Count];
            int res = 0;
            int max = 0;
            for (int i = 1; i < A.Count; i++)
            {
                if (max < A[i - 1])
                {
                    max = A[i - 1];
                }
                L[i] = max;
            }
            max = 0;
            for (int i = A.Count - 2; i >= 0; i--)
            {
                if (max < A[i + 1])
                {
                    max = A[i + 1];
                }
                R[i] = max;
            }
            for (int i = 1; i < A.Count - 1; i++)
            {
                int level = (L[i] > R[i]) ? R[i] : L[i];
                res += (level > A[i]) ? level - A[i] : 0;
            }
            return res;
#endif
            #endregion
            #region Approoch 2
#if true
            int n=A.Count;
            int left=0, right=n-1;
            int res=0;
            int maxLeft=0, maxRight=0;
            while (left <= right)
            {
                if (A[left] <= A[right])
                {
                    if (A[left] >= maxLeft)
                    {
                        maxLeft=A[left];
                    }
                    else
                    {
                        res += maxLeft - A[left];
                    }
                    left++;
                }
                else
                {
                    if(A[right] >= maxRight)
                    {
                        maxRight = A[right];
                    }
                    else
                    {
                        res += maxRight - A[right];
                    }
                    right--;
                }
            }

            return res;
#endif
#endregion
        }
        #endregion

        #region Day 50-2
        public List<int> solve(int A, List<List<int>> B)
        {
            int[] beg = new int[A];
            for (int i = 0; i < B.Count; i++)
            {
                int L = B[i][0]-1;
                int R = B[i][1]-1;
                int coin = B[i][2];
                beg[L] += coin;
                if (R + 1 < A)
                {
                    beg[R + 1] -= coin;
                }
            }
            for (int i = 1; i < A; i++)
            {
                beg[i] += beg[i - 1];
            }

            return beg.ToList();
        }
#endregion

        public int solve(List<int> A)
        {
            if (A.Count == 0)
            {
                return 0;
            }
            int max = A[0], min =A[0];
            int n = A.Count;
            for (int i = 0; i < n; i++)
            {
                if (max < A[i])
                {
                    max = A[i];
                }
                if (min > A[i])
                {
                    min = A[i];
                }
            }
            if (max == min)
            {
                return 1;
            }
            int length = n;
            int minIndex = -1, maxIndex = -1;
            for (int i = 0; i < n; i++)
            {
                if (A[i] == max || A[i] == min)
                {
                    if (A[i] == max)
                    {
                        maxIndex = i;
                        if (minIndex != -1)
                        {
                            int temp = i - minIndex + 1;
                            if (length > temp)
                            {
                                length = temp;
                            }
                        }
                    }
                    else
                    {
                        minIndex = i;
                        if (maxIndex != -1)
                        {
                            int temp = i - maxIndex + 1;
                            if (length > temp)
                            {
                                length = temp;
                            }
                        }
                    }
                }
            }
            return length;
        }
    }
}
