using System;
using System.ComponentModel.Design;
namespace Uppgift4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj något från menyn:");
            Console.WriteLine("1. Subrathera ett tal med ett annat tal");
            Console.WriteLine("2. Dividera ett tal med ett annat tal");
            Console.WriteLine("3. Avsluta programmet");
            Console.WriteLine("Välj ett alternativ:");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv in det första talet:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv in det andra talet:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            switch (choice) 
            {
                case 1:
                    Console.WriteLine($"Resultat: {number1 - number2}");
                    break;
                case 2:
                    Console.WriteLine($"Resultat: {number1 / number2}");

                    break;
                case 3:
                    Console.WriteLine("Programmet avslutas.");
                    break;
                default:
                    Console.WriteLine("Ogiltigt val.");
                    break;
                
                    
                   
            }
        }
    }
}
