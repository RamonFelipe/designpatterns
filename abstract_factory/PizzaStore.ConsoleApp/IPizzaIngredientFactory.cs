namespace PizzaStore.ConsoleApp
{
    public interface IPizzaIngredientsFactory
    {
        Dough CreateDough();
        Sauce CreateSauce();
        Cheese CreateCheese();
        Veggies[] CreateVeggies();
        Pepperoni CreatePepperoni();
        Clam CreateClam();
    }
}