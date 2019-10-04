namespace Starbuzz.ConsoleApp
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            this.description = "Dark Roast";
        }

        public override double Cost() => 0.99;
    }
}