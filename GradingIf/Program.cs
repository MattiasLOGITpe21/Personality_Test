using System;

namespace GradingIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis hinde sa said?");
            int hinne = Convert.ToInt32(Console.ReadLine());

            if (hinne == 5)
            {
                Console.WriteLine("Suurepärane");
            }
            else if (hinne == 4)
            {
                Console.WriteLine("Väga hea");
            }
            else if (hinne == 3)
            {
                Console.WriteLine("Hea");
            }
            else if (hinne == 2)
            {
                Console.WriteLine("Rahuldav");
            }
            else
            {
                Console.WriteLine("Puudulik");
            }
            Console.WriteLine("Tubli töö");
            Console.ReadLine();
        }
    }
}
