using System;
using System.Collections.Generic;

namespace Abgabe
{
    
    
        public class Room
        {
            public List<CharacterSetup.Character> characters = new List<CharacterSetup.Character>();
            public  List<Item> roomInventory = new List<Item>();

            public static List<Room> rooms = new List<Room>();
            
            public string name;
            public string information;
            public int roomNumber;
            public Room north;
            public Room east;
            public Room south;
            public Room west;
            public Room(string _name, string _information){
                name = _name;
                information = _information;
            }
            public static void RoomDescription(Room room){
                Console.WriteLine(room.name);
                Console.WriteLine(room.information);
                if (room.roomInventory.Count != 0){
                    Console.WriteLine("You see:");
                    foreach(var item in room.roomInventory){
                        Console.WriteLine(item.name);
                    }
                }
               
            }

              public static Room createData()
            {   
            
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

            Item potion = new Item
            (
                "potion",
                "health",
                false,
                0.3F,
                0,
                "LP +0.3"
            );
            

            Item sword = new Item
            (
                "mastersword",
                "gear",
                false,
                0,
                0.2F,
                "HP +0.2"
            );

            Item sheikahStone = new Item(
                
                "sheikastone",
                "normal",
                false,
                0,
                0,
                "The Sheikastone reveals a secret passageway"
            );
            Item statueOfZelda = new Item(
                
                "Zeldafigure",
                "normal",
                false,
                0,
                0,
                "A beautiful handmade figure of the Princess Zelda"
            );

            //Field neighbours
            Field.north = Kakariko;
            Field.roomInventory.Add(sword);
            Field.roomInventory.Add(potion);
            Field.characters.Add(CharacterSetup.link);
          

            //Kakariko neighbours
            Kakariko.east = ZoraDomain;
            Kakariko.south= Field;
            Kakariko.west = SheikahShrine;
            

            //ZoraDomain neighbours
            ZoraDomain.north = HyruleCastle;
            ZoraDomain.west = Kakariko;
            

            //SheikahShrine neighbours
            SheikahShrine.east = Kakariko;
            SheikahShrine.south = Field;
            SheikahShrine.roomInventory.Add(sheikahStone);
            SheikahShrine.characters.Add(CharacterSetup.guardian);

            //HyruleCastle neighbours
            HyruleCastle.south = ZoraDomain;
            HyruleCastle.roomInventory.Add(statueOfZelda);
            HyruleCastle.characters.Add(CharacterSetup.ganon);
            
            //List<Room>
            rooms.Add(Field);
            rooms.Add(Kakariko);
            rooms.Add(ZoraDomain);
            rooms.Add(SheikahShrine);
            rooms.Add(HyruleCastle);

            return Field;
           
        } 
            //public List<CharacterSetup.Character> characters;
               
    }        
      
    
}