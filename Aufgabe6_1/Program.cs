using System;
using System.Collections.Generic;

namespace Aufgabe6_1
{

    public class Person
    {
        public string Name;
        public int Age;
        private int Id;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Id = IDGenerator.GetInstance().GibMirNeId();
        }

        public override string ToString()
        {
            return "Name:" + Name + ", Age: " + Age + ", " + "Id: " + Id;
        }
    }

    /*
    class GlobalVariables
    {
        // public static int letzteID = 1;
        public static IDGenerator DerIdMacher = new IDGenerator();
    }
    */

    public class IDGenerator
    {
        private IDGenerator()
        {
            letzteID = 1;
        }

        private static IDGenerator _instance;

        public static IDGenerator GetInstance()
        {
            if (_instance == null)
                _instance = new IDGenerator();
            return _instance;
        }

        private int letzteID;
        public int GibMirNeId()
        {
            return letzteID++;
        }
    } 

    class Program
    {

        static void Main(string[] args)
        {
            

            List<Person> personen = new List<Person>();

            // Eine Stelle, an der Personen angelegt werden
            // {} deutet auf einen abgekürzten Konstruktor hin
            personen.Add(new Person("Dieter", 44));
            personen.Add(new Person("Hans", 54));
            personen.Add(new Person("Bernd", 44));

            foreach (var person in personen)
                Console.WriteLine(person);

            Console.WriteLine("Hello World!");
        }
    }
}