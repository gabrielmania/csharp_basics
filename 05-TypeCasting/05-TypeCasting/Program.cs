﻿class Program
{
    static void Main(string[] args)
    {
        // type casting = converting a value to a different data type
        //                useful when we accept user input (string)
        //                different data types can do different things

        double a = 3.14;
        int b = Convert.ToInt32(a);

        int c = 123;
        double d = Convert.ToDouble(c);

        int e = 123;
        String f = Convert.ToString(e);

        String g = "$";
        char h = Convert.ToChar(g);

        String i = "true";
        bool j = Convert.ToBoolean(i);

        Console.WriteLine(b.GetType());
        Console.WriteLine(d.GetType());
        Console.WriteLine(f.GetType());
        Console.WriteLine(h.GetType());
        Console.WriteLine(j.GetType());
    }
}