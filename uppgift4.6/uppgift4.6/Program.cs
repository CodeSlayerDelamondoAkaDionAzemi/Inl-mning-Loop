
using System;

namespace Uppgift4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett meddelande:");
            string meddelande = Console.ReadLine();

            Console.WriteLine("Hur många steg åt höger vill du flytta meddelandet?");
            int steg = int.Parse(Console.ReadLine());

            for (int i = 0; i < meddelande.Length; i++)
            {
                for (int j = 0; j < steg; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine(meddelande[i]);
            }
        }
    }
}
