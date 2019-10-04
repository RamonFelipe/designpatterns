using System;

namespace Strategy.ConsoleApp.QuackBehavior
{
    public class Squeak : IQuackBehavior
    {
        public void Quack() => Console.WriteLine("Squeak");
    }
}