using System;

namespace PizzaStore.ConsoleApp
{
    public abstract class Pizza
    {
        internal virtual void Prepare()
        {
            Console.WriteLine("Preparing a pizza");
        }

        internal virtual void Bake()
        {
            Console.WriteLine("Baking a pizza");
        }
        internal virtual void Cut()
        {
            Console.WriteLine("Cutting a pizza");
        }

        internal virtual void Box()
        {
            Console.WriteLine("Boxing a pizza");
        }

        internal abstract string Name { get; }
    }
}