﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace techgig
{
    /*
     * Given the roots of two binary trees p and q, write a function to check if they are the same or not.

Two binary trees are considered the same if they are structurally identical, and the nodes have the same value.

 

Example 1:


Input: p = [1,2,3], q = [1,2,3]
Output: true
Example 2:


Input: p = [1,2], q = [1,null,2]
Output: false
Example 3:


Input: p = [1,2,1], q = [1,1,2]
Output: false
 

Constraints:

The number of nodes in both trees is in the range [0, 100].
-104 <= Node.val <= 104
     */


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
    class Graph_Same_tree
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            bool flag = false;

            if (p.val == q.val)
            {
                if (p.left != null && q.left != null)
                {
                    flag = IsSameTree(p.left, q.left);
                }
                else if (p.left != null && q.left == null || p.left == null && q.left != null)
                {
                    return false;
                }
                else
                {
                    flag = true;
                }
                if (flag)
                {
                    if (p.right != null && q.right != null)
                    {
                        flag = IsSameTree(p.right, q.right);
                    }
                    else if (p.right != null && q.right == null || p.right == null && q.right != null)
                    {
                        return false;
                    }
                    else
                    {
                        flag = true;
                    }
                }
            }

            return flag;
        }


        public static void Main(String[] args)
        {
            Graph_Same_tree sr = new Graph_Same_tree();
            TreeNode root = new TreeNode(1, new TreeNode(2, null, null), new TreeNode(3, null, null));
            TreeNode root1 = new TreeNode(1, new TreeNode(2, null, null), new TreeNode(3, null, null));

            TreeNode root2 = new TreeNode();
            TreeNode root3 = new TreeNode();
            Console.WriteLine(sr.IsSameTree(root2, root3));
        }
    }
}