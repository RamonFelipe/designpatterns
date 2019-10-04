namespace Starbuzz.ConsoleApp
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            this.description = "Decaf";
        }

        public override double Cost() => 1.05;
    }
}