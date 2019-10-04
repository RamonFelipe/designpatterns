using System;

namespace Strategy.ConsoleApp.FlyBehavior
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly() => Console.WriteLine("I'm flying!");  
    }
}