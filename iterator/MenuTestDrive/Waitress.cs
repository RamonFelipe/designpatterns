using System;
using System.Collections;
using System.Linq;

namespace MenuTestDrive
{
    internal class Waitress
    {
        private readonly PancakeHouseMenu pancakeHouseMenu;
        private readonly DinerMenu dinerMenu;

        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
        {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine("--------");
            Console.WriteLine("BREAKFAST");
            Iterator pancakeIterator = pancakeHouseMenu.CreateIterator();
            PrintMenu(pancakeIterator);

            Console.WriteLine("LUNCH");
            Iterator dinnerIterator = dinerMenu.CreateIterator();
            PrintMenu(dinnerIterator);
        }

        private void PrintMenu(Iterator iterator)
        {
            while(iterator.HasNext())
            {
                var menuItem = (MenuItem)iterator.Next();
                Console.WriteLine(menuItem.Name + " ");
                Console.WriteLine(menuItem.Description + " ");
                Console.WriteLine(menuItem.Preco + " ");
            }
        } 
    }
}