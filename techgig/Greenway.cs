using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace techgig
{
//    Write a C# Sharp program to shift an element in left direction and return a new array.
//Sample Input:
//{ 10, 20, -30, -40, 50 }
//Expected Output :
//New array: 20 - 30 - 40 50 10
    internal class Greenway
    {
        public int[] Solution(int[] nums)
        {

            if (nums == null || nums.Length == 0)
            {
                return new int[0];
            }

            int[] result = new int[nums.Length];
            result[nums.Length-1]=nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                result[i - 1] = nums[i];
            }

            return result;
        }
        
        static void Main(string[] args)
        {
            int[] vs = { 5};
           
            Greenway greenway = new Greenway();
            int[] vs2=greenway.Solution(vs);

            foreach (var item in vs2)
            {
                Console.WriteLine(item);
            }


            

            
        }

         public int a = 1;

        public abstract class Greenway2
        {
            
        }
    }
}
