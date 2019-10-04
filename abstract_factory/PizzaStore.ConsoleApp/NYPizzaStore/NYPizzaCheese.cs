using System;

namespace PizzaStore.ConsoleApp
{
    public class NYPizzaCheese : Pizza
    {
        IPizzaIngredientsFactory pizzaIngredientsFactory;

        public NYPizzaCheese(IPizzaIngredientsFactory pizzaIngredientsFactory)
        {
            this.pizzaIngredientsFactory = pizzaIngredientsFactory;
        }
        
        internal override string Name => "Cheese Pizza of New York";

        internal override void Prepare()
        {
            dough = this.pizzaIngredientsFactory.CreateDough();
            sauce = this.pizzaIngredientsFactory.CreateSauce();
            cheese = this.pizzaIngredientsFactory.CreateCheese();
            clam = this.pizzaIngredientsFactory.CreateClam();
        }
    }
}