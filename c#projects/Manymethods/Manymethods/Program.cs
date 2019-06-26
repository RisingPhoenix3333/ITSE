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


            // calling the method
            Hello();

            // calling the second method
            addition();

            // calling the third method
            Catdog();

            // string interpolation -another way to concatenate strings

            Console.ReadKey(); // exit the console
        }

        public static void Hello()
        {
            //print out the message
            Console.WriteLine("Please enter your name.");

            // read the input
            var name = Console.ReadLine();

            // string concatenation and print to the console
            Console.WriteLine("Hello " + name);
        }

        public static void addition()
        {
            Console.WriteLine("Please enter first number");

            int firstnumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter second number");

            int secondnumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(firstnumber + secondnumber);
        }

        public static void Catdog()
        {
            Console.WriteLine("Do you prefer Cats or Dogs");

            string preference = Console.ReadLine();

            if (preference == "Dogs" || preference == "dogs")
            {
                Console.WriteLine("Bark");
            }
            if (preference == "Cats" || preference == "cats")
            {
                Console.WriteLine("Meow");
            }
        }
    }
}
    