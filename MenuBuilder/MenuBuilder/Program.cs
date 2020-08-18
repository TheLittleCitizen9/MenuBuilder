using System;

namespace MenuBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IntegersMenu integersMenu = new IntegersMenu();

            StringMenu.StringMenu stringMenu = new StringMenu.StringMenu();

            integersMenu.Main();
        }
    }
}
