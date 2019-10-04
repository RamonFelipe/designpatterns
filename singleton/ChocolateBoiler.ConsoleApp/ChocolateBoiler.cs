using System;

namespace ChocolateBoiler.ConsoleApp
{
    public class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;
        private volatile static ChocolateBoiler instance;

        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        public static ChocolateBoiler GetInstance()
        {
            if (instance == null)
                instance = new ChocolateBoiler();

            return instance;
        }

        public void Fill()
        {
            if (IsEmpty())
            {
                empty = false;
                boiled = false;

                Console.WriteLine("Fill!");
            }
        }

        public void Drain()
        {
            if (!IsEmpty() && IsBoiled())
            {
                empty = true;

                Console.WriteLine("Drain!");
            }
        }

        public void Boil()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                boiled = true;

                Console.WriteLine("Boil!");
            }
        }

        public bool IsEmpty()
        {
            return empty;
        }

        public bool IsBoiled()
        {
            return boiled;
        }
    }
}