using System;
using Strategy.ConsoleApp.FlyBehavior;
using Strategy.ConsoleApp.QuackBehavior;

namespace Strategy.ConsoleApp
{
    public class CallDuck : Duck
    {
        public CallDuck()
        {
            quackBehavior = new Squeak();
            flyBehavior = new FlyNoWay();
        }
        public override void Display() => Console.WriteLine("I'm a device not a duck.");
    }
}