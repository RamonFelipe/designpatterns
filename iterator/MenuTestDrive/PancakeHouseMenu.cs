using System;
using System.Collections;

namespace MenuTestDrive
{
    public class PancakeHouseMenu
    {
        private readonly ArrayList menuItems;

        public PancakeHouseMenu()
        {
            menuItems = new ArrayList();

            AddItem("K&B's Pancake Breakfast",
                    "Pancakes with acrambled eggs, and toast",
                    true,
                    2.99);
            AddItem("Regular Pancake Breakfast",
                    "Pancakes with fried eggs, sausage",
                    false,
                    2.99);

            AddItem("Blueberry Pancakes",
                    "Pancakes made with fresh blueberries",
                    true,
                    3.49);

            AddItem("Waffles",
                    "Waffles with your choice of bluberries or strawberries",
                    true,
                    3.59);
        }

        private void AddItem(string name, string description, bool vegetarian, double preco)
        {
            var menuItem = new MenuItem(name, description, vegetarian, preco);
            menuItems.Add(menuItem);
        }

        public Iterator CreateIterator()
        {
            return new PancakeHouseMenuIterator(menuItems);
        }
    }
}