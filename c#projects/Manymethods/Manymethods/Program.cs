using System;

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

            // calling the fourth method
            Oddeven();

            // calling the fifth method
            Inches();

            // calling the sixth method
            Guess();

            // calling the seventh method
            Echo();

            // calling the eight method 
            kilo();

            // calling the ninth method
            Datetime();

            // calling the tenth method
            bday();
            // string interpolation -another way to concatenate strings

            Console.ReadKey(); // exit the console
        }

        public static void Hello()
        {
            //print out the message
            Console.WriteLine("Please enter your name.");

            // read the input
            string name = Console.ReadLine();

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
        public static void Oddeven()
        {
            Console.WriteLine("Please enter a number");

            int number = Convert.ToInt32(Console.ReadLine());
            if ((number / 2) * 2 == number)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
        public static void Inches()
        {
            Console.WriteLine("Please enter your height in Feet with no decimals");

            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(number * 12);
        }
        public static void Guess()
        {
            Console.WriteLine("Please Guess a Word");

            string guess = Console.ReadLine();

            if (guess == "csharp" || guess == "Csharp" || guess == "CSharp")
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Wrong");
            }
        }
        public static void Echo()
        {
            Console.WriteLine("You have entered a cave, Write to speak");

            string name = Console.ReadLine();

            Console.WriteLine(name.ToUpper());

            Console.WriteLine(name.ToLower());

            Console.WriteLine(name.ToLower());
        }

        public static void kilo()
        {
            Console.WriteLine("Please enter your weight in pounds");

            int weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(weight / 2.2);
        }

        public static void Datetime()
        {
            DateTime thisDay = DateTime.Today;
            Console.WriteLine(thisDay.ToString());
            Console.WriteLine();
        }
        public static void bday()
        {
            Console.WriteLine("Please enter your birth year in this format (yyyy)");

            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(2019 - age);
        }
    }

}