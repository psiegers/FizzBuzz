using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperFizzBuzz;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basic output range 1 through 100
            Console.WriteLine("Basic output");
            Console.WriteLine();
            // Write a program that prints the numbers from 1 to 100. 
            // 1. For multiples of 3, print “Fizz” instead of the number. 
            // 2. For multiples of 5, print “Buzz”. 
            // 3. For Multiples of 3 and 5, print “FizzBuzz”
            SuperFB sfb = new SuperFB(100);
            sfb.Token1 = "Fizz";
            sfb.Token2 = "Buzz";
            sfb.PrintListBasic();
        }
    }
}
