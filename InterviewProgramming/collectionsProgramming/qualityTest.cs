using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProgramming.collectionsProgramming
{
    public  class qualityTest
    {
        public void sentenceReverse()
        {
            string str = "welcome to india";

            string[] strSplit = str.Split(" ");

            List<string> store = new List<string>();

            for (int i = strSplit.Length - 1; i >= 0; i--)
            {
                store.Add(strSplit[i]);
            }

            string newStore = string.Join(" ", store);
            Console.WriteLine(newStore);

            string[] newStr = newStore.Split(" ");
            List<string> revStore = new List<string>();

            for (int i = 0; i < newStr.Length; i++)
            {
                var charArray = store[i].ToCharArray();
                revStore.Add(reverseLetter(charArray));
            }

            string joinrev = string.Join(" ", revStore);
            Console.WriteLine(joinrev);

        }

        public static string reverseLetter(char[] charArray)
        {
            List<char> charList = new List<char>();

            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                charList.Add(charArray[i]);
            }
            return new string(charList.ToArray());
        }
    }
    
}
