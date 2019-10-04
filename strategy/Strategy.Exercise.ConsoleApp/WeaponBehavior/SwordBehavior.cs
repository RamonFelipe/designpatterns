using System;

namespace Strategy.Exercise.ConsoleApp.WeaponBehavior
{
    public class SwordBehavior : IWeaponBehavior
    {
        public void UseWeapon() => Console.WriteLine("I'm attacking with a sword.");
    }
}