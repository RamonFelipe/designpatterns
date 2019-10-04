namespace Starbuzz.ConsoleApp
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        : base(beverage)
        {
        }

        public override string GetDescription() => $"{beverage.GetDescription()}, Mocha";

        public override double Cost() => 0.20 + beverage.Cost();
    }
}