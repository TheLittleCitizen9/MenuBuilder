using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.IntMenu
{
    public class GoToMenuAction : IActions<int>
    {
        private IMenu<int> _nextMenu;

        public GoToMenuAction(IMenu<int> nextMenu)
        {
            _nextMenu = nextMenu;
        }
        public int Action(params int[] parameters)
        {
            return 1;
        }
    }
}
