using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{

    class Graph_Max_Depth_of_binary_tree
    {
        public int MaxDepth(TreeNode root)
        {
            int count = 1;
            if (root == null)
            {
                return 0;
            }
            if (root.left == null && root.right == null)
            {
                return count;
            }
            if (root.left != null || root.right != null)
            {
                int a=MaxDepth(root.left);
                int b=MaxDepth(root.right);
                if (a < b)
                {
                    count += b;
                }
                else
                {
                    count+=a;
                }
            }
            return count;
        }

        public int IsCheck(TreeNode root, int count)
        {
            bool flag = false;
            if (MaxDepth(root.left) != 0)
            {
                flag = true;
            }
            if (MaxDepth(root.right) != 0)
            {
                flag = true;
            }
            if (flag||count==0)
            {
                return (count + 1);
            }
            else
            {
                return count;
            }
        }
        public static void Main(String[] args)
        {
            TreeNode root15 = new TreeNode(15,null,null);
            TreeNode root7 = new TreeNode(7,null,null);
            TreeNode root20=new TreeNode(20,root15,root7);
            TreeNode root9=new TreeNode(9,null,null);
            TreeNode root3=new TreeNode(3,root9,root20);

            Graph_Max_Depth_of_binary_tree sr=new Graph_Max_Depth_of_binary_tree();

            Console.WriteLine(sr.MaxDepth(root3));
        }
    }

}
