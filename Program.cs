using System;
class Program
{
    static void Main(string[] args)
    {
        // Ask for the user's name
        Console.WriteLine("Vad heter du?");
        var name = Console.ReadLine();

        // Call the method to say hello
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
        // Print a greeting message
        Console.WriteLine($"Hej {name}! Välkommen till programmet.");
    }
}