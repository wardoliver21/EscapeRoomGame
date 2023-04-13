using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EscapeRoomGame
{
    internal class NopeRoom : BaseRoom
    {

        public override void Name()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("----------NOPE ROOM----------");
            Console.WriteLine("-----------------------------");
        }

        public override void DisplayDescription()
        {
            Console.WriteLine("You are in a room with a single word written on the wall: 'NOPE' which is made up of neon lightbulbs.");
            Console.WriteLine("Right under the big neon sign is an old computer.");
            Console.WriteLine();
        }

        public override void Explore()
        {
            Console.WriteLine("Would you like to explore the room? Y/N");
            string input = Console.ReadLine();

            if (input.ToUpper() == "Y")
            {
                Console.WriteLine(" You approach the computer... there is some low music playing, like an arcade game...");
                Console.WriteLine();
                Explore();
            }
            else if (input.ToUpper() == "N")
            {

            }
            else
            {
                Console.WriteLine("Wrong input, please select Y or N");
                Explore();
            }
        }

        // NOPE GAME
        public override void Solve()
        {
            
            Console.WriteLine("Welcome to NOPE game!");
            Console.WriteLine("To play, simply type 'nope' whenever prompted.");
            Console.WriteLine();

            while (true)
            {
                Console.Write("Are you ready to play? (yes/nope) ");
                string response = Console.ReadLine().ToLower();
                Console.WriteLine();

                if (response == "yes")
                {
                    Console.WriteLine("Okay, maybe next time. Goodbye!");
                    Console.WriteLine();
                break;
                }
                else if (response == "nope")
                {
                    Console.WriteLine("Great! Let's get started.");
                    Console.WriteLine();
                break;
                }
                else
                {
                    Console.WriteLine("Invalid response. Please enter 'yes' or 'no'.");
                    Console.WriteLine();
                }
            }
            Console.WriteLine("The rules of the game are simple:");
            Console.WriteLine("I'll say a word, and you have to say 'NOPE' if it contains the letters 'N', 'O', 'P', or 'E'.");
            Console.WriteLine("If you say 'NOPE' for a word that doesn't contain those letters, you lose!");
            Console.WriteLine("If you make it through all 3 words without losing, you win!");
            Console.WriteLine();

            string[] words = { "apple", "banana", "cherry"};
            int score = 0;

            foreach (string word in words)
            {
                Console.Write($"Word #{score + 1}: {word}. ");
                string response = Console.ReadLine().ToLower();

                if (response == "nope" && (word.Contains("n") || word.Contains("o") || word.Contains("p") || word.Contains("e")))
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect. Game over! You are Forever stuck in the Nope Room!!");
                    Console.WriteLine($"Your final score is {score}.");
                    Console.WriteLine();
                    return;
                }
            }

            Console.WriteLine("Congratulations, you win!");
            Console.WriteLine($"Your final score is {score}.");
            Console.WriteLine("A secret Door opens...you walk towards it..");
            Console.WriteLine();
        }     
    }
}
