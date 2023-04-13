using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeRoomGame
{
    internal class DeathRoom : BaseRoom
    {

        public override void Name()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("----------DEATH ROOM----------");
            Console.WriteLine("------------------------------");
        }

        public override void DisplayDescription()
        {
            Console.WriteLine("You have entered the final room. There is only a door with a screen on it");
            Console.WriteLine();
        }

        public override void Explore()
        {
            Console.WriteLine("Would you like to explore the room? Y/N");
            string input = Console.ReadLine();

            if (input.ToUpper() == "Y")
            {
                Console.WriteLine("On the screen, it looks like a hangman game is ready for you to initiate. Maybe its an hint that the word to be guessed will be death or horror related?");
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

        public override void Solve()
        {

            string[] words = { "fear", "doom", "bone", "dark", "moon", "hell", "soul", "dusk", "bane" };

            // Choose a random word from the list
            Random random = new Random();
            string wordToGuess = words[random.Next(words.Length)];

            // Instructions
            Console.WriteLine("Welcome to the Word Guessing Game!");
            Console.WriteLine($"The word to guess has {wordToGuess.Length} letters.");
            Console.WriteLine("You have 10 chances to guess the word one letter at a time.");
            Console.WriteLine();

            int remainingGuesses = 10;
            char[] guessedLetters = new char[wordToGuess.Length];

            while (remainingGuesses > 0)
            {
                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (guessedLetters[i] == '\0')
                    {
                        Console.Write("_ ");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write(guessedLetters[i] + " ");
                        Console.WriteLine();
                    }
                }
                Console.WriteLine();

                Console.Write("Enter a letter: ");
                char guess = Console.ReadLine()[0];

                bool correctGuess = false;
                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (wordToGuess[i] == guess)
                    {
                        guessedLetters[i] = guess;
                        correctGuess = true;
                    }
                }

                if (correctGuess)
                {
                    Console.WriteLine("Correct guess!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Incorrect guess.");
                    Console.WriteLine();
                    remainingGuesses--;
                }

                if (new string(guessedLetters) == wordToGuess)
                {
                    Console.WriteLine("Congratulations, you guessed the word! You escape the rooms safely");
                    Console.WriteLine();
                    return;
                }
            }

            Console.WriteLine("Sorry, you ran out of guesses. The word was " + wordToGuess + "You are forever stuck in the Death room.");
        }
    }  
}
