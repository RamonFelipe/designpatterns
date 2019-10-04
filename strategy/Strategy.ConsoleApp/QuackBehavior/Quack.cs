using System;

namespace Strategy.ConsoleApp.QuackBehavior
{
    public class RealQuack : IQuackBehavior
    {
        public void Quack() => Console.WriteLine("Quack");
    }
}