// <copyright file="Ceasarverschluesselung.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SortConsole
{
    /// <summary>
    /// Verschlüsselungsalgorithmus.
    /// </summary>
    public class Ceasarverschluesselung
    {
        /// <summary>
        /// Alles ausser klein grossbuchstaben und zahlen bleibt gleich, diese rotieren.
        /// </summary>
        /// <param name="plaintext">Klartext, der verschlüsselt wird.</param>
        /// <returns>Verschlüsselter Text von <paramref name="plaintext"/>.</returns>
        public static string Encrypt(string plaintext)
        {
            const int CipherOffset = 3;
            const int NumberZeroAscii = 48;
            const int NumberNineAscii = 57;
            const int smallLetterAAscii = 97;
            const int smallLetterZAscii = 122;
            const int bigLetterAAscii = 65;
            const int bigLetterZAscii = 90;

            char[] result = new char[plaintext.Length];
            for (int i = 0; i < result.Length; i++)
            {
                int asciiValue = (int)plaintext[i];

                // '0' <= asciiValue <= '9'
                if (asciiValue >= NumberZeroAscii && asciiValue <= NumberNineAscii)
                {
                    result[i] = (char)(((plaintext[i] - 48 + CipherOffset) % 10) + 48);
                }

                // 'A' <= asciiValue <= 'Z'
                else if (asciiValue >= bigLetterAAscii && asciiValue <= bigLetterZAscii)
                {
                    result[i] = (char)(((plaintext[i] - 65 + CipherOffset) % 26) + 65);
                }

                // 'a' <= asciiValue <= 'z'
                else if (asciiValue >= smallLetterAAscii && asciiValue <= smallLetterZAscii)
                {
                    result[i] = (char)(((plaintext[i] - 97 + CipherOffset) % 26) + 97);
                }
                else
                {
                    result[i] = plaintext[i];
                }
            }

            return new string(result);
        }

        public static string Decrypt(string s)
        {
            char[] result = new char[s.Length];
            for (int i = 0; i < result.Length; i++)
            {
                int asciiValue = System.Convert.ToInt32(s[i]);

                // Zahlen
                if (asciiValue >= 48 && asciiValue <= 57)
                {
                    int t = (int)s[i];
                    int q = Rest(t - 48 - 3, 10) + 48;
                    result[i] = (char)q;
                }

                // Grossbuchstaben
                else if (asciiValue >= 65 && asciiValue <= 90)
                {
                    int t = (int)s[i];
                    int q = Rest(t - 65 - 3, 26) + 65;
                    result[i] = (char)q;
                }

                // Kleinbuchstaben
                else if (asciiValue >= 97 && asciiValue <= 122)
                {
                    int t = (int)s[i];
                    int q = Rest(t - 97 - 3, 26) + 97;
                    result[i] = (char)q;
                }
                else
                {
                    result[i] = s[i];
                }
            }

            return new string(result);
        }

        /// <summary>
        /// Methode, damit Modulo auch für Negative Zahlen richtig funktioniert.
        /// </summary>
        /// <param name="x">Wert für Modulberechnung.</param>
        /// <param name="m">Divisor</param>
        private static int Rest(int x, int m)
        {
            return ((x % m) + m) % m;
        }
    }
}