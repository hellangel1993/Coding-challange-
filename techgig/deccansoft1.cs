using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
     public struct user
    {
        public int A;
        public string B;
    }
    class deccansoft1
    {
        static void Main(String[] args)
        {
            string str = Console.ReadLine();
            Operation(str);
        }
        static void Operation(string str)
        {
            string a="";
            IList<string> vs=new List<string>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString()==" "||str[i].ToString()=="."||str[i].ToString()==",")
                {
                    vs.Add(a);
                    a = "";
                }
                else
                {
                    a += str[i].ToString();
                }
            }
            if (str[str.Length-1].ToString()!=".")
            {
                vs.Add(a);
                a = "";
            }
            int b = vs.Count;//it gives the count of the list.and index starts from 0.....
            user[] users = new user[1];
            for (int i = 0; i < vs.Count; i++)
            {
                 String c= vs[i].ToString();
                users[i].B = c;
                users[i].A=CountOperation(vs, vs[i]);                
            }
        }
        static int  CountOperation(IList<string> list,string a)
        {
            int count = 0;
            int i = 0;
            while (i<list.Count)
            {
                if (a==list[i])
                {
                    count++;
                    list.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
            return count;
        }
    }
}
