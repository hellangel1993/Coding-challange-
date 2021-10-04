using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class Leetcode_200
    {
        public int NumIslands(char[][] grid)
        {
            int island = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] != '2' && grid[i][j] != '0')
                    {
                        grid[i][j] = '2';
                        find(grid, i, j);
                        island++;
                    }
                }
            }

            return island;
        }

        public void find(char[][] grid, int i, int j)
        {
            //top
            if (i > 0)
            {
                if (grid[i - 1][j] != '0' && grid[i - 1][j] != '2')
                {
                    grid[i - 1][j] = '2';
                    find(grid, i - 1, j);
                }
            }
            //down
            if (i < (grid.Length - 1))
            {
                if (grid[i + 1][j] != '0' && grid[i + 1][j] != '2')
                {
                    grid[i + 1][j] = '2';
                    find(grid, i + 1, j);
                }
            }
            //left
            if (j > 0)
            {
                if (grid[i][j - 1] != '0' && grid[i][j - 1] != '2')
                {
                    grid[i][j - 1] = '2';
                    find(grid, i, j - 1);
                }
            }
            //right
            if (j < grid[i].Length - 1)
            {
                if (grid[i][j + 1] != '0' && grid[i][j + 1] != '2')
                {
                    grid[i][j + 1] = '2';
                    find(grid, i, j + 1);
                }
            }
        }

        static void Main(string[] args)
        {
            Leetcode_200 leetcode = new Leetcode_200();
            char[][] vs = new char[][] { new char[] { '1', '1', '0', '0', '0' }, new char[] { '1', '1', '0', '0', '0' }, new char[] { '0', '0', '1', '0', '0' }, new char[] { '0', '0', '0', '1', '1' } };
            int a=leetcode.NumIslands(vs);
        }
    }//[["1","1","0","0","0"],["1","1","0","0","0"],["0","0","1","0","0"],["0","0","0","1","1"]]
}
