using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProgramming.Practice
{
    internal class demoCode
    {

        public void reverseM()
        {
            string str = "SHISHIR";
            string rev = "";

            for(int i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i];
            }
            Console.WriteLine(rev);
        }
 
    }
}
