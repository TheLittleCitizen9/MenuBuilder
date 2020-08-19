using MenuBuilder;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder_Example.IntMenu
{
    public class IntExitAction : IActions<int>
    {
        private IMenu<int> _prevMenu;
        public IntExitAction(IMenu<int> prevMenu)
        {
            _prevMenu = prevMenu;
        }

        public void Action(params int[] parameters)
        {
            Environment.Exit(0);
        }
    }
}
