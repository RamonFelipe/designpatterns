namespace Starbuzz.ConsoleApp
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            this.description = "House Blend Coffee";
        }

        public override double Cost() => 0.89;
    }
}