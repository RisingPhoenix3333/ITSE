using System;

namespace Mastermind
{
    
    class Program
    {
        static int[] numbers = new int[4];
        static void Main(string[] args)
        {
            Generator();
            MMstart();

            Console.ReadKey();






        }
        static int[] Generator()
        {
            
            Random generator = new Random();

            int randomNumber = generator.Next(0, 3);
            numbers[0] = randomNumber;

            int randomNumber2 = generator.Next(0, 3);
            numbers[1] = randomNumber2;

            int pcn1 = 0;
            numbers[2] = pcn1;

            int pcn2 = 0;
            numbers[3] = pcn2;
            return numbers;
        }
        static void MMstart()
        {
            int randomNumber = numbers[0];

            int randomNumber2 = numbers[1];

            int pcn1 = numbers[2];

            int pcn2 = numbers[3];

            bool IsWin(int [] numbers)
            {
               
                

                if (pcn1 == randomNumber && pcn2 == randomNumber2)
                {
                    Console.WriteLine("You win!");
                    return true;
                }

                else if (pcn1 == randomNumber2 && pcn2 == randomNumber)
                {
                    Console.WriteLine("2-0");
                    return false;
                }
                else if (pcn1 == randomNumber2 && pcn2 != randomNumber2 || pcn1 != randomNumber && pcn2 == randomNumber)
                {
                    Console.WriteLine("1-0");
                    return false;
                }
                else if (pcn1 == randomNumber && pcn2 != randomNumber2 || pcn1 != randomNumber && pcn2 == randomNumber2)
                {
                    Console.WriteLine("0-1");
                    return false;
                }
                else if (pcn1 != randomNumber && pcn2 != randomNumber2)
                {
                    Console.WriteLine("0-0");
                    return false;
                }
                return false;
            }
            while (IsWin(numbers) is false)
            {

                Console.WriteLine("I am Thinking of two colors. They can be Red, blue, or yellow");

                Console.WriteLine("Please enter your guess for the first color");

                string guess = Console.ReadLine().ToLower();

                Console.WriteLine("Please enter your guess for the second color");

                string guess2 = Console.ReadLine();


                if (guess == "Red" || guess == "red")
                {
                    pcn1 = 0;
                }

                else if (guess == "Blue" || guess == "blue")
                {
                    pcn1 = 1;
                }

                else if (guess == "Yellow" || guess == "yellow")
                {
                    pcn1 = 2;
                }



                if (guess2 == "Red" || guess2 == "red")
                {
                    pcn2 = 0;
                }

                else if (guess2 == "Blue" || guess2 == "blue")
                {
                    pcn2 = 1;
                }

                else if (guess2 == "Yellow" || guess2 == "yellow")
                {
                    pcn2 = 2;
                }

            }





            
        }
    }
}
