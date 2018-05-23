using System;

namespace Aufgabe5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public class Person
        {
            string name;
            int age;
        }

        public class Teilnehmer : Person
        {
            int registration_number;

            public void courses_to_attend(){

            }
        }
        public class Dozent : Person
        {
            float room;
            DateTime office_hours;

            public void courses_to_give(){

            }
        }
        public class Course
        {
            string title;
            DateTime course_hours;
            float room;
            public void find_Course(string Dozent, string Teilnehmer)
            {

            }
        }
        
    }
}
