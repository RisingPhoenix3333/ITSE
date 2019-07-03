using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            game();

            Console.ReadKey();
        }
        static void game()
        {

            Console.WriteLine("Rock, Paper, or scissors?");

            string hand = Console.ReadLine();

            Random generator = new Random();

            int randomNumber = generator.Next(0, 3);

            if (hand == "Rock" || hand == "rock")
            {
                if (randomNumber == 0)
                {
                    Console.WriteLine("Cp chose rock, Tie");
                }

                if (randomNumber == 1)
                {
                    Console.WriteLine("Cp chose paper, You lose");
                }
                
                if (randomNumber == 2)
                {
                    Console.WriteLine("Cp chose scissors, You win");
                }
            }
            if (hand == "paper" || hand == "Paper")
            {
                if (randomNumber == 0)
                {
                    Console.WriteLine("Cp chose rock, You Win");
                }
                if (randomNumber == 1)
                {
                    Console.WriteLine("Cp chose paper, tie");
                }

                if (randomNumber == 2)
                {
                    Console.WriteLine("Cp chose scissors, you lose");
                }

            }
            if (hand == "Scissors" || hand == "scissors")
            {
                if (randomNumber == 0)
                {
                    Console.WriteLine("Cp chose rock, you lose");
                }
                if (randomNumber == 1)
                {
                    Console.WriteLine("Cp chose paper, you win");
                }
                if (randomNumber == 2)
                {
                    Console.WriteLine("Cp chose scissors, tie");
                }
            }
        }
    }
}
