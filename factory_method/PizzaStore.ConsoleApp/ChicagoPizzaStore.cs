namespace PizzaStore.ConsoleApp
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if(type.Equals("cheese"))
                pizza = new ChigadoPizzaCheese();

            return pizza;
        }
    }
}