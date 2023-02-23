using System;

namespace Proget
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num = 0;

            Console.Write("Dimmi un numero: ");
            string numIns = Console.ReadLine();
            while(!Int32.TryParse(numIns, out num))
            {
                Console.Write("Dimmi un numero INTERO!!: ");
                numIns = Console.ReadLine();
            }
            
            int divi = 0;

            do
            {
                Console.Write("Dimmi una base tra 2 e 16: ");
                divi = Convert.ToInt32(Console.ReadLine()); ;
            } while (divi<2 || divi>16);


          
            string res = "";

            while(num > 0)
            {
                int resto = num % divi;
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
                num = num / divi;
            }
            //
            Console.WriteLine($"Il risultato è pari a: {res}");
        }
    }
}
