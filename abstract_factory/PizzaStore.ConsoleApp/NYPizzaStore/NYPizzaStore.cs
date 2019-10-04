namespace PizzaStore.ConsoleApp
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredientsFactory pizzaIngredientsFactory = new NYPizzaIngredientsFactory();

            if (type.Equals("cheese"))
                pizza = new NYPizzaCheese(pizzaIngredientsFactory);

            return pizza;
        }
    }
}
