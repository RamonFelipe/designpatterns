using System.Collections;

namespace MenuTestDrive
{
    public class PancakeHouseMenuIterator : Iterator
    {
        private readonly ArrayList items;
        int position = 0;
        
        public PancakeHouseMenuIterator(ArrayList items)
        {
            this.items = items;            
        }

        public bool HasNext()
        {
            if(position == items.Count) return false;
            return (position >= items.Count || items[position] != null);
        }

        public object Next()
        {
            var menuItem = (MenuItem)items[position];
            position = position + 1;

            return menuItem;
        }
    }
}