using System;

namespace PizzaStore.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyPizzaStore = new NYPizzaStore();
            var nyPizza = nyPizzaStore.OrderPizza("cheese");

            Console.WriteLine(nyPizza.Name);
            Console.WriteLine();

            // PizzaStore chicagoPizzaStore = new ChicagoPizzaStore();
            // var chicagoPizza = chicagoPizzaStore.OrderPizza("cheese");

            // Console.WriteLine(chicagoPizza.Name);
        }
    }
}
