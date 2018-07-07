using System;
using System.Collections.Generic;

namespace Aufgabe10
{
    
    class GameData{

        public static List<string> commands = new List<string>
        {
            "[north/n] [east/e] [south/s] [west/w]",
            "[help/h] [look/l] [inventory/i]",
            "[take] [drop/d <item>] [arm/d <item>] [use/d <item>]",
            "[quit]"
        };

         public static void GameStart(){
            HelpMethods.GameDescription();
        }
        
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
    

    
    
}
