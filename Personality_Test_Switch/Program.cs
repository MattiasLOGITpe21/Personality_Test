using System;

namespace Personality_Test_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma lemmikvärv");
            string lemmikvärv = Console.ReadLine().ToLower();

            switch (lemmikvärv)
            {
                case "punane":
                    Console.WriteLine("Oled romantiline");
                    break;
                case "sinine":
                    Console.WriteLine("Oled töökas");
                    break;
                case "roheline":
                    Console.WriteLine("Oled looduse sõber");
                    break;
                default:
                    Console.WriteLine($"Oled {lemmikvärv} ükssarvik");
                    break;

            }
            Console.ReadLine();
        }
    }
}
