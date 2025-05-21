using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProgramming.MultipleMethods
{
    public class customMethods
    {

        public void reverseOrder()
        {
            int[] arr = { 5, 4, 3, 4 };
            int rev;

            for(int i =arr.Length-1;i>=0;i--)
            {
                rev =  arr[i];
                Console.WriteLine(rev);
            }
            
        }


        public void largestNumber()
        {
            int[] arr = { 5, 4, 3, 4 };
            int largest = arr[0];

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > largest)
                {
                    largest = arr[i];
                }
                
            }
            Console.WriteLine(" Largest number" +largest);
        }


        public void LargestNumber()
        {
            Console.WriteLine("Enter numbers separated by space:");
            string input = Console.ReadLine();

            string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            List<int> numbers = new List<int>();

            foreach (var token in tokens)
            {
                if (int.TryParse(token, out int num))
                {
                    numbers.Add(num);
                }
                else
                {
                    Console.WriteLine($"Invalid input skipped: {token}");
                }
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine("No valid numbers entered.");
                return;
            }

            int largest = numbers[0];

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }
            }

            Console.WriteLine("Largest number: " + largest);
        }


        public void smallestNumber()
        {
            int[] arr = { 12, 34, 6, 23, 54 };

            int smallest = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                }
            }
            Console.WriteLine(smallest);
        }

        public void factorialNum()
        {
            //5! = 5*4*3*2*1 =120
            int input = 5;
            int result = 1;

            for(int i = 1;i<=input;i++)
            {
                result = result * i;
            }
            Console.WriteLine(result);
        }

        public int fac(int n)
        {
            
           if(n == 1)
            {
                return n;
            }
            else
            {
                return n * fac(n - 1);
            }   

        }

        public void fibonacciNum()
        {
            //0 1 1 2 3 5 8
            int input = 6;
            int num1 = 0;
            int num2 = 1;
            int num3;

            for(int i = 1; i <= input; i++)
            {
                Console.WriteLine(num1);
                num3 = num1 + num2;
                num1 = num2;
                num2 = num3;
                
            }
           
        }



        public void sentencereverse()
        {
            //enter input
            string str = "Test Automation Engineer";
            //split input in sentence to words
            string[] strSplit = str.Split(" ");
            //create a list to store  them
            List<string> strStore = new List<string>();
            //addd them in list from end index to reverse them
            for(int i = strSplit.Length - 1; i >= 0; i--)
            {
                strStore.Add(strSplit[i]);
            }
            // join them in sentence
            string newStr = string.Join(" ", strStore);
            Console.WriteLine(newStr);

            string[] newStrSplit = newStr.Split(" ");

            List<string> newStore = new List<string>();

            //customMethods ct = new customMethods();

            for (int i = 0; i < newStrSplit.Length; i++)
            {
                var charArray = newStrSplit[i].ToCharArray();

                newStore.Add(reverseLetter(charArray));
            }
            Console.WriteLine(string.Join(" ", newStore));


        }

        public void reverrseLetterSentence(string newStr)
        {
            string[] newStrSplit = newStr.Split(" ");

            List<string> newStore = new List<string>();

            //customMethods ct = new customMethods();

            for (int i = 0; i < newStrSplit.Length; i++)
            {
                var charArray = newStrSplit[i].ToCharArray();

                 newStore.Add(reverseLetter(charArray));
            }
            Console.WriteLine(string.Join(" ", newStore));
        }

        public void reverseString(string str)
        {
            string rev = "";
            for(int i=str.Length-1; i>=0; i--)
            {
                rev = rev + str[i];
            }
            Console.WriteLine(rev);
        }


        public string reverseLetter(char[] charArray)
        {
            List<char> charList = new List<char>();

            for(int i = charArray.Length - 1; i >= 0; i--)
            {
                charList.Add(charArray[i]);
            }

            return new string (charList.ToArray());
        }




















































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

        public void duplicateNum()
        {
            Console.WriteLine("Enter number");
            int[] arr = { 1, 2, 5, 1, 2, 5, 8 };

            var num = new Dictionary<int, int>();

            foreach(var j in arr)
            {
                if (num.ContainsKey(j))
                {
                    num[j]++;
                }
                else
                {
                    num[j] = 1;
                }
            }

            Console.WriteLine("Duplicate num");
            foreach(var i in num)
            {
                if (i.Value > 1)
                {
                    Console.WriteLine($" {i.Key} appears {i.Value} times");
                }
            }

            Console.WriteLine("removing duplicate and printing the unique number");

            foreach(var k in num)
            {
                if(k.Value == 1)
                {
                    Console.WriteLine($"num {k.Key}");
                }
            }

            Console.WriteLine("non- repeating");

            foreach(var l in arr)
            {
                if (num[l] == 1)
                {
                    Console.WriteLine(l + " ");
                }
            }

            var number = new HashSet<int>();
            Console.WriteLine("Number after removing duplicates");

            foreach(var numb in arr)
            {
                if (!number.Contains(numb))
                {
                    Console.WriteLine(numb + " ");
                    number.Add(numb);
                }
            }
        }

    }
}
