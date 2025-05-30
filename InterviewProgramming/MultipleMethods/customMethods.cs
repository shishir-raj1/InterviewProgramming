﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
            string str = "Test Automation Engineer";
            string[] strSplit = str.Split(" ");

            List<string> strStore = new List<string>();

            for(int i = strSplit.Length - 1; i >= 0; i--)
            {
                strStore.Add(strSplit[i]);
            }
            string newStr = string.Join(" ", strStore);
            Console.WriteLine(newStr);

            string[] newStrSplit = newStr.Split(" ");

            List<string> newStore = new List<string>();

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

        public void reverseNum(int num)
        {
            int digit;
            int rev = 0;

            while (num > 0)
            {
                digit = num % 10;
                rev = rev*10 + digit;
                num = num / 10;
            }

            Console.WriteLine(rev);

        }

        public void sum(int num)
        {
            int digit;
            int sum = 0;

            while (num > 0)
            {
                digit = num % 10;
                sum = sum + digit;
                num = num / 10;
            }
            Console.WriteLine(sum);
        }

        public void sumNatural()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sum = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine(sum);
        }

        public void occurance()
        {
            string str = "SHISHIR";

            var store = new Dictionary<char,int>();

            foreach(char c in str)
            {
                if (store.ContainsKey(c))
                {
                    store[c]++;
                }
                else
                {
                    store[c] = 1;
                }
            }

            foreach(var s in store)
            {
                Console.WriteLine($"character = {s.Key}, count = {s.Value}");
            }

            Console.WriteLine("remove occurance and print");

            foreach(char o in str)
            {
                if (store[o] == 1)
                {
                    Console.WriteLine(o);
                }
            }

            var rstring = new HashSet<char>();
            Console.WriteLine("String after removing duplicates");

            foreach (var rstr in str)
            {
                if (!rstring.Contains(rstr))
                {
                    Console.WriteLine(rstr + " ");
                    rstring.Add(rstr);
                }
            }


        }

        public void removeOccurance()
        {
            string str = "SHISHIR";

            var reOccur = new HashSet<char>();

            foreach (var c in str)
            {
                if (!reOccur.Contains(c))
                {
                    Console.WriteLine(c);
                    reOccur.Add(c);
                }
            }
        }

        public void splitWords()
        {
            string str = "My name is Shishir";

            string[] wordSplit = str.Split(" ");

            List<string> words = new List<string>();

            for(int i=wordSplit.Length-1; i >= 0; i--)
            {
                words.Add(wordSplit[i]);
            }

            string wordsJoin = string.Join(" ", words);
            Console.WriteLine(wordsJoin);

            List<string> reverseWords = new List<string>();
            string rev;

            for (int i=0;i < words.Count; i++)
            {
                //reverseString(words[i]);
               // reverseWords.Add(words[i]);
               
            }

             string reverseJoin = string.Join(" ", reverseWords);
            Console.WriteLine(reverseJoin);
            
        }


        public void RemDup()
        {
            int[] arr = { 1, 2, 3, 2, 1 };

            HashSet<int> set = new HashSet<int>();

            List<int> list = new List<int>();

            foreach (int i in arr)
            {
                set.Add(i);
            }

            string setJoin = string.Join(" ", set);
            Console.WriteLine(setJoin);

            foreach (int i in set)
            {
                list.Add(i);
                
            }

            string listJoin = string.Join(" ", list);
            Console.WriteLine(listJoin);
            

        }


        public void fchar()
        {
            string str = "shishir";
            int index = str.IndexOf("i");
            int count = 0;

            for (int i = index +1; i < str.Length; i++)
            {
                if (str[i] == 'i')
                {
                    count++;
                }
            }
            Console.WriteLine("Number of i = " +count);
        }

        public void sArray()
        {
            int[] arr = { 1, 2, 5, 7, 2, 9, 23, 45, 2 };

            for(int i = 0; i < arr.Length-1; i++)
            {
                for(int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
                
            }

            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
            
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


        public void toggleCharacter(string str)
        {
            //input = sHishiR
            //output = ShISHIr
            char[] ch = str.ToCharArray();
            string result = " ";

            foreach (char i in ch)
            {
                if (char.IsUpper(i))
                {
                    result = result + char.ToLower(i);
                }
                else if (char.IsLower(i)) {
                    
                     result = result + char.ToUpper(i);
                }else
                {
                     result = result + i;
                }

                
            }
            Console.WriteLine(result);
            
        }

        public void OccuranceOfDigit()
        {

            //input = 8378391113344; 
            //digit 1 repeated 3 times

            Console.WriteLine("Enter a Number");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a digit you want to check");
            int digit = int.Parse(Console.ReadLine());

            int count = 0;

            while(number > 0)
            {
                if (number%10 == digit)
                {
                    count++;
                }
                 
                 number = number / 10;
            }
            Console.WriteLine(count);

            Console.WriteLine("Digit " +digit +"occurs " +count +"times");

        }

        //input = {1,2,1,5,3,2,1,2,4}
        //output = largest number = and the index = 5 and index is 3

        public void findIndex()
        {
            int[] num = { 1, 2, 1, 5, 3, 2, 1, 2, 4 };

            int largest = num[0];
            int index = 0;

            for(int i = 1;i < num.Length;i++)
            {
                if (num[i] > largest)
                {
                    largest = num[i];
                    index = i;
                }
            }
            Console.WriteLine("Largest number " +largest);
            Console.WriteLine("Index of Largest number " + index);

        }

        public void wordOccurance()
        {
            string str = "SHISHIR";

            var dict = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict[c] = 1;
                }
            }

            foreach (var i in dict)
            {
                Console.WriteLine($"character = {i.Key} count is {i.Value} ");
            }
        }

        public void adjacentchar()
        {
            string str = "SHISHIR";
            char[] charArray = str.ToCharArray();

            //reverse character out= HSSIIHR


            for (int i = 0; i < str.Length - 1; i=i + 2)
            {
                var temp = charArray[i]; // temp= s
                charArray[i] = charArray[i + 1];// 0=H
                charArray[i + 1] = temp; // 1=s

            }
             
            string s = string.Concat(charArray);

            string newStr = string.Join(" ", s );
            Console.WriteLine(newStr);
        }

        public void reverse(string str)
        {
            string rev = "";
            for (int i = str.Length - 1; i > 0; i--)
            {
                rev = rev + str[i];
            }
            Console.WriteLine(rev);
        }

        public void stringWordCount()
        {
            string str = "This this is is done by Saket Saket";

            string[] strSplit = str.ToUpper().Split(" ");


            Console.WriteLine("count the words : " + strSplit.Length);

            var dict = new Dictionary<string, int>();

            

            foreach (var s in strSplit)
            {
                if (dict.ContainsKey(s))
                {
                    dict[s]++;
                }
                else
                {
                    dict[s] = 1;
                }
            }

            foreach (var c in dict)
            {
                Console.WriteLine($"words = {c.Key} and the count is {c.Value}");
            }

        }

    }

}

