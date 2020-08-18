using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.StringMenu
{
    public class StringExitAction : IActions<string>
    {
        private IMenu<string> _prevMenu;
        public StringExitAction(IMenu<string> prevMenu)
        {
            _prevMenu = prevMenu;
        }
        public string Action(params string[] parameters)
        {
            if(_prevMenu != null)
            {
                _prevMenu.Main();
            }
            return "Exiting String Menu";
        }
    }
}
