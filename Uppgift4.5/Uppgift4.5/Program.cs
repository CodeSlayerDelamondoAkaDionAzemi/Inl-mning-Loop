
using System;

namespace Uppgift4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal:");
            string heltal = Console.ReadLine();

            string resultat = "";

            for (int i = 0; i < heltal.Length; i++)
            {
                int siffra = int.Parse(heltal[i].ToString());

                if (siffra == 9)
                {
                    siffra = 0;
                }
                else
                {
                    siffra++;
                }

                resultat += siffra;
            }

            Console.WriteLine("Det nya talet blir: " + resultat);
        }
    }
}
