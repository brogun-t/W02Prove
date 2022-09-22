using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> names = new List<string>();
        names.Add("Bob");
        names.Add("Jimbo");
        names.Add("Henrieta");

        names.ForEach(name => Console.Write(name + " "));

        List<string> stuff = new List<string>{"a", "b", "c", "d"};
        stuff.ForEach(thing => Console.Write(thing + " "));

        int x = 5;
        int y = 7;
        int result = adder(x,y);

        Console.WriteLine($"{x} + {y} = {result}");

    }

    static int adder(int a, int b)
    {
        return a + b;
    }
}