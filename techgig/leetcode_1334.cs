using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class leetcode_1334
    {
        public int FindTheCity(int n, int[][] edges, int distanceThreshold)
        {
            Dictionary<int, List<node1334>> adj = new Dictionary<int, List<node1334>>();
            for (int i = 0; i < edges.Length; i++)
            {
                if (adj.ContainsKey(edges[i][0]))
                {
                    adj[edges[i][0]].Add(new node1334(edges[i][1], edges[i][2]));
                }
                else
                {
                    adj.Add(edges[i][0], new List<node1334>());
                    adj[edges[i][0]].Add(new node1334(edges[i][1], edges[i][2]));
                }

                if (adj.ContainsKey(edges[i][1]))
                {
                    adj[edges[i][1]].Add(new node1334(edges[i][0], edges[i][2]));
                }
                else
                {
                    adj.Add(edges[i][1], new List<node1334>());
                    adj[edges[i][1]].Add(new node1334(edges[i][0], edges[i][2]));
                }
            }

            List<int> a = new List<int>();

            for (int i = 0; i < n; i++)
            {
                a.Add(dfs(distanceThreshold,adj,new List<int>(),i,0));
            }

            return 0;
        }

        private int dfs(int dist, Dictionary<int, List<node1334>> adj, List<int> visited, int s, int cover)
        {
            if (visited.Contains(s))
            {
                return 0;
            }
            visited.Add(s);
            int count = 0;
            for (int i = 0; i < adj[s].Count; i++)
            {
                if ((cover + adj[s][i].weight) <= dist&&!(visited.Contains(adj[s][i].final)))
                {
                    cover += adj[s][i].weight;
                    int co = (dfs(dist, adj, visited, adj[s][i].final, cover));
                    if (co>=count)
                    {
                        count = co;
                    }
                    cover-=adj[s][i].weight;
                    count++;
                }
                else
                {
                    //return 0;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            int[][] edge = { new int[] { 0, 1, 3 }, new int[] { 1, 2, 1 }, new int[] { 1, 3, 4 }, new int[] { 2, 3, 1 } };

            leetcode_1334 leetcode_1334=new leetcode_1334();
            leetcode_1334.FindTheCity(4, edge, 4);
        }
    }

    public class node1334
    {
        public int final;
        public int weight;

        public node1334(int f, int w)
        {
            final = f;
            weight = w;
        }
    }
}

