namespace SortConsole
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;

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
                    menuChoice = Console.ReadLine() !;
                }

                if (menuChoice.Equals("2"))
                {
                    Console.WriteLine("Geben sie ein Wort ein");
                    Ceasarverschluesselung c = new Ceasarverschluesselung();
                    String r = Ceasarverschluesselung.Encrypt(Console.ReadLine() !);
                    Console.WriteLine(r);
                }
                else if (menuChoice.Equals("1"))
                {
                    Console.WriteLine("Geben Sie beliebige Zahlen kommagetrennt ein:");
                    string input = Console.ReadLine() !;
                    int[] inputNumbers = NumberInputReader.ReadNumberFromInput(input);

                    if (inputNumbers.Length == 0)
                    {
                        // output try again.
                    }

                    Sorter c = new Sorter();
                    int[] sortedNumbers = Sorter.Sort(inputNumbers);

                    string output = string.Join(", ", sortedNumbers);

                    Console.WriteLine(output);
                }
            }
            while (menuChoice != "9");

            Console.WriteLine("Danke und Tschüss!");
        }
    }
}
