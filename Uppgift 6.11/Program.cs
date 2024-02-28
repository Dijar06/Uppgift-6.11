using System;

namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett valfritt tecken till din kvadrat:");
            string tecken = Console.ReadLine();
            Console.WriteLine("Ange storlek:");
            int storlek = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange mellanrum:");
            int mellanrum = int.Parse(Console.ReadLine());
            if (mellanrum == 0)
            {
                RitaKvadrat(storlek, tecken);
            }
            else
            {
                RitaKvadrat(storlek, tecken, mellanrum);
            }

        }

        static void RitaKvadrat(int storlek, string tecken)
        {
            for (int i = 0; i < storlek; i++)
            {
                for (int j = 0; j < storlek; j++)
                {
                    Console.Write(tecken);
                }
                Console.WriteLine();
            }
        }

        static void RitaKvadrat(int storlek, string tecken, int mellanrum)
        {
            for (int i = 0; i < storlek; i++)
            {
                for (int j = 0; j < storlek; j++)
                {
                    Console.Write(tecken);
                    for (int k = 0; k < mellanrum; k++)
                    {
                        Console.Write(" ");
                    }
                }
                for (int k = 0; k < mellanrum; k++)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}