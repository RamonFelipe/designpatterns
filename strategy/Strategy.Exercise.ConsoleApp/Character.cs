using Strategy.Exercise.ConsoleApp.WeaponBehavior;

namespace Strategy.Exercise.ConsoleApp
{
    public abstract class Character
    {
        protected IWeaponBehavior weaponBehavior;

        public void Fight() => weaponBehavior.UseWeapon();

        public void SetWeapon(IWeaponBehavior weaponBehavior) => this.weaponBehavior = weaponBehavior;
    }
}