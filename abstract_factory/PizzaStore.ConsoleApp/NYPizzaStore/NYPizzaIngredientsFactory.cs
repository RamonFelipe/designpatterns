using PizzaStore.ConsoleApp;

public class NYPizzaIngredientsFactory : IPizzaIngredientsFactory
{
    public Cheese CreateCheese()
    {
        return new ReggianoCheese();
    }

    public Clam CreateClam()
    {
        return new FreshClam();
    }

    public Dough CreateDough()
    {
        return new ThinCrustDough();
    }

    public Pepperoni CreatePepperoni()
    {
        return new SlicedPepperoni();
    }

    public Sauce CreateSauce()
    {
        return new MarinaraSauce();
    }

    public Veggies[] CreateVeggies()
    {
        return new Veggies[] { new Garlic(), new Onion() };
    }
}
