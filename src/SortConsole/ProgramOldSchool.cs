using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortConsole
{
    public static class ProgramOldSchool
    {
        public static void Main(string[] args)
        {
            string menuChoice;

            do
            {

                Console.WriteLine(@"
┌─────────────────────────────────────────┐
│ Was möchten sie tun?                    │
├─────────────────────────────────────────┤
│ 1) Zahlen sortieren                     │
│ 2) Text verschlüsseln                   │
│ 3) Text entschlüsseln                   │
│                                         │
│ 9) Programm verlassen                   │
└─────────────────────────────────────────┘

Ihre Eingabe: ");

                menuChoice = Console.ReadLine();
           

                while (menuChoice != "1" && menuChoice != "2" && menuChoice != "3" && menuChoice != "9")
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte 1, 2, 3 oder 9 eingeben: ");
                    menuChoice = Console.ReadLine();
                }

                if (menuChoice.Equals("2"))
                {
                    Console.WriteLine("Geben sie ein Wort ein");
                    Ceasarverschlüsselung c = new Ceasarverschlüsselung();
                    String r = Ceasarverschlüsselung.Lock(Console.ReadLine());
                    Console.WriteLine(r);
                }
                else if (menuChoice.Equals("3"))
                {
                    Console.WriteLine("Geben sie ein Wort ein");
                    Ceasarverschlüsselung c = new Ceasarverschlüsselung();
                    String r = Ceasarverschlüsselung.unlock(Console.ReadLine());
                    Console.WriteLine(r);
                }

            } while (menuChoice != "9");

            Console.WriteLine("Danke und Tschüss!");

        }
    }
}
