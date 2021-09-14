using System;

namespace Personality_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja lemmikvärvi
            //kui kasutaja sisestab "punane", konsool kuvab "romantiline"
            //kui kasutaja sisestab "sinine", konsool kuvab "töökas"
            //kui kasutaja sisestab "roheline", konsoole kuvab "oled looduse sõber"
            //kui kasutaja sisestab midagi muud, konsool kuvab "oled ükssarvik"

            Console.WriteLine("Palun sisesta oma lemmikvärv");
            string lemmikvärv = Console.ReadLine();

            if (lemmikvärv == "punane")
            {
                Console.WriteLine("Oled romantiline inimene!");
            }
            else if (lemmikvärv == "sinine")
            {
                Console.WriteLine("Oled töökas inimene!");
            }
            else if (lemmikvärv == "roheline")
            {
                Console.WriteLine("Oled looduse sõber!");
            }
            else
            {
                Console.WriteLine($"Oled {lemmikvärv} ükssarvik!");
            }
            Console.ReadLine();
                
        }
    }
}
