using System;
using System.Collections.Generic;

namespace Aufgabe10
{
    public class HelpMethods{
        public static void tellCases(){
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "yes":
                case "y":
                    Console.WriteLine("Oh that is great. Than i have no doubt you will defeat this beast! Fare well my Friend!");
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
    }

}