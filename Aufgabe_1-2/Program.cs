using System;

namespace Aufgabe_1_2
{
    class Program
    {
        static string[] subjects = { "Harry", "Hermine", "Ron", "Hagrid", "Snape", "Dumbledore" };
        static string[] verbs = { "braut", "liebt", "studiert", "hasst", "zaubert", "zerstört" };
        static string[] objects = { "Zaubertränke", "den Grimm", "Lupin", "Hogwards", "die Karte des Rumtreibers", "Dementoren" };
        static bool[] usedsubject = {false, false, false, false, false, false};
        static bool[] usedverb = {false, false, false, false, false, false};
        static bool[] usedobject = {false, false, false, false, false, false}; 
        
        static void Main(string[] args)
        {
            for(int i=0; i<subjects.Length; i++){
                string a = GetVerse();
                Console.WriteLine(a);
            }            
        }  

        public static string GetVerse(){

            string vers;
            Random rnd = new Random();
            int cntSubj;
            int cntVerb;
            int cntObj;

            do{
                cntSubj = rnd.Next(subjects.Length);
            } while (usedsubject[cntSubj] == true);
            do{
                cntVerb = rnd.Next(verbs.Length);
            } while (usedverb[cntVerb] == true);
            do{
                cntObj = rnd.Next(objects.Length);
            } while (usedobject[cntObj] == true);

            vers = subjects[cntSubj] + " " + verbs[cntVerb] + " " + objects[cntObj];

            usedsubject[cntSubj] = true;
            usedverb[cntVerb] = true;
            usedobject[cntObj] = true;

            return vers;
        }
    }    
}