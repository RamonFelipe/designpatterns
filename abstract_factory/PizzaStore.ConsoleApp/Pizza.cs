using System;

namespace PizzaStore.ConsoleApp
{
    public abstract class Pizza
    {
        protected Dough dough;
        protected Sauce sauce;
        protected Veggies[] veggies;
        protected Cheese cheese;
        protected Pepperoni pepperoni;
        protected Clam clam;

        internal abstract string Name { get; }
        internal abstract void Prepare();

        internal virtual void Bake()
        {
            Console.WriteLine("Assar por 25 minutos a 350.");
        }
        internal virtual void Cut()
        {
            Console.WriteLine("Cortar a pizza em fatias diagonais.");
        }

        internal virtual void Box()
        {
            Console.WriteLine("Colocar a pizza na caixa oficial da pizzaria.");
        }
    }
}