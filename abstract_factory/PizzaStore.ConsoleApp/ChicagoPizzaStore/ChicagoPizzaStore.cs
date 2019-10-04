namespace PizzaStore.ConsoleApp
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredientsFactory pizzaIngredientsFactory = new ChicagoPizzaIngredientsFactory();
            
            if (type.Equals("cheese"))
                pizza = new ChigadoPizzaCheese(pizzaIngredientsFactory);

            return pizza;
        }
    }
}