using MenuBuilder.IntMenu;
using MenuBuilder.StringMenu;
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


            stringMenu.AddAction("Reverse", "Reverse a word", new ReverseAction());
            stringMenu.AddAction("Exit", "Exit from String Menu", new StringExitAction(integersMenu));

            integersMenu.AddAction("1", "Add Numbers", new AddAction());
            integersMenu.AddAction("2", "Reduce Numbers", new ReduceAction());
            integersMenu.AddAction("3", "Go To String Menu", new GoToMenuAction(stringMenu));
            integersMenu.AddAction("4", "Exit", new IntExitAction(null));

            integersMenu.Main();
        }
    }
}
