using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProgramming.collectionsProgramming
{
    public class frquencyOfElement
    {

        public void frequency()
        {
            int[] arr = { 1, 2, 3, 2, 4, 5, 1, 6 };

            // Frequency of each element
            var freq = new Dictionary<int, int>();

            foreach (int num in arr)
            {
                if (freq.ContainsKey(num))
                {
                    freq[num]++;
                }
                else
                {
                    freq[num] = 1;
                }
            }

            foreach (var pair in freq)
            {
                Console.WriteLine($"Element = {pair.Key}, Frequency = {pair.Value}");
            }

        }




    }
}
