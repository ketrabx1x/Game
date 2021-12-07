using System;

namespace PowiedzmyZeGra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Witaj!");
            Console.WriteLine("Czy chcesz rozpocząć nową gre? T/N");
            String czy = Console.ReadLine();
            if (czy.Equals("N"))
            {
                Console.WriteLine("Koniec gry!");
                return;
            }
            else if (czy.Equals("T")) ;
            else
            {
                Console.WriteLine("Zła opcja!");
                return;
            }
            Console.WriteLine("Witaj w kreatorze postaci"); ;
            Console.Write("\tPodaj imie swojej postaci: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            String imie = Console.ReadLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Postac postac = new Postac(imie, 2, 2, 2);
            Console.Write("\tWitaj ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(imie);
            Console.ResetColor();
            Console.WriteLine();
            int punkty = 5;
            while (punkty > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine();
                Console.WriteLine("Twoje punkty: siła (" + postac.sila + ") zdrowie (" + postac.zdrowie + ") charyzma (" + postac.charyzma + ")");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Masz " + punkty + " punktów do rozdania");
                Console.WriteLine("\t(1) +1 do siły");
                Console.WriteLine("\t(2) +1 do zdrowia");
                Console.WriteLine("\t(3) +1 do charyzmy");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                String czy2 = Console.ReadLine();
                if (czy2.Equals("1"))
                {
                    postac.DodajSile();
                    punkty--;
                }
                else if (czy2.Equals("2"))
                {
                    postac.DodajZdrowie();
                    punkty--;
                }
                else if (czy2.Equals("3"))
                {
                    postac.DodajCharyzme();
                    punkty--;
                }
                else
                {
                    Console.WriteLine("Zła liczba");
                }
                Console.ResetColor();
                if (punkty == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Twoje punkty: siła (" + postac.sila + ") zdrowie (" + postac.zdrowie + ") charyzma (" + postac.charyzma + ")");
                    Console.ResetColor();
                }
                Console.ResetColor();
            }
            Console.ReadKey();
        }
    }
}