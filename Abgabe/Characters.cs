using System;
using System.Collections.Generic;

namespace Abgabe
{

    public class CharacterSetup
    {
        public class Character
        {
            public string name;
            public string type;
            public float lifepoints;
            public float hitpoints;
            public string information;
            public List<Item> inventory;

        }

        public static Avatar link = new Avatar
        (
            "Link",
            "Avatar",
            1F,
            0.3F,
            new List<Item>()
        );

        public static Enemy guardian = new Enemy
        (
            "Guardian",
            "Enemy",
            0.3F,
            0.1F,
            new List<Item>()
        );

        public static Enemy ganon = new Enemy
        (
                    "the calamity ganon",
                    "Enemy",
                    1F,
                    0.2F,
                    new List<Item>()
        );

        public static Friend zora = new Friend
        (
            "Prince Sidon",
            "Friend"
        );



        public class Avatar : Character
        {
            public Avatar(string _name, string _type, float Lifepoints, float Hitpoints, List<Item> Inventory)
            {

                this.name = _name;
                this.type = _type;
                this.lifepoints = Lifepoints;
                this.hitpoints = Hitpoints;
                this.inventory = Inventory;

            }
        }
        public class Enemy : Character
        {
            public Enemy(string _name, string _type, float Lifepoints, float Hitpoints, List<Item> Inventory)
            {

                this.name = _name;
                this.type = _type;
                this.lifepoints = Lifepoints;
                this.hitpoints = Hitpoints;
                this.inventory = Inventory;

            }

        }   

        public class Friend : Character
        {
            public Friend(string _name, string _type)
            {
                this.name = _name;
                this.type = _type;

            }
           


        }     

    }
}
