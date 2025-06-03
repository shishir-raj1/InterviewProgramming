using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProgramming.collectionsProgramming
{
    public class stringQuestions
    {

        public void changeString()
        {
            string str = "Automation Test Engineer";
            //o/p = Automation tset Engineer
            string[] splitStr = str.Split(" ");

            for (int i = 0; i < splitStr.Length; i++)
            {
                if (splitStr[i] == "Test")
                {

                    splitStr[i] = reverseStr(splitStr[i]);
                    //Console.WriteLine(splitStr[i]);
                }
                
            }

            string full = string.Join(" ", splitStr);
            Console.WriteLine(full);

        }

        public string reverseStr(string newstr)
        {
            string rev = " ";

            for (int i = newstr.Length -1; i>=0 ; i--)
            {
                rev = rev + newstr[i];
            }
            return rev;
        }
    }
}
