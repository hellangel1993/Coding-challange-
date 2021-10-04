using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    public class leetcode2
    {
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            int[] finish = new int[numCourses];
            List<List<int>> adj = new List<List<int>>();
            for (int i = 0; i < numCourses; i++)
            {
                adj.Add(new List<int>());
            }
            for (int i = 0; i < prerequisites.Length; i++)
            {
                adj[prerequisites[i][0]].Add(prerequisites[i][1]);
            }
            
            int[] visit= new int[numCourses];
            for (int i = 0; i < numCourses; i++)
            {
                if (visit[i]==0&&!CoursePath(adj,i,visit))
                {
                    return false;
                }
            }
            return true;
        }

        public bool CoursePath(List<List<int>> adj, int course,int[] visited)
        {
            if (visited[course] == 2)
            {
                return true;
            }
            if (visited[course]==1)
            {
                return false;
            }
            visited[course] = 1;
            for (int i = 0; i < adj[course].Count; i++)
            {
                if (!CoursePath(adj, adj[course][i], visited))
                {
                    return false;
                }
                
            }

            visited[course] = 2;

            return true;
        }

        //public bool FindPath(List<List<int>> adj, int[] visit, int node)
        //{
        //    if (adj[node].Count == 0)
        //    {
        //        return true;
        //    }
        //    visit[node] = 1;
        //    for (int i = 0; i < adj[node].Count; i++)
        //    {
        //        int temp = (adj[node][i]);
        //        if (visit[temp] != 1)
        //        {
        //            if (FindPath(adj, visit, temp) == false)
        //            {
        //                return false;
        //            }
        //        }
        //    }
        //    return true;
        //}


        static void Main(string[] args)
        {
            leetcode2 ls = new leetcode2();
            int[][] vs = new int[][] { new int[] { 1,0 },new int[] {1,2 }, new int[] { 3,2}, new int[] { 4,3}, new int[] { 5,4}, new int[] { 3,5 } };
            
            Console.WriteLine(ls.CanFinish(6, vs));
        }
    }
}
