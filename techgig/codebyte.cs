using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
    class MainClass
    {
        #region hard
        public static string Calculator(string str)
        {

            // code goes here 
            MainClass nc = new MainClass();
            int result = nc.EvalExpression(str.ToCharArray());
            Console.WriteLine(result);
            return str;

        }

        public int EvalExpression(char[] exp)
        {
            Stack<int> vStack = new Stack<int>();
            Stack<char> opStack = new Stack<char>();
            opStack.Push('(');
            int pos = 0;
            while (pos <= exp.Length)
            {
                if (pos == exp.Length || exp[pos] == ')')
                {
                    ProcessClosing(vStack, opStack);
                    pos++;
                }
                else if (exp[pos] >= '0' && exp[pos] <= '9')
                {
                    pos = ProcessInputN(exp, pos, vStack);
                }
                else
                {
                    ProcessInpitOP(exp[pos], vStack, opStack);
                    pos++;
                }
            }
            return vStack.Pop();
        }

        public void ProcessClosing(Stack<int> vStack, Stack<char> opStack)
        {
            while ((opStack.Peek()) != '(')
            {
                ExcuteOp(vStack, opStack);
            }

            opStack.Pop();
        }
        public int ProcessInputN(char[] exp, int pos, Stack<int> vStack)
        {
            int value = 0;
            while (pos < exp.Length && exp[pos] >= '0' && exp[pos] <= '9')
            {
                value = 10 * value + (int)(exp[pos++] - '0');
            }

            vStack.Push(value);

            return pos;
        }

        public void ProcessInpitOP(char op, Stack<int> vStack, Stack<char> opStack)
        {
            while (opStack.Count > 0 && Operatorcauseeval(op, opStack.Peek()))
            {
                ExcuteOp(vStack, opStack);
            }
            opStack.Push(op);
        }

        public bool Operatorcauseeval(char op, char prevOp)
        {
            bool evalute = false;
            switch (op)
            {
                case '+':
                case '-':
                    evalute = (prevOp != '(');
                    break;
                case '*':
                case '/':
                    evalute = (prevOp == '*' || prevOp == '/');
                    break;
                case ')':
                    evalute = true;
                    break;
            }
            return evalute;
        }

        public void ExcuteOp(Stack<int> vStack, Stack<char> opStack)
        {
            int right = vStack.Pop();
            int left = vStack.Pop();
            char op = opStack.Pop();

            int result = 0;
            switch (op)
            {
                case '+':
                    result = left + right;
                    break;
                case '-':
                    result = left - right;
                    break;
                case '*':
                    result = left * right;
                    break;
                case '/':
                    result = left / right;
                    break;
            }

            vStack.Push(result);
        }


        #endregion

        #region mediam
        public static string CountingMinutes(string str)
        {

            // code goes here  
            string[] t = str.Split('-');
            MainClass mc = new MainClass();
            int tfrom = mc.getminute(t[0]);
            int tto = mc.getminute(t[1]);

            Console.WriteLine(tfrom + " " + tto);
            int result = 0;
            bool flag=false;

            if (t[0].Contains("am") && t[1].Contains("am"))
            {
                flag = true;
            }
            else if (t[0].Contains("pm") && t[1].Contains("pm"))
            {
                flag = true;
            }
            if (tfrom > tto&&flag)
            {
                result = (tto+(24*60)) - tfrom;
            }
            else if(flag==false)
            {
                result = (tto+(12*60))-tfrom;
            }
            else
            {
                result = (tto) - tfrom;
            }

            Console.WriteLine(result);
            return str;

        }

        public int getminute(string h)
        {
            int min = 0;
            string[] str = h.Split(':');
            if (str[1].Contains("am"))
            {
                min += 60 * (Convert.ToInt32(str[0]));
            }
            else
            {
                min += 60 * (Convert.ToInt32(str[0]));
            }

            min += (Convert.ToInt32(str[1].Substring(0, 2)));

            return min;
        }

        static void Main()
        {
            // keep this function call here
            Console.WriteLine(CountingMinutes("1:23pm-1:08pm"));
            //Console.WriteLine(CountingMinutes("12:30pm-12:00am")); 
        }
        #endregion

        //static void Main()
        //{
        //    // keep this function call here
        //    Console.WriteLine(Calculator("6*(4/2)+3*1"));
        //}

    }
}
