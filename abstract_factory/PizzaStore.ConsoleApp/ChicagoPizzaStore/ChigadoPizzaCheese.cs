using System;

namespace PizzaStore.ConsoleApp
{
    public class ChigadoPizzaCheese : Pizza
    {
        IPizzaIngredientsFactory pizzaIngredientsFactory;

        public ChigadoPizzaCheese(IPizzaIngredientsFactory pizzaIngredientsFactory)
        {
            this.pizzaIngredientsFactory = pizzaIngredientsFactory;
        }

        internal override string Name => "Cheese Pizza of Chicago.";

        internal override void Cut() => Console.WriteLine("Here the pizza is cutted in horizontal.");

        internal override void Prepare()
        {
            dough = this.pizzaIngredientsFactory.CreateDough();
            sauce = this.pizzaIngredientsFactory.CreateSauce();
            cheese = this.pizzaIngredientsFactory.CreateCheese();
            clam = this.pizzaIngredientsFactory.CreateClam();
        }
    }
}