using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class techgig14
    {
        static void Main(String[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            string[] vs = new string[a];
            for (int i = 0; i < a; i++)
            {
                vs[i] = Console.ReadLine();
            }
            for (int l = 0; l < a; l++)
            {
                for (int j = 0; j < a; j++)
                {
                    if ( vs[l][0] == vs[j][0])
                    {
                        for (int k = 0; k < vs[l].Length; k++)
                        {
                            try
                            {
                                if (vs[l][k] > vs[j][k] && vs[l][k - 1] == vs[j][k - 1])
                                {
                                    string temp = "";
                                    temp = vs[j];
                                    vs[j] = vs[l];
                                    vs[l] = temp;
                                    break;
                                }
                            }
                            catch (Exception)
                            {
                                continue;
                            }
                            
                        }
                    }
                    else if (vs[l][0] > vs[j][0])
                    {
                        for (int k = 0; k < vs[l].Length; k++)
                        {
                            try
                            {
                                if (vs[l][k] > vs[j][k] )
                                {
                                    string temp = "";
                                    temp = vs[j];
                                    vs[j] = vs[l];
                                    vs[l] = temp;
                                    break;
                                }
                            }
                            catch (Exception)
                            {
                                continue;
                            }

                        }
                    }

                }
            }
            for (int m = a-1; m >= 0; m--)
            {
                Console.WriteLine(vs[m]);
            }            
                
            
            //for (int j = 0; j < a; j++)
            //{
            //    for (int k = j; k < a; k++)
            //    {
            //        char[]  b = new char[vs[j].Length];
            //        char[] c = new char[vs[k].Length];
            //        foreach (char d in vs[j])
            //        {
            //            int l = 0;
            //            b[l] = d;
            //            l++;
            //        }
            //        foreach (char e in vs[k])
            //        {
            //            int m = 0;
            //            c[m] = e;
            //            m++;
            //        }
            //        for (int n = 0; n < vs[j].Length; n++)
            //        {

            //        }
            //    }
            //}
            Console.ReadLine();
        }
    }
}
