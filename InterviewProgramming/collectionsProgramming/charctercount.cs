using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProgramming.collectionsProgramming
{
    public class charctercount
    {
        public void countChar()
        {
            string str = "SHISHIR";
            var num = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (num.ContainsKey(c))
                {
                    num[c]++;
                }
                else
                {
                    num[c] = 1; // First occurrence
                }

                Console.WriteLine($"char = {c} count = {num[c]}");
            }
        }





    }
}
