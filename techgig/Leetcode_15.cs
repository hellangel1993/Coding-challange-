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

        static void Main(string[] args)
        {
            Leetcode_15 leetcode_15= new Leetcode_15();

            leetcode_15.ThreeSum(new int[] { 0,0, 0 });
        }
    }
}
