using System;
using System.Reflection.PortableExecutable;
using System.Threading.Channels;

public class Ceasarverschlüsselung
{
    public static string Lock(string s)
    {

        string res = "";
        int i = 0;
        foreach (char c in s)
        {
            // (([ASCII der Eingabe] - 48 + 3) % 10) + 48

            res = res.Insert(i, ((char)((c - 48 + 3) % 10) + 48).ToString());
            i++;
        }
        return res;
    }
    //Alles ausser klein grossbuchstaben und zahlen bleibt gleich, diese rotieren
    public static string Lock2(string s)
    {
        char[] result = new char[s.Length];
        for (int i = 0; i < result.Length; i++)
        {
            int asciiValue = System.Convert.ToInt32((char)(s[i]));
            if (asciiValue >= 48 && asciiValue <= 57)
            {
                result[i] = (char)(((s[i] - 48 + 3) % 10) + 48);
            }
            else if (asciiValue >= 65 && asciiValue <= 90)
            {
                result[i] = (char)(((s[i] - 65 + 3) % 26) + 65);
            }
            else if (asciiValue >= 97 && asciiValue <= 122)
            {
                result[i] = (char)(((s[i] - 97 + 3) % 26) + 97);
            }
            else
            {
                result[i] = s[i];
            }
        }

        return new string(result);
    }

    public static string Unlock(string s) 
    {
        char[] result = new char[s.Length];
        for (int i = 0; i < result.Length; i++)
        {
            int asciiValue = System.Convert.ToInt32((char)(s[i]));
            //Zahlen
            if (asciiValue >= 48 && asciiValue <= 57)
            {
                int t = (int)s[i];
                int q = (Rest(t - 48 - 3,10) + 48);
                result[i] = (char)(q);
            }
            //Grossbuchstaben
            else if (asciiValue >= 65 && asciiValue <= 90)
            {
                int t = (int)s[i];
                int q = (Rest(t - 65 - 3, 26) + 65);
                result[i] = (char)(q);
            }
            //Kleinbuchstaben
            else if (asciiValue >= 97 && asciiValue <= 122)
            {
                int t = (int)s[i];
                int q = (Rest(t - 97 - 3, 26) + 97);
                result[i] = (char)(q);
            }
            else
            {
                result[i] = s[i];
            }
        }
        return new string(result);
    }

    //Methode, damit Modulo auch für Negative Zahlen richtig funktioniert
    private static int Rest(int x, int m)
    {
        return (x % m + m) % m;
    }
}