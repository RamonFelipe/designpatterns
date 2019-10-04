using System;
using Strategy.ConsoleApp.FlyBehavior;
using Strategy.ConsoleApp.QuackBehavior;

namespace Strategy.ConsoleApp
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new RealQuack();
            flyBehavior = new FlyWithWings();
        }

        public override void Display() => Console.WriteLine("I'm a real Mallard duck");
    }
}