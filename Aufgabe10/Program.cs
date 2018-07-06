using System;
using System.Collections.Generic;

namespace Aufgabe10
{
    class Program
    {
        static void Main(string[] args)
        {

             /* RoomSetup.createRooms();
            Console.WriteLine(RoomSetup.rooms.Count);
            foreach(var room in RoomSetup.rooms){
                Console.WriteLine(room.name + "          " + room.information + "          " +room.neighbours["north"]);
            }  */
            /* 
            RoomSetup.rooms.Add(RoomSetup.Field); */

            /* CharacterSetup.createEnemies();
            CharacterSetup.createFriends(); */
            displayInventory();

            
        }

        public static void displayInventory(){
            ItemSetup.createItems();
            foreach(var item in ItemSetup.normal){
                Console.WriteLine(item.type + "      " + item.name + "      " + item.placeholder + "    " + item.information );
            } 
            foreach(var item in ItemSetup.gear){
                Console.WriteLine(item.type + "      " + item.name + "      " + item.armed + "      " + item.hitpoints+ "          " + item.information );
            }
            foreach(var item in ItemSetup.health){
                Console.WriteLine(item.type + "      " + item.name + "      " + item.lifepoints + "      " + item.information );
            }
        }
    }
}
