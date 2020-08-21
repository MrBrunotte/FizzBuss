using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuss
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  for 1 <-- i in numbers DO
                if number is divisible with 3 and 5 
                print FizzBuzz
                
                else if number is divisible with 3
                print Fizz
                
                else if number is divisible with 5
                print Buzz
                
                else
                print number
                */
            for (int i = 1; i < 16; i++)
            {
                if (i%3 == 0 &&
                    i%5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("FizzBuss");
                
                }
                else if (i%3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Fizz");       
                }
                else if (i%5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(i);
                }
                Console.ReadLine();
            }

            /*for (int i = 1; i <= 100; i++)
            {
                string str = "";
                if (i % 3 == 0)
                {
                    str += "Fizz";
                }
                if (i % 5 == 0)
                {
                    str += "Buzz";
                }
                if (str.Length == 0)
                {
                    str = i.ToString();
                }
                Console.WriteLine(str);
                Console.ReadLine();
            }*/

        }
     
    }
}
