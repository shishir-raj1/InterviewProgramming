using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using InterviewProgramming.collectionsProgramming;
using InterviewProgramming.MultipleMethods;
using InterviewProgramming.oopsProgramming;
using InterviewProgramming.Practice;

internal class program
{
    public static void Main(string[] args)
    {
        // See https://aka.ms/new-console-template for more information
       
       // Console.WriteLine("Enter your Input");
       // var input = Console.ReadLine();

        customMethods c = new customMethods();

        c.adjacentchar();
        c.stringWordCount();

        qualityTest q = new qualityTest();
        q.sentenceReverse();



        Console.ReadKey();
    }


}