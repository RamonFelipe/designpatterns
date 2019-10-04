namespace MenuTestDrive
{
    public class MenuItem
    {
        private readonly string name;
        private readonly string description;
        private readonly bool vegetarian;
        private readonly double preco;

        public MenuItem(string name, string description, bool vegetarian, double preco)
        {
            this.name = name;
            this.description = description;
            this.vegetarian = vegetarian;
            this.preco = preco;
        }

        public string Name => name;
        public string Description => description;
        public bool Vegetarian => vegetarian;
        public double Preco => preco;
    }
}