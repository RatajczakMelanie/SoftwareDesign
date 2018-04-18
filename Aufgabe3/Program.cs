using System;

namespace Aufgabe3
{
    class Program
    {
        static void Main(string[] args)
        {
           toHexal();
        }

        static int toHexal(int dec){
            int factor;
            int [] residuals = new int[] {};
            if(dec <= 1023 && dec >= 0){
                do{
                    int modulo = dec % 6;
                    int dec_minus_modulo = dec - modulo;
                    factor = dec_minus_modulo/6;

                }while(factor != 0);
            }
        
            //Math.Exp(System.Double)
            
        }
    }
}
