using System;
using Strategy.Exercise.ConsoleApp.WeaponBehavior;

namespace Strategy.Exercise.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Character king = new King();

            king.Fight();

            king.SetWeapon(new SwordBehavior());

            king.Fight();   
        }
    }
}
