namespace EscapeRoomGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create the rooms
            BaseRoom devilRoom = new DevilRoom();
            BaseRoom nopeRoom = new NopeRoom();
            BaseRoom deathRoom = new DeathRoom();

            // Ordre d'execution du programme
            devilRoom.Name();
            devilRoom.DisplayDescription();
            devilRoom.Explore();
            devilRoom.Solve();

            nopeRoom.Name();
            nopeRoom.DisplayDescription();
            nopeRoom.Explore();
            nopeRoom.Solve();
           
            deathRoom.Name();
            deathRoom.DisplayDescription();
            deathRoom.Explore();
            deathRoom.Solve();

            // Keep the console window open
            Console.ReadLine();
        }
    }
}