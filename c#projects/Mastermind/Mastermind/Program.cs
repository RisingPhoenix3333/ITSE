using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            MM();

           
      

            



        }
        static void MM()
        {
            Console.WriteLine("Please enter your guess for the first color");

            string guess = Console.ReadLine();

            Console.WriteLine("Please enter your guess for the second color");

            string guess2 = Console.ReadLine();

            Random generator = new Random();

            int randomNumber = generator.Next(0, 3);

            int randomNumber2 = generator.Next(0, 3);



            if (randomNumber == 0 && randomNumber2 == 0)
            {
                if (guess == "0" && guess2 == "0")
                {
                    Console.WriteLine("You win");
                }
                else if (guess == "1" && guess2 == "0" || guess == "2" && guess2 == "0" || guess == "0" && guess2 == "1" || guess == "0" && guess2 == "2")
                {
                    Console.WriteLine("0-1");
                }
                else if (guess == "1" && guess2 == "1" || guess == "2" && guess2 == "2" || guess == "1" && guess2 == "2" || guess == "2" && guess2 == "1")
                {
                    Console.WriteLine("0-0");
                }

            }
            if (randomNumber == 1 && randomNumber2 == 0)
            {
                if (guess == "1" && guess2 == "0")
                {
                    Console.WriteLine("You Win");
                }
                else if (guess == "0" && guess2 == "2" || guess == "2" && guess2 == "1")
                {
                    Console.WriteLine("1-0");
                }
                else if (guess == "2" && guess2 == "2")
                {
                    Console.WriteLine("0-0");
                }
                else if (guess == "0" && guess2 == "1")
                {
                    Console.WriteLine("2-0");
                }
                else if (guess == "")
                

                
            }
        }
    }
}
