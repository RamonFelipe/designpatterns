using Strategy.Exercise.ConsoleApp.WeaponBehavior;

namespace Strategy.Exercise.ConsoleApp
{
    public class King : Character
    {
        public King()
        {
            weaponBehavior = new KnifeBehavior();
        }
    }
}