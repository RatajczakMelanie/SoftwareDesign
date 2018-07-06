using System;
using System.Collections.Generic;

namespace Aufgabe10
{
    class ItemSetup{
        public static List<Normal> normal = new List<Normal>();
         public static List<Gear> gear = new List<Gear>();
          public static List<Health> health = new List<Health>();
        public static void createItems()
        {   
            Normal description = new Normal
            {
                type = "  type  ",
                name = "  name  ",
                placeholder = "  HP/LP (only gear/health)    armed (only gear)  ",
                information = "  information  ",
            };
            normal.Add(description);

            Health potion = new Health{
                type = "health",
                name = "potion",
                lifepoints = 0.3F,
                information = "LP +0.3"
            };
            health.Add(potion);

            Gear sword = new Gear{
                type = "gear",
                name = "Mastersword",
                armed = false,
                hitpoints = 0.2F,
                information = "HP +0.2",
            };
            gear.Add(sword);

            Normal sheikahStone = new Normal{
                type = "normal",
                name = "Sheikastone",
                placeholder = "   ",
                information = "The Shiekahstone reveals a secret passageway to you.",
            };
            normal.Add(sheikahStone);
        }
    }
}