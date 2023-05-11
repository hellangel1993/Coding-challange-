using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //int sol = Scaler.MinimumTotal(new List<List<int>> { new List<int> { 9 }, new List<int> { 3, 8 }, new List<int> { 0, 2, 4 }, new List<int> { 8, 3, 9, 0 }, new List<int> { 5, 2, 2, 7, 3 }, new List<int> { 7, 9, 0, 2, 3, 9 }, new List<int> { 9, 7, 0, 3, 9, 8, 6 }, new List<int> { 5, 7, 6, 2, 7, 0, 3, 9 } });
            //int sol = Scaler.solve(new List<int> { 359, 963, 465, 706, 146, 282, 828, 962, 492 }, new List<int> { 96, 43, 28, 37, 92, 5, 3, 54, 93 }, 383);
            //string sol = Scaler.day39ass1("crulgzfkif gg ombt vemmoxrgf qoddptokkz op xdq hv ");
            //int sol = Scaler.day39ass3(7);
            //int sol = Scaler.coinchange2(new List<int> { 1, 2, 3 }, 4);
            //int[] sol = Scaler.RotationGame(new int[] { 1, 1, 1, 1, 1 }, 6);
            //int a = Scaler.MaximunNumberofOne(new List<List<int>>
            //{
            //    new List<int> { 0, 0, 1, 1, 1 }, new List<int> { 0, 0, 0, 1, 1 }, new List<int> { 0, 0, 0, 1, 1 },
            //    new List<int> { 0, 0, 0, 0, 1 }, new List<int> { 0, 0, 0, 1, 1 }
            //});
            //int a = Scaler.Sort613(new List<int> { 3, 4, 2, 1, 5 });
            //int a = Scaler.Day73ass3(new ListNode(46, new ListNode(76, new ListNode(35))));
            //var a = Scaler.Day17ass5(new List<List<int>>
            //{
            //    new List<int>{1,2,3,4},new
            //        List<int>{5,6,7,8},new List<int>{9,2,3,4}
            //});
            //  var a = Scaler.Day26ass3(new List<int> { 533, -666, -500, 169, 724, 478, 358, -38, -536, 705, -855, 281, -173, 961, -509, -5, 942, -173, 436, -609, -396, 902, -847, -708, -618, 421, -284, 718, 895, 447, 726, -229, 538, 869, 912, 667, -701, 35, 894, -297, 811, 322, -667, 673, -336, 141, 711, -747, -132, 547, 644, -338, -243, -963, -141, -277, 741, 529, -222, -684, 35, -810, 842, -712, -894, 40, -58, 264, -352, 446, 805, 890, -271, -630, 350, 6, 101, -607, 548, 629, -377, -916, 954, -244, 840, -34, 376, 931, -692, -56, -561, -374, 323, 537, 538, -882, -918, -71, -459, -167, 115, -361, 658, -296, 930, 977, -694, 673, -614, 21, -255, -76, 72, -730, 829, -223, 573, 97, -488, 986, 290, 161, -364, -645, -233, 655, 574, -969, -948, 350, 150, -59, 724, 966, 430, 107, -809, -993, 337, 457, -713 }, 118);
            //var a = Scaler.Day29ass2(new List<int> { 20,3,13,5,10,14,8,5,11,9,1,11 }, 9);
            //Scaler.Day30ass8(new List<List<int>>{new List<int>{1,2,3},new List<int>{4,5,6},new List<int>{7,8,9}});
            //var a = Scaler.Day26ass1(new List<int> { 1, 2, 3, 7, 1, 2, 3 }); //{ -7, 1, 5, 2, -4, 3, 0 });
            //var a = Scaler.Day26ass21(new List<int> { 1, 2, 3, 4, 5, 11, 1, 2, 3, 4, 5 });
            //var a = Scaler.Day31ass2(new List<int> { 1, 6, 4, 2, 6, 9 }, new List<int> { 2, 5, 7, 3, 2, 7 });
            //var a = Scaler.Day31ass2(new List<int> { 5,9,10,4,7,8 }, new List<int> { 5,6,4,7,2,5});
            //var a = Scaler.Day31ass1("11010110000000000");
            //var a = Scaler.Day31ass1("001000000011");
            //var a = Scaler.addBinary("1010110111001101101000", "1000011011000000111100110");
            //var a = Scaler.subsets(new List<int> { 1, 2, 3 });
            //var a = Scaler.permute(new List<int> { 1,2,2 });
            //var a = Scaler.findMod("475933435476588477482929993998487477372912019283839484", 3);
            //var a = Scaler.isPerfectCube(1);
            //var a = Scaler.Day12HW4(-2213);
            //var a=Scaler.Day33ass2(8);
            //var a = Scaler.Day40ass1(new List<int> { 1, 2, 2, 1 }, new List<int> { 2, 3, 1, 3 });
            //var a= Scaler.Day37ass5(10);
            //var a = Scaler.Day40ass2(new List<int> { 8, 15, 1, 10, 5, 19, 19, 3, 5, 6, 6, 2, 8, 2, 12, 16, 3 });
            //var a = Scaler.lszero(new List<int> { -19, 8, 2, -8, 19, 5, -2, -23 });
            //var a = Scaler.twoSum(new List<int> { 4, 7, -4, 2, 2, 2, 3, -5, -3, 9, -4, 9, -7, 7, -1, 9, 9, 4, 1, -4, -2, 3, -3, -5, 4, -7, 7, 9, -4, 4, -8 }, -3);
            //var a = Scaler.Day41ass1(new List<int> { 1, 1000000000 }, 1000000000);
            //var a = Scaler.lengthoflongeststring("abcabcbb");
            //var a = Scaler.patternStach("))))))");
            //var a = Scaler.SortedArrayToBST(new int[] { 1, 2, 3, 4, 5, -1, -1, -1, -1, -1,6,-1, -1, });
            //var a= Scaler.inorderTraversal(new TreeNode(1,new TreeNode(6,null,null),new TreeNode(2,new TreeNode(3,null,null),null)));
            //var a = Scaler.preorderTraversal(new TreeNode(1, new TreeNode(2, null, null), new TreeNode(2, new TreeNode(3, null, null), null)));
            //var a = Scaler.longestPalindrome("abb");
            //var a= Scaler.postorderTraversal(new TreeNode(1, new TreeNode(6, null, null), new TreeNode(2, new TreeNode(3, null, null), null)));
            //var a = Scaler.Day46ass2(new List<List<int>> { new List<int> { 2, 19, 0 }, new List<int> { 2, 5, 1 }, new List<int> { 2, 8, 0 }, new List<int> { 1, 7, -1 }, new List<int> { 1, 5, -1 } });
            //Scaler.faactset();
            //var a = Scaler.countMinSquares(6);
            //var a = Scaler.maxSubArray(new List<int> { -120, -202, -293, -60, -261, -67, 10, 82, -334, -393, -428, -182, -138, -167, -465, -347, -39, -51, -61, -491, -216, -36, -281, -361, -271, -368, -122, -114, -53, -488, -327, -182, -221, -381, -431, -161, -59, -494, -406, -298, -268, -425, -88, -320, -371, -5, 36, 89, -194, -140, -278, -65, -38, -144, -407, -235, -426, -219, 62, -299, 1, -454, -247, -146, 24, 2, -59, -389, -77, -19, -311, 18, -442, -186, -334, 41, -84, 21, -100, 65, -491, 94, -346, -412, -371, 89, -56, -365, -249, -454, -226, -473, 91, -412, -30, -248, -36, -95, -395, -74, -432, 47, -259, -474, -409, -429, -215, -102, -63, 80, 65, 63, -452, -462, -449, 87, -319, -156, -82, 30, -102, 68, -472, -463, -212, -267, -302, -471, -245, -165, 43, -288, -379, -243, 35, -288, 62, 23, -444, -91, -24, -110, -28, -305, -81, -169, -348, -184, 79, -262, 13, -459, -345, 70, -24, -343, -308, -123, -310, -239, 83, -127, -482, -179, -11, -60, 35, -107, -389, -427, -210, -238, -184, 90, -211, -250, -147, -272, 43, -99, 87, -267, -270, -432, -272, -26, -327, -409, -353, -475, -210, -14, -145, -164, -300, -327, -138, -408, -421, -26, -375, -263, 7, -201, -22, -402, -241, 67, -334, -452, -367, -284, -95, -122, -444, -456, -152, 25, 21, 61, -320, -87, 98, 16, -124, -299, -415, -273, -200, -146, -437, -457, 75, 84, -233, -54, -292, -319, -99, -28, -97, -435, -479, -255, -234, -447, -157, 82, -450, 86, -478, -58, 9, -500, -87, 29, -286, -378, -466, 88, -366, -425, -38, -134, -184, 32, -13, -263, -371, -246, 33, -41, -192, -14, -311, -478, -374, -186, -353, -334, -265, -169, -418, 63, 77, 77, -197, -211, -276, -190, -68, -184, -185, -235, -31, -465, -297, -277, -456, -181, -219, -329, 40, -341, -476, 28, -313, -78, -165, -310, -496, -450, -318, -483, -22, -84, 83, -185, -140, -62, -114, -141, -189, -395, -63, -359, 26, -318, 86, -449, -419, -2, 81, -326, -339, -56, -123, 10, -463, 41, -458, -409, -314, -125, -495, -256, -388, 75, 40, -37, -449, -485, -487, -376, -262, 57, -321, -364, -246, -330, -36, -473, -482, -94, -63, -414, -159, -200, -13, -405, -268, -455, -293, -298, -416, -222, -207, -473, -377, -167, 56, -488, -447, -206, -215, -176, 76, -304, -163, -28, -210, -18, -484, 45, 10, 79, -441, -197, -16, -145, -422, -124, 79, -464, -60, -214, -457, -400, -36, 47, 8, -151, -489, -327, 85, -297, -395, -258, -31, -56, -500, -61, -18, -474, -426, -162, -79, 25, -361, -88, -241, -225, -367, -440, -200, 38, -248, -429, -284, -23, 19, -220, -105, -81, -269, -488, -204, -28, -138, 39, -389, 40, -263, -297, -400, -158, -310, -270, -107, -336, -164, 36, 11, -192, -359, -136, -230, -410, -66, 67, -396, -146, -158, -264, -13, -15, -425, 58, -25, -241, 85, -82, -49, -150, -37, -493, -284, -107, 93, -183, -60, -261, -310, -380 });
            //var a = Scaler.addBinary("110", "10");
            //var a = Scaler.Day51ass4(new List<List<int>> { new List<int> { -83, -73, -70, -61 }, new List<int> { -56, -48, -13, 4 }, new List<int> { 38, 48, 71, 71 } });
            //var a = Scaler.Day68ass1(new List<int> { 1, 2, 3, 4, 5 }, 5);
            //var a=Scaler.adjacent(new List<List<int>> { new List<int>() { 16, 5, 54, 55, 36, 82, 61, 77, 66, 61 }, new                                                        List<int> { 31, 30, 36, 70, 9, 37, 1, 11, 68, 14 } });
            //var a = Scaler.Day57ass1(new List<int> { 3, 9, 6, 8, 3 });
            //var a = Scaler.Day78ass1(3);
            //var a = Scaler.Day63ass1(new List<int> { 1, 4, 10, 2, 1, 5 });
            //var a = Scaler.repeatedNumber(new List<int> { 1, 2, 3, 1, 1 });
            
        }

        #region Day 83 ass2
        public int lca(TreeNode A, int B, int C)
        {
            if (checkNodeExists(A,B)==false||checkNodeExists(A,C)==false)
            {
                return -1;
            }
            return getLca(A,B,C);
        }

        bool checkNodeExists(TreeNode A,int val)
        {
            if (A==null)
            {
                return false;
            }

            if (A.val==val)
            {
                return true;
            }

            return checkNodeExists(A.left,val)||checkNodeExists(A.right,val);
        }

        int getLca(TreeNode A,int B,int C)
        {
            if (A==null)
            {
                return 0;
            }
            if (A.val==B||A.val==C)
            {
                return A.val;
            }

            int left=getLca(A.left,B,C);
            int right=getLca(A.right,B,C);
            if (left==0)
            {
                return right;
            }
            else if (right==0)
            {
                return left;
            }

            return A.val;
        }
        #endregion

        #region Day 95 ass2
        public int Dat95ass2(int A, List<int> B,List<int> C)
        {
            int[] dp=new int[A+1];
            for (int i = 1; i <= A; i++)
            {
                for (int j = 0; j < B.Count; j++)
                {
                    if (C[j]<=i)
                    {
                        dp[i] = Math.Max(dp[i], B[j] + dp[i - C[j]]);
                    }
                }
            }
            return dp[A];
        }
        #endregion

        #region Day 90 ass4
        int mod = 10000003;
        public int seats(string A)
        {
            int i = 0, j = A.Length - 1;
            while (i < j)
            {
                char itemp = A[i];
                char jtemp = A[j];
                if (itemp=='x'&&jtemp!='x')
                {
                    j--;
                }
                else if (jtemp=='x'&&itemp!='x')
                {
                    i++;
                }
                else
                {
                    i++;
                    j--;
                }
            }

            return (LeftCheck(A.Substring(0, i)) + RightCheck(A.Substring(i))) % mod;
        }

        private int LeftCheck(string A)
        {
            int count = 0;
            int sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i]=='x')
                {
                    count++;
                }
                else
                {
                    sum += count;
                    sum %= mod;
                }
            }
            return sum;
        }
        private int RightCheck(string A)
        {
            int count = 0;
            int sum = 0;
            for (int i = A.Length-1; i >=0; i--)
            {
                if (A[i]=='x')
                {
                    count++;
                }
                else
                {
                    sum += count;
                    sum %= mod;
                }
            }
            return sum;
        }
        #endregion
        #region Day 73 ass4
        public ListNode reverseBetween(ListNode A, int B, int C)
        {
            ListNode prev = null;
            ListNode curr = A;
            if (B==1)
            {
                return reverse_list(A, C - B + 1);
            }
            else
            {
                for (int i = 1; i < B; i++)
                {
                    prev = curr;
                    curr=curr.next;
                }
                prev.next = reverse_list(curr, C - B + 1);
                return A;
            }
        }

        public static ListNode reverse_list(ListNode A,int B)
        {
            ListNode first = A;
            ListNode prev = null;
            ListNode curr = A;
            ListNode temp;

            for (int i = 0; i < B; i++)
            {
                temp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = temp;
            }
            first.next = curr;
            return prev;
        }
        #endregion

        #region Day 37 ass4

#if false
        public int repeatedNumber(List<int> a)
        {
            int can1 = a[0];
            int can2 = 0;
            int vote1 = 1;
            int vote2 = 0;
            for(int i=1; i<a.Count; i++)
            {
                if (a[i]==can1)
                {
                    vote1++;
                }
                else if (a[i]==can2)
                {
                    vote2++;
                }
                else if (vote1==0)
                {
                    vote1++;
                    can1 = a[i];
                }
                else if (vote2==0)
                {
                    vote2++;
                    can2 = a[i];
                }
                else
                {
                    vote1--;
                    vote2--;
                }
            }
            int count1=0,count2=0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i]==can1)
                {
                    count1++;
                }
                if (a[i]==can2)
                {
                    count2++;
                }
            }
            if (count1>(a.Count/3))
            {
                return can1;
            }
            if (count2>(a.Count/3))
            {
                return can2;
            }

            return -1;
        }
#else
        public int repeatedNumber(List<int> A)
        {
            if (A.Count == 0)
                return -1;

            // vector<pair<int, int>>temp(2);
            List<List<int>> temp = new List<List<int>>();

            for (int i = 0; i < 2; i++)
            {
                temp.Add(new List<int>());
                for (int j = 0; j < 2; j++)
                {
                    temp[i].Add(0);
                }
            }
            temp[0][1] = temp[1][1] = 0;
            for (int i = 0; i < A.Count; i++)
            {
                int j;
                if (temp[0][0] == A[i] || temp[1][0] == A[i])
                {
                    if (temp[0][0] == A[i]) temp[0][1] += 1;
                    else temp[1][1] += 1;
                }
                else
                {
                    int l;
                    if (temp[0][1] == 0 || temp[1][1] == 0)
                    {
                        int index = (temp[0][1] == 0) ? 0 : 1;
                        temp[index][0] = A[i];
                        temp[index][1] = 1;
                    }
                    else
                    {
                        temp[0][1] -= 1;
                        temp[1][1] -= 1;
                    }
                }
            }
            for (int i = 0; i < 2; i++)
            {
                int ac = 0; // actual count
                for (int j = 0; j < A.Count; j++)
                    if (A[j] == temp[i][0])
                        ac++;
                if (ac > (A.Count / 3)) return temp[i][0];
            }
            return -1;
        }
#endif
#endregion
        #region Day 63 ass1
        public List<int> Day63ass1(List<int> A)
        {
            quicksort(A,0,A.Count-1);
            return A;
        }

        public void quicksort(List<int> A,int s,int e)
        {
            if (s>=e)
            {
                return;
            }
            int pi=partition(A,s,e);
            quicksort(A,s,pi-1);
            quicksort(A,pi+1,e);
        }
        public int partition(List<int> A,int s,int e)
        {
            int p = A[e];
            int i = s;
            for (int j = s; j < e; j++)
            {
                if (A[j]<p)
                {
                    int temp = A[j];
                    A[j] = A[i];
                    A[i] = temp;
                    i++;
                }
            }
            int temp2 = A[i];
            A[i] = A[e];
            A[e] = temp2;
            return i;
        }

        //{
        //    int p1 = 1;
        //    int p2 = A.Count - 1;
        //    while (p1 <= p2)
        //    {
        //        if (A[p1] <= A[0])
        //        {
        //            p1 = p1 + 1;
        //        }
        //        else if (A[p2] > A[0])
        //        {
        //            p2 = p2 - 1;
        //        }
        //        else
        //        {
        //            A = Swap(A, p1, p2);
        //            p1++;
        //            p2--;
        //        }
        //    }

        //    return Swap(A,0,p2);
        //}

        //private List<int> Swap(List<int> A, int p1, int p2)
        //{
        //    int temp = A[p1];
        //    A[p1] = A[p2];
        //    A[p2] = temp;
        //    return A;
        //}
        #endregion

        #region Day 78 ass1
        public string Day78ass1(int A)
        {
            Queue<string> strings = new Queue<string>();
            strings.Enqueue("1");
            strings.Enqueue("2");
            int i = 1;
            string res = "";
            while (i <= A)
            {
                res=strings.Dequeue();
                strings.Enqueue(res+"1");
                strings.Enqueue(res+"2");
                i++;
            }

            return res + Reverse(res);
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        #endregion
        #region Day57 ass1
        public int Day57ass1(List<int> A)
        {
            int n=A.Count;
            int[] pre=new int[n];
            int[] post=new int[n];

            pre[0] = A[0];
            for (int i = 1; i < n; i++)
            {
                pre[i] = GCD(pre[i - 1], A[i]);
            }

            post[n - 1] = A[n - 1];
            for (int i = n-2; i >=0; i--)
            {
                post[i] = GCD(post[i + 1], A[i]);
            }

            int res = post[1];
            for (int i = 1; i < n; i++)
            {
                if (i==n-1)
                {
                    res = Math.Max(res, pre[i - 1]);
                }
                else
                {
                    res=Math.Max(res, GCD(pre[i - 1], post[i+1]));
                }
            }

            return res;
        }

        private int GCD(int A,int B)
        {
            if (B == 0)
            {
                return A;
            }
            return GCD(B, A % B);
        }
        #endregion
        #region Day 94 ass3
        public int adjacent(List<List<int>> A)
        {
            int n = A[0].Count;
            List<int> vs = new List<int>();

            for (int i = 0; i < n; i++)
            {
                if (A[0][i] > A[1][i])
                {
                    vs.Add(A[0][i]);
                }
                else
                {
                    vs.Add(A[1][i]);
                }
            }

            if (n == 1)
            {
                return Math.Max(A[0][0], A[1][0]);
            }
            vs[1] = Math.Max(vs[0], vs[1]);
            for (int i = 2; i < n; i++)
            {
                int temp = Math.Max(vs[i - 1], vs[i] + vs[i - 2]);
                vs[i] = temp;
            }

            return vs[n - 1];
        }
        #endregion

        #region Day 68 ass1
        public List<int> Day68ass1(List<int> A,int B)
        {
            int j = 0;
            long sum = 0;
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] == B)
                {
                    return new List<int> { A[i] };
                }
                sum += A[i];
                while (sum > B)
                {
                    sum -= A[j++];
                }

                if (sum == B)
                {
                    List<int> vs = new List<int>();
                    for (int k = j; k <= i; k++)
                    {
                        vs.Add(A[k]);
                    }
                    return vs;
                }
            }
            return new List<int> { -1 };
        }
        #endregion
        #region Day 56 ass4
        public int Dat56ass4(int A,int B)
        {
            int power = B - 2;
            int powerFunctionValue = calculatePowerFunctionValue(A, power, B);
            return powerFunctionValue;
        }

        private int calculatePowerFunctionValue(int A,int power,int B)
        {
            if (power==0)
            {
                return 1;
            }
            if (power%2==1)
            {
                long halfpower = calculatePowerFunctionValue(A, power / 2, B);
                return (int)((A % B * halfpower % B * halfpower % B) % B);
            }
            else
            {
                long halfPowerValue = calculatePowerFunctionValue(A, power / 2, B);
                return (int)((halfPowerValue % B * halfPowerValue % B) % B);
            }
        }
        #endregion

        #region Day 51 ass4
        public long Day51ass4(List<List<int>> A)
        {
            int n = A.Count-1;
            int m = A[0].Count-1;
            long max_sum = A[n][m];
            long[,] prefix=new long[n+1,m+1];
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= m; j++)
                { 
                    prefix[i,j] = A[i][j];
                }
            }

            for (int r = n - 1; r >= 0; r--)
            {
                prefix[r,m] += prefix[r + 1, m];
                max_sum = Math.Max(max_sum, prefix[r, m]);
            }
            for (int c = m - 1; c >= 0; c--)
            {
                prefix[n, c] += prefix[n, c + 1];
                max_sum = Math.Max(max_sum, prefix[n, c]);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = m - 1; j >= 0; j--)
                {
                    prefix[i, j] += prefix[i + 1, j] + prefix[i, j + 1] - prefix[i + 1, j + 1];
                    max_sum = Math.Max(max_sum, prefix[i, j]);
                }
            }

            return max_sum;
        }
        #endregion

        #region Day 54 ass4
        public string addBinary(string A, string B)
        {
            int carry = 0, i = A.Length - 1, j = B.Length - 1;
            string ans = "";
            while (i >= 0 || j >= 0 || carry != 0)
            {
                int sum = 0;
                if (i >= 0)
                {
                    sum += (A[i] - '0');
                    i--;
                }
                if (j>=0)
                {
                    sum += B[j] - '0';
                    j--;
                }
                sum+= carry;
                int bit = sum % 2;
                carry = sum / 2;
                ans += (char)(bit + '0');
            }

            //System.Text.StringBuilder
            StringBuilder res= new StringBuilder();
            for(int k = ans.Length - 1; k >= 0; k--)
            {
                res.Append(ans[k]);
            }

            return res.ToString();
        }
        #endregion

        #region Day 50 ass3
        public int maxSubArray(List<int> A)
        {
            int cur_sum = 0;
            int max_Sum = Int32.MinValue;
            for(int i=0; i<A.Count; i++)
            {
                cur_sum += A[i];
                max_Sum=Math.Max(max_Sum,cur_sum);
                if (cur_sum < 0) {
                    cur_sum = 0;
                }
            }
            return max_Sum;
        }
        #endregion

        #region Day 93 ass3
        public int countMinSquares(int A)
        {
            //check(A, 0);
            
            return count;
        }

        

        int count = 0;
        public void check(int A, int index)
        {
            if (A == 0)
            {
                count++;
                return;
            }

            for (int i = 1; i <= A; i++)
            {
                if (A < A - (i * i))
                {
                    break;
                }
                check(A-(i*i), index++);

            }
        }
        #endregion

        #region factset
        public void faactset()
        {
            var names = new string[] { "Dog", "Cat", "Giraffe", "Monkey", "Tortoise" };
            List<string> vs=new List<string>();
            foreach (var name in names)
            {
                if (name.Length>3)
                {
                    vs.Add(name);
                }
            }

            vs.Sort();
            foreach (var name in vs)
            {
                Console.WriteLine(name);
            }
        }
        #endregion

        #region Day 46 ass2
        public ListNode Day46ass2(List<List<int>> A)
        {
            ListNode head = null;
            int op, x, index;
            for (int i = 0; i < A.Count; i++)
            {
                op = A[i][0];
                x = A[i][1];
                index = A[i][2];

                ListNode newNode = new ListNode(x);
                ListNode prev = head;

                int cnt = 0;
                ListNode temp = prev;
                while (temp != null)
                {
                    cnt++;
                    temp = temp.next;
                }
                switch (op)
                {
                    case 0:
                        //Adding node before first node                        
                        newNode.next = head;
                        head = newNode;
                        break;
                    case 1:
                        //Adding node at the end of linked list                                                                        
                        if (cnt == 0)
                        {
                            newNode.next = head;
                            head = newNode;
                        }
                        else
                        {
                            while (prev.next != null)
                            {
                                prev = prev.next;
                            }
                            newNode.next = null;
                            prev.next = newNode;
                        }
                        break;
                    case 2:
                        //Insert element at given position
                        if (index == 0)
                        {
                            newNode.next = head;
                            head = newNode;
                        }
                        else if (index <= cnt)
                        {
                            for (int pos = 0; pos < index - 1; pos++)
                            {
                                prev = prev.next;
                            }
                            newNode.next = prev.next;
                            prev.next = newNode;
                        }
                        break;
                    case 3:
                        //Delete element from given position                    
                        if (x < cnt)
                        {
                            if (x == 0)
                            {
                                head = head.next;
                            }
                            else
                            {
                                for (int pos = 0; pos < x - 1; pos++)
                                {
                                    prev = prev.next;
                                }
                                prev.next = prev.next.next;
                            }
                        }
                        break;
                }
            }
            return head;
        }
        //{
        //    ListNode list = null;

        //    int i = 0;
        //    while (i<A.Count)
        //    {
        //        List<int> a = A[i];
        //        switch (a[0])
        //        {
        //            case 0:
        //                list=CaseZero(a[1], list); break;
        //            case 1:
        //                list=CaseOne(a[1], list);
        //                break;
        //            case 2:
        //                list = CaseSecond(a[1], list, a[2]);
        //                break;
        //            case 3:
        //                list = CaseThird(a[1], list);
        //                break;
        //        }
        //        i++;
        //    }
        //    return list;
        //}

        //public ListNode CaseZero(int x,ListNode listNode)
        //{
        //    ListNode node = new ListNode(x);
        //    node.next= listNode;
        //    return node;
        //}
        //public ListNode CaseOne(int x, ListNode listNode)
        //{
        //    ListNode node = new ListNode(x);
        //    ListNode temp = listNode;
        //    while (temp != null && temp.next != null)
        //    {
        //        temp = temp.next;
        //    }
        //    if (temp == null)
        //    {
        //        temp = node;
        //    }
        //    else
        //        temp.next = node;
        //    return listNode;
        //}
        //public ListNode CaseSecond(int x,ListNode listNode,int index)
        //{
        //    int i = 1;
        //    ListNode node = new ListNode(x);
        //    ListNode temp = listNode;

        //    if (temp == null)
        //    {
        //        return node;
        //    }
        //    else
        //    {
        //        int k=1;
        //        while (temp != null)
        //        {
        //            temp=temp.next;
        //            k++;
        //        }
        //        temp = listNode;
        //        if (k < index)
        //        {
        //            return listNode;
        //        }
        //        else
        //        {
        //            for (int j = 0; j < k-1; j++)
        //            {
        //                temp = temp.next;
        //            }
        //            ListNode next = temp.next;
        //            temp.next = node;
        //            node.next = next;
        //        }

        //        return listNode;
        //    }
        //}
        //public ListNode CaseThird(int index,ListNode listNode)
        //{
        //    if(listNode == null)
        //    {
        //        return listNode;
        //    }
        //    int i = 1;
        //    ListNode temp = listNode;
        //    while (i<index&& listNode.next != null)
        //    {
        //        temp=temp.next;
        //        i++;
        //    }
        //    ListNode next = null;
        //    if (temp.next!=null)
        //    {
        //        next = temp.next.next;
        //    }
        //    temp.next = next;
        //    return listNode;
        //}
        #endregion

        #region day 47 ass3
        public List<int> postorderTraversal(TreeNode A)
        {
            List<int> list = new List<int>();
            Stack<TreeNode> trees = new Stack<TreeNode>();
            trees.Push(A);
            while(trees.Count > 0)
            {
                TreeNode temp= trees.Pop();
                list.Add(temp.val);
                if (temp.left != null)
                {
                    trees.Push(temp.left);
                }
                if (temp.right!=null)
                {
                    trees.Push(temp.right);
                }
            }

            list.Reverse();

            return list;
        }
        #endregion
        #region day 39 ass7
        public string longestPalindrome(string A)
        {
            string len1 = String.Empty, len2 = String.Empty, longestString = String.Empty;
            for (int i = 0; i < A.Length; i++)
            {
                //odd
                len1 = check(A, i, i);
                if (len1.Length>longestString.Length)
                {
                    longestString = len1;
                }

                //even
                len2 = check(A, i, i+1);
                if (len2.Length>longestString.Length) { longestString = len2; }
            }

            return longestString;
        }

        public string check(string A,int s,int e)
        {
            while (s >= 0 && e < A.Length && A[s] == A[e])
            {
                s--;
                e++;
            }
            return A.Substring(s + 1, e - s - 1);
        }
        #endregion

        #region Day 47 ass2
        public List<int> preorderTraversal(TreeNode A)
        {
            List<int> result = new List<int>();
            Stack<TreeNode> nodes = new Stack<TreeNode>();
            nodes.Push(A);
            while (nodes.Count != 0)
            {
                TreeNode temp = nodes.Peek();
                nodes.Pop();
                result.Add(temp.val);
                if (temp.right != null)
                {
                    nodes.Push(temp.right);
                }
                if (temp.left != null)
                {
                    nodes.Push(temp.left);
                }
            }

            return result;

        }
        #endregion
        #region Day 47 ass1
        public List<int> inorderTraversal(TreeNode A)
        {
            List<int> list = new List<int>();
            if (A == null)
                return list;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            while (A != null)
            {
                stack.Push(A);
                A = A.left;
            }

            while (stack.Count != 0)
            {
                TreeNode cur = stack.Peek();
                stack.Pop();
                list.Add(cur.val);
                A = cur.right;
                while (A != null)
                {
                    stack.Push(A);
                    A = A.left;
                }
            }

            return list;
        }
        #endregion

        #region test26-03-2023
        public class TreeNode2
        {
            public int val;
            public TreeNode2 left;
            public TreeNode2 right;
            public TreeNode2(int x) { this.val = x; this.left = null; this.right = null; }
        }

        public TreeNode2 SortedArrayToBST(int[] A)
        {
            if (A.Length == 0)
            {
                return null;
            }

            //return Construct(nums, 0);
            Queue<TreeNode2> trees = new Queue<TreeNode2>();
            TreeNode2 pafrent = new TreeNode2(A[0]);
            trees.Enqueue(pafrent);
            for (int i = 1; i < A.Length - 1; i = i + 2)
            {
                TreeNode2 temp = trees.Dequeue();
                temp.left = (A[i] != -1) ? new TreeNode2(A[i]) : null;
                temp.right = (A[i + 1] != -1) ? new TreeNode2(A[i + 1]) : null;
                if (temp.left != null)
                {
                    trees.Enqueue(temp.left);
                }

                if (temp.right != null)
                {
                    trees.Enqueue(temp.right);
                }

            }

            return pafrent;

        }




        public int patternStach(string A)
        {

            Stack<char> stack = new Stack<char>();
            stack.Push(A[0]);
            for (int i = 1; i < A.Length; i++)
            {

                if (A[i] == ')' && stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else if (A[i] == '}' && stack.Peek() == '{')
                {
                    stack.Pop();
                }
                else if (A[i] == ']' && stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(A[i]);
                }
            }

            return (stack.Count == 0) ? 1 : 0;
        }

        public int lengthoflongeststring(string A)
        {
            cusList cusList = new cusList();
            int i = 0;
            int res = 0;
            while (i < A.Length)
            {
                if (cusList.Contains(A[i]))
                {
                    cusList.Remove(A[i]);
                }
                else
                {
                    cusList.Add(A[i]);
                    res = (res < cusList.Count()) ? cusList.Count() : res;
                    i++;
                }
            }
            return res;
        }

        class cusList
        {
            List<char> list = new List<char>();
            HashSet<char> hash = new HashSet<char>();
            public cusList() { }
            public void Add(char A)
            {
                list.Add(A);
                hash.Add(A);
            }
            public void Remove(char A)
            {
                char temp = list[0];
                list.RemoveAt(0);
                hash.Remove(temp);
            }
            public bool Contains(char A)
            {
                return hash.Contains(A);
            }
            public int Count() { return list.Count; }
        }
        #endregion

        #region day 41 ass1
        public List<int> Day41ass1(List<int> A, int B)
        {
            List<int> vs = new List<int>();
            int sum = 0;
            int i = 0;
            while (i < A.Count)
            {
                if (sum < B)
                {

                    vs.Add(A[i]);
                    sum += A[i];
                    i++;
                }
                if (sum > B)
                {
                    sum -= vs[0];
                    vs.RemoveAt(0);
                }

                if (sum == B)
                {
                    return vs;
                }
            }
            return new List<int> { -1 };
        }
        #endregion

        #region Day 41 ass4
        public List<int> twoSum(List<int> A, int B)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            for (int i = 0; i < A.Count; i++)
            {
                int temp = B - A[i];
                if (result.ContainsKey(A[i]))
                {
                    return new List<int> { result[A[i]] + 1, i + 1 };
                }
                else
                {
                    if (!result.ContainsKey(temp))
                    {
                        result.Add(temp, i);
                    }
                }
            }

            return new List<int>();
        }
        #endregion
        #region Day 40 ass3
        public List<int> lszero(List<int> A)
        {
            Dictionary<int, int> vs = new Dictionary<int, int>();
            int max = 0;

            int si = -1;
            int se = -1;
            int sum = 0;
            vs.Add(0, -1);
            for (int i = 0; i < A.Count; i++)
            {
                sum += A[i];
                if (vs.ContainsKey(sum))
                {
                    int temp = i - vs[sum];
                    if (temp > max)
                    {
                        si = vs[sum] + 1;
                        se = i;
                        max = temp;
                    }
                }
                else
                {
                    vs.Add(sum, i);
                }
            }

            List<int> list = new List<int>();
            if (si == -1)
            {
                return list;
            }
            for (int i = si; i < se + 1; i++)
            {
                list.Add(A[i]);
            }
            return list;
        }
        #endregion
        #region Day 40 ass2
        public int Day40ass2(List<int> A)
        {
            Dictionary<int, int> vs = new Dictionary<int, int>();
            int res = A.Count + 1;
            for (int i = 0; i < A.Count; i++)
            {
                if (vs.ContainsKey(A[i]))
                {
                    if (res > vs[A[i]])
                    {
                        res = vs[A[i]];
                    }
                }
                else
                {
                    vs.Add(A[i], i);
                }
            }
            if (res == A.Count + 1)
            {
                return -1;
            }
            else
            {
                return A[res];
            }
        }
        #endregion
        #region Day 37 ass5
        public int Day37ass5(int A)
        {
            int ans = 0;
            int power = 5;
            while (A > 0)
            {
                int r = A % 2;
                A = A / 2;
                ans += r * power;
                power *= 5;
            }
            return ans;
        }
        #endregion

        #region Day 40 ass1
        public List<int> Day40ass1(List<int> A, List<int> B)
        {
            Dictionary<int, int> vs = new Dictionary<int, int>();
            foreach (var item in A)
            {
                if (vs.ContainsKey(item))
                {
                    vs[item]++;
                }
                else
                {
                    vs.Add(item, 1);
                }
            }
            List<int> res = new List<int>();
            foreach (var item in B)
            {
                if (vs.ContainsKey(item) && vs[item] > 0)
                {
                    res.Add(item);
                    vs[item]--;
                }
            }
            return res;
        }
        #endregion

        #region Day 33 ass2
        public int Day33ass2(int A)
        {
            int count = 0;
            while (A > 0)
            {
                if ((A & 1) == 1)
                {
                    count++;
                }
                A = A >> 1;
            }
            return count;
        }
        #endregion
        #region Day 37 ass1
        public int majorityElement(List<int> A)
        {
            int N = A.Count / 2;
            Dictionary<int, int> vs = new Dictionary<int, int>();
            foreach (int i in A)
            {
                if (vs.ContainsKey(i))
                {
                    vs[i]++;
                }
                else
                {
                    vs.Add(i, 1);
                }
            }

            int res = 0;
            int count = 0;
            foreach (KeyValuePair<int, int> i in vs)
            {
                if (i.Value > N && count < i.Value)
                {
                    res = i.Key;
                    count = i.Value;
                }
            }

            return res;
        }
        #endregion

        #region Day 12 HW4

        public int Day12HW4(int A)
        {
            return (int)Math.Ceiling((double)(A / 200));
        }
        #endregion
        #region Day 12 HW8
        public int isPerfectCube(int A)
        {
            for (int i = 1; i <= A; i++)
            {
                int temp = 1;
                for (int j = 0; j < 3; j++)
                {
                    temp = temp * i;
                }
                if (temp == A)
                {
                    return 1;
                }
            }
            return 0;
        }
        #endregion
        #region Day 36 ass 4

        public int findMod(string A, int B)
        {
            long carry = (A[0] - '0');
            if (carry >= B)
            {
                carry = (A[0] - '0') % B;
            }

            for (int i = 1; i < A.Length; i++)
            {
                carry = carry * 10 + A[i] - '0';

                if (carry >= B)
                {
                    carry = carry % B;
                }

            }

            return (int)carry;
        }

        #endregion

        #region Day 91 ass 2

        public List<List<int>> permute(List<int> A)
        {
            List<List<int>> res = new List<List<int>>();
            int[] hash = new int[11];
            List<int> cur = new List<int>();
            for (int i = 0; i < A.Count; i++)
            {
                hash[A[i]]++;
            }
            fetch(res, hash, cur, A.Count);
            return res;
        }

        public void fetch(List<List<int>> res, int[] hash, List<int> cur, int n)
        {
            if (cur.Count == n)
            {
                res.Add(new List<int>(cur));
            }

            for (int i = 0; i < 11; i++)
            {
                if (hash[i] > 0)
                {
                    hash[i]--;
                    cur.Add(i);
                    fetch(res, hash, cur, n);
                    hash[i]++;
                    cur.RemoveAt(cur.Count - 1);
                }
            }
        }

        //public List<List<int>> permute(List<int> A)
        //{
        //    List<List<int>> res = new List<List<int>>();
        //    List<int> cur = new List<int>();
        //    fetch(A, 0, res);
        //    return res;
        //}

        //public void fetch(List<int> A, int i, List<List<int>> res)
        //{
        //    if (i >= A.Count)
        //    {
        //        if (Exist(res, A))
        //        {
        //            res.Add(new List<int>(A));
        //        }
        //    }

        //    for (int j = i; j < A.Count; j++)
        //    {
        //        swap(A, i, j);
        //        fetch(A, i + 1, res);
        //        swap(A, j, i);
        //    }
        //}

        //public void swap(List<int> A, int i, int j)
        //{
        //    int temp = A[i];
        //    A[i] = A[j];
        //    A[j] = temp;
        //}

        //public bool Exist(List<List<int>> res, List<int> cur)
        //{
        //    return !res.Any(x => x.Equals(cur));
        //}

        #endregion

        #region Day 91 ass 1

        public List<List<int>> subsets(List<int> A)
        {
            List<List<int>> res = new List<List<int>>();
            List<int> cur = new List<int>();
            A.Sort();
            //Set(A, 0, A.Count, cur, res);
            res.Sort(new ListComapre());
            return res;
        }

        class ListComapre : IComparer<List<int>>
        {
            public int Compare(List<int> x, List<int> y)
            {
                int i = 0;
                while (i < x.Count && i < y.Count)
                {
                    if (x[i] != y[i])
                    {
                        return x[i] - y[i];
                    }

                    i++;
                }

                return x.Count - y.Count;
            }

            public void Set(List<int> A, int i, int n, List<int> cur, List<List<int>> res)
            {
                if (i >= n)
                {
                    res.Add(new List<int>(cur));
                    return;
                }

                Set(A, i + 1, n, cur, res);
                cur.Add(A[i]);
                Set(A, i + 1, n, cur, res);
                cur.Remove(A[i]);
                return;
            }

            #endregion

            #region Day 32 ass 2

            public string addBinary(string A, string B)
            {
                int i = A.Length - 1;
                int j = B.Length - 1;
                int carry = 0;
                string temp = "";
                while (i >= 0 || j >= 0 || carry > 0)
                {
                    int sum = 0;
                    if (i >= 0)
                    {
                        sum += (A[i] - '0');
                        i--;
                    }

                    if (j >= 0)
                    {

                    }
                }

                string res = string.Empty;
                for (int q = temp.Length - 1; i >= 0; i--)
                {
                    res += temp[i];
                }

                return res;
            }

            #endregion

            #region Day 31 ass 1

            public int Day31ass1(string A)
            {
                int res = 0;
                int temp = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] == '1')
                    {
                        temp++;
                        if (i + 1 < A.Length && A[i + 1] == '0')
                        {
                            temp += Run(A, i + 1);
                            if (res < temp)
                            {
                                res = temp;
                            }

                            temp = 0;
                        }

                        if (res < temp)
                        {
                            res = temp;
                        }
                    }
                    else if (A[i] == '0' && i + 1 < A.Length && A[i + 1] == '0')
                    {
                        if (res < temp)
                        {
                            res = temp;
                        }

                        temp = 0;
                    }
                    else if (A[i] == '0' && i + 1 < A.Length && A[i + 1] == '1')
                    {
                        temp += Run(A, i + 1) + 1;
                        if (res < temp && res != 0)
                        {
                            res = temp;
                        }

                        temp = 0;
                    }

                }

                return res;
            }

            public int Day31ass11(string A)
            {
                return maximum_one(A);
            }

            public static int maximum_one(String s)
            {
                // To count all 1's in the string
                int cnt_one = 0;
                int n = s.Length;
                for (int i = 0; i < n; i++)
                {
                    if (s[i] == '1')
                        cnt_one++;
                }

                // To store cumulative 1's
                int[] left = new int[n];
                int[] right = new int[n];
                if (s[0] == '1')
                    left[0] = 1;
                else
                    left[0] = 0;

                if (s[n - 1] == '1')
                    right[n - 1] = 1;
                else
                    right[n - 1] = 0;
                for (int i = 1; i < n; i++)
                {
                    if (s[i] == '1')
                        left[i] = left[i - 1] + 1;
                    else
                        left[i] = 0;
                }

                for (int i = n - 2; i >= 0; i--)
                {
                    if (s[i] == '1')
                        right[i] = right[i + 1] + 1;

                    else
                        right[i] = 0;
                }

                int cnt = 0, max_cnt = 0;
                for (int i = 0; i < n; ++i)
                    max_cnt = Math.Max(max_cnt, Math.Max(right[i], left[i]));
                for (int i = 1; i < n - 1; i++)
                {
                    if (s[i] == '0')
                    {
                        int sum = left[i - 1] + right[i + 1];

                        if (sum < cnt_one)
                            cnt = sum + 1;

                        else
                            cnt = sum;

                        max_cnt = Math.Max(max_cnt, cnt);
                        cnt = 0;
                    }
                }

                return max_cnt;
            }

            public int Run(string A, int index)
            {
                int res = 1;
                for (int i = index + 1; i < A.Length; i++)
                {
                    if (A[i] == '1')
                    {
                        res++;
                    }
                    else
                    {
                        break;
                    }
                }

                return res;
            }

            #endregion

            #region Day 31 ass 2

            public int Day31ass2(List<int> A, List<int> B)
            {
                //int res = int.MaxValue;
                //for (int i = 0; i < A.Count - 2; i++)
                //{
                //    int temp = call(A, B, i, 2);
                //    if (temp < res&&temp!=-1)
                //    {
                //        res = temp;
                //    }
                //}
                //return res;
                int res = int.MaxValue;
                for (int j = 1; j < A.Count - 1; j++)
                {
                    int tempSum = int.MaxValue;
                    int resI = int.MaxValue;
                    int resK = int.MaxValue;
                    for (int i = 0; i < j; i++)
                    {
                        if (A[i] < A[j] && B[i] < resI)
                        {
                            resI = B[i];
                        }
                    }

                    for (int k = j + 1; k < A.Count; k++)
                    {
                        if (A[j] < A[k] && B[k] < resK)
                        {
                            resK = B[k];
                        }
                    }

                    if (res > B[j] + resI + resK && resK != int.MaxValue && resI != int.MaxValue)
                    {
                        res = B[j] + resI + resK;
                    }
                }

                if (res != int.MaxValue)
                {
                    return res;
                }
                else
                {
                    return -1;
                }
            }

            public int call(List<int> A, List<int> B, int index, int height)
            {

                if (index >= A.Count)
                {
                    return -1;
                }
                //if (height == 0 && A[index - 1] < A[index])
                //{
                //    return B[index];
                //}

                if (height == 0)
                {
                    return B[index];
                }


                int res = int.MaxValue;
                for (int i = index + 1; i < A.Count; i++)
                {
                    if (A[index] < A[i])
                    {
                        int temp = call(A, B, i, height - 1);
                        if (temp != -1 && temp < res)
                        {
                            res = temp;
                        }
                    }
                }

                if (res != int.MaxValue)
                {
                    return res + B[index];
                }

                return -1;
            }

            #endregion

            #region Day 26 ass2

            private int cntIndexesToMakeBalance(int[] arr, int n)
            {
                if (n == 1)
                {
                    return 1;
                }

                if (n == 2)
                    return 0;

                int sumEven = 0;
                int sumOdd = 0;

                for (int i = 0; i < n; i++)
                {
                    if (i % 2 == 0)
                    {
                        sumEven += arr[i];
                    }
                    else
                    {
                        sumOdd += arr[i];
                    }
                }

                int currOdd = 0;
                int currEven = arr[0];
                int res = 0;
                int newEvenSum = 0;
                int newOddSum = 0;

                for (int i = 1; i < n - 1; i++)
                {
                    if (i % 2 == 1)
                    {
                        currOdd += arr[i];
                        newEvenSum = currEven + sumOdd
                                     - currOdd;
                        newOddSum = currOdd + sumEven
                                    - currEven - arr[i];
                    }
                    else
                    {
                        currEven += arr[i];
                        newOddSum = currOdd + sumEven
                                    - currEven;
                        newEvenSum = currEven + sumOdd
                                     - currOdd - arr[i];
                    }

                    if (newEvenSum == newOddSum)
                    {
                        res++;
                    }
                }

                if (sumOdd == sumEven - arr[0])
                {
                    res++;
                }

                if (n % 2 == 1)
                {
                    if (sumOdd == sumEven - arr[n - 1])
                    {
                        res++;
                    }
                }
                else
                {
                    if (sumEven == sumOdd - arr[n - 1])
                    {
                        res++;
                    }
                }

                return res;
            }

            public int Day26ass21(List<int> A)
            {
                int n = A.Count;
                int[] a = new int[n];
                for (int i = 0; i < n; i++) a[i] = A[i];
                return cntIndexesToMakeBalance(a, n);
            }

            public int Day26ass2(List<int> A)
            {
                int res = 0;
                for (int i = 0; i < A.Count; i++)
                {
                    int even = 0;
                    int odd = 0;
                    //pre remove
                    for (int j = 0; j < i; j++)
                    {
                        if (j % 2 == 0)
                        {
                            even += A[j];
                        }
                        else
                        {
                            odd += A[j];
                        }
                    }

                    //after remove
                    for (int j = i + 1; j < A.Count; j++)
                    {
                        if ((j - 1) % 2 == 0)
                        {
                            even += A[j];
                        }
                        else
                        {
                            odd += A[j];
                        }
                    }

                    if (even == odd)
                    {
                        res++;
                    }
                }

                return res;
            }

            #endregion

            #region Day 26 ass1


            public int Day26ass1(List<int> A)
            {
                int[] pre = new int[A.Count];
                pre[0] = A[0];
                for (int i = 1; i < A.Count; i++)
                {
                    pre[i] = pre[i - 1] + A[i];
                }

                for (int i = 0; i < A.Count; i++)
                {
                    int left = (i == 0) ? 0 : pre[i - 1];
                    int right = (i == A.Count - 1) ? 0 : pre[A.Count - 1] - pre[i];
                    if (left == right)
                    {
                        return i;
                    }
                }

                return -1;
            }

            #endregion

            #region Day 30 ass8

            public void Day30ass8(List<List<int>> a)
            {
                for (int i = 0; i < a.Count; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        int temp = a[i][j];
                        a[i][j] = a[j][i];
                        a[j][i] = temp;
                    }
                }

                for (int i = 0; i < a.Count; i++)
                {
                    for (int j = 0; j < a.Count / 2; j++)
                    {
                        int temp = a[i][j];
                        a[i][j] = a[i][a.Count - 1 - j];
                        a[i][a.Count - 1 - j] = temp;
                    }
                }
            }

            #endregion

            #region Day 29 ass 2

            public int Day29ass2(List<int> A, int B)
            {
                int res = 0;

                for (int i = 1; i < A.Count; i++)
                {
                    A[i] += A[i - 1];
                }

                float avg = (float)A[B - 1] / B;
                for (int i = B; i < A.Count; i++)
                {
                    float temp = (float)(A[i] - A[i - B]) / B;
                    if (avg > temp)
                    {
                        avg = temp;
                        res = i - B + 1;
                    }
                }

                return res;
            }

            #endregion

            #region Day 26 ass 3

            public int Day26ass3(List<int> A, int B)
            {
                for (int i = 1; i < A.Count; i++)
                {
                    A[i] += A[i - 1];
                }

                int j = B;
                int n = A.Count - 1;
                int res = A[0];
                while (j >= 0)
                {
                    int temp;
                    if ((n + 1 - B - (B - j)) >= 0)
                        temp = A[n] - (A[n - (B - j)] - A[n + 1 - B - (B - j)]);
                    else
                        temp = A[n] - A[n - (B - j)];
                    if (temp > res)
                    {
                        res = temp;
                    }

                    j--;
                }

                return res;
            }

            #endregion

            #region Day 17 ass 5

            public List<int> Day17ass5(List<List<int>> A)
            {
                List<int> vs = new List<int>();
                for (int i = 0; i < A[0].Count; i++)
                {
                    int temp = A[0][i];
                    for (int j = 1; j < A.Count; j++)
                    {
                        temp += A[j][i];
                    }

                    vs.Add(temp);
                }

                return vs;
            }

            #endregion

            #region Day 73 ass 3

            public int Day73ass3(ListNode A)
            {
                ListNode fast = A;
                ListNode slow = A;
                while (fast.next != null && fast.next.next != null)
                {
                    fast = fast.next.next;
                    slow = slow.next;
                }

                return slow.val;
            }

            #endregion

            #region Day61 ass 3

            public int Sort613(List<int> A)
            {
                //A = Scaler.LocalSort(A);
                for (int i = 1; i < A.Count; i++)
                {
                    if (A[i - 1] + 1 != A[i])
                    {
                        return 0;
                    }
                }

                return 1;
            }

            public static List<int> LocalSort(List<int> A)
            {
                int i = 1;
                while (i < A.Count)
                {
                    if (A[i - 1] > A[i])
                    {
                        int temp = A[i];
                        A[i] = A[i - 1];
                        A[i - 1] = temp;
                        i = 1;
                    }
                    else
                    {
                        i++;
                    }
                }

                return A;
            }

            #endregion

            #region Day52 ass 4

            public int MaximunNumberofOne(List<List<int>> A)
            {
                int res = -1;
                int high = 0;
                for (int i = 0; i < A.Count; i++)
                {
                    int temp = 0;
                    for (int j = 0; j < A.Count; j++)
                    {
                        temp += A[i][j];
                    }

                    if (temp > high)
                    {
                        res = i;
                        high = temp;
                    }
                }

                return res;
            }

            #endregion

            #region Day 25 ass1

            public int[] RotationGame(int[] vs, int B)
            {
                int count = 0;
                int[] res = new int[vs.Length];
                while (count < vs.Length)
                {
                    int index = count + B;
                    if (index >= vs.Length)
                    {
                        index = index % vs.Length;
                    }

                    res[index] = vs[count];
                    count++;
                }

                for (int i = 0; i < res.Length; i++)
                {
                    Console.Write(res[i] + " ");
                }

                return res;
            }

            #endregion

            #region day 96 ass1

            public int coinchange2(List<int> A, int B)
            {
                int mod = 10000007;
                int[] ways = new int[B + 1];
                ways[0] = 1;

                for (int i = 0; i <= A.Count; i++)
                {
                    for (int j = A[i]; j <= B; j++)
                    {
                        ways[j] += ways[j - A[i]];
                        ways[j] %= mod;
                    }
                }

                return ways[B];
            }

            #endregion

            #region day 39 ass3

            public List<char> day39ass3(List<char> A)
            {
                List<char> res = new List<char>();
                for (int i = 0; i < A.Count; i++)
                {
                    if (A[i] - 'A' < 26 && A[i] - 'A' >= 0)
                    {
                        res.Add((char)('a' + (A[i] - 'A')));
                    }
                    else
                    {
                        res.Add(A[i]);
                    }
                }

                return res;
            }

            #endregion

            #region day 39 ass1

            public string day39ass1(string A)
            {
                if (A == "")
                {
                    return A;
                }

                string[] vs = A.Split(' ');
                string res = "";
                for (int i = 0; i < vs.Length; i++)
                {
                    if (vs[i] != "")
                    {
                        if (i != 0)
                        {
                            res += " ";
                        }

                        res += vs[i];
                    }
                }

                return res;
            }

            #endregion

            #region day 95 ass1

            public int solve(List<int> A, List<int> B, int C)
            {
                return weight(A, B, 0, C);
            }

            //Dictionary<string, int> cache = new Dictionary<string, int>();
            public int weight(List<int> V, List<int> W, int i, int j)
            {
                if (i > V.Count - 1 || j == 0)
                {
                    return 0;
                }

                if (cache.ContainsKey(i + "@" + j))
                {
                    return cache[i + "@" + j];
                }
                else
                {
                    int left = weight(V, W, i + 1, j);
                    int pick = 0;
                    if (j >= W[i])
                    {
                        pick = weight(V, W, i + 1, j - W[i]) + V[i];
                    }

                    if (left >= pick)
                    {
                        cache.Add(i + "@" + j, left);
                    }
                    else
                    {
                        cache.Add(i + "@" + j, pick);
                    }

                    return cache[i + "@" + j];
                }
            }

            #endregion

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

                    int right = Travel(A, i, j + 1);
                    int down = Travel(A, i + 1, j);

                    cache.Add(i + "@" + j, right + down);

                    return right + down;
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
                public bool isBst = false;
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
                string[] vs1 = input.Split(' ');
                int count = int.Parse(vs1[0]);
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
                    while (f != null && f.next != null)
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
                while (res.Count != A.Count)
                {
                    if (res.Count == 0)
                    {
                        res.Push(check);
                        check = input.Pop();
                    }
                    else if (res.Peek() > check)
                    {
                        input.Push(res.Pop());
                    }
                    else if (res.Peek() <= check)
                    {
                        res.Push(check);
                        if (input.Count != 0)
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
                        second = res.Pop();
                        first = res.Pop();
                        switch (A[i])
                        {
                            case "+":
                                res.Push(first + second);
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
                    while (res.Count > 0)
                    {
                        output += res.Pop();
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

                if (res.Count > 0)
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

                    temp = temp.next;
                }

                if (A != null)
                {
                    temp.next = A;
                }
                else
                {
                    temp.next = B;
                }

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
                    //res = res + (Scaler.pow(bit) * dig);
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

                int n = Move(A, B) % C;
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
                int n = A.Count;
                int left = 0, right = n - 1;
                int res = 0;
                int maxLeft = 0, maxRight = 0;
                while (left <= right)
                {
                    if (A[left] <= A[right])
                    {
                        if (A[left] >= maxLeft)
                        {
                            maxLeft = A[left];
                        }
                        else
                        {
                            res += maxLeft - A[left];
                        }

                        left++;
                    }
                    else
                    {
                        if (A[right] >= maxRight)
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
                    int L = B[i][0] - 1;
                    int R = B[i][1] - 1;
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

                int max = A[0], min = A[0];
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
}
