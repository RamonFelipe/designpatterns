using System;

namespace PizzaStore.ConsoleApp
{
    public class ChigadoPizzaCheese : Pizza
    {
        internal override string Name => "Cheese Pizza of Chicago.";
        internal override void Cut() => Console.WriteLine("Here the pizza is cutted in horizontal.");
    }
}