using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    public interface IMenu
    {
        void RunOption(string option, string input = null);
        void Main();
    }
}
