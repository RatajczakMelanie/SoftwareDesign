using System;
using System.Collections.Generic;

namespace Abgabe
{
    public class HelpMethods
    {

        public static string [] words;
        public static Room currentRoom = Room.createData();
        public static Room currentEnemyRoom = EnemyCurrentRoom.SheikahShrine;
        public static bool isFightCase = true;
        public static List<string> commands = new List<string>
        {
            "[north/n] [east/e] [south/s] [west/w]",
            "[help/h] [look/l] [inventory/i]",
            "[take] [drop/d <item>] [arm/d <item>] [use/d <item>]",
            "[quit]"
        };
    

        public static void TellCases()
        {
            string input = Console.ReadLine().ToLower();
            
            switch (input)
            {
                case "yes":
                case "y":
                    Console.WriteLine("Oh that is great. Than i have no doubt you will defeat this beast! Farewell my Friend!");
                    break;

                case "no":
                case "n":
                    Console.WriteLine("That is not good. Go back to the field your journey started and look for a sword of your kind!");
                    break;
                
                case "q":
                    case "quit":
                    Quit();
                    break;

                default:
                    Console.WriteLine("I did not understand what you said. Please answer with [yes/y] or [no/n].");
                    TellCases();
                    break;
            }
            
        }
        public static void displayInventory()
        {
            
            Console.WriteLine("Inventory:" + Environment.NewLine + "Name - Type - Armed - Lifepoints - Hitpoints - Information ");
            foreach(var item in CharacterSetup.link.inventory)
            {
                Console.WriteLine( item.name + "      " +  item.type + "    " + item.armed + "    " + item.lifepoints + "    " + item.hitpoints + "    " + item.information );
            } 
            
         } 
        public static void GameDescription()
        {
            string gameDescription = 
            Environment.NewLine +
            "Hello adventurerer, Welcome to a game full of mysteries and danger. You're name is Link right?" 
            + Environment.NewLine 
            + "Open all possible commands by pressing [help/h]."
            + Environment.NewLine 
            + "To end your adventure and go back to your boring life press [q]. "
            + Environment.NewLine 
            + "Your aventure is starting right this second...";
            Console.WriteLine(gameDescription);
        }
        public static void Quit()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-END-");
            Console.ResetColor();
            Environment.Exit(0);
        }
        public static void Help()
        {
            Console.WriteLine("Commands:"+Environment.NewLine);
            foreach(var command in commands)
            {
                Console.WriteLine(command);
            }
        }
        public static void Take(string itemname, Room room)
        {
            List<Item> roomInventory_Copy = new List<Item>();
            
            foreach(var item in room.roomInventory)
            {
                if(itemname == item.name)
                {
                    Console.WriteLine("You took: " + itemname);
                    //CharacterSetup.link.inventory.Add(item);
                    roomInventory_Copy.Add(item);
                    CharacterSetup.link.inventory.Add(item);
                   
                }
            } 
            foreach(var item in roomInventory_Copy){
                room.roomInventory.Remove(item);
                 
            }
            /* foreach(var item in room.roomInventory){
                        Console.WriteLine(item.name);
                    } */
        }

         public static void Drop(string itemname, Room room)
         {
            List<Item> inventory_Copy = new List<Item>();
            
            foreach(var item in CharacterSetup.link.inventory)
            {
                if(itemname == item.name)
                {
                    Console.WriteLine("You dropped: " + itemname);
                    //CharacterSetup.link.inventory.Add(item);
                    inventory_Copy.Add(item);
                    room.roomInventory.Add(item);
                   
                }
            } 
            foreach(var item in inventory_Copy){
                CharacterSetup.link.inventory.Remove(item);
                 
            }
            /* foreach(var item in CharacterSetup.link.inventory){
                        Console.WriteLine(item.name);
                    } */
        } 
        public static void Chat(){
            Console.WriteLine("Hello adventurer... wait... Link is that you? You must no that ahead lies the Castle of Hyrule. The Calamity Ganon has poisened this ground. Before you go any further, have you armed a sword?");
            TellCases();
        }

        public static void Fight(){
            List<CharacterSetup.Character> characters_Copy = new List<CharacterSetup.Character>(); 
            
                foreach(var enemy in currentRoom.characters)
                {
                    if (enemy.type == "Enemy")
                    {
                        enemy.lifepoints = enemy.lifepoints - CharacterSetup.link.hitpoints;
                        if(enemy.lifepoints < 0){
                            enemy.lifepoints = 0;
                        }
                        Console.WriteLine("You cost " + enemy.name + " " + CharacterSetup.link.hitpoints + " Hitpoints. The beast fights back! ");
                        CharacterSetup.link.lifepoints = CharacterSetup.link.lifepoints - enemy.hitpoints;
                        Console.WriteLine("Your lifepoints: " + CharacterSetup.link.lifepoints  + " / Your enemy's lifepoints: " + enemy.lifepoints );
                        
                        if (enemy.lifepoints > 0)
                        {
                            Console.WriteLine("Attack again!");
                        }
                        
                    }
                    
                    if (enemy.lifepoints <= 0){
                        Console.WriteLine("Nice, you've slain the beast!");
                        characters_Copy.Add(enemy);
                    }
                    if (CharacterSetup.link.lifepoints <=  0){
                        Console.WriteLine("You're dead. Try again.");
                        Quit();
                    }
                }
                foreach(var enemy in characters_Copy){
                    currentRoom.characters.Remove(enemy);
                    EnemyCurrentRoom.SheikahShrine.characters.Remove(enemy);
                }
            
        }
        
        public static void Look(){
            Room.RoomDescription(currentRoom);
        }

        public static void Arm(string itemname)
        {

            List<Item> inventory_Copy = new List<Item>();

            float hitpoints = CharacterSetup.link.hitpoints;

            if(CharacterSetup.link.inventory.Count != 0)
            {

                foreach(var item in CharacterSetup.link.inventory)
                {
                    
                    if(itemname == item.name)
                    {
                        if(item.type == "gear")
                        {
                            Console.WriteLine("You armed: " + itemname);
                            float hitpointsItem = item.hitpoints;
                            float upgradedHitpoints = hitpoints + hitpointsItem;
                            Console.WriteLine("Your hitpoints were upgraded from " + CharacterSetup.link.hitpoints + " to " + upgradedHitpoints);
                            CharacterSetup.link.hitpoints = upgradedHitpoints;
                            item.armed = true;
                            inventory_Copy.Add(item);
                            currentRoom.roomInventory.Remove(item);
                        
                        }
                        else
                        {
                            Console.WriteLine("You can only arm items with type 'gear'");
                            
                        }
                    }
                    else
                    {
                        Console.WriteLine("There is no item inventory with that name, to see what's in your inventory press [inventory/i].");
                    }
                } 
                foreach(var item in inventory_Copy){
                    CharacterSetup.link.inventory.Remove(item);
                    
                }
            }
            else
            {
                Console.WriteLine("Either your inventory is empty or you didn't choose an item, try picking something up you can arm.");
            }
        }

        public static void Use(string itemname)
        {   

            List<Item> inventory_Copy = new List<Item>();

            float lifepoints = CharacterSetup.link.lifepoints;

            if(CharacterSetup.link.inventory.Count != 0)
            {

                foreach(var item in CharacterSetup.link.inventory)
                {
                    
                    if(itemname == item.name)
                    {
                        if(item.type == "health")
                        {
                            Console.WriteLine("You used: " + itemname);
                            float lifepointsItem = item.lifepoints;
                            float upgradedLifepoints = lifepoints + lifepointsItem;
                            Console.WriteLine("Your lifepoints were upgraded from " + CharacterSetup.link.lifepoints + " to " + upgradedLifepoints);
                            CharacterSetup.link.lifepoints = upgradedLifepoints;
                            
                            inventory_Copy.Add(item);
                            currentRoom.roomInventory.Remove(item);
                        
                        }
                        else
                        {
                             Console.WriteLine("You can only use items with type 'health'");
                        }
                    }else
                    {
                       Console.WriteLine("There is no item inventory with that name, to see what's in your inventory press [inventory/i].");
                    }    
                }     
                        foreach(var item in inventory_Copy){
                            CharacterSetup.link.inventory.Remove(item);
                        }   
                    
                    
            }else
            {
                Console.WriteLine("Either your inventory is empty or you didn't choose an item, try picking something up you can use.");
            }
            
            

            
        }
          public static Array SplitInput()
        {
            Room.RoomDescription(currentRoom);
            string input = Console.ReadLine().ToLower();
            words = input.Split(' ');
            return words;
        } 
        public static Random randomNumber = new Random();

        public static void EnemyRoomChange(){

            
            int number = randomNumber.Next(0,3);
            
            switch(number)
            {
                case 0:
                if(EnemyCurrentRoom.SheikahShrine.east != null)
                {   
                    if(currentRoom.characters.Count <= 1)
                    {
                        EnemyCurrentRoom.SheikahShrine.characters.Remove(CharacterSetup.guardian);
                        currentEnemyRoom = EnemyCurrentRoom.SheikahShrine.east;
                        currentEnemyRoom.characters.Add(CharacterSetup.guardian);
                    }
                }else{
                    number ++;
                }
                break;

                case 2:
                if(EnemyCurrentRoom.SheikahShrine.north != null)
                {
                    if(currentRoom.characters.Count <= 1)
                    {
                        EnemyCurrentRoom.SheikahShrine.characters.Remove(CharacterSetup.guardian);
                        currentEnemyRoom = EnemyCurrentRoom.SheikahShrine.north;
                        currentEnemyRoom.characters.Add(CharacterSetup.guardian);
                    }
                }else{
                    number ++;
                }
                break;

                case 1:
                if(EnemyCurrentRoom.SheikahShrine.south != null)
                {
                    if(currentRoom.characters.Count <= 1)
                    {
                        EnemyCurrentRoom.SheikahShrine.characters.Remove(CharacterSetup.guardian);
                        currentEnemyRoom = EnemyCurrentRoom.SheikahShrine.south;
                        currentEnemyRoom.characters.Add(CharacterSetup.guardian);
                    }
                }else{
                    number ++;
                }
                break;

                

                case 3:
                if(EnemyCurrentRoom.SheikahShrine.west != null)
                {
                    if(currentRoom.characters.Count <= 1)
                    {
                        EnemyCurrentRoom.SheikahShrine.characters.Remove(CharacterSetup.guardian);
                        currentEnemyRoom = EnemyCurrentRoom.SheikahShrine.west;
                        currentEnemyRoom.characters.Add(CharacterSetup.guardian);
                    }
                }else{
                    number ++;
                }
                break;

                default:
                number = 0;
                Console.WriteLine("Error in EnemyRoomChange(). Check if your room has any neighbours.");
                break;
            }
            
        }

        public static Room RoomChange(string direction){
            
            switch(direction){
                case "north":
                currentRoom.characters.Remove(CharacterSetup.link);
                currentRoom = currentRoom.north;
                currentRoom.characters.Add(CharacterSetup.link);
                EnemyRoomChange();
                break;

                case "east":
                currentRoom.characters.Remove(CharacterSetup.link);
                currentRoom = currentRoom.east;
                currentRoom.characters.Add(CharacterSetup.link);
                EnemyRoomChange();
                break;

                case "south":
                currentRoom.characters.Remove(CharacterSetup.link);
                currentRoom = currentRoom.south;
                currentRoom.characters.Add(CharacterSetup.link);
                EnemyRoomChange();
                break;

                case "west":
                currentRoom.characters.Remove(CharacterSetup.link);
                currentRoom = currentRoom.west;
                currentRoom.characters.Add(CharacterSetup.link);
                EnemyRoomChange();
                break;


                default:
                Console.WriteLine("Error in method RoomChange");
                break;
            }
            return currentRoom;

            

            
        }

       
        public static void CheckCases()
        {
            
            
            
            //string input = "";
            
            for(;;){
                SplitInput();
                
                switch(words[0])
                {
                    case "n":
                    case "north":
                    if(currentRoom.north != null)
                    {
                        //currentRoom.characters.Remove(CharacterSetup.link);
                       /*  foreach(var character in currentRoom.characters)
                        {
                            Console.WriteLine(character.name);
                        } */
                        RoomChange("north");
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
                    if(currentRoom.east != null)
                    {
                       RoomChange("east");
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
                    if(currentRoom.south != null)
                    {
                        RoomChange("south");
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
                    if(currentRoom.west != null)
                    {
                        RoomChange("west");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Nothing Here!");
                        Console.ResetColor();
                    }
                    break;

                    case "q":
                    case "quit":
                    Quit();
                    break;

                    case "a":
                    case "arm":
                    if(words.Length > 1){
                        Arm(words[1]);
                    }else{
                        Console.WriteLine("You need to enter two words.");
                    }
                    break;

                    case "u":
                    case "use":
                    if(words.Length > 1){
                        Use(words[1]);
                    }else{
                        Console.WriteLine("You need to enter two words.");
                    }
                    break;

                    case "h":
                    case "help":
                    Help();
                    break;

                    case "i":
                    case "inventory":
                    displayInventory();
                    break;

                    case "f":
                    case "fight":
                    Fight();
                    break;

                    case "d":
                    case "drop":
                    if(words.Length > 1){
                        Drop(words[1], currentRoom);
                    }else{
                        Console.WriteLine("You need to enter two words.");
                    }
                    
                    break;

                    case "l":
                    case "look":
                    Look();
                    break;

                    case "t":
                    case "take":
                    if(words.Length > 1){
                        Take(words[1], currentRoom);
                    }else{
                        Console.WriteLine("You need to enter two words.");
                    }
                    break;

                    case "c":
                    case "chat":
                    Chat();
                    break;

                    default:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("I can not understand a word you're saying. Just try again."
                    + Environment.NewLine
                    + "Open the possible commands by pressing [help/h]");
                    Console.ResetColor();
                    break;
                }
            }
        }        
    }
}