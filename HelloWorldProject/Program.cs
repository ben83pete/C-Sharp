using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldProject
{
    class Program
    {
        static int A = 7;

        static void WhileExample()
        { var counter = 0;
            while (counter < 10) { Console.WriteLine($"Count is {counter}");
                //counter = counter + 1;
            }
        }

        static void Print()
        {
            Console.WriteLine($"The value of A is {A}");
        }

        static void Main(string[] args) /* Method called Main, 
            this is the start of the program. */
        {
            WhileExample();
            var counter = 0;            
            var B = 13;
            var C = A * B;
            Console.WriteLine("Hello World!");
            Console.WriteLine("by Ben");
            Console.WriteLine($"For A = {A} and B = {B}, A * B={C}");
            Console.WriteLine($"Value of counter is {counter}");

         }
    
    }
}
