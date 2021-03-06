using System;
using System.Collections.Generic;

namespace Abgabe
{
    public class EnemyCurrentRoom
    {
            public static Room SheikahShrine = new Room
            (
                "The SheikahShrine",
                "You've entered The Sheikahshrine. A stream of power flows through you."
                + Environment.NewLine 
                + "What would you like to do?"
                
            );
    }
           
        
    
    public class Room
    {
        public List<CharacterSetup.Character> characters = new List<CharacterSetup.Character>();
        public  List<Item> roomInventory = new List<Item>();

        public static List<Room> rooms = new List<Room>();
        
        public string name;
        public string information;
        public Room north;
        public Room east;
        public Room south;
        public Room west;
        public Room(string _name, string _information){
            name = _name;
            information = _information;
        }
        public static void RoomDescription(Room room){
            Console.WriteLine(Environment.NewLine + room.name);
            Console.WriteLine(room.information);
            if (room.roomInventory.Count != 0){
                Console.WriteLine("You see:");
                foreach(var item in room.roomInventory){
                    Console.WriteLine(item.name);
                }
            }
            if(room.characters.Count > 1){
                Console.WriteLine("Here with you:");
                foreach(var character in room.characters){
                    switch(character.type)
                    {
                        case "Friend":
                        Console.WriteLine(character.name);
                        Console.WriteLine("you can chat with " + character.name + " by pressing [chat/c].");
                        break;

                        case "Enemy":
                        Console.WriteLine(character.name);
                        Console.WriteLine("Fight " + character.name + " by pressing [fight/f].");
                        break;
                    }
                    

                        
                }
            }
            
        }
     
        public static Room createData()
        {   
        
        Room Field = new Room
        (
            "A Field",
            "You are standing on a wide field. In the north you see little houses and huge mountains."
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
            "You've entered the Zora village. People here like to swim, water is their element. You're waddling into water."
            
            
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

        /* Item sheikahStone = new Item(
            
            "sheikastone",
            "normal",
            false,
            0,
            0,
            "The Sheikastone reveals a secret passageway"
        ); */
        Item statueOfZelda = new Item(
            
            "zeldafigure",
            "normal",
            false,
            0,
            0,
            "A beautiful handmade figure of the Princess Zelda"
        );

        //Field
        Field.north = Kakariko;
        Field.roomInventory.Add(sword);
        Field.characters.Add(CharacterSetup.link);
        
        //Kakariko
        Kakariko.east = ZoraDomain;
        Kakariko.south= Field;
        Kakariko.west = EnemyCurrentRoom.SheikahShrine;

         //SheikahShrine
        EnemyCurrentRoom.SheikahShrine.east = Kakariko;
        EnemyCurrentRoom.SheikahShrine.characters.Add(CharacterSetup.guardian);
        EnemyCurrentRoom.SheikahShrine.roomInventory.Add(potion);
        
        //ZoraDomain
        ZoraDomain.north = HyruleCastle;
        ZoraDomain.west = Kakariko;
        ZoraDomain.characters.Add(CharacterSetup.zora);
        
        //HyruleCastle
        HyruleCastle.south = ZoraDomain;
        HyruleCastle.characters.Add(CharacterSetup.ganon);
        CharacterSetup.ganon.inventory.Add(statueOfZelda);
        
        //List<Room>
        rooms.Add(Field);
        rooms.Add(Kakariko);
        rooms.Add(ZoraDomain);
        rooms.Add(EnemyCurrentRoom.SheikahShrine);
        rooms.Add(HyruleCastle);

        return Field;
        
    } 
        
            
}        
      
    
}