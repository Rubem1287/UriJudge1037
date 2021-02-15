using System;
using System.Globalization;
namespace Uri_1037
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (a >= 0 && a <= 25)
            {
                
                Console.Write("Intervalo : 0,25");

            }

            else if (a >= 25.01 && a <= 50)
            {
                Console.Write("Intervalo : 25,50");
            }



            else if (a >= 50.01 && a <= 75)
            {
                Console.Write("Intervalo : 50,75");
            }



            else if (a >= 75.01 && a <= 100)
            {
                Console.Write("Intervalo : 75,100");
            }
            

            if (a >= 100.01 || a < 0)
            {
               
                Console.Write("Fora de intervalo");
            }

           
        }
    }
}
