
using System;
namespace uppgift4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många X per grupp?");
            int xPerGroup = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hur många O per grupp?");
            int oPerGroup = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hur många O-mönster per rad?");
            int oPatternsPerRow = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hur många rader?");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < oPatternsPerRow; j++)
                {
                    for (int k = 0; k < xPerGroup; k++)
                    {
                        Console.Write("X");
                    }

                    Console.Write("-");

                    for (int l = 0; l < oPerGroup; l++)
                    {
                        Console.Write("O");
                    }

                    Console.Write("-");
                }

                for (int k = 0; k < xPerGroup; k++)
                {
                    Console.Write("X");
                }

                Console.WriteLine();
            }
        }
    }
}

