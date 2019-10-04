namespace Starbuzz.ConsoleApp
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage beverage;

        public CondimentDecorator(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription() => this.beverage.GetDescription();
    }
}