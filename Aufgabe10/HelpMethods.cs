using System;
using System.Collections.Generic;

namespace Aufgabe10
{
    public class HelpMethods{

        public static string [] words;
        public static bool isFightCase = true;
        public static void tellCases(){
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

                default:
                    Console.WriteLine("I did not understand what you said. Please answer with [yes/y] or [no/n].");
                    tellCases();
                    break;
            }
        }

        public static void displayWholeInventory(){
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

         public static void GameDescription()
        {
            string gameDescription = 
        "Hello adventurerer, Welcome to a game full of mysteries and danger. You're name is Link right?" 
        + Environment.NewLine 
        + "Open all possible commands by pressing [help/h]."
        + Environment.NewLine 
        + "To end your adventure and go back to your boring life press [q]. "
        + Environment.NewLine 
        + "Your aventure is starting right this second...";
        Console.WriteLine(gameDescription);
        }

        public static Array SplitInput()
        {
            string _input = Console.ReadLine().ToLower();
            words = _input.Split(' ');
            return words;
        }

        public static float Arm(string _words){
            return 0.1F;
        }

        public static float Use(string _words){
            return 0.2F;
        }

        public static float Fight(){
            return 0.2F;
        }

        public static void CheckCases(){
            SplitInput();
            CheckFightCases(words);
            
        }
        public static void CheckFightCases(string [] _words){
            
            words = _words;

            switch(_words[0])
            {
                case "q":
                case "quit":
                Quit();
                break;

                case "a":
                case "arm":
                Arm(words[1]);
                break;

                case "u":
                case "use":
                Use(words[1]);
                break;

                case "h":
                case "help":
                Help();
                break;

                case "i":
                case "inventory":
                displayWholeInventory();
                break;

                case "f":
                case "fight":
                Fight();
                break;

                // if(enemy im raum){}
                default:
                Console.WriteLine("Your input is invalid. Try again. Valid inputs are [arm/a], [inventory/i], [use/u], [quit/q], [fight/f]");
                isFightCase = false;
                break;

                /*else{
                default:
                isFightCase = false;
                CheckNonFightCases();
                break;
                }*/
            }
        }

        public static void CheckNonFightCases(string [] _words)
        {
            words = _words;

            switch(_words[0])
            {
                case "h":
                case "help":
                Help();
                break;

                case "d":
                case "drop":
                Arm(words[1]);
                break;

                case "l":
                case "look":
                Use(words[1]);
                break;

                case "i":
                case "inventory":
                displayWholeInventory();
                break;

                case "t":
                case "take":
                Take();
                break;

                case "m":
                case "move":
                Moving.Move();
                break;

                default:
                Console.WriteLine("Your input is invalid. Press [help/h] to display all possible commands.");
                CheckCases();
                break;
            }
            
        }

        public static void Help(){
            Console.WriteLine("Commands:"+Environment.NewLine);
            foreach(var command in GameData.commands){
                Console.WriteLine(command);
            }
        }

        public static void Take(){

        }
        public static void Quit(){
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-END-");
            Console.ResetColor();
            Environment.Exit(0);
        }
    }
}