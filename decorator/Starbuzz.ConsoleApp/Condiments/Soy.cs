namespace Starbuzz.ConsoleApp
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage) 
        : base(beverage)
        {
        }

        public override string GetDescription() => $"{this.beverage.GetDescription()}, Soy";

        public override double Cost() => 0.15 + this.beverage.Cost();
    }
}