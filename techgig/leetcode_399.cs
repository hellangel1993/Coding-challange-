using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class leetcode_399
    {
        public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
        {
            Dictionary<string, List<node>> adj = new Dictionary<string, List<node>>();
            for (int i = 0; i < equations.Count; i++) 
            {
                if (adj.ContainsKey(equations[i][0]))
                {
                    adj[equations[i][0]].Add(new node(equations[i][1],values[i]));
                }
                else
                {
                    adj.Add(equations[i][0],new List<node>());
                    adj[equations[i][0]].Add(new node(equations[i][1],values[i]));
                }

                if (adj.ContainsKey(equations[i][1]))
                {
                    adj[equations[i][1]].Add(new node(equations[i][0], 1 / values[i]));
                }
                else
                {
                    adj.Add(equations[i][1], new List<node>());
                    adj[equations[i][1]].Add(new node(equations[i][0], 1 / values[i]));
                }
            }
            List<double> result=new List<double>();
            foreach (List<string> item in queries)
            {
                result.Add(dfs(item[0], item[1], new List<string>(), adj));
            }

            return result.ToArray();
        }

        private double dfs(string s,string d,List<string> visited, Dictionary<string, List<node>> adj)
        {
            

            if (!(adj.ContainsKey(s) && adj.ContainsKey(d)))
            {
                return -1.0;
            }

            if (s.Equals(d))
            {
                return 1.0;
            }

            visited.Add(s);

            foreach (node item in adj[s])
            {
                if (!(visited.Contains(item.final)))
                {
                    double temp=dfs(item.final,d,visited, adj);
                    if (temp == -1.0)
                    {
                        //return -1.0;
                    }
                    else
                    {
                        return temp * item.weight;
                    }
                }
            }

            return -1.0;
        }

        static void Main(string[] args)
        {
            leetcode_399 leetcode_399=new leetcode_399();
            List<IList<string>> equations = new List<IList<string>>();
            double[] vs1 = new double[] { 3.0,4.0,5.0,6.0 };
            List<IList<string>> que =new List<IList<string>>();
            equations.Add(new List<string>() { "x1", "x2" });
            equations.Add(new List<string>() { "x2", "x3" });
            equations.Add(new List<string>() { "x3", "x4" });
            equations.Add(new List<string>() { "x4", "x5" });
            que.Add(new List<string>() { "x1", "x5" });
            que.Add(new List<string>() { "x5", "x2" });
            que.Add(new List<string>() { "x2", "x4" });
            que.Add(new List<string>() { "x2", "x2" });
            que.Add(new List<string>() { "x2", "x9" });
            que.Add(new List<string>() { "x9", "x9" });

            leetcode_399.CalcEquation(equations, vs1, que);

            
        }
    }
    public class node
    {
        public String final;
        public double weight;

        public node(string f, double w)
        {
            final = f;
            weight = w;
        }
    }
}
