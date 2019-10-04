namespace Starbuzz.ConsoleApp
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage) : base(beverage)
        {
        }

        public override string GetDescription() => $"{this.beverage.GetDescription()}, Whip";

        public override double Cost() => 0.10 + this.beverage.Cost();
    }
}