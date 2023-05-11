using System.Collections.Generic;

namespace techgig
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    internal class LeetcodeLinkList
    {
        // leetcode 143
        public void ReorderList(ListNode head)
        {
            ListNode dummy = new ListNode();
            ListNode temp = dummy;

            while (head != null)
            {
                if (head.next == null || head.next.next == null)
                {
                    break;
                }
                temp.next = head;
                ListNode innerTemp = head.next;
                while (innerTemp != null)
                {
                    if (innerTemp.next != null)
                    {
                        if (innerTemp.next.next == null)
                        {
                            innerTemp.next.next = head.next;
                            head.next = innerTemp.next;
                            innerTemp.next = null;
                        }
                        innerTemp = innerTemp.next;
                    }
                }
                head = head.next.next;
                temp = temp.next.next;
            }
        }
        // leetcode 2
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode res = new ListNode();
            ListNode temp = res;
            int carry = 0;

            while (l1 != null || l2 != null)
            {
                int val = 0;
                if (l1 != null && l2 != null)
                {
                    if ((l1.val + l2.val + carry) > 9)
                    {
                        val = ((l1.val + l2.val) - 10) + carry;
                        carry = 1;
                    }
                    else
                    {
                        val = (l1.val + l2.val) + carry;
                        carry = 0;
                    }
                    temp.next = new ListNode(val, null);
                    l1 = l1.next;
                    l2 = l2.next;
                    temp = temp.next;
                }
                else if (l1 == null && l2 != null)
                {
                    if (l2.val + carry > 9)
                    {
                        val = (l2.val + carry) - 10;
                        carry = 1;
                    }
                    else
                    {
                        val = l2.val + carry;
                        carry = 0;
                    }
                    temp.next = new ListNode(val, null);
                    l2 = l2.next;
                    temp = temp.next;
                }
                else if (l1 != null && l2 == null)
                {
                    if (l1.val + carry > 9)
                    {
                        val = (l1.val + carry) - 10;
                        carry = 1;
                    }
                    else
                    {
                        val = l1.val + carry;
                        carry = 0;
                    }
                    temp.next = new ListNode(val, null);
                    l1 = l1.next;
                    temp = temp.next;
                }
            }
            if (carry != 0)
            {
                temp.next = new ListNode(carry, null);
            }

            return res.next;
        }
        // leetcode 24
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode dummy = new ListNode(0);
            ListNode temp = dummy;

            while (head != null)
            {
                /*
                 * [1] [2] [3] [4]
                 *  h   t   tn
                 *  [1] [3]    [2] [4]
                 *  h    hn/tn  t   
                 *  [2] [1] [3]
                 *  t   tn/h   hn
                 */



                //temp = head.next;
                //head.next = temp.next;
                //temp.next = head;
                //head = head.next;
                ////temp.next = temp.next.next;
                //temp=head.next;
            }

            return dummy.next;
        }
        //leetcode 82
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
            {
                return head;
            }

            ListNode dummy = new ListNode();
            ListNode temp = dummy;
            List<int> vs = new List<int>();

            while (head != null)
            {
                if (!(vs.Contains(head.val)))
                {
                    if (head.next != null)
                    {
                        if (head.val == head.next.val)
                        {
                            vs.Add(head.val);
                            head.next = head.next.next;
                        }
                        else
                        {
                            temp.next = head;
                            head = head.next;
                            temp = temp.next;
                        }
                    }
                    else
                    {
                        temp.next = head;
                        head = head.next;
                        temp = temp.next;
                    }
                }
                else
                {
                    if (head.next == null)
                    {
                        temp.next = null;
                    }
                    head = head.next;
                }
                //head = head.next;
            }

            return dummy.next;
        }
        //leetcode 21
        public ListNode MergeTwoLists(ListNode A, ListNode B)
        {
            if (A == null && B == null)
            {
                return new ListNode();
            }
            ListNode dummy = new ListNode(-100);

            ListNode temp = dummy;

            while (A != null || B != null)
            {
                if (A != null && B != null)
                {
                    if (A.val <= B.val)
                    {
                        temp.next = A;
                        A = A.next;
                        temp = temp.next;
                    }
                    else
                    {
                        temp.next = B;
                        B = B.next;
                        temp = temp.next;
                    }
                }
                else if (A == null && B != null)
                {
                    temp.next = B;
                    break;
                }
                else if (A != null && B == null)
                {
                    temp.next = A;
                    break;
                }
            }

            return dummy.next;
        }

        public ListNode ReverseKGroup(ListNode head, int k)
        {
            if (k == 1 || head == null || head.next == null)
            {
                return head;
            }

            ListNode dummy = new ListNode();
            ListNode temp = dummy;
            temp.next = head;


            int count = 0;

            while (head != null)
            {
                ListNode dummy2 = new ListNode();
                ListNode temp2 = dummy;
                while (count != k)
                {
                    count++;
                    temp2 = head.next;
                    head.next = head.next.next;
                    temp.next = head;
                    head = temp.next;
                }
            }

            return temp;
        }

        //leetcode 114
        #region Leetcode 114
        public void Flatten1(TreeNode root)
        {
            if (root == null || (root.left == null && root.right == null))
                return;

            TreeNode left = root.left;
            TreeNode right = root.right;

            root.left = null;

            Flatten1(left);
            Flatten1(right);

            root.right = left;
            TreeNode current = root;
            while (current.right != null)
            {
                current = current.right;
            }

            current.right = right;

        }

        public void Flatten2(TreeNode root)
        {
            if (root == null || (root.left == null && root.right == null))
                return;
            while (root != null)
            {
                if (root.left != null)
                {
                    TreeNode left = root.left;
                    TreeNode current = left;
                    while (current.right != null)
                    {
                        current = current.right;
                    }
                    current.right = root.right;
                    root.left = null;
                    root.right = left;
                }
                root = root.right;
            }
        }

        #endregion

        #region Leetcode 116

        public class Node116
        {
            public int val;
            public Node116 left;
            public Node116 right;
            public Node116 next;

            public Node116() { }

            public Node116(int _val)
            {
                val = _val;
            }

            public Node116(int _val, Node116 _left, Node116 _right, Node116 _next)
            {
                val = _val;
                left = _left;
                right = _right;
                next = _next;
            }
        }

        public Node116 Connect(Node116 root)
        {
            if (root == null)
                return root;
            List<Node116> vs = new List<Node116>();
            Node116 head = root;
            vs.Add(root);
            vs.Add(new Node116(1001));
            while (vs.Count != 0)
            {
                if (vs[0].val != 1001)
                {
                    Node116 temp = vs[0];
                    if (temp.left!=null)
                    {
                        vs.Add(temp.left);
                        vs.Add(temp.right);
                    }

                    if (vs[1].val != 1001)
                    {
                        vs[0].next = vs[1];
                    }
                    else
                    {
                        vs.Add(new Node116(1001));
                    }
                    vs.RemoveAt(0);
                }
                else
                {
                    vs.RemoveAt(0);
                }
            }
            return root;
        }

        #endregion

        #region Leetcode 144
        public IList<int> PreorderTraversal(TreeNode root)
        {
            if (root == null || (root.left == null && root.right == null))
            {
                return new List<int>() { root.val };
            }

            List<int> vs = new List<int>();
            vs.Add(root.val);

            while (root != null)
            {
                if (root.left != null)
                {
                    TreeNode left = root.left;
                    TreeNode current = left;
                    vs.Add(left.val);
                    while (current.right != null)
                    {
                        current = current.right;
                    }
                    current.right = root.right;
                    root.left = null;
                    root.right = left;
                }
                root = root.right;
            }
            return vs;
        }
        #endregion


        #region Leetcode 53
        public int MaxSubArray(int[] nums)
        {
            int perSum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                int temp = nums[i];
                if (nums[i] <= nums[i - 1] + nums[i])
                {
                    nums[i] = nums[i - 1] + nums[i];
                    
                }
                if (nums[i] > perSum)
                {
                    perSum = nums[i];
                }
            }

            return perSum;
        }
        #endregion

        #region Leetcode 54

        public IList<int> SpiralOrder(int[][] matrix)
        {
            int l = 0, r = matrix[0].Length - 1;
            int t = 0, b = matrix.Length - 1;
            List<int> res = new List<int>();
            int count = ((r + 1) * (b + 1));

            while (res.Count!=count)//(l < r && t < b)
            {
                //left to right
                for (int i = l; i <= r; i++)
                {
                    res.Add(matrix[t][i]);
                }
                t++;
                //top to bottom
                for (int i = t; i <= b; i++)
                {
                    res.Add(matrix[i][r]);
                }
                r--;
                //rigth to left
                for (int i = r; i >= l; i--)
                {
                    res.Add(matrix[b][i]);
                }
                b--;
                //bottom to top
                for (int i = b; i >= t; i--)
                {
                    res.Add(matrix[i][l]);
                }
                l++;
            }

            return res;
        }
        #endregion

        #region Leetcode 59
        public int[][] GenerateMatrix(int n)
        {
            int l = 0, r = n-1;
            int t = 0, b = n-1;

            int count = 1;
            int[][] vs = new int[n][];

            for (int i = 0; i < n; i++)
            {
                vs[i] = new int[n];
            }

            while (count <= (n * n))
            {
                //left to right
                for (int i = l; i <= r; i++)
                {
                    vs[t][i] = count++;
                }
                t++;
                if (count == (n * n)+1)
                {
                    break;
                }
                //top to bottom
                for (int i = t; i <= b; i++)
                {
                    vs[i][r] = count++;
                }
                r--;
                if (count == (n * n) + 1)
                {
                    break;
                }
                //right to left
                for (int i = r; i >= l; i--)
                {
                    vs[b][i] = count++;
                }
                b--;
                if (count == (n * n) + 1)
                {
                    break;
                }
                //bottom to top
                for (int i = b; i >= t; i--)
                {
                    vs[i][l] = count++;
                }
                l++;
                if (count == (n * n) + 1)
                {
                    break;
                }
            }

            return vs;
        }
        #endregion

        #region leetcode 226
        public TreeNode InvertTree(TreeNode root)
        {
            TreeNode temp = new TreeNode(root.val);

            if (root.left != null)
            {
                temp.right = Expand(root.left);
            }
            if (root.right != null)
            {
                temp.left = Expand(root.right);
            }

            return temp;
        }

        //left
        public TreeNode Expand(TreeNode old)
        {
            if (old == null)
                return null;
            TreeNode mirror = new TreeNode(old.val);

            if (old.left != null)
            {
                old.right = Expand(old.left);
            }
            if (old.right != null)
            {
                old.left = Expand(old.right);
            }

            return mirror;
        }
        #endregion

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        static void Main(string[] args)
        {
            LeetcodeLinkList l = new LeetcodeLinkList();
            l.MergeTwoLists(new ListNode(1,null), new ListNode(1, new ListNode(3, new ListNode(4, null))));
            //l.DeleteDuplicates(new ListNode(1,new ListNode(1,new ListNode(1,new ListNode(2,new ListNode(3,new ListNode(4,new ListNode(4,new ListNode(4,null)))))))));
            //l.SwapPairs(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, null)))));
            //l.AddTwoNumbers(new ListNode(3, new ListNode(7, null)), new ListNode(9, new ListNode(2, null)));
            //l.ReorderList(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5,null))))));
            //l.ReverseKGroup((new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, null)))))), 2);
            //l.Flatten2(new TreeNode(1,(new TreeNode(2,new TreeNode(3),(new TreeNode(4)))),new TreeNode(5,null,new TreeNode(6))));
            //l.PreorderTraversal(new TreeNode(1, (new TreeNode(2, new TreeNode(3), (new TreeNode(4)))), new TreeNode(5, null, new TreeNode(6))));
            //l.Connect(new Node116(1, new Node116(2, new Node116(4), new Node116(5), null), new Node116(3, new Node116(6), new Node116(7), null), null));
            //int a = l.MaxSubArray(new int[2] { -2, 1 });//, -3, 4, -1, 2, 1, -5, 4 });
            //var vs = l.SpiralOrder(new int[3][] { new int[3] { 1, 2, 3 }, new int[3] { 4, 5, 6 }, new int[3] { 7, 8, 9 } });
            //int[][] vs = l.GenerateMatrix(3);

            //l.InvertTree(new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(7, new TreeNode(6), new TreeNode(9))));
        }
    }
}
