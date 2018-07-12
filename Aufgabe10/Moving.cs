using System;
using System.Collections.Generic;

namespace Aufgabe10
{
    class Moving
    {
        public static Room currentRoom;
        public static Room Move()
        {
            currentRoom = Room.createData();
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
                        //currentRoom.characters.Remove(CharacterSetup.link);
                        foreach(var character in currentRoom.characters){
                            Console.WriteLine(character.name);
                        }
                        
                        currentRoom = currentRoom.north;
                        currentRoom.characters.Add(CharacterSetup.link);
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
            return currentRoom;
        }
    }
}