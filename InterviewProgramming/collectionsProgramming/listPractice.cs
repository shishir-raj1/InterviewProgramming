using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProgramming.collectionsProgramming
{
    public class listPractice
    {

        public void addNumbers()
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);

            foreach (int num in numbers)
            {
                Console.Write(num +" ");
            }

            
        }

        public void addObject()
        {
            List<int> numb = new List<int> { 1, 45, 21, 67, 333, 2 ,3,4};

            numb.Remove(3);
            numb.Sort();

            foreach (int nums in numb)
            {
                Console.WriteLine(nums);
            }

        }
        

        
    }
}
