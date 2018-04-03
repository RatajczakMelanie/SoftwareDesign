using System;

namespace Aufgabe1
{
    class Program
    {
        public static double w;
        public static double k;
        public static double o;
        

        public static void getCubeVolume(char typevolume, double d){
            //int d = 2;
            switch (typevolume)
                {
                    case 'w':
                        w = Math.Pow(d,3);
                       /* Console.WriteLine(w);*/
                        break;
                    case 'k':
                        k = Math.PI*Math.Pow(d,3)/6;
                        //Console.WriteLine(k);
                        break;
                    case 'o':
                        o = Math.Sqrt(2)*Math.Pow(d,3)/3;
                       // Console.WriteLine(o);
                        break;
                    default:
                        Console.WriteLine("Dein Wert " + typevolume + " ist ungültig");
                        break;
                }
        }
        public static void getCubeSurface(char typesurface, double d){
            switch (typesurface)
                {
                    case 'w':
                        w = 6*Math.Pow(d,2);
                        break;
                    case 'k':
                        k = Math.PI*Math.Pow(d,2);
                        break;
                    case 'o':
                        o = 2*Math.Sqrt(3)*Math.Pow(d,2);
                        //Console.WriteLine(o);
                        break;
                    default:
                        Console.WriteLine("Dein Wert " + typesurface + " ist ungültig");
                        break;
                }
        }

        static void Main(string[] args)
        {   
            char b;
            double d;

           //foreach(string arg in args){
                b =  char.Parse(args[0]);
                d = double.Parse(args[1]);             
           // }
            getCubeInfo(b, d); 
            
        }

        



        public static void getCubeInfo(char objectType, double d){

            getCubeVolume(objectType, d);
            Console.Write("V = ");
            switch(objectType){
                case 'w':
                Console.WriteLine(w);
                break;
                case 'k':
                Console.WriteLine(k);
                break;
                case 'o':
                Console.WriteLine(o);
                break;
                default:
                break;
            }

            getCubeSurface(objectType, d);
            Console.Write("A = ");
            switch(objectType){
                case 'w':
                Console.WriteLine(w);
                Console.WriteLine("Körper : Würfel");
                break;
                case 'k':
                Console.WriteLine(k);
                Console.WriteLine("Körper : Kugel");
                break;
                case 'o':
                Console.WriteLine(o);
                Console.WriteLine("Körper : Oktaeder");
                break;
                default:
                break;
            }
        }

    }  
}
