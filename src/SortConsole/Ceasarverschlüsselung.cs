using System;
using System.Threading.Channels;

public class Ceasarverschlüsselung
{
    public static string Lock(string s){
        string res="";
        int i = 0;
        foreach(char c in s)
        {
            res = res.Insert(i, ((char)(c + 3)).ToString()); 
            i++;
        }
        return res;
}

    public static string Lock2(string s)
    {
        char[] result = new char[s.Length];
        for(int i = 0; i < result.Length; i++)
        {
            result[i] = (char)(s[i] + 3);
        }

        return new string(result);
    }

    public static string unlock(string s)
    {
        string res = "";
        int i = 0;
        foreach (char c in s)
        {
            res.Insert(i, ((char)(c - 3)).ToString());
        }
        return res;
    }
}