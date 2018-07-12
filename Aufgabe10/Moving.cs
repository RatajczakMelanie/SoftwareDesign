using System;
using System.Collections.Generic;

namespace Aufgabe10
{
    class Moving
    {
        public static void Move(){
        Room currentRoom = Room.createData();
        string input = "";

            while (input != "q")
            {   
                Room.RoomDescription(currentRoom);
                input = Console.ReadLine().ToLower();
                switch (input)
                {
                    case "n":
                    case "north":
                    if(currentRoom.north != null){
                        currentRoom = currentRoom.north;
                    }
                    else
                    {
                        //Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Nothing Here!");
                        Console.ResetColor();
                    }
                    break;
                    case "e":
                    case "east":
                    if(currentRoom.east != null){
                        currentRoom = currentRoom.east;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Nothing Here!");
                        Console.ResetColor();
                    }
                    break;
                    case "s":
                    case "south":
                    if(currentRoom.south != null){
                        currentRoom = currentRoom.south;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Nothing Here!");
                        Console.ResetColor();
                    }
                    break;
                    case "w":
                    case "west":
                    if(currentRoom.west != null){
                        currentRoom = currentRoom.west;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Nothing Here!");
                        Console.ResetColor();
                    }
                    break;

                    default:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("I can not understand a word you're saying. Just try again."
                    + Environment.NewLine
                    + "Open the possible commands by pressing [help/h]");
                    Console.ResetColor();
                    break;

                    case "q":
                    case "quit":
                    HelpMethods.Quit();
                    break;


                }

            }
        }
    }
}