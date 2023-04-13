using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EscapeRoomGame
{
    // Child class : parent class
    internal class DevilRoom : BaseRoom
    {

        // Nom de la salle
        public override void Name()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("----------DEVIL ROOM----------");
            Console.WriteLine("------------------------------");
        }

        // Description de la salle
        public override void DisplayDescription()
        {
            Console.WriteLine("The room is dimly lit.. The walls and ceiling seems to be textured.. There is a locked door in front of you with a keypad.");
            Console.WriteLine();
        }

        // Explorer la salle
        public override void Explore()
        {
            Console.WriteLine("Would you like to explore the room? Y/N , if not, try to solve the puzzle");
            string input = Console.ReadLine();

            if (input.ToUpper() == "Y")
            {
                Console.Write(" You look around you and notice all the walls and ceilings are covered in 666 666 666 666 666 666 666... What could this mean ? ");
                Console.WriteLine("");
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

        // Resoudre le probleme
        public override void Solve()
        {
            Console.WriteLine(" You approach the door with the keypad, there is some writing next to it...");
            Console.WriteLine("DEVIL UPSIDE DOWN");
            Console.WriteLine();
            Console.WriteLine(" Enter the code to proceed to the next room:  ");

            int answer = int.Parse(Console.ReadLine());

            if (answer == 999)
            {
                Console.WriteLine("The door unlocks, you hear a Devilish laugh and you move on to the next room.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Incorrect answer. Try again.");
                Solve();
            }
        }      
    }
}
