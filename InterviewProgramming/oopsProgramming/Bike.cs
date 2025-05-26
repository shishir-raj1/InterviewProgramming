using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace InterviewProgramming.oopsProgramming
{
    public class Bike : yamaha
    {
        public Bike()
        {
            Console.WriteLine("welocome to Bike world");
        }

        public Bike(int x)
        {
          //  this();
          //  super();
            Console.WriteLine("heloo bike");
        }
    }
}
