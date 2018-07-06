using System;
using System.Collections.Generic;

namespace Aufgabe10
{
    //class GameData{
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

    class Friend : Character
    {
              public void tell()
        {
            Console.Write("Weiche zurück!");
        }        
    }

    public class Enemy : Character
    {


    } 


    //GameData Class}

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
        public void arm(){

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
/* 
    public class Field : Room{

    }

    public class Kakariko : Room{

    }

    public class ZoraDomain : Room{

    }

    public class SheikahShrine : Room{

    }
    public class HyruleCastle : Room{

    } */

}
