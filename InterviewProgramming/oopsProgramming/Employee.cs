using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProgramming.oopsProgramming
{
    public class Employee
    {
        //instance variable
        private int experience;
          
        //constructor
        public Employee()
        {
            //code
        }

        //property
        public int Experience
        {
            get
            {
                return experience;
            }
            set
            {
                experience = value;
            }
        }

        //method

        public void CalculateSalary()
        {
            int salary = Experience * 100;
            Console.WriteLine("salary:{0}", salary);
        }
    }


}
