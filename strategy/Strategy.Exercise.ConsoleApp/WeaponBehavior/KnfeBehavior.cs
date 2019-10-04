using System;

namespace Strategy.Exercise.ConsoleApp.WeaponBehavior
{
    public class KnifeBehavior : IWeaponBehavior
    {
        public void UseWeapon() => Console.WriteLine("I'm attacking with a knife.");
    }
}