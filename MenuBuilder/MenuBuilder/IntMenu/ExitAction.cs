using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    public class ExitAction : IActions<int>
    {
        private IMenu<int> _prevMenu;
        public ExitAction(IMenu<int> prevMenu)
        {
            _prevMenu = prevMenu;
        }

        public int Action(params int[] parameters)
        {
            if(_prevMenu != null)
            {
                _prevMenu.Main();
            }
            return -1;
        }
    }
}
