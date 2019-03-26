using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class google
    {
        static void Main(string[] args)
        {
            string str = "abcdbwa";
            IDictionary<char, int> keys = new Dictionary<char,int>();
            for (int i = 0; i < str.Length; i++)
            {
                try
                {
                    keys[str[i]] += 1;
                }
                catch (Exception)
                {
                    keys.Add(str[i], 1);
                }
            }
            foreach (var item in keys)
            {
                if (item.Value>1)
                {
                    Console.Write(item.Key);
                }
            }
            Console.ReadLine();
        }
    }
}   