
using System;

namespace Uppgift4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett heltal:");
            int tal = int.Parse(Console.ReadLine());
            int storstaTal = tal;

            Console.WriteLine("Vill du skriva ett nytt heltal? (ja/nej)");
            string svar = Console.ReadLine();

            while (svar == "ja")
            {
                Console.WriteLine("Skriv ett heltal:");
                int nyttTal = int.Parse(Console.ReadLine());

                if (nyttTal > storstaTal)
                {
                    storstaTal = nyttTal;
                }

                Console.WriteLine("Vill du skriva ett nytt heltal? (ja/nej)");
                svar = Console.ReadLine();
            }

            if (svar == "nej")
            {
                Console.WriteLine("Tack för ditt deltagande.");
                Console.WriteLine("Det största heltalet du skrev var: " + storstaTal);
            }
            else
            {
                Console.WriteLine("Ogiltigt svar. Programmet avslutas.");
            }
        }
    }
}
