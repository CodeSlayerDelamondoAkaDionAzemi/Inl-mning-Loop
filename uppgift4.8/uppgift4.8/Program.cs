using System;
namespace uppgift4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bestäm triangelns sidlängd:");
            int längd = Convert.ToInt32(Console.ReadLine());

            if (längd <= 0)
            {
                Console.WriteLine("Sidlängden måste vara större än 0.");
                return;
            }

            else if (längd > 20)
            {
                Console.WriteLine("Sidlängden får inte vara större än 20.");
                return;
            }

            else
            {
                for (int i = 1; i <= längd; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }


            }
        }
    }
}