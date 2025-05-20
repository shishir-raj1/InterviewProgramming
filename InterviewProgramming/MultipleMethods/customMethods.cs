using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProgramming.MultipleMethods
{
    public class customMethods
    {
        public void freqCount()
        {
            int[] arr = { 1, 2, 3, 7, 2, 5, 8, 1, 7, 3 };

            var num = new Dictionary<int, int>();

            foreach(int i in arr)
            {
                if (num.ContainsKey(i))
                {
                    num[i]++;
                }
                else
                {
                    num[i] = 1;
                }
            }
            foreach(var j in num)
            {
                Console.WriteLine($"number = {j.Key}, count = {j.Value}");
            }
        }

    }
}
