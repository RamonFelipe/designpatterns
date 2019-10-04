using System;

namespace ChocolateBoiler.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var chocolateBoiler = ChocolateBoiler.GetInstance();
            chocolateBoiler.Fill();
            chocolateBoiler.Boil();
            chocolateBoiler.Drain();
        }
    }
}
