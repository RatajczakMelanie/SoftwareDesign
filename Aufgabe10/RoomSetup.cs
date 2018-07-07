using System;
using System.Collections.Generic;

namespace Aufgabe10
{
    class RoomSetup
    {
        public static List<Room> rooms = new List<Room>();
        public static void createRooms()
        {   
            
            Room Field = new Room
            {
                name = "A Field",
                information = "sdfsdf",
                characters = new List<Character>(),
                roomInventory = new Dictionary<string, Item>{
                    {"north", ItemSetup.health[0]},
                }
            };
            
            rooms.Add(Field);

            Room Kakariko = new Room
            {
                name = "Kakariko",
                information = "sdfsdf",
                characters = new List<Character>(),
                roomInventory = new Dictionary<string, Item>()
            };
            rooms.Add(Kakariko);

            Room ZoraDomain = new Room
            {
                name = "The Zora village",
                information = "sdfsdf",
                characters = new List<Character>(),
                roomInventory = new Dictionary<string, Item>()
            };
            rooms.Add(ZoraDomain);

            Room SheikahShrine = new Room
            {
                name = "The Sheikahshrine",
                information = "sdfsdf",
                characters = new List<Character>(),
                roomInventory = new Dictionary<string, Item>()
            };
            rooms.Add(SheikahShrine);

            Room HyruleCastle = new Room
            {
                name = "The castle of Hyrule",
                information = "sdfsdf",
                characters = new List<Character>(),
                roomInventory = new Dictionary<string, Item>()
            };
            rooms.Add(HyruleCastle);

            // Adding Neighbour Dictionary after Room Declerations
             Field.neighbours = new Dictionary<string, Room>
            {
                {"north", Kakariko},
                {"south", null},
                {"east", null},
                {"west", null},
            };
            Kakariko.neighbours = new Dictionary<string, Room>
            {
                {"north", null},
                {"south", null},
                {"east", ZoraDomain},
                {"west", SheikahShrine},
            };
            ZoraDomain.neighbours = new Dictionary<string, Room>
            {
                {"north", HyruleCastle},
                {"south", null},
                {"east", null},
                {"west", Kakariko},
            };
            SheikahShrine.neighbours = new Dictionary<string, Room>
            {
                {"north", null},
                {"south", Field},
                {"east", Kakariko},
                {"west", null},
            };
            HyruleCastle.neighbours = new Dictionary<string, Room>
            {
                {"north", null},
                {"south", ZoraDomain},
                {"east", null},
                {"west", null},
            }; 
        } 
    }
}