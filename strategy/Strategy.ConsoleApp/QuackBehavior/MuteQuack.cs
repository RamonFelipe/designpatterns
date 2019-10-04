using System;

namespace Strategy.ConsoleApp.QuackBehavior
{
    public class MuteQauck : IQuackBehavior
    {
        public void Quack() => Console.WriteLine("<< Silence >>");
    }
}