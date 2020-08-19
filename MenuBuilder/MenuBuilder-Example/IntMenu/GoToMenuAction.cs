using MenuBuilder;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder_Example.IntMenu
{
    public class GoToMenuAction : IActions<int>
    {
        private IMenu<string> _nextMenu;

        public GoToMenuAction(IMenu<string> nextMenu)
        {
            _nextMenu = nextMenu;
        }
        public void Action(params int[] parameters)
        {
            _nextMenu.Main();
        }
    }
}
