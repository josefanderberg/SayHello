using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Vad heter du?");
        var name = Console.ReadLine();
        SayHello(name);
    }

    static void SayHello(string name)
    {
        Console.WriteLine($"Hej {name}! Välkommen till programmet.");

    }
}