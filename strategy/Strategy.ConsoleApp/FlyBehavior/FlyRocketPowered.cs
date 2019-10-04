using System;

namespace Strategy.ConsoleApp.FlyBehavior
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly() => Console.WriteLine("I'm flying with a rocket.");
    }
}