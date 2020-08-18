using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    public abstract class BasicMenu<T> : IMenu<T>
    {
        public abstract void Main();

        public abstract void RunOption(string option, params T[] variables);
    }
}
