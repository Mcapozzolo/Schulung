using System;
using System.Threading.Channels;

public class Ceasarverschlüsselung
{
    public static string Lock(string s){
        string res="";
        int i = 0;
        foreach(char c in s)
        {
            res.Insert(i, ((char)(c + 3)).ToString()); 
        }
        return res;
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