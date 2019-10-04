using System;

namespace MenuTestDrive
{
    public class DinerMenu
    {
        private const int MAX_ITEMS = 6;
        private int numerOfItems = 0;
        private readonly MenuItem[] menuItems;

        public DinerMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];

            AddItem("Vegetarian BLT",
                    "(Fakin') Bacon with lettuce & tomato on whole wheat",
                    true,
                    2.99);
            AddItem("BLT",
                    "Bacon with lettuce & tomato on whole wheat",
                    false,
                    2.99);

            AddItem("Soup of the day",
                    "Soup of the day, with a side of potato salad",
                    true,
                    3.29);

            AddItem("Hotdog",
                    "A hot dog, with saurkraut, relish, onions, topped with cheese",
                    true,
                    3.05);
        }

        private void AddItem(string name, string description, bool vegetarian, double preco)
        {
            var menuItem = new MenuItem(name, description, vegetarian, preco);

            if(numerOfItems > MAX_ITEMS)
                Console.WriteLine("Sorry, menu is full! Can't add item to menu.");
            else
            {
                menuItems[numerOfItems] = menuItem;
                numerOfItems = numerOfItems + 1;                
            }
        }

        public Iterator CreateIterator()
        {
            return new DinerMenuIterator(menuItems);
        }
    }
}