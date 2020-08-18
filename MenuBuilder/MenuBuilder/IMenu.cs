using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    public interface IMenu<T>
    {
        void RunOption(string option, params T[] variables);
        void Main();
    }
}
