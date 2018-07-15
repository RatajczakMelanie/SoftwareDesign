using System;
using System.Collections.Generic;

namespace Abgabe
{
    public class Game
    {
        public static void GameStart()
        {   
            GameDescription();
            HelpMethods.CheckCases();
        }

        public static void GameWin(){
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You killed the Calamity Ganon and took the handmade figure of the Princess Zelda."
            + Environment.NewLine
            +"You saved the people of Hyrule and everyone loves you."
            + Environment.NewLine
            +"There's nothing left for you to do."
            + Environment.NewLine
            + "So either end your adventure by entering [quit/q] or explore the rest of this world."
            + Environment.NewLine
            + "Thank you for playing The Legend of Zelda - Text Adventure!");
            Console.ResetColor();
        }

            public static void GameDescription()
        {   
            string gameDescription = 
            Environment.NewLine +
            "Hello adventurer, welcome to a game full of mysteries and danger. You're name is Link right?" 
            + Environment.NewLine 
            + "Open all possible commands by pressing [help/h]."
            + Environment.NewLine 
            + "To end your adventure and go back to your boring life press [quit/q]. "
            + Environment.NewLine 
            + "Your aventure is starting right this second...";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(gameDescription);
            Console.ResetColor();
        }
    }
}