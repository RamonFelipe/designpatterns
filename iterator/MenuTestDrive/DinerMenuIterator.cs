namespace MenuTestDrive
{
    public class DinerMenuIterator : Iterator
    {
        private readonly MenuItem[] items;
        int position = 0;
        
        public DinerMenuIterator(MenuItem[] items)
        {
            this.items = items;            
        }

        public bool HasNext()
        {
            return (position > items.Length || items[position] != null);
        }

        public object Next()
        {
            var menuItem = (MenuItem)items[position];
            position = position + 1;

            return menuItem;
        }
    }
}