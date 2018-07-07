using System;
using System.Collections.Generic;

namespace Aufgabe10
{
    class RoomSetup
    {
        
        public static List<Room> rooms = new List<Room>();

        public class Room
        {
            public string name;
            public string information;
            public Room north;
            public Room east;
            public Room south;
            public Room west;
            public Room(string Name, string Information){
                name = Name;
                information = Information;
            }
            public static void RoomDescription(Room room){
                Console.WriteLine(room.name);
                Console.WriteLine(room.information);
            }
            //public List<CharacterSetup.Character> characters;
            //public List<Item> roomInventory;
        }        
        public static Room createRooms()
        {   
            /* Room noExit = new Room
            (
                "There is no exit!",
                "Try another direction."
            ); */
            Room Field = new Room
            (
                "A Field",
                "You are Standing on a wide Field. In the North you see little houses and huge mountains."
                + Environment.NewLine 
                + "What would you like to do?"
            );

            Room Kakariko = new Room
            (
                "Kakariko",
                "You've reached the beautiful town of Kakariko."
                + Environment.NewLine 
                + "What would you like to do?"
                
            );
            
            Room ZoraDomain = new Room
            (
                "The Zora village",
                "You've entered the Zora village. People here like to swim, water is their element. You're waddeling into Water."
                
            );

            Room SheikahShrine = new Room
            (
                "The SheikahShrine",
                "You've entered The Sheikahshrine. You can sense that there might be some special item here."
                + Environment.NewLine 
                + "What would you like to do?"
            );

            Room HyruleCastle = new Room
            (
                "The Castle of Hyrule",
                "You've entered the great castle of Hyrule. Beware!"
                
            );

            //Field neighbours
            Field.north = Kakariko;
            /* Field.east = noExit;
            Field.south = noExit;
            Field.west = noExit; */

            //Kakariko neighbours
            //Kakariko.north = noExit;
            Kakariko.east = ZoraDomain;
            Kakariko.south= Field;
            Kakariko.west = SheikahShrine;

            //ZoraDomain neighbours
            ZoraDomain.north = HyruleCastle;
            /* ZoraDomain.east = noExit;
            ZoraDomain.south = noExit; */
            ZoraDomain.west = Kakariko;

            //SheikahShrine neighbours
            //SheikahShrine.north = noExit;
            SheikahShrine.east = Kakariko;
            SheikahShrine.south = Field;
            //SheikahShrine.west = noExit;

            //HyruleCastle neighbours
           /*  HyruleCastle.north = noExit;
            HyruleCastle.east = noExit; */
            HyruleCastle.south = ZoraDomain;
           // HyruleCastle.west = noExit;
            
            //List<Room>
            rooms.Add(Field);
            rooms.Add(Kakariko);
            rooms.Add(ZoraDomain);
            rooms.Add(SheikahShrine);
            rooms.Add(HyruleCastle);

            return Field;
           
        } 
    }
}