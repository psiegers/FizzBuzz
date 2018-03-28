using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperFizzBuzz;

namespace FizzBuzzAdv
{
    class Program
    {
        static void Main(string[] args)
        {
            // Advanced output
            Console.WriteLine("Advanced output according to requirements");
            Console.WriteLine();
            // 1. Print the numbers from range -12 through 145
            // 2. For multiples of 3, print “Fizz”
            // 3. For Multiples of 7, print “Buzz”
            // 4. For Multiples of 38, print “Bazz”
            // Note: Print the appropriate combination of tokens for any number 
            // that matches more than one of these rules
            SuperFB sfb = new SuperFB(-12, 145, "Fizz", "Buzz", "Bazz", 3, 7, 38);
            sfb.PrintListRange();

            // write two empty lines
            Console.WriteLine();
            Console.WriteLine();

            // Advanced output with other tokens
            Console.WriteLine("Advanced output with other tokens");
            Console.WriteLine();
            // 1. Print the numbers from range -55 through 121
            // 2. For multiples of 4, print “Frog”
            // 3. For Multiples of 13, print “Duck”
            // 4. For Multiples of 9, print “Chicken”
            // Note: Print the appropriate combination of tokens for any number 
            // that matches more than one of these rules
            sfb = new SuperFB(-55, 121, "Frog", "Duck", "Chicken", 4, 13, 9);
            sfb.PrintListRange();
        }
    }
}
