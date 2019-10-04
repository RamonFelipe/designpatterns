namespace PizzaStore.ConsoleApp
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if(type.Equals("cheese"))
                pizza = new NYPizzaCheese();

            return pizza;
        }
    }
}
