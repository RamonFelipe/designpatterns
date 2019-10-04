using System;

public class Light
{
    public void On()
    {
        Console.WriteLine("The light is on!");
        Console.WriteLine();
    }

    internal void Off()
    {
        Console.WriteLine("The light is off!");
        Console.WriteLine();
    }
}