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
