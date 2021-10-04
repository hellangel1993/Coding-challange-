using System;
using System.Collections.Generic;

namespace techgig
{
    class geekforgeek_trapping_rain_water
    {
        IList<IList<int>> output = new List<IList<int>>();
        int n, k;

        public IList<IList<int>> Subsets(int[] nums)
        {
            n = nums.Length;
            for (k = 0; k < n + 1; ++k)
            {
                Backtrack(0, new List<int>(), nums);
            }


            return output;
        }

        public void Backtrack(int first, List<int> curr, int[] nums)
        {
            if (curr.Count == k)
            {
                output.Add(new List<int>(curr));
                return;
            }

            for (int i = first; i < n; ++i)
            {
                curr.Add(nums[i]);
                Backtrack(i + 1, curr, nums);
                curr.Remove(curr.Count - 1);
            }
        }


        bool areTrianglesSimilar(int[] coordinates)
        {
            int[] a1 = { coordinates[0], coordinates[1] };
            int[] a2 = { coordinates[6], coordinates[7] };
            int[] b1 = { coordinates[2], coordinates[3] };
            int[] b2 = { coordinates[8], coordinates[9] };
            int[] c1 = { coordinates[4], coordinates[5] };
            int[] c2 = { coordinates[10], coordinates[11] };

            if (a1[0] == 0 && a1[1] == 0)
            {
                if (a2[0] != 0 || a2[1] != 0)
                {
                    return false;
                }
            }


            int B1 = (b1[0] - a1[0] == 0) ? (b1[1] - a1[1]) : (b1[0] - a1[0]);
            int C1 = (c1[0] - a1[0] == 0) ? (c1[1] - a1[1]) : (c1[0] - a1[0]);
            int B2 = (b2[0] - a2[0] == 0) ? (b2[1] - a2[1]) : (b2[0] - a2[0]);
            int C2 = (c2[0] - a2[0] == 0) ? (c2[1] - a2[1]) : (c2[0] - a2[0]);

            if (((double)B1 / (double)C1) == ((double)B2 / (double)C2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsValidSudoku(string[][] board)
        {
            for (int i = 0; i < 9; i++)
            {
                List<string> r = new List<string>();
                List<string> c = new List<string>();
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] != ".")
                    {
                        if (r.Contains(board[i][j]))
                        {
                            return false;
                        }
                        else
                        {
                            r.Add(board[i][j]);
                        }
                    }
                    if (board[j][i] != ".")
                    {
                        if (c.Contains(board[j][i]))
                        {
                            return false;
                        }
                        else
                        {
                            c.Add(board[j][i]);
                        }
                    }
                }
                if (r.Count == 0 || c.Count == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(String[] args)
        {
            int[] n = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };

            geekforgeek_trapping_rain_water abc = new geekforgeek_trapping_rain_water();
            int[] a = { 0, 0, 0, 5, 4, 0, 0, 0, 4, 3, 4, 0 };

            string[][] matrix = {new string[]{ ".", ".", ".", ".", "5", ".", ".", "1", "." }
                                ,new string[]{ ".", "4", ".", "3", ".", ".", ".", ".", "." }
                                ,new string[]{ ".", ".", ".", ".", ".", "3", ".", ".", "1" }
                                ,new string[]{ "8", ".", ".", ".", ".", ".", ".", "2", "." }
                                ,new string[]{ ".", ".", "2", ".", "7", ".", ".", ".", "." }
                                ,new string[]{ ".", "1", "5", ".", ".", ".", ".", ".", "." }
                                ,new string[]{ ".", ".", ".", ".", ".", "2", ".", ".", "." }
                                ,new string[]{ ".", "2", ".", "9", ".", ".", ".", ".", "." }
                                ,new string[]{ ".", ".", "4", ".", ".", ".", ".", ".", "." } };
            abc.IsValidSudoku(matrix);
            abc.areTrianglesSimilar(a);
            //IList<IList<int>> list = abc.Subsets(n);
        }
    }
    public class path
    {
        int startingshop = 0;
        int endshop = 0;
        int travelWeight = 0;

        public path(int x, int y, int c)
        {
            startingshop = x;
            endshop = y;
            travelWeight = c;
        }
    }

}
