using System;
using System.Collections.Generic;
using System.Linq;

namespace Aufgabe3
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(toHexal(231));
        }

        public static int toHexal(int dec){
            int factor;
            int hexal = 0;
            System.Collections.Generic.List<int> residuals = new System.Collections.Generic.List<int>();
            if(dec <= 1023 && dec >= 0){
                do{
                    int modulo = dec % 6;
                    int dec_minus_modulo = dec - modulo;
                    residuals.Add(modulo);
                    //residuals.Insert(0, dec_minus_modulo);
                    factor = dec_minus_modulo/6;
                    dec = factor;
                    
                    //string a = residuals.ToString();
                    //Console.WriteLine(a);
                }while(factor != 0);
            }
            residuals.Reverse();
            for(int i = 0; i<=residuals.Count-1; i++){
                hexal += residuals[i] * Convert.ToInt32(Math.Pow(10,residuals.Count-i-1));
            }
             
            return hexal;
            //Math.Exp(System.Double)
            
        }
    }
}
