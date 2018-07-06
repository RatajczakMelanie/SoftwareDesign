using System;
using System.Collections.Generic;

namespace Aufgabe10
{
    class CharacterSetup
    {
        public static void createCharacters()
        {
            Avatar link = new Avatar
            {
                name = "Link",
                lifepoints = 1F,
                hitpoints = 0.2F,
                information = "Hi i'm Link!",
            };

            Enemy ganon = new Enemy
            {
                name = "The Calamity Ganon",
                lifepoints = 1F,
                hitpoints = 0.2F,
                information = "I'm the mighty Ganon, defeat me if you can!",
            };

            Enemy guardian = new Enemy 
            {
                name = "Guardian",
                lifepoints = 1F,
                hitpoints = 0.2F,
                information = "I'm the guardian of the Sheikah Shrine if you enter, you'll have to defeat me!",
            };

            Friend Zora = new Friend
            {
                name = "Prince Sidon",
                lifepoints = 1F,
                hitpoints = 0.2F,
                information = "Hey i'm a friendly Zora, who knows, i might have a useful tip for you.",
            };
        }
    }
}