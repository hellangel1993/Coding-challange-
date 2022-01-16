using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    internal class Leetcode_15
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            if (nums.Length == 0)
            {
                return new List<IList<int>>();
            }
            else if (nums.Length == 1 && nums[0] == 0)
            {
                return new List<IList<int>>();
            }
            List<IList<int>> res = new List<IList<int>>();


            res.AddRange(cal(nums));

            return res;
        }

        public IList<IList<int>> cal(int[] list)
        {
            List<IList<int>> res = new List<IList<int>>();
            for (int prod = 0; prod < list.Length; prod++)//i
            {
                for (int i = 0; i < list.Length; i++)//j
                {
                    if (prod != i)
                    {
                        for (int j = 0; j < list.Length; j++)//k
                        {
                            if (j == i || j == prod)
                            {
                                continue;
                            }
                            else if (prod != i && i != j && prod != j)
                            {
                                if ((list[prod] + list[i] + list[j]) == 0)
                                {
                                    if (res.Count != 0)
                                    {
                                        bool flag = false;
                                        foreach (List<int> item in res)
                                        {
                                            if ((item.Contains(list[prod])) && (item.Contains(list[i])) && (item.Contains(list[j])))
                                            {
                                                if (list[prod] == list[i] && list[prod] == list[j] && list[i] == list[j] && (item[0] != list[i] || item[1] != list[i] || item[2] != list[i]))
                                                {
                                                    flag = true;
                                                }
                                                else
                                                {
                                                    flag = false;
                                                    break;
                                                }
                                            }
                                            else
                                            {
                                                flag = true;

                                            }
                                        }
                                        if (flag)
                                        {
                                            res.Add(new List<int>() { list[prod], list[i], list[j] });
                                        }
                                    }
                                    else
                                    {
                                        res.Add(new List<int>() { list[prod], list[i], list[j] });
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return res;
        }


        public int LongestSubsequence(int[] arr, int difference)
        {
            Dictionary<int, int> vs = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (vs.ContainsKey(arr[i] - difference))
                {
                    if (vs.ContainsKey(arr[i]))
                    {
                        vs[arr[i]] = (vs[(arr[i] - difference)] + 1);
                    }
                    else
                    {
                        vs.Add(arr[i], (vs[(arr[i] - difference)] + 1));
                    }

                }
                else
                {
                    if (!vs.ContainsKey(arr[i]))
                    {
                        vs.Add(arr[i], 1);
                    }
                }
            }

            int res = 1;
            foreach (KeyValuePair<int, int> a in vs)
            {
                if (a.Value > res)
                {
                    res = a.Value;
                }
            }

            return res;
        }

        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums.Length == 0)
            {
                return null;
            }

            return Construct(nums, 0, nums.Length-1);
        }

        public TreeNode Construct(int[] nums, int left, int right)
        {
            if (left > right)
            {
                return null;
            }
            int midPoint = left + (right - left) / 2;
            TreeNode node = new TreeNode(nums[midPoint]);
            node.left = Construct(nums, left, midPoint - 1);
            node.right = Construct(nums, midPoint + 1, right);
            return node;
        }


        static void Main(string[] args)
        {
            Leetcode_15 leetcode_15 = new Leetcode_15();

            //leetcode_15.ThreeSum(new int[] { 0,0, 0 });

            //leetcode_15.LongestSubsequence(new int[] { 1, 5, 7, 8, 5, 3, 4, 2, 1 }, -2);

            leetcode_15.SortedArrayToBST(new int[] { -10, -3, 0, 5, 9 });
        }
    }

    public class TreeNode1
    {
        public int val;
        public TreeNode1 left;
        public TreeNode1 right;
        public TreeNode1(int val = 0, TreeNode1 left = null, TreeNode1 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

}
