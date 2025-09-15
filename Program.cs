using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Vad heter du?");
        var name = Console.ReadLine();

        if (string.IsNullOrEmpty(name))
        {
            SayHello();
        }
        else
        {
            SayHello(name);
        }
    }

    static void SayHello(string name = "Gäst")
    {
        Console.WriteLine($"Hej {name}! Välkommen till programmet.");

    }
}