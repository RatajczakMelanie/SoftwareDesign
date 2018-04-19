using System;
using System.Collections.Generic;

namespace Aufgabe3
{
    class Program
    {
        static void Main(string[] args)
        { 
           /* Console.WriteLine(ConvertDecimalToHexal(15));
           Console.WriteLine(ConvertHexalToDecimal(23));
           Console.WriteLine(ConvertToBaseFromDecimal(6,231));
           Console.WriteLine(ConvertToDecimalFromBase(6,1023)); */
           ConvertNumberToBaseFromBase(231, 6,10);
           Console.WriteLine("Die Zahl "+ input +" vom "+ f_base +"er System entspricht der Zahl " + systemNumber + " im "+ t_base +"er System." );
        }
        static int systemNumber;
        static int sum;

        static int input;
        static int f_base;
        static int t_base;
        
        public static int ConvertDecimalToHexal(int dec){
            ConvertToBaseFromDecimal(6,dec);
            return systemNumber;
        }

        public static int ConvertHexalToDecimal(int hexal){
            ConvertToDecimalFromBase(6,hexal);
            return sum;
        }

        public static int ConvertToBaseFromDecimal(int toBase, int dec){
            int factor;
            systemNumber = 0;
            List<int> residuals = new List<int>();
            if(dec <= 1023 && dec >= 0){
                do{
                    int modulo = dec % toBase;
                    residuals.Add(modulo);
                    int dec_minus_modulo = dec - modulo;
                    factor = dec_minus_modulo/toBase;
                    dec = factor;
                }while(factor != 0);
            }
            residuals.Reverse();
            for(int i = 0; i<=residuals.Count-1; i++){
                systemNumber += residuals[i] * Convert.ToInt32(Math.Pow(10,residuals.Count-i-1));
            }
            return systemNumber;
        
        }
        public static int ConvertToDecimalFromBase(int fromBase, int number){
            sum = 0;
            int[] digits = new int[1 + (int)Math.Log10(number)];
            for(int i = digits.Length-1; i >= 0; i--){
                int digit;
                number = Math.DivRem(number, 10, out digit);
                digits[i]=digit;
            }
            List<int> outputs = new List<int>();
            Array.Reverse(digits);
            for(int i= 0; i <= digits.Length-1; i++){
                int multiplication = digits[i] * (int)Math.Pow(fromBase,i);
                outputs.Add(multiplication);
            }
            for(int i= 0; i <= outputs.Count-1; i++){
                sum = sum + outputs[i];
            }
            return sum;
        }

        static int ConvertNumberToBaseFromBase(int number, int toBase, int fromBase){
            systemNumber=0;
            input = number;
            t_base = toBase;
            f_base = fromBase;

            if(toBase <= 10 && toBase >= 2 && fromBase <= 10 && fromBase >=2){
                int dec=0;
                dec = (ConvertToDecimalFromBase(fromBase,number));
                systemNumber = ConvertToBaseFromDecimal(toBase,dec);
                
            }
            return systemNumber;
        }
    }
}
