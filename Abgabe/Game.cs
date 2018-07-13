using System;
using System.Collections.Generic;

namespace Abgabe
{
    public class Game
    {
        public static void GameStart()
        {   
            HelpMethods.GameDescription();
            HelpMethods.CheckCases();
        }

        public static void GameWin(){
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You killed the Calamity Ganon and took the handmade Figure of the Princess Zelda."
            + Environment.NewLine
            +"There's nothing left for you to do."
            + Environment.NewLine
            + "So either end your adventure by entering [quit/q] or explore the rest of this world."
            + Environment.NewLine
            + "Thank you for Playing The Legend of Zelda - Text Adventure!");
            Console.ResetColor();
        }
    }
}