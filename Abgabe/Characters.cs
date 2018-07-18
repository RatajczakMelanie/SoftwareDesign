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
            0.2F,
            new List<Item>()
        );

        public static Enemy guardian = new Enemy
        (
            "Guardian",
            "Enemy",
            "I'm the guardian of the Sheikashrine. I will protect my legacy.",
            0.5F,
            0.15F,
            new List<Item>()
        );

        public static Enemy ganon = new Enemy
        (
                    "the calamity ganon",
                    "Enemy",
                    "I'm the mighty Calamity Ganon! Defeat me if you can!",
                    0.9F,
                    0.23F,
                    new List<Item>()
        );
        

        public static Friend zora = new Friend
        (
            "Prince Sidon",
            "Friend",
            "Hey I'm Prince Sidon. You might remember my sister?"
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
            public Enemy(string _name, string _type, string _information, float Lifepoints, float Hitpoints, List<Item> Inventory)
            {

                this.name = _name;
                this.type = _type;
                this.information = _information;
                this.lifepoints = Lifepoints;
                this.hitpoints = Hitpoints;
                this.inventory = Inventory;

            }

        }   

        public class Friend : Character
        {
            public Friend(string _name, string _type, string _information)
            {
                this.name = _name;
                this.type = _type;
                this.information = _information;

            }
           


        }     

    }
}
