using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Största(10, 20));
        int tal1 = int.Parse(Console.ReadLine());
        int tal2 = int.Parse(Console.ReadLine());  
    }
    static int Största(int tal1, int tal2)
    {
        if (tal1 > tal2)
        {
            return tal1;
        }
        else
        {
            return tal2;
        }
        Console.WriteLine(Största(tal1, tal2));

    }
}
