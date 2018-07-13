using System;
using System.Collections.Generic;

namespace Abgabe
{

    public class CharacterSetup
    {
        public class Character
        {
            public string name;
            public float lifepoints;
            public float hitpoints;
            public string information;
            public List<Item> inventory;

        }

        public static Avatar link = new Avatar
        (
            "Link",
            1F,
            0.3F,
            new List<Item>()
        );

        public static Enemy guardian = new Enemy
        (
            "Guardian",
            1F,
            0.2F,
            new List<Item>()
        );

        public static Enemy ganon = new Enemy
        (
                    "The Calamity Ganon",
                    1F,
                    0.2F,
                    new List<Item>()
        );

        public static Friend Zora = new Friend
        (
            "Prince Sidon"
        );



        public class Avatar : Character
        {
            public Avatar(string Name, float Lifepoints, float Hitpoints, List<Item> Inventory)
            {

                this.name = Name;
                this.lifepoints = Lifepoints;
                this.hitpoints = Hitpoints;
                this.inventory = Inventory;

            }
        }
        public class Enemy : Character
        {
            public Enemy(string Name, float Lifepoints, float Hitpoints, List<Item> Inventory)
            {

                this.name = Name;
                this.lifepoints = Lifepoints;
                this.hitpoints = Hitpoints;
                this.inventory = Inventory;

            }

        }   

        public class Friend : Character
        {
            public Friend(string Name)
            {
                this.name = Name;

            }
            public static void tell()
            {
                Console.WriteLine("Hello i'm Prince Sidon, prince of the Zora Village. " + Environment.NewLine + "I'm so excited to meet you, but let my words be a warning. " + Environment.NewLine + "In the room in the north you'll find a cruel monster. " + Environment.NewLine + "Have you armed your sword yet? ");
                HelpMethods.tellCases();
            }


        }     

    }
}
