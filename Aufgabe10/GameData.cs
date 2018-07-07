using System;
using System.Collections.Generic;

namespace Aufgabe10
{
    
    class GameData{

        public static string user_input = Console.ReadLine().ToLower();
    }
    public class Character
    {   
        public string name;
        public float lifepoints;
        public float hitpoints;
        public string information;
        public List<Item> inventory = new List<Item>();
          
    }

    public class Avatar : Character{
       
        public virtual void goInDirection()
        {
            Console.WriteLine("Weiche zurück!");
        }   
        public void fight()
        {
            Console.Write("Weiche zurück!");
        }  

    }

    public class Friend : Character
    {
        public static void tell()
        {
            
            Console.WriteLine("Hello i'm Prince Sidon, prince of the Zora Village. " + Environment.NewLine + "I'm so excited to meet you, but let my words be a warning. " + Environment.NewLine + "In the room in the north you'll find a cruel monster. " + Environment.NewLine + "Have you armed your sword yet? ");
            
            HelpMethods.tellCases();
        }        
    }

    public class Enemy : Character
    {


    } 


    

    public class Item{
        public string type;
        public string name;
        public string information;

    }

    public class Health : Item {
        public float lifepoints;
        public void use(){

        }
    }
    public class Gear : Item{
        public float hitpoints;
        public bool armed;
        public void arm(Item item){
            
        }
    }
    public class Normal : Item{
        public string placeholder;
        public void specialText(){

        }
    }
    

    //public List<> rooms = new List<Room>();

    public class Room{
        public string name;
        public string information;
        public List<Character> characters;
        public Dictionary<string, Room> neighbours;
        public Dictionary<string, Item> roomInventory;
        
    }
    
}
