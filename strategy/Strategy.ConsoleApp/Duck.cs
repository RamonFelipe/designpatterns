using System;
using Strategy.ConsoleApp.FlyBehavior;
using Strategy.ConsoleApp.QuackBehavior;

namespace Strategy.ConsoleApp
{
    public abstract class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public Duck() { }

        public abstract void Display();

        public void PerformFly() => flyBehavior.Fly();
        
        public void PerformQuack() => quackBehavior.Quack();
        
        public void SetFlyBehavior(IFlyBehavior flyBehavior) => this.flyBehavior = flyBehavior;
        
        public void SetQuackBehavior(IQuackBehavior quackBehavior) => this.quackBehavior = quackBehavior;
        
        public void Swim() => Console.WriteLine("All ducks float, even decoys");
    }
}