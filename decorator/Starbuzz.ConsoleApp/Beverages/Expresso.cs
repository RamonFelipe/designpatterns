namespace Starbuzz.ConsoleApp
{
    public class Expresso : Beverage
    {
        public Expresso()
        {
            description = "Expresso";
        }

        public override double Cost() => 1.99;
    }
}