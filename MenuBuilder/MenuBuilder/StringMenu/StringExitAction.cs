using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.StringMenu
{
    public class StringExitAction : IActions<string>
    {
        private IMenu<int> _prevMenu;
        public StringExitAction(IMenu<int> prevMenu)
        {
            _prevMenu = prevMenu;
        }
        public void Action(params string[] parameters)
        {
            if(_prevMenu != null)
            {
                _prevMenu.Main();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
