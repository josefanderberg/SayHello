using System;
class Program
{
    static void Main(string[] args)
    {
        var name = Console.ReadLine();
        SayHello(name);
    }

    static void SayHello(string name)
    {
        Console.WriteLine($"Hello {name}! Välkommen till programmet.");
    }
}