using System;

namespace Proget
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dimmi un numero: ");
            int num = Convert.ToInt32(Console.ReadLine());            
            Console.Write("Dimmi una base: ");
            int div = Convert.ToInt32(Console.ReadLine());

          
            string res = "";

            while(num > 0)
            {
                int resto = num % div;
                string alfa = "";
                switch (resto)
                {
                    case 10:
                        alfa = "A";
                        break;                    
                    case 11:
                        alfa = "B";
                        break;                    
                    case 12:
                        alfa = "C";
                        break;                    
                    case 13:
                        alfa = "D";
                        break;                    
                    case 14:
                        alfa = "E";
                        break;                    
                    case 15:
                        alfa = "F";
                        break;
                    default:
                        alfa = alfa + resto;
                        break;
                }
                res = alfa + res;
                num = num / div;
            }

            Console.WriteLine($"Il risultato è pari a: {res}");
        }
    }
}
