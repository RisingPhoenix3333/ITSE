using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manymethods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //print out the message
            Console.WriteLine("Please enter your name.");

            // read the input
            var name = Console.ReadLine();

            // print to the console
            Console.WriteLine("Hello " + name);

            // calling the method
            Hello(name);

            // string interpolation -another way to concatenate strings
            Console.WriteLine($"Hello {name}!");
            Console.ReadKey(); // exit the console
        }

        public static void Hello(string name)
        {
            // string concatenation and print to the console
            Console.WriteLine("Hello " + name);
        }
    }
   
}
    