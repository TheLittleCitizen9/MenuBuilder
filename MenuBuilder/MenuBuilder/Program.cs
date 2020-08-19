using MenuBuilder.IntMenu;
using MenuBuilder.StringMenu;
using System;

namespace MenuBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            IntegersMenu integersMenu = new IntegersMenu();

            StringMenu.StringMenu stringMenu = new StringMenu.StringMenu();


            stringMenu.AddAction("Reverse", "Reverse a word", new ReverseAction(), true);
            stringMenu.AddAction("Exit", "Exit from String Menu", new StringExitAction(integersMenu));

            integersMenu.AddAction("1", "Add Numbers", new AddAction(), true);
            integersMenu.AddAction("2", "Reduce Numbers", new ReduceAction(), true);
            integersMenu.AddAction("3", "Go To String Menu", new GoToMenuAction(stringMenu));
            integersMenu.AddAction("4", "Exit", new IntExitAction(null));

            integersMenu.Main();
        }
    }
}
