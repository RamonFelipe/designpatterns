using System;
using Strategy.ConsoleApp.FlyBehavior;
using Strategy.ConsoleApp.QuackBehavior;

namespace Strategy.ConsoleApp
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            base.flyBehavior = new FlyNoWay();
            base.quackBehavior = new RealQuack();
        }

        public override void Display() => Console.WriteLine("I'm a model duck.");
    }
}