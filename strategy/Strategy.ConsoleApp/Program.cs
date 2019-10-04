using System;
using Strategy.ConsoleApp.FlyBehavior;

namespace Strategy.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck modelDuck = new CallDuck();

            modelDuck.PerformQuack();

            modelDuck.PerformFly();

            modelDuck.SetFlyBehavior(new FlyRocketPowered());

            modelDuck.PerformFly();
        }
    }
}
