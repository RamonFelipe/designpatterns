using System;

namespace MenuTestDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            var waitress = new Waitress(new PancakeHouseMenu(), new DinerMenu());
            waitress.PrintMenu();
        }
    }
}
